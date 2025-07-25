using Npgsql;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Visual.Data.Repositories
{
    public class MateriaRepository
    {
        private static readonly string QUERIES_PATH = Path.Combine(Directory.GetCurrentDirectory(), "Queries", "MateriaQueries.json");

        private Dictionary<string, string> LoadQueries()
        {
            string json = File.ReadAllText(QUERIES_PATH);
            return JsonSerializer.Deserialize<Dictionary<string, string>>(json)
                ?? new Dictionary<string, string>();
        }

        public int Create(string nombre)
        {
            var queries = LoadQueries();
            using (var conn = DBConnection.GetConnection())
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(queries["InsertMateria"], conn))
                {
                    cmd.Parameters.AddWithValue("nombre", nombre);
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
                using (var cmd = new NpgsqlCommand(queries["GetMateriaById"], conn))
                {
                    cmd.Parameters.AddWithValue("id", id);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new
                            {
                                Id = reader.GetInt32(0),
                                Nombre = reader.GetString(1)
                            };
                        }
                    }
                }
            }
            return null;
        }

        public dynamic? GetByNombre(string nombre)
        {
            var queries = LoadQueries();
            using (var conn = DBConnection.GetConnection())
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(queries["GetMateriaByNombre"], conn))
                {
                    cmd.Parameters.AddWithValue("nombre", $"%{nombre}%");
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new
                            {
                                Id = reader.GetInt32(0),
                                Nombre = reader.GetString(1)
                            };
                        }
                    }
                }
            }
            return null;
        }

        public void Update(int id, string nombre)
        {
            var queries = LoadQueries();
            using (var conn = DBConnection.GetConnection())
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(queries["UpdateMateria"], conn))
                {
                    cmd.Parameters.AddWithValue("id", id);
                    cmd.Parameters.AddWithValue("nombre", nombre);
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
                using (var cmd = new NpgsqlCommand(queries["DeleteMateria"], conn))
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
                using (var cmd = new NpgsqlCommand(queries["SearchMateria"], conn))
                {
                    cmd.Parameters.AddWithValue("search", $"%{searchTerm}%");
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            results.Add(new
                            {
                                Id = reader.GetInt32(0),
                                Nombre = reader.GetString(1)
                            });
                        }
                    }
                }
            }
            return results;
        }
    }
}