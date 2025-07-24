using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;
using System.Text.Json;

namespace Visual
{
    public partial class ListadoNotas : UserControl
    {
        public ListadoNotas()
        {
            InitializeComponent();
            btnCerrar.Click += (s, e) => this.Parent.Controls.Remove(this);
            CargarNotas();
        }

        private void CargarNotas()
        {
            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();

                    var json = System.IO.File.ReadAllText("queries.json");
                    var queries = JsonSerializer.Deserialize<System.Collections.Generic.Dictionary<string, string>>(json);

                    var query = queries["ListadoNotas"];

                    var adapter = new NpgsqlDataAdapter(query, conn);
                    var dt = new DataTable();
                    adapter.Fill(dt);

                    dgvNotas.DataSource = dt;

                    // Formatear columnas
                    if (dgvNotas.Columns["Nota"] != null)
                    {
                        dgvNotas.Columns["Nota"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                        dgvNotas.Columns["Nota"].DefaultCellStyle.Format = "N2";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar notas: {ex.Message}");
            }
        }
    }
}