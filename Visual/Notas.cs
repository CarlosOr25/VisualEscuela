using System;
using System.Windows.Forms;
using Npgsql;
using System.Text.Json;

namespace Visual
{
    public partial class Notas : UserControl
    {
        public Notas()
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

                    using (var cmd = new NpgsqlCommand(queries["InsertCalificacion"], conn))
                    {
                        // Obtener ID de inscripción
                        cmd.Parameters.AddWithValue("inscripcion", GetInscripcionId(txtCI.Text));
                        cmd.Parameters.AddWithValue("nota", decimal.Parse(txtNota.Text));

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Nota registrada exitosamente!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private int GetInscripcionId(string ci)
        {
            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();

                    var json = System.IO.File.ReadAllText("queries.json");
                    var queries = JsonSerializer.Deserialize<System.Collections.Generic.Dictionary<string, string>>(json);

                    using (var cmd = new NpgsqlCommand(queries["GetInscripcionId"], conn))
                    {
                        cmd.Parameters.AddWithValue("ci", ci);
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