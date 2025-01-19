using System.Data.SQLite;

namespace biblioteca
{
    public partial class Form1 : Form
    {
        // Cadena de conexi�n a la base de datos
        string conString = $@"Data Source={Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Database.db")};Version=3;";

        // Constructor del formulario que realiza la inicializaci�n
        public Form1()
        {
            InitializeComponent();
            // Establece la conexi�n a la base de datos y actualiza el estado de los usuarios y libros
            using (SQLiteConnection connection = new SQLiteConnection(conString))
            {
                connection.Open();

                // Actualiza el estado de los usuarios, estableciendo 'Online' a 0 para todos
                SQLiteCommand command = new SQLiteCommand("UPDATE Users SET Online = 0", connection);
                command.ExecuteNonQuery();

                // Actualiza la disponibilidad de los libros seg�n el n�mero de copias
                SQLiteCommand command1 = new SQLiteCommand("UPDATE [libros] SET Disponibilidad=1 WHERE [Numero de Copias] > 0", connection);
                command1.ExecuteNonQuery();

                // Actualiza la disponibilidad de los libros a 0 si no hay copias disponibles
                SQLiteCommand command2 = new SQLiteCommand("UPDATE [libros] SET Disponibilidad=0 WHERE [Numero de Copias] = 0", connection);
                command2.ExecuteNonQuery();
            }
        }

        // Evento de clic en el bot�n de inicio de sesi�n
        private void button1_Click(object sender, EventArgs e)
        {
            // Consulta SQL para obtener la contrase�a del usuario seg�n su ID
            String querry = "SELECT Contrasena FROM Users" + $" WHERE ID=@ID";
            String pass = "";

            // Establece la conexi�n con la base de datos y obtiene la contrase�a del usuario
            using (SQLiteConnection connection = new SQLiteConnection(conString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(querry, connection))
                {
                    command.Parameters.AddWithValue("@ID", UserText.Text);
                    pass = (string)command.ExecuteScalar();  // Obtiene la contrase�a del usuario

                    // Si se encuentra una contrase�a, la limpia de espacios
                    if (pass != null)
                    {
                        pass = pass.Replace(" ", "");
                    }
                }

                // Verifica si la contrase�a introducida coincide con la almacenada
                if (pass == (string)PasswordText.Text)
                {
                    // Si la contrase�a es correcta, actualiza el n�mero de logins y el estado Online del usuario
                    MainMenu menu = new MainMenu();
                    SQLiteCommand command = new SQLiteCommand($"UPDATE Users SET Logins = Logins + 1 WHERE ID='{UserText.Text.Replace("'", "''")}'", connection);
                    SQLiteCommand command2 = new SQLiteCommand($"UPDATE Users SET Online = 1 WHERE ID='{UserText.Text.Replace("'", "''")}'", connection);
                    command2.ExecuteNonQuery();
                    command.ExecuteNonQuery();

                    // Muestra el men� principal y oculta el formulario actual
                    menu.Show();
                    this.Hide();
                }
            }
        }

        // Evento de clic en el bot�n para registrarse
        private void signUpBut_Click(object sender, EventArgs e)
        {
            // Abre el formulario de registro de usuario
            userSignUp user = new userSignUp();
            user.Show();
            this.Hide();
        }
    }
}
