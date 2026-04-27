using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMV_Control
{
    public partial class FormProdutos : Form
    {


        public FormProdutos()
        {
            InitializeComponent();

        }
        
        
        private void FormProdutos_Load(object sender, EventArgs e)
        {

            SQLiteConnection conn = Conexão.Abrir();

            string sql = "SELECT * FROM produtos";

            SQLiteDataAdapter da = new SQLiteDataAdapter(sql, conn);

            DataTable dt = new DataTable();

            da.Fill(dt);

            gridProdutos.DataSource = dt;

            CarregarProdutos();


        }
        void CarregarProdutos()
        {
            SQLiteConnection conn = Conexão.Abrir();

            string sql = "SELECT * FROM produtos";

            SQLiteDataAdapter da = new SQLiteDataAdapter(sql, conn);

            DataTable dt = new DataTable();

            da.Fill(dt);

            gridProdutos.DataSource = dt;
        }


        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            SQLiteConnection conn = Conexão.Abrir();

            string sql = "INSERT INTO produtos(nome,preco,estoque,tamanho) VALUES(@nome,@preco,@estoque,@tamanho)";

            SQLiteCommand cmd = new SQLiteCommand(sql, conn);

            cmd.Parameters.AddWithValue("@nome", txtNome.Text);
            cmd.Parameters.AddWithValue("@preco", txtPreco.Text);
            cmd.Parameters.AddWithValue("@estoque", txtEstoque.Text);
            cmd.Parameters.AddWithValue("@tamanho", textTamanho.Text);


            cmd.ExecuteNonQuery();

            MessageBox.Show("Produto cadastrado!");

            CarregarProdutos(); // ATUALIZA O GRID
        }

        private void gridProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            txtId.Text = gridProdutos.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = gridProdutos.CurrentRow.Cells[1].Value.ToString();
            txtPreco.Text = gridProdutos.CurrentRow.Cells[2].Value.ToString();
            txtEstoque.Text = gridProdutos.CurrentRow.Cells[3].Value.ToString();
            textTamanho.Text = gridProdutos.CurrentRow.Cells[4].Value.ToString();
        }

        private void txtEstoque_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            SQLiteConnection conn = Conexão.Abrir();

            string sql = "UPDATE produtos SET nome=@nome, preco=@preco, estoque=@estoque WHERE id=@id";

            SQLiteCommand cmd = new SQLiteCommand(sql, conn);

            cmd.Parameters.AddWithValue("@nome", txtNome.Text);
            cmd.Parameters.AddWithValue("@preco", txtPreco.Text);
            cmd.Parameters.AddWithValue("@estoque", txtEstoque.Text);
            cmd.Parameters.AddWithValue("@id", txtId.Text);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Produto atualizado!");

            CarregarProdutos();
        }

        private void gridProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                txtId.Text = gridProdutos.Rows[e.RowIndex].Cells["id"].Value.ToString();
                txtNome.Text = gridProdutos.Rows[e.RowIndex].Cells["nome"].Value.ToString();
                txtPreco.Text = gridProdutos.Rows[e.RowIndex].Cells["preco"].Value.ToString();
                txtEstoque.Text = gridProdutos.Rows[e.RowIndex].Cells["estoque"].Value.ToString();
            }

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            SQLiteConnection conn = Conexão.Abrir();

            string sql = "DELETE FROM produtos WHERE id=@id";

            SQLiteCommand cmd = new SQLiteCommand(sql, conn);

            cmd.Parameters.AddWithValue("@id", txtId.Text);

            cmd.ExecuteNonQuery();

            DialogResult r = MessageBox.Show(
                    "Deseja excluir o produto?",
                    "Confirmar",
                    MessageBoxButtons.YesNo);


            if (r == DialogResult.No)
            {
                return;
            }

            MessageBox.Show("Produto excluído!");

            CarregarProdutos();

        }
    }
    
}

