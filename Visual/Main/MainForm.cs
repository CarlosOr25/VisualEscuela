using System;
using System.Windows.Forms;
using Visual.Entities.Persona;
using Visual.Entities.Materia;
using Visual.Entities.Curso;
using Visual.Entities.Inscripcion;
using Visual.Entities.Seccion;
using Visual.Entities.Planilladenotas;
using Visual.Entities.ListadoNotas;
using Visual.Entities.Mantenimiento;
using Visual.Entities.Notas;
using Visual.Entities.Reportes;

namespace Visual.Main
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
            btnReportes.Click += (s, e) => CargarReportes();
            btnMantenimiento.Click += (s, e) => CargarMantenimiento();
            btnInscripcion.Click += (s, e) => CargarInscripcion();
            btnNotas.Click += (s, e) => CargarNotas();

            reportesMenuItem.Click += (s, e) => CargarReportes();
            inscripcionMenuItem.Click += (s, e) => CargarInscripcion();
            notasMenuItem.Click += (s, e) => CargarNotas();

            materiaMenuItem.Click += (s, e) => CargarMateria();
            seccionMenuItem.Click += (s, e) => CargarSeccion();
            personaMenuItem.Click += (s, e) => CargarPersona();
            cursoMenuItem.Click += (s, e) => CargarCurso();
        }

        private void CargarPersona() => CargarPantalla(new Persona(), "Gestión de Personas");
        private void CargarMateria() => CargarPantalla(new Materia(), "Gestión de Materias");
        private void CargarCurso() => CargarPantalla(new Curso(), "Gestión de Cursos");
        private void CargarInscripcion() => CargarPantalla(new Inscripcion(), "Gestión de Inscripciones");
        private void CargarNotas() => CargarPantalla(new Notas(), "Gestión de Notas");
        private void CargarSeccion() => CargarPantalla(new Seccion(), "Gestión de Secciones");

        private void CargarReportes()
        {
            var reportes = new Reportes();
            reportes.MostrarPlanillaNotas += (s, e) => CargarPantalla(new Planilladenotas(), "Planilla de Notas");
            reportes.MostrarListadoNotas += (s, e) => CargarPantalla(new ListadoNotas(), "Listado de Notas");
            CargarPantalla(reportes, "Módulo de Reportes");
        }

        private void CargarMantenimiento()
        {
            var mantenimiento = new Mantenimiento();
            mantenimiento.MostrarMateria += (s, e) => CargarMateria();
            mantenimiento.MostrarSeccion += (s, e) => CargarSeccion();
            mantenimiento.MostrarPersona += (s, e) => CargarPersona();
            mantenimiento.MostrarCurso += (s, e) => CargarCurso();
            CargarPantalla(mantenimiento, "Módulo de Mantenimiento");
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