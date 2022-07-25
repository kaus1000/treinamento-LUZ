using System;

namespace SchoolApp.Utils
{
    public class PostgreSql : IDbCrud
    {
        private readonly NpgsqlConnectionStringBuilder _conexao;

        public PostgreSql(string host, string usuario, string senha, string bancoDeDados)
        {
            var str = new NpgsqlConnectionStringBuilder
            {
                Host = host,
                Username = usuario,
                Password = senha,
                Database = bancoDeDados,
                Port = 5432
            };

            _conexao = new NpgsqlConnection(str.ConnectionString);

            Conectar();
        }


        public void Conectar() { _conexao.Open(); }

        public void Desconectar() { _conexao.Close(); }

        private class NpgsqlConnectionStringBuilder
        {
            public string Host { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }
            public string Database { get; set; }
            public int Port { get; set; }
            public object ConnectionString { get; internal set; }

            internal void Close()
            {
                throw new NotImplementedException();
            }

            internal void Open()
            {
                throw new NotImplementedException();
            }
        }

        private class NpgsqlConnection : NpgsqlConnectionStringBuilder
        {
            private object connectionString;

            public NpgsqlConnection(object connectionString)
            {
                this.connectionString = connectionString;
            }
        }
    }
}