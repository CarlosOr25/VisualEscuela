using Npgsql;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text.Json;

namespace Visual.Data.Repositories
{
    public class NotasRepository
    {
        private const string QUERIES_PATH = @"Queries\NotasQueries.json";

        private Dictionary<string, string> LoadQueries()
        {
            try
            {
                string fullPath = Path.Combine(Directory.GetCurrentDirectory(), QUERIES_PATH);
                string json = File.ReadAllText(fullPath);
                return JsonSerializer.Deserialize<Dictionary<string, string>>(json)
                    ?? new Dictionary<string, string>();
            }
            catch
            {
                return new Dictionary<string, string>();
            }
        }

        public void Create(int inscripcionId, decimal nota)
        {
            var queries = LoadQueries();
            using (var conn = DBConnection.GetConnection())
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(queries["InsertCalificacion"], conn))
                {
                    cmd.Parameters.AddWithValue("inscripcion", inscripcionId);
                    cmd.Parameters.AddWithValue("nota", nota);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public dynamic? GetById(int id)
        {
            var queries = LoadQueries();
            using (var conn = DBConnection.GetConnection())
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(queries["GetCalificacionById"], conn))
                {
                    cmd.Parameters.AddWithValue("id", id);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new
                            {
                                Id = reader.GetInt32(0),
                                InscripcionId = reader.GetInt32(1),
                                Nota = reader.GetDecimal(2)
                            };
                        }
                    }
                }
            }
            return null;
        }

        public void Update(int id, decimal nota)
        {
            var queries = LoadQueries();
            using (var conn = DBConnection.GetConnection())
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(queries["UpdateCalificacion"], conn))
                {
                    cmd.Parameters.AddWithValue("id", id);
                    cmd.Parameters.AddWithValue("nota", nota);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Delete(int id)
        {
            var queries = LoadQueries();
            using (var conn = DBConnection.GetConnection())
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(queries["DeleteCalificacion"], conn))
                {
                    cmd.Parameters.AddWithValue("id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<dynamic> Search(string searchTerm)
        {
            var results = new List<dynamic>();
            var queries = LoadQueries();
            using (var conn = DBConnection.GetConnection())
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(queries["SearchCalificacion"], conn))
                {
                    cmd.Parameters.AddWithValue("search", $"%{searchTerm}%");
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            results.Add(new
                            {
                                Id = reader.GetInt32(0),
                                Nota = reader.GetDecimal(2),
                                Nombre = reader.GetString(4),  // Nombre del estudiante
                                CI = reader.GetString(3),      // CI del estudiante
                                Materia = reader.GetString(5)            // Materia
                            });
                        }
                    }
                }
            }
            return results;
        }

        public DataTable GetListadoNotas()
        {
            var dt = new DataTable();
            var queries = LoadQueries();
            using (var conn = DBConnection.GetConnection())
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(queries["ListadoNotas"], conn))
                {
                    using (var adapter = new NpgsqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }

            if (dt.Columns.Contains("CI"))
            {
                dt.Columns["CI"].ColumnName = "Nombre_temp";
            }

            if (dt.Columns.Contains("Estudiante"))
            {
                dt.Columns["Estudiante"].ColumnName = "CI";
            }

            if (dt.Columns.Contains("Nombre_temp"))
            {
                dt.Columns["Nombre_temp"].ColumnName = "Nombre";
            }

            return dt;
        }

        public int GetInscripcionId(string ci)
        {
            var queries = LoadQueries();
            using (var conn = DBConnection.GetConnection())
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(queries["GetInscripcionId"], conn))
                {
                    cmd.Parameters.AddWithValue("ci", ci);
                    var result = cmd.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : 1;
                }
            }
        }

        public DataTable GetPlanillaNotas()
        {
            var dt = new DataTable();
            var queries = LoadQueries();
            using (var conn = DBConnection.GetConnection())
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(queries["PlanillaNotas"], conn))
                {
                    using (var adapter = new NpgsqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            return dt;
        }
    }
}