using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace PMV_Control
{
    public class Conexão
    {
        public static SQLiteConnection Abrir()
        {
            string caminho = @"Data Source=erp.db;Version=3;";
            SQLiteConnection conn = new SQLiteConnection(caminho);
            conn.Open();
            return conn;
        }
    }
}
