using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SQLite;
using System.Data.SQLite;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace PMV_Control
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
            

        private void btnEntrar_Click_1(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "" && txtSenha.Text == "")
            {
                FormMenu menu = new FormMenu();
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            SQLiteConnection conn = Conexão.Abrir();

            string check = "SELECT COUNT(*) FROM usuarios WHERE usuario='admin'";

            SQLiteCommand cmdCheck = new SQLiteCommand(check, conn);


            string criarTabela = @"CREATE TABLE IF NOT EXISTS usuarios(
                                     id INTEGER PRIMARY KEY AUTOINCREMENT,
                                                             usuario TEXT,
                                                               senha TEXT )";


                SQLiteCommand cmdCriar = new SQLiteCommand(criarTabela, conn);
                cmdCriar.ExecuteNonQuery();
            string criarProdutos =   @"CREATE TABLE IF NOT EXISTS produtos(
                                     id INTEGER PRIMARY KEY AUTOINCREMENT,
                                     nome TEXT,
                                     preco REAL,
                                     estoque INTEGER)";


            SQLiteCommand cmdProdutos = new SQLiteCommand(criarProdutos, conn);
            cmdProdutos.ExecuteNonQuery();

            try
            {
                string addColuna = "ALTER TABLE produtos ADD COLUMN tamanho TEXT;";
                SQLiteCommand cmdAlter = new SQLiteCommand(addColuna, conn);
                cmdAlter.ExecuteNonQuery();
            }
            catch
            {
                // Se já existir, ignora o erro
            }

            int existe = Convert.ToInt32(cmdCheck.ExecuteScalar());

            if (existe == 0)
            {
                string sql = "INSERT INTO usuarios(usuario,senha) VALUES('admin','123')";
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
        }

       
    }
    }
    



