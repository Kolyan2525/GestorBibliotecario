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
    public partial class ConfiguracionDeUsuario : Form
    {
        // Cadena de conexión a la base de datos
        string conString = $@"Data Source={Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Database.db")};Version=3;";

        // Metodo que actualiza la informacion del usuario en la interfaz
        public void actualizacionTexto()
        {
            // Establece la conexion a la base de datos
            using (SQLiteConnection connection = new SQLiteConnection(conString))
            {
                connection.Open();

                // Obtiene el nombre del usuario que esta logueado
                SQLiteCommand command = new SQLiteCommand("SELECT Nombre FROM Users WHERE Online=1", connection);
                String name = command.ExecuteScalar().ToString();
                nameLbl.Text = $"Nombre: {name}";

                // Obtiene el apellido del usuario
                SQLiteCommand command1 = new SQLiteCommand("SELECT Apellido FROM Users WHERE Online=1", connection);
                String apellido = command1.ExecuteScalar().ToString();
                apellidoLbl.Text = $"Apellido: {apellido}";

                // Obtiene el correo electronico del usuario
                SQLiteCommand command2 = new SQLiteCommand("SELECT Email FROM Users WHERE Online=1", connection);
                String email = command2.ExecuteScalar().ToString();
                correoLbl.Text = $"Correo: {email}";

                // Obtiene el telefono del usuario
                SQLiteCommand command3 = new SQLiteCommand("SELECT Telefono FROM Users WHERE Online=1", connection);
                String telefono = command3.ExecuteScalar().ToString();
                telefonoLbl.Text = $"Telefono: {telefono}";

                // Verifica si el usuario tiene un libro reservado
                SQLiteCommand command6 = new SQLiteCommand($"SELECT Reservado FROM Users WHERE Online=1", connection);
                String hayLibro = command6.ExecuteScalar().ToString();

                String nombreDeLibro = "";
                String fechaDeReserva = "";

                // Si el usuario tiene un libro reservado, obtiene los detalles
                if (hayLibro == "True")
                {
                    SQLiteCommand command4 = new SQLiteCommand("SELECT ISBNDeReserva FROM Users WHERE Online=1", connection);
                    String idLibro = command4.ExecuteScalar().ToString();
                    SQLiteCommand command5 = new SQLiteCommand($"SELECT Titulo FROM [libros] WHERE ISBN={Convert.ToInt32(idLibro)}", connection);
                    nombreDeLibro = command5.ExecuteScalar().ToString();

                    SQLiteCommand command7 = new SQLiteCommand("SELECT FechaReserva FROM Users WHERE Online=1", connection);
                    fechaDeReserva = command7.ExecuteScalar().ToString();
                }

                // Muestra el libro reservado y la fecha de reserva
                reservaLbl.Text = $"Libro reservado: {nombreDeLibro}";
                fechaLbl.Text = $"Fecha de reserva: {fechaDeReserva}";
            }
        }

        // Constructor que inicializa el formulario y actualiza la informacion del usuario
        public ConfiguracionDeUsuario()
        {
            InitializeComponent();
            actualizacionTexto();
        }

        // Evento de clic para actualizar los datos del usuario
        private void actualizarBut_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection connection = new SQLiteConnection(conString))
            {
                connection.Open();

                // Verifica la contraseña ingresada por el usuario
                SQLiteCommand command = new SQLiteCommand("SELECT Contrasena FROM Users WHERE Online=1", connection);
                String pass = command.ExecuteScalar().ToString();

                // Si la contraseña es correcta, se actualizan los campos ingresados por el usuario
                if (pass.Replace(" ", "") == passBut.Text.Replace(" ", ""))
                {
                    // Si se ha ingresado un nuevo nombre, se actualiza
                    if (nuevoNombreBut.Text.Replace(" ", "") != "")
                    {
                        SQLiteCommand command2 = new SQLiteCommand($"UPDATE Users SET Nombre = '{nuevoNombreBut.Text.Replace("'", "''")}' WHERE Online=1", connection);
                        command2.ExecuteNonQuery();
                    }
                    // Si se ha ingresado un nuevo apellido, se actualiza
                    if (nuevoApellidoBut.Text.Replace(" ", "") != "")
                    {
                        SQLiteCommand command2 = new SQLiteCommand($"UPDATE Users SET Apellido = '{nuevoApellidoBut.Text.Replace("'", "''")}' WHERE Online=1", connection);
                        command2.ExecuteNonQuery();
                    }
                    // Si se ha ingresado un nuevo correo, se actualiza
                    if (nuevoCorreoBut.Text.Replace(" ", "") != "")
                    {
                        SQLiteCommand command2 = new SQLiteCommand($"UPDATE Users SET Email = '{nuevoCorreoBut.Text.Replace("'", "''")}' WHERE Online=1", connection);
                        command2.ExecuteNonQuery();
                    }
                    // Si se ha ingresado una nueva contraseña, se actualiza
                    if (nuevaContrasenaBut.Text.Replace(" ", "") != "")
                    {
                        SQLiteCommand command2 = new SQLiteCommand($"UPDATE Users SET Contrasena = '{nuevaContrasenaBut.Text.Replace("'", "''")}' WHERE Online=1", connection);
                        command2.ExecuteNonQuery();
                    }
                    // Si se ha ingresado un nuevo telefono, se actualiza
                    if (nuevoTelefonoBut.Text.Replace(" ", "") != "")
                    {
                        SQLiteCommand command2 = new SQLiteCommand($"UPDATE Users SET Telefono = '{nuevoTelefonoBut.Text.Replace("'", "''")}' WHERE Online=1", connection);
                        command2.ExecuteNonQuery();
                    }
                }
                else
                {
                    // Si la contraseña es incorrecta, se muestra un mensaje
                    MessageBox.Show("Contraseña Incorrecta");
                }

                // Actualiza la interfaz con los nuevos datos
                actualizacionTexto();
            }
        }

        // Evento de clic para volver al menú principal
        private void volverBut_Click(object sender, EventArgs e)
        {
            MainMenu menu = new MainMenu();
            menu.Show();
            this.Hide();
        }
    }
}
