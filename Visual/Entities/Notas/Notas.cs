using System;
using System.Windows.Forms;
using Visual.Data.Repositories;
using System.Linq;

namespace Visual.Entities.Notas
{
    public partial class Notas : UserControl
    {
        private readonly NotasRepository _repo = new NotasRepository();
        private readonly MateriaRepository _materiaRepo = new MateriaRepository();
        private readonly InscripcionRepository _inscripcionRepo = new InscripcionRepository();
        private int? _currentId = null;

        public Notas()
        {
            InitializeComponent();
            CargarMaterias();
            SetupCRUDControls();
        }

        private void SetupCRUDControls()
        {
            btnGuardar.Click += BtnGuardar_Click;
            btnBuscar.Click += BtnBuscar_Click;
            dgvNotas.SelectionChanged += DgvNotas_SelectionChanged;
            btnSalir.Click += (s, e) => this.Parent?.Controls.Remove(this);
            btnListado.Click += (s, e) => CargarListadoNotas();
            cboMaterias.SelectedValueChanged += CboMaterias_SelectedValueChanged;
        }

        private void CboMaterias_SelectedValueChanged(object? sender, EventArgs e)
        {
            if (cboMaterias.SelectedValue != null)
            {
                int materiaId = Convert.ToInt32(cboMaterias.SelectedValue);
                CargarEstudiantesPorMateria(materiaId);
            }
        }

        private void CargarMaterias()
        {
            var materias = _materiaRepo.Search("");
            cboMaterias.DataSource = materias;
            cboMaterias.DisplayMember = "Nombre";
            cboMaterias.ValueMember = "Id";
        }

        private void CargarEstudiantesPorMateria(int materiaId)
        {
            var estudiantes = _inscripcionRepo.GetEstudiantesByMateria(materiaId);
            var displayEstudiantes = estudiantes.Select(est => new {
                Id = est.Id,
                Display = $"{est.Nombre} - {est.CI}"
            }).ToList();

            cboEstudiantes.DataSource = displayEstudiantes;
            cboEstudiantes.DisplayMember = "Display";
            cboEstudiantes.ValueMember = "Id";
        }

        private void LoadDataGridView(string searchTerm)
        {
            var data = _repo.Search(searchTerm);
            dgvNotas.DataSource = data;
        }

        private void DgvNotas_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvNotas.SelectedRows.Count > 0)
            {
                var row = dgvNotas.SelectedRows[0];
                _currentId = Convert.ToInt32(row.Cells["Id"].Value);
                txtNota.Text = row.Cells["Nota"].Value?.ToString() ?? "";
            }
        }

        private void BtnGuardar_Click(object? sender, EventArgs e)
        {
            try
            {
                // Validar selección
                if (cboEstudiantes.SelectedValue == null)
                {
                    MessageBox.Show("Seleccione un estudiante");
                    return;
                }

                int estudianteId = Convert.ToInt32(cboEstudiantes.SelectedValue);
                decimal nota = decimal.Parse(txtNota.Text);

                int inscripcionId = _inscripcionRepo.GetInscripcionIdByEstudiante(estudianteId);
                _repo.Create(inscripcionId, nota);
                MessageBox.Show("Nota registrada correctamente");
                LoadDataGridView("");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void BtnBuscar_Click(object? sender, EventArgs e)
        {
            LoadDataGridView(txtBuscar.Text);
        }

        private void CargarListadoNotas()
        {
            var listado = new Visual.Entities.ListadoNotas.ListadoNotas();
            listado.Dock = DockStyle.Fill;
            Parent?.Controls.Add(listado);
            listado.BringToFront();
        }
    }
}