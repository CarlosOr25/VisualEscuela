using Npgsql;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Visual.Data.Repositories
{
    public class InscripcionRepository
    {
        private static readonly string QUERIES_PATH = Path.Combine(Directory.GetCurrentDirectory(), "Queries", "InscripcionQueries.json");

        private Dictionary<string, string> LoadQueries()
        {
            string json = File.ReadAllText(QUERIES_PATH);
            return JsonSerializer.Deserialize<Dictionary<string, string>>(json)
                ?? new Dictionary<string, string>();
        }

        public int Create(int cursoId, int personaId)
        {
            var queries = LoadQueries();
            using (var conn = DBConnection.GetConnection())
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(queries["InsertInscripcion"], conn))
                {
                    cmd.Parameters.AddWithValue("curso", cursoId);
                    cmd.Parameters.AddWithValue("persona", personaId);
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        public dynamic? GetById(int id)
        {
            var queries = LoadQueries();
            using (var conn = DBConnection.GetConnection())
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(queries["GetInscripcionById"], conn))
                {
                    cmd.Parameters.AddWithValue("id", id);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new
                            {
                                Id = reader.GetInt32(0),
                                CursoId = reader.GetInt32(1),
                                PersonaId = reader.GetInt32(2)
                            };
                        }
                    }
                }
            }
            return null;
        }

        public dynamic? GetByCi(string ci)
        {
            var queries = LoadQueries();
            using (var conn = DBConnection.GetConnection())
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(queries["GetInscripcionByCi"], conn))
                {
                    cmd.Parameters.AddWithValue("ci", ci);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new
                            {
                                Id = reader.GetInt32(0),
                                CursoId = reader.GetInt32(1),
                                PersonaId = reader.GetInt32(2)
                            };
                        }
                    }
                }
            }
            return null;
        }

        public void Update(int id, int cursoId, int personaId)
        {
            var queries = LoadQueries();
            using (var conn = DBConnection.GetConnection())
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(queries["UpdateInscripcion"], conn))
                {
                    cmd.Parameters.AddWithValue("id", id);
                    cmd.Parameters.AddWithValue("curso", cursoId);
                    cmd.Parameters.AddWithValue("persona", personaId);
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
                using (var cmd = new NpgsqlCommand(queries["DeleteInscripcion"], conn))
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
                using (var cmd = new NpgsqlCommand(queries["SearchInscripcion"], conn))
                {
                    cmd.Parameters.AddWithValue("search", $"%{searchTerm}%");
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            results.Add(new
                            {
                                Id = reader.GetInt32(0),
                                CursoId = reader.GetInt32(1),
                                PersonaId = reader.GetInt32(2),
                                Estudiante = reader.GetString(3),
                                Materia = reader.GetString(4)
                            });
                        }
                    }
                }
            }
            return results;
        }
    }
}