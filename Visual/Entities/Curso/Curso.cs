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
        private int? _currentId = null;

        public Curso()
        {
            InitializeComponent();
            SetupCRUDControls();
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
                txtMateria.Text = row.Cells["MateriaNombre"].Value?.ToString() ?? "";
                txtSeccion.Text = row.Cells["SeccionNombre"].Value?.ToString() ?? "";
            }
        }

        private void BtnGuardar_Click(object? sender, EventArgs e)
        {
            try
            {
                int materiaId = _repo.GetMateriaId(txtMateria.Text);
                int seccionId = _repo.GetSeccionId(txtSeccion.Text);

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
                int materiaId = _repo.GetMateriaId(txtMateria.Text);
                int seccionId = _repo.GetSeccionId(txtSeccion.Text);

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
            txtMateria.Text = "";
            txtSeccion.Text = "";
            txtBuscar.Text = "";
            _currentId = null;
        }
    }
}