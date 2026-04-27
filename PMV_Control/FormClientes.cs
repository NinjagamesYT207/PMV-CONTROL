using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMV_Control

    {
        public partial class FormClientes : Form
        {
            DataTable tabela = new DataTable();

            public FormClientes()
            {
                InitializeComponent();

                tabela.Columns.Add("Nome");
                tabela.Columns.Add("Telefone");
                tabela.Columns.Add("Email");

                gridClientes.DataSource = tabela;
            }

            private void btnSalvar_Click(object sender, EventArgs e)
            {
                tabela.Rows.Add(
                    txtNome.Text,
                    txtTelefone.Text,
                    txtEmail.Text
                );

                txtNome.Clear();
                txtTelefone.Clear();
                txtEmail.Clear();
            }

        private void FormClientes_Load(object sender, EventArgs e)
        {

        }
    }
    }


