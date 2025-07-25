using Npgsql;

namespace Visual.Data
{
    public static class DBConnection
    {
        public static NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection("Host=localhost;Port=5432;Database=escuela;Username=postgres;Password=reyes1011");
        }
    }
}