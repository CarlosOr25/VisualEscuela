using System;
using System.Windows.Forms;
using Npgsql;
using System.Text.Json;
using System.IO;

namespace Visual
{
    public partial class Persona : UserControl
    {
        public Persona()
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

                    // Cargar consultas desde JSON
                    var json = File.ReadAllText("queries.json");
                    var queries = JsonSerializer.Deserialize<System.Collections.Generic.Dictionary<string, string>>(json);

                    using (var cmd = new NpgsqlCommand(queries["InsertPersona"], conn))
                    {
                        cmd.Parameters.AddWithValue("ci", txtCI.Text);
                        cmd.Parameters.AddWithValue("nombre", $"{txtNombre.Text} {txtApellido.Text}");
                        cmd.Parameters.AddWithValue("tipo", GetTipoPersonaId(txtTipo.Text));

                        var id = cmd.ExecuteScalar();
                        MessageBox.Show($"Persona creada con ID: {id}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private int GetTipoPersonaId(string tipo)
        {
            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();

                    var json = File.ReadAllText("queries.json");
                    var queries = JsonSerializer.Deserialize<System.Collections.Generic.Dictionary<string, string>>(json);

                    using (var cmd = new NpgsqlCommand(queries["GetTipoPersonaId"], conn))
                    {
                        cmd.Parameters.AddWithValue("tipo", $"%{tipo}%");
                        var result = cmd.ExecuteScalar();
                        return result != null ? Convert.ToInt32(result) : 1;
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