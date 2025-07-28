using System;
using System.Windows.Forms;
using Visual.Data.Repositories;
using System.Linq;

namespace Visual.Entities.Inscripcion
{
    public partial class InscripcionControl : UserControl
    {
        private readonly PersonaRepository personaRepo = new PersonaRepository();
        private readonly CursoRepository cursoRepo = new CursoRepository();
        private readonly InscripcionRepository _inscripcionRepo = new InscripcionRepository();

        public InscripcionControl()
        {
            InitializeComponent();
            LoadData();
            btnInscribir.Click += OnInscribirClicked;
        }

        private void LoadData()
        {
            // Cargar estudiantes (mostrar nombre y CI)
            var estudiantes = personaRepo.GetByTipo(1);
            var displayEstudiantes = estudiantes.Select(e => new {
                Id = e.Id,
                Display = $"{e.Nombre} - {e.CI}"
            }).ToList();

            cboEstudiantes.DataSource = displayEstudiantes;
            cboEstudiantes.DisplayMember = "Display";
            cboEstudiantes.ValueMember = "Id";

            // Cargar cursos
            var cursos = cursoRepo.GetAll();
            var cursosDisplay = cursos.Select(c => new
            {
                Id = c.Id,
                Display = $"{c.MateriaNombre} - {c.SeccionNombre}"
            }).ToList();

            cboCursos.DataSource = cursosDisplay;
            cboCursos.DisplayMember = "Display";
            cboCursos.ValueMember = "Id";
        }

        private void OnInscribirClicked(object? sender, EventArgs e)
        {
            try
            {
                int estudianteId = Convert.ToInt32(cboEstudiantes.SelectedValue);
                int cursoId = Convert.ToInt32(cboCursos.SelectedValue);

                int inscripcionId = _inscripcionRepo.Create(cursoId, estudianteId);
                MessageBox.Show($"Inscripción exitosa! ID: {inscripcionId}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}