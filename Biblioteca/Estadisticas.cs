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
    public partial class Estadisticas : Form
    {
        // Cadena de conexión a la base de datos
        string conString = $@"Data Source={Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Database.db")};Version=3;";

        // Constructor de la clase Estadisticas que inicializa el formulario
        public Estadisticas()
        {
            InitializeComponent();

            // Establece la conexión a la base de datos y obtiene la información necesaria
            using SQLiteConnection connection = new SQLiteConnection(conString);
            {
                // Consulta para obtener el título de los libros y las veces que han sido reservados
                SQLiteCommand command0 = new SQLiteCommand("SELECT Titulo, VecesReservado FROM [libros]", connection);
                SQLiteDataAdapter adapter0 = new SQLiteDataAdapter(command0);

                // Consulta para obtener los nombres de los usuarios y el número de logins
                SQLiteCommand command1 = new SQLiteCommand("SELECT Nombre, Logins FROM Users", connection);
                SQLiteDataAdapter adapter1 = new SQLiteDataAdapter(command1);

                // Crea las tablas para almacenar los resultados de las consultas
                DataTable libros = new DataTable();
                DataTable Users = new DataTable();

                // Llena las tablas con los resultados de las consultas
                adapter0.Fill(libros);
                adapter1.Fill(Users);

                // Asigna las tablas a los controles DataGridView para mostrar los datos
                dataUsuarios.DataSource = Users;
                dataLibros.DataSource = libros;
            }
        }

        // Evento de carga del formulario
        private void Estadisticas_Load(object sender, EventArgs e)
        {
            // Aquí podrías agregar lógica adicional si es necesario al cargar el formulario
        }

        // Evento de clic en el botón para volver al menú principal
        private void volverBut_Click(object sender, EventArgs e)
        {
            // Crea una nueva instancia del menú principal y lo muestra
            MainMenu menu = new MainMenu();
            menu.Show();
            this.Hide();
        }
    }
}
