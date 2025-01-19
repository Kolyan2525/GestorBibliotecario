using System.Data.SQLite;

namespace biblioteca
{
    public partial class Form1 : Form
    {
        // Cadena de conexión a la base de datos
        string conString = $@"Data Source={Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Database.db")};Version=3;";

        // Constructor del formulario que realiza la inicialización
        public Form1()
        {
            InitializeComponent();
            // Establece la conexión a la base de datos y actualiza el estado de los usuarios y libros
            using (SQLiteConnection connection = new SQLiteConnection(conString))
            {
                connection.Open();

                // Actualiza el estado de los usuarios, estableciendo 'Online' a 0 para todos
                SQLiteCommand command = new SQLiteCommand("UPDATE Users SET Online = 0", connection);
                command.ExecuteNonQuery();

                // Actualiza la disponibilidad de los libros según el número de copias
                SQLiteCommand command1 = new SQLiteCommand("UPDATE [libros] SET Disponibilidad=1 WHERE [Numero de Copias] > 0", connection);
                command1.ExecuteNonQuery();

                // Actualiza la disponibilidad de los libros a 0 si no hay copias disponibles
                SQLiteCommand command2 = new SQLiteCommand("UPDATE [libros] SET Disponibilidad=0 WHERE [Numero de Copias] = 0", connection);
                command2.ExecuteNonQuery();
            }
        }

        // Evento de clic en el botón de inicio de sesión
        private void button1_Click(object sender, EventArgs e)
        {
            // Consulta SQL para obtener la contraseña del usuario según su ID
            String querry = "SELECT Contrasena FROM Users" + $" WHERE ID=@ID";
            String pass = "";

            // Establece la conexión con la base de datos y obtiene la contraseña del usuario
            using (SQLiteConnection connection = new SQLiteConnection(conString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(querry, connection))
                {
                    command.Parameters.AddWithValue("@ID", UserText.Text);
                    pass = (string)command.ExecuteScalar();  // Obtiene la contraseña del usuario

                    // Si se encuentra una contraseña, la limpia de espacios
                    if (pass != null)
                    {
                        pass = pass.Replace(" ", "");
                    }
                }

                // Verifica si la contraseña introducida coincide con la almacenada
                if (pass == (string)PasswordText.Text)
                {
                    // Si la contraseña es correcta, actualiza el número de logins y el estado Online del usuario
                    MainMenu menu = new MainMenu();
                    SQLiteCommand command = new SQLiteCommand($"UPDATE Users SET Logins = Logins + 1 WHERE ID='{UserText.Text.Replace("'", "''")}'", connection);
                    SQLiteCommand command2 = new SQLiteCommand($"UPDATE Users SET Online = 1 WHERE ID='{UserText.Text.Replace("'", "''")}'", connection);
                    command2.ExecuteNonQuery();
                    command.ExecuteNonQuery();

                    // Muestra el menú principal y oculta el formulario actual
                    menu.Show();
                    this.Hide();
                }
            }
        }

        // Evento de clic en el botón para registrarse
        private void signUpBut_Click(object sender, EventArgs e)
        {
            // Abre el formulario de registro de usuario
            userSignUp user = new userSignUp();
            user.Show();
            this.Hide();
        }
    }
}
