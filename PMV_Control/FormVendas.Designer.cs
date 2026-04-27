namespace PMV_Control
{
    partial class FormVendas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridVendas = new System.Windows.Forms.DataGridView();
            this.btnAdicionarLinha = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.txtFinal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridVendas)).BeginInit();
            this.SuspendLayout();
            // 
            // gridVendas
            // 
            this.gridVendas.BackgroundColor = System.Drawing.Color.Navy;
            this.gridVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridVendas.Location = new System.Drawing.Point(30, 43);
            this.gridVendas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridVendas.Name = "gridVendas";
            this.gridVendas.RowHeadersWidth = 68;
            this.gridVendas.Size = new System.Drawing.Size(1472, 647);
            this.gridVendas.TabIndex = 0;
            this.gridVendas.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridVendas_CellValueChanged);
            this.gridVendas.CurrentCellDirtyStateChanged += new System.EventHandler(this.gridVendas_CurrentCellDirtyStateChanged);
            this.gridVendas.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.gridVendas_DefaultValuesNeeded);
            // 
            // btnAdicionarLinha
            // 
            this.btnAdicionarLinha.Location = new System.Drawing.Point(1010, 698);
            this.btnAdicionarLinha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdicionarLinha.Name = "btnAdicionarLinha";
            this.btnAdicionarLinha.Size = new System.Drawing.Size(100, 48);
            this.btnAdicionarLinha.TabIndex = 1;
            this.btnAdicionarLinha.Text = "Adicionar";
            this.btnAdicionarLinha.UseVisualStyleBackColor = true;
            this.btnAdicionarLinha.Click += new System.EventHandler(this.btnAdicionarLinha_Click_1);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(1117, 694);
            this.btnFinalizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(100, 39);
            this.btnFinalizar.TabIndex = 2;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnCalcular_Click_1);
            // 
            // txtFinal
            // 
            this.txtFinal.Location = new System.Drawing.Point(1347, 716);
            this.txtFinal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFinal.Name = "txtFinal";
            this.txtFinal.Size = new System.Drawing.Size(132, 22);
            this.txtFinal.TabIndex = 3;
            // 
            // FormVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1518, 839);
            this.Controls.Add(this.txtFinal);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.btnAdicionarLinha);
            this.Controls.Add(this.gridVendas);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormVendas";
            this.Text = "FormVendas";
            this.Load += new System.EventHandler(this.FormVendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridVendas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridVendas;
        private System.Windows.Forms.Button btnAdicionarLinha;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.TextBox txtFinal;
    }
}