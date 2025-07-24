using Npgsql;

namespace Visual
{
    public static class DBComponent
    {
        public static NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection("Host=localhost;Port=5432;Database=escuela;Username=postgres;Password=123456");
        }
    }
}