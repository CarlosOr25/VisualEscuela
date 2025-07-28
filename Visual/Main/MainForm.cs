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
            reportesMenuItem.Click += (s, e) => CargarReportes();
            mantenimientoMenuItem.Click += (s, e) => CargarMantenimiento();
            inscripcionMenuItem.Click += (s, e) => CargarInscripcion();
            notasMenuItem.Click += (s, e) => CargarNotas();

            materiaMenuItem.Click += (s, e) => CargarMateria();
            seccionMenuItem.Click += (s, e) => CargarSeccion();
            personaMenuItem.Click += (s, e) => CargarPersona();
            cursoMenuItem.Click += (s, e) => CargarCurso();
        }

        private void CargarPersona()
        {
            var persona = new Persona();
            CargarPantalla(persona, "Gesti�n de Personas");
        }

        private void CargarMateria() => CargarPantalla(new Materia(), "Gesti�n de Materias");
        private void CargarCurso() => CargarPantalla(new Curso(), "Gesti�n de Cursos");
        private void CargarInscripcion() => CargarPantalla(new InscripcionControl(), "Gesti�n de Inscripciones");
        private void CargarNotas() => CargarPantalla(new Notas(), "Gesti�n de Notas");
        private void CargarSeccion() => CargarPantalla(new Seccion(), "Gesti�n de Secciones");

        private void CargarReportes()
        {
            var reportes = new Reportes();
            reportes.MostrarProfesores += (s, e) => CargarProfesores();
            reportes.MostrarListadoNotas += (s, e) => CargarPantalla(new ListadoNotas(), "Listado de Notas");
            CargarPantalla(reportes, "M�dulo de Reportes");
        }

        private void CargarProfesores()
        {
            var profesores = new Persona();
            profesores.SetTipoFilter(2);
            CargarPantalla(profesores, "Profesores");
        }

        private void CargarMantenimiento()
        {
            var mantenimiento = new Mantenimiento();
            mantenimiento.MostrarMateria += (s, e) => CargarMateria();
            mantenimiento.MostrarSeccion += (s, e) => CargarSeccion();
            mantenimiento.MostrarPersona += (s, e) => CargarPersona();
            mantenimiento.MostrarCurso += (s, e) => CargarCurso();

            panelContent.Controls.Clear();
            mantenimiento.Dock = DockStyle.Fill;
            panelContent.Controls.Add(mantenimiento);
            tsslStatus.Text = "M�dulo de Mantenimiento";
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