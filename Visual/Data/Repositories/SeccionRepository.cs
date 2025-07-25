using Npgsql;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Visual.Data.Repositories
{
    public class SeccionRepository
    {
        private static readonly string QUERIES_PATH = Path.Combine(Directory.GetCurrentDirectory(), "Queries", "SeccionQueries.json");

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
                using (var cmd = new NpgsqlCommand(queries["InsertSeccion"], conn))
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
                using (var cmd = new NpgsqlCommand(queries["GetSeccionById"], conn))
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

        public void Update(int id, string nombre)
        {
            var queries = LoadQueries();
            using (var conn = DBConnection.GetConnection())
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(queries["UpdateSeccion"], conn))
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
                using (var cmd = new NpgsqlCommand(queries["DeleteSeccion"], conn))
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
                using (var cmd = new NpgsqlCommand(queries["SearchSeccion"], conn))
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