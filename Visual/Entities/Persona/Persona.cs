using System;
using System.Windows.Forms;
using Visual.Data.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace Visual.Entities.Persona
{
    public partial class Persona : UserControl
    {
        private readonly PersonaRepository _repo = new PersonaRepository();
        private int? _currentId = null;

        public Persona()
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
            dgvPersonas.SelectionChanged += DgvPersonas_SelectionChanged;
        }

        private void LoadDataGridView(string searchTerm)
        {
            var data = _repo.Search(searchTerm);
            dgvPersonas.DataSource = data;
        }

        private void DgvPersonas_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvPersonas.SelectedRows.Count > 0)
            {
                var row = dgvPersonas.SelectedRows[0];
                _currentId = Convert.ToInt32(row.Cells["Id"].Value);
                txtCI.Text = row.Cells["CI"].Value?.ToString() ?? "";

                var nombreCompleto = row.Cells["Nombre"].Value?.ToString()?.Split(' ') ?? Array.Empty<string>();
                txtNombre.Text = nombreCompleto.Length > 0 ? nombreCompleto[0] : "";
                txtApellido.Text = nombreCompleto.Length > 1 ? nombreCompleto[1] : "";
                txtTipo.Text = row.Cells["TipoId"].Value?.ToString() ?? "";
            }
        }

        private void BtnGuardar_Click(object? sender, EventArgs e)
        {
            try
            {
                string ci = txtCI.Text;
                string nombreCompleto = $"{txtNombre.Text} {txtApellido.Text}";
                int tipoId = _repo.GetTipoPersonaId(txtTipo.Text);

                int id = _repo.Create(ci, nombreCompleto, tipoId);
                _currentId = id;
                MessageBox.Show($"Persona creada con ID: {id}");
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
                MessageBox.Show("Seleccione una persona primero");
                return;
            }

            try
            {
                string ci = txtCI.Text;
                string nombreCompleto = $"{txtNombre.Text} {txtApellido.Text}";
                int tipoId = _repo.GetTipoPersonaId(txtTipo.Text);

                _repo.Update(_currentId.Value, ci, nombreCompleto, tipoId);
                MessageBox.Show("Persona actualizada correctamente");
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
                MessageBox.Show("Seleccione una persona primero");
                return;
            }

            if (MessageBox.Show("¿Está seguro de eliminar esta persona?", "Confirmar",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    _repo.Delete(_currentId.Value);
                    MessageBox.Show("Persona eliminada correctamente");
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
            txtCI.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtTipo.Text = "";
            txtBuscar.Text = "";
            _currentId = null;
        }
    }
}