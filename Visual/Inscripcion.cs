﻿using System;
using System.Windows.Forms;
using Npgsql;
using System.Text.Json;

namespace Visual
{
    public partial class Inscripcion : UserControl
    {
        public Inscripcion()
        {
            InitializeComponent();
            btnInscribir.Click += BtnInscribir_Click;
        }

        private void BtnInscribir_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();

                    var json = System.IO.File.ReadAllText("queries.json");
                    var queries = JsonSerializer.Deserialize<System.Collections.Generic.Dictionary<string, string>>(json);

                    using (var transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            // 1. Crear persona (estudiante)
                            int personaId;
                            using (var cmd = new NpgsqlCommand(queries["InsertPersona"], conn))
                            {
                                cmd.Transaction = transaction;
                                cmd.Parameters.AddWithValue("ci", txtCI.Text);
                                cmd.Parameters.AddWithValue("nombre", $"{txtNombre.Text} {txtApellido.Text}");
                                cmd.Parameters.AddWithValue("tipo", 1); // 1 = Estudiante
                                personaId = Convert.ToInt32(cmd.ExecuteScalar());
                            }

                            // 2. Crear inscripción (simplificado)
                            int inscripcionId;
                            using (var cmd = new NpgsqlCommand(queries["InsertInscripcion"], conn))
                            {
                                cmd.Transaction = transaction;
                                cmd.Parameters.AddWithValue("curso", 1); // ID de curso fijo (ejemplo)
                                cmd.Parameters.AddWithValue("persona", personaId);
                                inscripcionId = Convert.ToInt32(cmd.ExecuteScalar());
                            }

                            transaction.Commit();
                            MessageBox.Show($"Inscripción exitosa! ID: {inscripcionId}");
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show($"Error en inscripción: {ex.Message}");
                        }
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