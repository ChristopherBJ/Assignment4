
using Npgsql;



var connectionString = "host=localhost;db=postgres;uid=postgres;pwd=Graese3600";


using var connection = new NpgsqlConnection(connectionString);
connection.Open();

using var cmd = new NpgsqlCommand();

cmd.Connection = connection;
cmd.CommandText = "select * from categories";

using var reader = cmd.ExecuteReader();

while(reader.Read())
{
    Console.WriteLine(reader.GetInt32(0));
}