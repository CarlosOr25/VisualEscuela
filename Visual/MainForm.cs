using System;
using System.Windows.Forms;

namespace Visual
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            ConectarEventos();
        }

        private void ConectarEventos()
        {
            // Eventos para ToolStrip
            btnReportes.Click += (s, e) => CargarReportes();
            btnMantenimiento.Click += (s, e) => CargarMantenimiento();
            btnInscripcion.Click += (s, e) => CargarInscripcion();
            btnNotas.Click += (s, e) => CargarNotas();

            // Eventos para MenuStrip
            reportesMenuItem.Click += (s, e) => CargarReportes();
            inscripcionMenuItem.Click += (s, e) => CargarInscripcion();
            notasMenuItem.Click += (s, e) => CargarNotas();

            // Eventos para los submenús de Mantenimiento
            materiaMenuItem.Click += (s, e) => CargarMateria();
            seccionMenuItem.Click += (s, e) => CargarSeccion();
            personaMenuItem.Click += (s, e) => CargarPersona();
            cursoMenuItem.Click += (s, e) => CargarCurso();
        }

        private void CargarReportes()
        {
            var pantallaReportes = new Reportes();

            pantallaReportes.MostrarPlanillaNotas += (sender, args) =>
            {
                CargarPantalla(new Planilladenotas(), "Planilla de notas abierta");
            };

            pantallaReportes.MostrarListadoNotas += (sender, args) =>
            {
                CargarPantalla(new ListadoNotas(), "Listado de notas cargado");
            };

            CargarPantalla(pantallaReportes, "Módulo de Reportes cargado");
        }

        private void CargarMantenimiento()
        {
            var pantallaMantenimiento = new Mantenimiento();
            pantallaMantenimiento.MostrarMateria += (sender, args) => CargarMateria();
            pantallaMantenimiento.MostrarSeccion += (sender, args) => CargarSeccion();
            pantallaMantenimiento.MostrarPersona += (sender, args) => CargarPersona();
            pantallaMantenimiento.MostrarCurso += (sender, args) => CargarCurso();
            CargarPantalla(pantallaMantenimiento, "Módulo de Mantenimiento cargado");
        }

        private void CargarMateria()
        {
            CargarPantalla(new Materia(), "Ficha de Materia abierta");
        }

        private void CargarSeccion()
        {
            CargarPantalla(new Seccion(), "Ficha de Sección abierta");
        }

        private void CargarPersona()
        {
            CargarPantalla(new Persona(), "Ficha de Persona abierta");
        }

        private void CargarCurso()
        {
            CargarPantalla(new Curso(), "Ficha de Curso abierta");
        }

        private void CargarInscripcion()
        {
            CargarPantalla(new Inscripcion(), "Módulo de Inscripción cargado");
        }

        private void CargarNotas()
        {
            CargarPantalla(new Notas(), "Módulo de Notas cargado");
        }

        private void CargarPantalla(UserControl pantalla, string mensaje)
        {
            panelContent.Controls.Clear();
            pantalla.Dock = DockStyle.Fill;
            panelContent.Controls.Add(pantalla);
            tsslStatus.Text = mensaje;
        }
    }
}