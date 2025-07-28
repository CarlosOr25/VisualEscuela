using Npgsql;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Visual.Data.Repositories
{
    public class CursoRepository
    {
        private static readonly string QUERIES_PATH = Path.Combine(Directory.GetCurrentDirectory(), "Queries", "CursoQueries.json");

        private Dictionary<string, string> LoadQueries()
        {
            string json = File.ReadAllText(QUERIES_PATH);
            return JsonSerializer.Deserialize<Dictionary<string, string>>(json)
                ?? new Dictionary<string, string>();
        }

        public int Create(int materiaId, int seccionId)
        {
            var queries = LoadQueries();
            using (var conn = DBConnection.GetConnection())
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(queries["InsertCurso"], conn))
                {
                    cmd.Parameters.AddWithValue("materia", materiaId);
                    cmd.Parameters.AddWithValue("seccion", seccionId);
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
                using (var cmd = new NpgsqlCommand(queries["GetCursoById"], conn))
                {
                    cmd.Parameters.AddWithValue("id", id);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new
                            {
                                Id = reader.GetInt32(0),
                                MateriaId = reader.GetInt32(1),
                                SeccionId = reader.GetInt32(2)
                            };
                        }
                    }
                }
            }
            return null;
        }

        public void Update(int id, int materiaId, int seccionId)
        {
            var queries = LoadQueries();
            using (var conn = DBConnection.GetConnection())
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(queries["UpdateCurso"], conn))
                {
                    cmd.Parameters.AddWithValue("id", id);
                    cmd.Parameters.AddWithValue("materia", materiaId);
                    cmd.Parameters.AddWithValue("seccion", seccionId);
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
                using (var cmd = new NpgsqlCommand(queries["DeleteCurso"], conn))
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
                using (var cmd = new NpgsqlCommand(queries["SearchCurso"], conn))
                {
                    cmd.Parameters.AddWithValue("search", $"%{searchTerm}%");
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            results.Add(new
                            {
                                Id = reader.GetInt32(0),
                                MateriaId = reader.GetInt32(1),
                                SeccionId = reader.GetInt32(2),
                                MateriaNombre = reader.GetString(3),
                                SeccionNombre = reader.GetString(4)
                            });
                        }
                    }
                }
            }
            return results;
        }

        public int GetMateriaId(string nombre)
        {
            var queries = LoadQueries();
            using (var conn = DBConnection.GetConnection())
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(queries["GetMateriaId"], conn))
                {
                    cmd.Parameters.AddWithValue("nombre", $"%{nombre}%");
                    var result = cmd.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : 1;
                }
            }
        }

        public int GetSeccionId(string nombre)
        {
            var queries = LoadQueries();
            using (var conn = DBConnection.GetConnection())
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(queries["GetSeccionId"], conn))
                {
                    cmd.Parameters.AddWithValue("nombre", $"%{nombre}%");
                    var result = cmd.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : 1;
                }
            }
        }

        public List<dynamic> GetAll()
        {
            var results = new List<dynamic>();
            var queries = LoadQueries();
            using (var conn = DBConnection.GetConnection())
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(queries["GetAllCursos"], conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            results.Add(new
                            {
                                Id = reader.GetInt32(0),
                                MateriaId = reader.GetInt32(1),
                                SeccionId = reader.GetInt32(2),
                                MateriaNombre = reader.GetString(3),
                                SeccionNombre = reader.GetString(4)
                            });
                        }
                    }
                }
            }
            return results;
        }
    }
}