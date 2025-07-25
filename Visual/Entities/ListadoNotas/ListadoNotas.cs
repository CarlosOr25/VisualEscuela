using System;
using System.Windows.Forms;
using Visual.Data.Repositories;
using System.Data;

namespace Visual.Entities.ListadoNotas
{
    public partial class ListadoNotas : UserControl
    {
        private readonly NotasRepository _repo = new NotasRepository();

        public ListadoNotas()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void CargarDatos()
        {
            dgvNotas.DataSource = _repo.GetListadoNotas();

            if (dgvNotas.Columns["Nota"] != null)
            {
                dgvNotas.Columns["Nota"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvNotas.Columns["Nota"].DefaultCellStyle.Format = "N2";
            }
        }
    }
}