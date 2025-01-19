using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace biblioteca
{
    public partial class Form2 : Form
    {
        // Cadena de conexión a la base de datos
        string conString = $@"Data Source={Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Database.db")};Version=3;";
        // Método para actualizar el contenido del dataGridView con los datos de la base de datos
        public void refresh()
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(conString))
                {
                    // Consulta base para obtener todos los registros
                    String query = "SELECT * FROM [libros]";

                    // Aplica filtro si el campo de texto o el checkbox de disponibilidad están marcados
                    if (filtroText.Text != "" || disponibleBox.Checked)
                    {
                        query += " WHERE ";

                        // Aplica filtro si solo está marcado el checkbox de disponibilidad
                        if (disponibleBox.Checked && filtroText.Text == "")
                        {
                            query += "Disponibilidad=1";
                        }

                        // Aplica filtro si solo hay texto en el campo de filtro
                        if (filtroText.Text != "" && !disponibleBox.Checked)
                        {
                            query += $"Genero='{filtroText.Text.Replace("'", "''")}'";
                        }

                        // Aplica filtro si ambos, texto en el filtro y checkbox de disponibilidad, están seleccionados
                        if (filtroText.Text != "" && disponibleBox.Checked)
                        {
                            query += $"Disponibilidad=1 AND Genero='{filtroText.Text.Replace("'", "''")}'";
                        }

                        // Ejecuta la consulta y llena el dataGridView con los resultados
                        using (SQLiteCommand command = new SQLiteCommand(query, connection))
                        using (SQLiteDataAdapter sd = new SQLiteDataAdapter(command))
                        {
                            DataTable dt = new DataTable();
                            sd.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                    }
                    else
                    {
                        // Ejecuta consulta base sin filtros
                        using (SQLiteCommand command = new SQLiteCommand("SELECT * FROM [libros]", connection))
                        using (SQLiteDataAdapter sd = new SQLiteDataAdapter(command))
                        {
                            if (disponibleBox.Checked)
                            {
                                sd.InsertCommand = new SQLiteCommand("SELECT * FROM [libros]" + " WHERE Disponibilidad=True", connection);
                            }
                            DataTable dt = new DataTable();
                            sd.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Constructor del formulario, actualiza el dataGridView al cargar el formulario
        public Form2()
        {
            InitializeComponent();
            refresh();
        }

        // Método que maneja el evento de clic en las celdas del dataGridView
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        // Método que maneja el evento de clic en el botón de actualizar
        private void button1_Click(object sender, EventArgs e)
        {
            refresh();
        }

        // Método para manejar el evento de clic en el botón de eliminar un registro
        private void DeleteBut_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                MessageBox.Show("Delete?");
                int id = Convert.ToInt32(textBox1.Text);
                String querry = $"DELETE FROM [Libros] WHERE ISBN={id}";
                using (SQLiteConnection connection = new SQLiteConnection(conString))
                {
                    connection.Open();
                    SQLiteCommand command = new SQLiteCommand(querry, connection);
                    command.ExecuteNonQuery();
                }
            }
            else
            {
                MessageBox.Show("Incompleto");
            }
        }

        // Método para manejar el evento de clic en el botón de agregar un nuevo libro
        private void AdditionBut_Click(object sender, EventArgs e)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(conString))
                {
                    connection.Open();

                    // Verifica si el libro ya existe en la base de datos
                    SQLiteCommand command1 = new SQLiteCommand($"SELECT CASE WHEN EXISTS (SELECT 1 FROM [libros] WHERE ISBN = {ISBNText.Text}) THEN 1 ELSE 0 END", connection);
                    if (ISBNText.Text != "" && TituloText.Text != "" && AutorText.Text != "" && EditorialText.Text != "" && AnoText.Text != "" && GeneroText.Text != "" && CopiasText.Text != "")
                    {
                        String exist = command1.ExecuteScalar().ToString();
                        if (exist == "0")
                        {
                            // Agrega un nuevo libro si no existe
                            string query = $"INSERT INTO [libros] (ISBN, Titulo, Autor, Editorial, [Ano de Publicacion], Genero, [Numero de Copias], Disponibilidad) " +
                                           $"VALUES (@ISBN, @Titulo, @Autor, @Editorial, @Ano, @Genero, @Copias, @Disponibilidad)";

                            using (SQLiteCommand command = new SQLiteCommand(query, connection))
                            {
                                // Agrega parámetros para evitar SQL Injection
                                command.Parameters.AddWithValue("@ISBN", ISBNText.Text);
                                command.Parameters.AddWithValue("@Titulo", TituloText.Text);
                                command.Parameters.AddWithValue("@Autor", AutorText.Text);
                                command.Parameters.AddWithValue("@Editorial", EditorialText.Text);
                                command.Parameters.AddWithValue("@Ano", AnoText.Text);
                                command.Parameters.AddWithValue("@Genero", GeneroText.Text);
                                command.Parameters.AddWithValue("@Copias", CopiasText.Text);

                                // Establece la disponibilidad según el número de copias
                                if (Convert.ToInt32(CopiasText.Text) > 0)
                                {
                                    command.Parameters.AddWithValue("@Disponibilidad", 1);
                                }
                                else
                                {
                                    command.Parameters.AddWithValue("@Disponibilidad", 0);
                                }
                                command.ExecuteNonQuery();
                            }
                        }
                        else if (exist == "1")
                        {
                            // Actualiza la cantidad de copias si el libro ya existe
                            using (SQLiteCommand command0 = new SQLiteCommand("UPDATE [libros] SET [Numero de Copias] = [Numero de Copias] + @copias WHERE ISBN = @isbn", connection))
                            {
                                command0.Parameters.AddWithValue("@copias", CopiasText.Text);
                                command0.Parameters.AddWithValue("@isbn", ISBNText.Text);

                                command0.ExecuteNonQuery();
                                refresh();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Todos los campos deben ser rellenados");
                    }

                }

                // Limpia los campos de texto después de agregar
                ISBNText.Text = string.Empty;
                TituloText.Text = string.Empty;
                AutorText.Text = string.Empty;
                EditorialText.Text = string.Empty;
                AnoText.Text = string.Empty;
                GeneroText.Text = string.Empty;
                CopiasText.Text = string.Empty;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        // Método para manejar el evento de clic en el botón de regresar al menú principal
        private void returnBut_Click(object sender, EventArgs e)
        {
            MainMenu menu = new MainMenu();
            menu.Show();
            this.Hide();
        }

        // Método para manejar la reserva de libros
        private void reservarBut_Click(object sender, EventArgs e)
        {
            if (reservaText.Text != "")
            {
                using (SQLiteConnection connection = new SQLiteConnection(conString))
                {
                    connection.Open();

                    // Obtiene el número de copias disponibles y verifica si el usuario tiene reservas activas
                    SQLiteCommand command0 = new SQLiteCommand($"SELECT [Numero de Copias] FROM [libros] WHERE ISBN = {reservaText.Text}", connection);
                    string copias = command0.ExecuteScalar().ToString();

                    SQLiteCommand command3 = new SQLiteCommand($"SELECT Reservado FROM Users WHERE Online=1", connection);
                    String reservado = command3.ExecuteScalar().ToString();

                    if (Convert.ToInt32(copias) > 0 && reservado == "False")
                    {
                        // Reserva el libro y actualiza las bases de datos correspondientes
                        SQLiteCommand command1 = new SQLiteCommand($"UPDATE [Libros] SET [Numero de Copias] = [Numero de Copias] - 1, VecesReservado = VecesReservado + 1 WHERE ISBN ={reservaText.Text}", connection);
                        command1.ExecuteNonQuery();
                        copias = command0.ExecuteScalar().ToString();

                        SQLiteCommand command4 = new SQLiteCommand($"UPDATE Users SET Reservado=1, ISBNDeReserva={reservaText.Text}, FechaReserva = '{DateTime.Today.Year}/{DateTime.Today.Month}/{DateTime.Today.Day}' WHERE Online=1", connection);
                        command4.ExecuteNonQuery();

                        MessageBox.Show("Libro Reservado");

                        // Si no hay copias disponibles, se actualiza la disponibilidad del libro
                        if (Convert.ToInt16(copias) == 0)
                        {
                            SQLiteCommand command2 = new SQLiteCommand($"UPDATE [Libros] SET Disponibilidad = 0 WHERE ISBN = {reservaText.Text}", connection);
                            command2.ExecuteNonQuery();
                        }
                    }
                    else if (Convert.ToInt32(copias) == 0)
                    {
                        MessageBox.Show("Libro no disponible");
                    }
                    else if (reservado == "True")
                    {
                        MessageBox.Show("Ya tienes un libro reservado");
                    }
                }
            }
        }

        // Método para manejar la devolución de libros
        private void devolucionBut_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection connection = new SQLiteConnection(conString))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand("SELECT Reservado FROM Users WHERE Online=1", connection);
                String reservado = command.ExecuteScalar().ToString();

                SQLiteCommand command3 = new SQLiteCommand("SELECT ISBNDeReserva FROM Users WHERE Online=1", connection);
                String libroReservado = command3.ExecuteScalar().ToString();

                SQLiteCommand command5 = new SQLiteCommand($"SELECT Titulo FROM [libros] WHERE ISBN = {libroReservado}", connection);
                String nombreLibro = command5.ExecuteScalar().ToString();

                if (reservado == "True")
                {
                    // Devolución del libro
                    SQLiteCommand command1 = new SQLiteCommand($"UPDATE [libros] SET [Numero de Copias] = [Numero de Copias] + 1 WHERE ISBN={libroReservado}", connection);
                    command1.ExecuteNonQuery();

                    SQLiteCommand command4 = new SQLiteCommand($"UPDATE Users SET ISBNDeReserva = 0, FechaReserva = NULL, Reservado = 0", connection);
                    command4.ExecuteNonQuery();

                    MessageBox.Show($"Has devuelto el libro {nombreLibro}");
                }
                else
                {
                    MessageBox.Show("No tienes un libro que devolver");
                }
            }
        }
    }
}
