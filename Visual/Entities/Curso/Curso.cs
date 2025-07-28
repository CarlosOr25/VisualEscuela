using System;
using System.Windows.Forms;
using Visual.Data.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace Visual.Entities.Curso
{
    public partial class Curso : UserControl
    {
        private readonly CursoRepository _repo = new CursoRepository();
        private readonly MateriaRepository _materiaRepo = new MateriaRepository();
        private readonly SeccionRepository _seccionRepo = new SeccionRepository();
        private int? _currentId = null;

        public Curso()
        {
            InitializeComponent();
            SetupCRUDControls();
            LoadComboBoxes();
            LoadDataGridView("");
        }

        private void SetupCRUDControls()
        {
            btnGuardar.Click += BtnGuardar_Click;
            btnBuscar.Click += BtnBuscar_Click;
            btnActualizar.Click += BtnActualizar_Click;
            btnEliminar.Click += BtnEliminar_Click;
            btnLimpiar.Click += BtnLimpiar_Click;
            dgvCursos.SelectionChanged += DgvCursos_SelectionChanged;
        }

        private void LoadComboBoxes()
        {
            // Cargar materias
            var materias = _materiaRepo.Search("");
            cboMateria.DataSource = materias;
            cboMateria.DisplayMember = "Nombre";
            cboMateria.ValueMember = "Id";

            // Cargar secciones
            var secciones = _seccionRepo.Search("");
            cboSeccion.DataSource = secciones;
            cboSeccion.DisplayMember = "Nombre";
            cboSeccion.ValueMember = "Id";
        }

        private void LoadDataGridView(string searchTerm)
        {
            var data = _repo.Search(searchTerm);
            dgvCursos.DataSource = data;
        }

        private void DgvCursos_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvCursos.SelectedRows.Count > 0)
            {
                var row = dgvCursos.SelectedRows[0];
                _currentId = Convert.ToInt32(row.Cells["Id"].Value);

                // Manejo de posibles valores nulos
                if (row.Cells["MateriaId"].Value != null)
                {
                    cboMateria.SelectedValue = Convert.ToInt32(row.Cells["MateriaId"].Value);
                }

                if (row.Cells["SeccionId"].Value != null)
                {
                    cboSeccion.SelectedValue = Convert.ToInt32(row.Cells["SeccionId"].Value);
                }
            }
        }

        private void BtnGuardar_Click(object? sender, EventArgs e)
        {
            try
            {
                // Validar selección
                if (cboMateria.SelectedValue == null || cboSeccion.SelectedValue == null)
                {
                    MessageBox.Show("Seleccione materia y sección");
                    return;
                }

                int materiaId = Convert.ToInt32(cboMateria.SelectedValue);
                int seccionId = Convert.ToInt32(cboSeccion.SelectedValue);

                int id = _repo.Create(materiaId, seccionId);
                _currentId = id;
                MessageBox.Show($"Curso creado con ID: {id}");
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

        private void BtnActualizar_Click(object? sender, EventArgs e)
        {
            if (!_currentId.HasValue)
            {
                MessageBox.Show("Seleccione un curso primero");
                return;
            }

            try
            {
                // Validar selección
                if (cboMateria.SelectedValue == null || cboSeccion.SelectedValue == null)
                {
                    MessageBox.Show("Seleccione materia y sección");
                    return;
                }

                int materiaId = Convert.ToInt32(cboMateria.SelectedValue);
                int seccionId = Convert.ToInt32(cboSeccion.SelectedValue);

                _repo.Update(_currentId.Value, materiaId, seccionId);
                MessageBox.Show("Curso actualizado correctamente");
                LoadDataGridView("");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void BtnEliminar_Click(object? sender, EventArgs e)
        {
            if (!_currentId.HasValue)
            {
                MessageBox.Show("Seleccione un curso primero");
                return;
            }

            if (MessageBox.Show("¿Está seguro de eliminar este curso?", "Confirmar",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    _repo.Delete(_currentId.Value);
                    MessageBox.Show("Curso eliminado correctamente");
                    _currentId = null;
                    LoadDataGridView("");
                    LimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        private void BtnLimpiar_Click(object? sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            cboMateria.SelectedIndex = -1;
            cboSeccion.SelectedIndex = -1;
            txtBuscar.Text = "";
            _currentId = null;
        }
    }
}