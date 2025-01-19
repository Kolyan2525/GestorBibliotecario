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
    public partial class MainMenu : Form
    {
        // Cadena de conexión a la base de datos (local) que se usa en varias partes del código
        string conString = $@"Data Source={Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Database.db")};Version=3;";

        // Constructor del formulario principal
        public MainMenu()
        {
            InitializeComponent(); // Inicializa los componentes de la interfaz de usuario
        }

        // Evento que maneja el clic en el botón de catalogo
        private void catalogoBut_Click(object sender, EventArgs e)
        {
            // Crea una nueva instancia del formulario de catálogo y lo muestra
            Form2 form2 = new Form2();
            form2.Show();
            // Esconde el formulario principal
            this.Hide();
        }

        // Evento que maneja el clic en el botón de configuración de usuario
        private void userBut_Click(object sender, EventArgs e)
        {
            // Crea una nueva instancia del formulario de configuración de usuario y lo muestra
            ConfiguracionDeUsuario config = new ConfiguracionDeUsuario();
            config.Show();
            // Esconde el formulario principal
            this.Hide();
        }

        // Evento que maneja el clic en el botón de cerrar sesión
        private void logOutBut_Click(object sender, EventArgs e)
        {
            // Abre una conexión a la base de datos y actualiza el estado del usuario a offline
            using (SQLiteConnection connection = new SQLiteConnection(conString))
            {
                connection.Open(); // Abre la conexión
                // Actualiza el campo Online a 0 para todos los usuarios que están conectados
                SQLiteCommand command0 = new SQLiteCommand("UPDATE Users SET Online = 0 WHERE Online = 1", connection);
                command0.ExecuteNonQuery(); // Ejecuta la consulta SQL
            }
            // Crea una nueva instancia del formulario de login y lo muestra
            Form1 form1 = new Form1();
            form1.Show();
            // Esconde el formulario principal
            this.Hide();
        }

        // Evento que maneja el clic en el botón de reservaciones
        private void reservacionesBut_Click(object sender, EventArgs e)
        {
            // Crea una nueva instancia del formulario de estadísticas y lo muestra
            Estadisticas est = new Estadisticas();
            est.Show();
            // Esconde el formulario principal
            this.Hide();
        }
    }
}
