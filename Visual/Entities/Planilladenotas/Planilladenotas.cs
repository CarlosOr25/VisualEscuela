using System;
using System.Windows.Forms;
using Visual.Data.Repositories;
using System.Data;

namespace Visual.Entities.Planilladenotas
{
    public partial class Planilladenotas : UserControl
    {
        private readonly NotasRepository _repo = new NotasRepository();

        public Planilladenotas()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void CargarDatos()
        {
            dgvNotas.DataSource = _repo.GetPlanillaNotas();

            if (dgvNotas.Columns["Nota"] != null)
            {
                dgvNotas.Columns["Nota"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvNotas.Columns["Nota"].DefaultCellStyle.Format = "N2";
            }
        }
    }
}