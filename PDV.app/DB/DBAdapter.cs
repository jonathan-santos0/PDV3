
using Microsoft.Data.Sqlite;
using System.Data;
using System.Diagnostics;

namespace PDV.app.DB
{
     
    /// <summary>
    /// Auxilia o uso do banco de dados. 
    /// </summary>
    public static class DBAdapter
    {
        private static SqliteConnection? _conn = null;

        /// <summary>
        /// Faz a tentativa de login no banco.
        /// </summary>
        /// <param name="userName">Nome de usuário</param>
        /// <param name="password">Informar senha</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static bool AttemptLogin(string userName, string password)
        {
            SqliteConnection conn = GetConn();
            SqliteCommand comm = conn.CreateCommand();
            comm.CommandText =
            "SELECT * " +
            "FROM USERS";

            using (SqliteDataReader reader = comm.ExecuteReader())
            {
                while (reader.Read())
                {
                    var name = reader["ST_LOGIN"].ToString();
                    var pass = reader["ST_PASSWORD"].ToString();
                    bool inactive = reader.GetBoolean("BL_INACTIVE");
                    int inactiveInt = reader.GetInt32("BL_INACTIVE");
                    string inactiveStr = inactive ? "inactive" : "active";
                    Debug.WriteLine($"Hello, {name} password: {pass}, status: {inactiveInt} / {inactive} - {inactiveStr}");
                }
            } 
            return false;
        }
        /// <summary>
        /// Devolve a conexão do SQLite
        /// </summary>
        /// <returns></returns>
        private static SqliteConnection GetConn() 
        {
            //Testar se já existe a conexão
            if (_conn == null)
            {
                _conn = new SqliteConnection("Data Source=pdv_db.db");
                _conn.Open();
            }
            return _conn;
        }
    }   

}
