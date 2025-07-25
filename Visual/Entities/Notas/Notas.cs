using System;
using System.Windows.Forms;
using Visual.Data.Repositories;
using System.Collections.Generic;
using System.Linq;
using Visual.Entities.ListadoNotas;

namespace Visual.Entities.Notas
{
    public partial class Notas : UserControl
    {
        private readonly NotasRepository _repo = new NotasRepository();
        private int? _currentId = null;

        public Notas()
        {
            InitializeComponent();
            SetupCRUDControls();
            LoadDataGridView("");
        }

        private void SetupCRUDControls()
        {
            btnGuardar.Click += BtnGuardar_Click;
            btnBuscar.Click += BtnBuscar_Click;
            dgvNotas.SelectionChanged += DgvNotas_SelectionChanged;
            btnSalir.Click += (s, e) => this.Parent?.Controls.Remove(this);
            btnListado.Click += (s, e) => CargarListadoNotas();
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
                txtCI.Text = row.Cells["Estudiante"].Value?.ToString()?.Split('-')[0].Trim() ?? "";
                txtNota.Text = row.Cells["Nota"].Value?.ToString() ?? "";
            }
        }

        private void BtnGuardar_Click(object? sender, EventArgs e)
        {
            try
            {
                int inscripcionId = _repo.GetInscripcionId(txtCI.Text);
                decimal nota = decimal.Parse(txtNota.Text);

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

        private void BtnActualizar_Click(object? sender, EventArgs e)
        {
            if (!_currentId.HasValue)
            {
                MessageBox.Show("Seleccione una nota primero");
                return;
            }

            try
            {
                decimal nota = decimal.Parse(txtNota.Text);
                _repo.Update(_currentId.Value, nota);
                MessageBox.Show("Nota actualizada correctamente");
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
                MessageBox.Show("Seleccione una nota primero");
                return;
            }

            if (MessageBox.Show("¿Está seguro de eliminar esta nota?", "Confirmar",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    _repo.Delete(_currentId.Value);
                    MessageBox.Show("Nota eliminada correctamente");
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
            txtNota.Text = "";
            txtBuscar.Text = "";
            _currentId = null;
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