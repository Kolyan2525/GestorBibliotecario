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
    public partial class userSignUp : Form
    {
        // Constructor del formulario de registro de usuario
        public userSignUp()
        {
            InitializeComponent(); // Inicializa los componentes del formulario
        }

        // Cadena de conexión a la base de datos (local) para la conexión a SQL Server
        string conString = $@"Data Source={Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Database.db")};Version=3;";

        // Evento que maneja el clic en el botón de registro de usuario
        private void signUpBut_Click(object sender, EventArgs e)
        {
            if (idText.Text != "" && nombreText.Text != "" && apellidoText.Text != "" && emailText.Text != "" && contrasenaText.Text != "" && telefonoText.Text != "")
            {
                // Abre una conexión a la base de datos
                using (SQLiteConnection connection = new SQLiteConnection(conString))
                {
                    connection.Open(); // Abre la conexión a la base de datos

                    // Consulta SQL para insertar un nuevo usuario en la tabla Users
                    string querry = $"INSERT INTO Users (ID, Nombre, Apellido, Email, Contrasena, Telefono)" +
                                    $"VALUES (@ID, @Nombre, @Apellido, @Email, @Contrasena, @Telefono)";

                    // Crea un comando SQL con los parámetros para insertar los datos del nuevo usuario
                    using (SQLiteCommand command = new SQLiteCommand(querry, connection))
                    {
                        // Asigna los valores de los campos de texto a los parámetros de la consulta
                        command.Parameters.AddWithValue("@ID", idText.Text);
                        command.Parameters.AddWithValue("@Nombre", nombreText.Text);
                        command.Parameters.AddWithValue("@Apellido", apellidoText.Text);
                        command.Parameters.AddWithValue("@Email", emailText.Text);
                        command.Parameters.AddWithValue("@Contrasena", contrasenaText.Text);
                        command.Parameters.AddWithValue("@Telefono", telefonoText.Text);

                        // Ejecuta la consulta de inserción en la base de datos
                        command.ExecuteNonQuery();

                        // Esconde el formulario de registro y abre el formulario de login
                        this.Hide();
                        Form1 form1 = new Form1();
                        form1.Show();
                        // Muestra un mensaje indicando que el nuevo usuario ha sido registrado
                        MessageBox.Show("New User Signed");
                    }
                }
            }
            else
            {
                MessageBox.Show("Campos incompletos");
            }

            
        }

        // Evento que maneja el clic en el botón de volver al formulario de login
        private void volverBut_Click(object sender, EventArgs e)
        {
            // Crea una nueva instancia del formulario de login y lo muestra
            Form1 form1 = new Form1();
            form1.Show();
            // Esconde el formulario de registro
            this.Hide();
        }
    }
}
