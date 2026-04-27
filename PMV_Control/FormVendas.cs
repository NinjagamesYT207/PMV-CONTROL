using System;
using System.Globalization;
using System.Windows.Forms;

namespace PMV_Control
{
    public partial class FormVendas : Form
    {
        // Inciando Link com Estoque
        private FormProdutos FormProdutos;

        public FormVendas()
        {
            InitializeComponent();
        }


        private void FormVendas_Load(object sender, EventArgs e)
        {
            // Adiciona Linhas



            DataGridViewComboBoxColumn material = new DataGridViewComboBoxColumn();
            material.Name = "material";
            material.HeaderText = "Material";



            DataGridViewComboBoxColumn materialC = new DataGridViewComboBoxColumn();
            materialC.Name = "materialC";
            materialC.HeaderText = "MaterialC";

            DataGridViewComboBoxColumn tamanho = new DataGridViewComboBoxColumn();
            tamanho.Name = "tamanho";
            tamanho.HeaderText = "tamanho";





            gridVendas.Columns.Add(material);
            gridVendas.Columns.Add(materialC);
            gridVendas.Columns.Add(tamanho);

            gridVendas.Columns.Add("peso", "Peso");
            gridVendas.Columns.Add("valorKg", "Valor kg");
            gridVendas.Columns.Add("tempo", "Tempo");
            gridVendas.Columns.Add("valorCorte", "Valor Corte");
            gridVendas.Columns.Add("quantidade", "Quantidade");
            gridVendas.Columns.Add("dobra", "Dobra");
            gridVendas.Columns.Add("valorDobra", "Valor Dobra");
            gridVendas.Columns.Add("valorTotalDobra", "Valor Total Dobra");
            gridVendas.Columns.Add("ValorUnitario", "Valor Un.");
            gridVendas.Columns.Add("total", "Valor Total");





            // Define Materiais
            material.Items.Add("Aluminio");
            material.Items.Add("Inox");
            material.Items.Add("Carbono");

            // Define Materiais Clientes
            materialC.Items.Add("Sim");
            materialC.Items.Add("Não");

            // Define os Tamanhos
            tamanho.Items.Add("3000x1500");
            tamanho.Items.Add("3000x1200");
            tamanho.Items.Add("3000x1250");





            // Define Formato R$    
            gridVendas.Columns["valorDobra"].DefaultCellStyle.Format = "C2";
            gridVendas.Columns["ValorUnitario"].DefaultCellStyle.Format = "C2";
            gridVendas.Columns["ValorTotalDobra"].DefaultCellStyle.Format = "C2";
            gridVendas.Columns["valorKg"].DefaultCellStyle.Format = "C2";
            gridVendas.Columns["valorCorte"].DefaultCellStyle.Format = "C2";
            gridVendas.Columns["total"].DefaultCellStyle.Format = "C2";

            // Bloqueia Edição
            gridVendas.Columns["total"].ReadOnly = true;
            gridVendas.Columns["valorkg"].ReadOnly = true;
            gridVendas.Columns["valorDobra"].ReadOnly = true;
            gridVendas.Columns["ValorCorte"].ReadOnly = true;
            gridVendas.Columns["valorTotalDobra"].ReadOnly = true;
            gridVendas.Columns["ValorUnitario"].ReadOnly = true;
            gridVendas.Columns["valorDobra"].DefaultCellStyle.NullValue = "1.5";

            // Bloqueia add linhs automaticamente
            gridVendas.AllowUserToAddRows = false;
        }

        private void btnAdicionarLinha_Click_1(object sender, EventArgs e)
        {
            // add linhas
            int row = gridVendas.Rows.Add();

            // define valor dobra
            gridVendas.Rows[row].Cells["valorDobra"].Value = 1.5m;
        }

        private void btnCalcular_Click_1(object sender, EventArgs e)
        {
           

        }


        private void gridVendas_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Define o país
            var row = gridVendas.Rows[e.RowIndex];
            var cultura = new CultureInfo("pt-BR");

            // MATERIAL - define valores automáticos
            if (gridVendas.Columns[e.ColumnIndex].Name == "material")
            {
                string material = row.Cells["material"].Value?.ToString();


                if (material == "Carbono")
                {
                    row.Cells["valorKg"].Value = 12;
                    row.Cells["valorCorte"].Value = 0.12;
                }
                else
                {
                    row.Cells["valorKg"].Value = 50;
                    row.Cells["valorCorte"].Value = 0.3;
                }

                string materialC = row.Cells["materialC"].Value?.ToString();


                if (materialC == "Sim")
                {
                    row.Cells["valorKg"].Value = 0;
                }
           
            }

            //MATERIALC - define valores automáticos
            if (gridVendas.Columns[e.ColumnIndex].Name == "materialC")
            {
                string materialC = row.Cells["materialC"].Value?.ToString();


                if (materialC == "Sim")
                {
                    row.Cells["valorKg"].Value = 0;
                }
                else
                {

                    string material = row.Cells["material"].Value?.ToString();


                    if (material == "Carbono")
                    {
                        row.Cells["valorKg"].Value = 12;
                        row.Cells["valorCorte"].Value = 0.12;
                    }
                    else
                    {
                        row.Cells["valorKg"].Value = 50;
                        row.Cells["valorCorte"].Value = 0.3;
                    }

                }
            }

            // Definição de variavel 
            decimal peso = 0;
            decimal valorKg = 0;
            decimal tempo = 0;
            decimal valorCorte = 0;
            decimal valorDobra = 0;
            decimal qtdDobra = 0;
            decimal qtdPecas = 0;

            // Lê os valores
            decimal.TryParse(Convert.ToString(row.Cells["peso"].Value), NumberStyles.Any, cultura, out peso);
            decimal.TryParse(Convert.ToString(row.Cells["valorKg"].Value), NumberStyles.Any, cultura, out valorKg);
            decimal.TryParse(Convert.ToString(row.Cells["tempo"].Value), NumberStyles.Any, cultura, out tempo);
            decimal.TryParse(Convert.ToString(row.Cells["valorCorte"].Value), NumberStyles.Any, cultura, out valorCorte);
            decimal.TryParse(Convert.ToString(row.Cells["valorDobra"].Value), NumberStyles.Any, cultura, out valorDobra);
            decimal.TryParse(Convert.ToString(row.Cells["dobra"].Value), NumberStyles.Any, cultura, out qtdDobra);
            decimal.TryParse(Convert.ToString(row.Cells["Quantidade"].Value), NumberStyles.Any, cultura, out qtdPecas);


            // Calculo Dobra
            decimal totalDobra = qtdDobra * valorDobra * peso;
            row.Cells["ValorTotalDobra"].Value = totalDobra;

            // Calculo Unitario
            decimal valorUnitario = (peso * valorKg) + (tempo * valorCorte) + totalDobra;
            row.Cells["valorUnitario"].Value = valorUnitario;

            // Calculo Total
            decimal total = valorUnitario * qtdPecas;
            row.Cells["total"].Value = total;


            txtFinal.Text = CalcularTotalGeral().ToString("C2");


        }
        private decimal CalcularTotalGeral()
        {
            decimal totalGeral = 0;
            var cultura = new CultureInfo("pt-BR");

            foreach (DataGridViewRow row in gridVendas.Rows)
            {
                if (row.IsNewRow) continue;

                decimal valor = 0;

                decimal.TryParse(
                    row.Cells["total"].Value?.ToString(),
                    NumberStyles.Any,
                    cultura,
                    out valor
                );

                totalGeral += valor;
            }

            return totalGeral;
        }

        private void gridVendas_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (gridVendas.IsCurrentCellDirty)
            {
                gridVendas.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void gridVendas_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            // Mostra o valor ao iniciar
            e.Row.Cells["valorDobra"].Value = 1.5m;
        }



    }
}

