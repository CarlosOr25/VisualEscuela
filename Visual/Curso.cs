using System;
using System.Windows.Forms;
using Npgsql;
using System.Text.Json;

namespace Visual
{
    public partial class Curso : UserControl
    {
        public Curso()
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

                    using (var cmd = new NpgsqlCommand(queries["InsertCurso"], conn))
                    {
                        cmd.Parameters.AddWithValue("materia", GetMateriaId(txtMateria.Text));
                        cmd.Parameters.AddWithValue("seccion", GetSeccionId(txtSeccion.Text));

                        var id = cmd.ExecuteScalar();
                        MessageBox.Show($"Curso creado con ID: {id}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private int GetMateriaId(string nombre)
        {
            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();

                    var json = System.IO.File.ReadAllText("queries.json");
                    var queries = JsonSerializer.Deserialize<System.Collections.Generic.Dictionary<string, string>>(json);

                    using (var cmd = new NpgsqlCommand(queries["GetMateriaId"], conn))
                    {
                        cmd.Parameters.AddWithValue("nombre", $"%{nombre}%");
                        return Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
            }
            catch
            {
                return 1;
            }
        }

        private int GetSeccionId(string nombre)
        {
            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();

                    var json = System.IO.File.ReadAllText("queries.json");
                    var queries = JsonSerializer.Deserialize<System.Collections.Generic.Dictionary<string, string>>(json);

                    using (var cmd = new NpgsqlCommand(queries["GetSeccionId"], conn))
                    {
                        cmd.Parameters.AddWithValue("nombre", $"%{nombre}%");
                        return Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
            }
            catch
            {
                return 1;
            }
        }
    }
}