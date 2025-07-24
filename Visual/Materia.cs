using System;
using System.Windows.Forms;
using Npgsql;
using System.Text.Json;

namespace Visual
{
    public partial class Materia : UserControl
    {
        public Materia()
        {
            InitializeComponent();
            btnGuardar.Click += BtnGuardar_Click;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();

                    var json = System.IO.File.ReadAllText("queries.json");
                    var queries = JsonSerializer.Deserialize<System.Collections.Generic.Dictionary<string, string>>(json);

                    using (var cmd = new NpgsqlCommand(queries["InsertMateria"], conn))
                    {
                        cmd.Parameters.AddWithValue("nombre", txtNombre.Text);
                        var id = cmd.ExecuteScalar();
                        MessageBox.Show($"Materia creada con ID: {id}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}