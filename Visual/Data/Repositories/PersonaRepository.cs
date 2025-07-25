using Npgsql;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Visual.Data.Repositories
{
    public class PersonaRepository
    {
        private static readonly string QUERIES_PATH = Path.Combine(Directory.GetCurrentDirectory(), "Queries", "PersonaQueries.json");

        private Dictionary<string, string> LoadQueries()
        {
            string json = File.ReadAllText(QUERIES_PATH);
            return JsonSerializer.Deserialize<Dictionary<string, string>>(json)
                ?? new Dictionary<string, string>();
        }

        public int Create(string ci, string nombre, int tipoId)
        {
            var queries = LoadQueries();
            using (var conn = DBConnection.GetConnection())
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(queries["InsertPersona"], conn))
                {
                    cmd.Parameters.AddWithValue("ci", ci);
                    cmd.Parameters.AddWithValue("nombre", nombre);
                    cmd.Parameters.AddWithValue("tipo", tipoId);
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
                using (var cmd = new NpgsqlCommand(queries["GetPersonaById"], conn))
                {
                    cmd.Parameters.AddWithValue("id", id);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new
                            {
                                Id = reader.GetInt32(0),
                                CI = reader.GetString(1),
                                Nombre = reader.GetString(2),
                                TipoId = reader.GetInt32(3)
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
                using (var cmd = new NpgsqlCommand(queries["GetPersonaByCi"], conn))
                {
                    cmd.Parameters.AddWithValue("ci", ci);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new
                            {
                                Id = reader.GetInt32(0),
                                CI = reader.GetString(1),
                                Nombre = reader.GetString(2),
                                TipoId = reader.GetInt32(3)
                            };
                        }
                    }
                }
            }
            return null;
        }

        public void Update(int id, string ci, string nombre, int tipoId)
        {
            var queries = LoadQueries();
            using (var conn = DBConnection.GetConnection())
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(queries["UpdatePersona"], conn))
                {
                    cmd.Parameters.AddWithValue("id", id);
                    cmd.Parameters.AddWithValue("ci", ci);
                    cmd.Parameters.AddWithValue("nombre", nombre);
                    cmd.Parameters.AddWithValue("tipo", tipoId);
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
                using (var cmd = new NpgsqlCommand(queries["DeletePersona"], conn))
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
                using (var cmd = new NpgsqlCommand(queries["SearchPersona"], conn))
                {
                    cmd.Parameters.AddWithValue("search", $"%{searchTerm}%");
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            results.Add(new
                            {
                                Id = reader.GetInt32(0),
                                CI = reader.GetString(1),
                                Nombre = reader.GetString(2),
                                TipoId = reader.GetInt32(3)
                            });
                        }
                    }
                }
            }
            return results;
        }

        public int GetTipoPersonaId(string tipo)
        {
            var queries = LoadQueries();
            using (var conn = DBConnection.GetConnection())
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(queries["GetTipoPersonaId"], conn))
                {
                    cmd.Parameters.AddWithValue("tipo", $"%{tipo}%");
                    var result = cmd.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : 1;
                }
            }
        }
    }
}