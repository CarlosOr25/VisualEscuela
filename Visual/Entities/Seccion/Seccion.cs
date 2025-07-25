using System;
using System.Windows.Forms;
using Visual.Data.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace Visual.Entities.Seccion
{
    public partial class Seccion : UserControl
    {
        private readonly SeccionRepository _repo = new SeccionRepository();
        private int? _currentId = null;

        public Seccion()
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
            dgvSecciones.SelectionChanged += DgvSecciones_SelectionChanged;
        }

        private void LoadDataGridView(string searchTerm)
        {
            var data = _repo.Search(searchTerm);
            dgvSecciones.DataSource = data;
        }

        private void DgvSecciones_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvSecciones.SelectedRows.Count > 0)
            {
                var row = dgvSecciones.SelectedRows[0];
                _currentId = Convert.ToInt32(row.Cells["Id"].Value);
                txtNombre.Text = row.Cells["Nombre"].Value.ToString();
            }
        }

        private void BtnGuardar_Click(object? sender, EventArgs e)
        {
            try
            {
                int id = _repo.Create(txtNombre.Text);
                _currentId = id;
                MessageBox.Show($"Sección creada con ID: {id}");
                LoadDataGridView("");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void BtnBuscar_Click(object? sender, EventArgs e) => LoadDataGridView(txtBuscar.Text);

        private void BtnActualizar_Click(object? sender, EventArgs e)
        {
            if (!_currentId.HasValue)
            {
                MessageBox.Show("Seleccione una sección primero");
                return;
            }

            try
            {
                _repo.Update(_currentId.Value, txtNombre.Text);
                MessageBox.Show("Sección actualizada correctamente");
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
                MessageBox.Show("Seleccione una sección primero");
                return;
            }

            if (MessageBox.Show("¿Está seguro de eliminar esta sección?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    _repo.Delete(_currentId.Value);
                    MessageBox.Show("Sección eliminada correctamente");
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

        private void BtnLimpiar_Click(object? sender, EventArgs e) => LimpiarCampos();

        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtBuscar.Text = "";
            _currentId = null;
        }
    }
}