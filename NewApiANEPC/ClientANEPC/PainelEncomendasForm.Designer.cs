
namespace ClientANEPC
{
    partial class PainelEncomendasForm
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
            this.buttonBuscarHistorico = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.idEncomenda = new System.Windows.Forms.ColumnHeader();
            this.idEquipa = new System.Windows.Forms.ColumnHeader();
            this.Entregue = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDetalhesEncomenda = new System.Windows.Forms.Button();
            this.textBoxIdEnc = new System.Windows.Forms.TextBox();
            this.listView2 = new System.Windows.Forms.ListView();
            this.idProduto = new System.Windows.Forms.ColumnHeader();
            this.Quantidade = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // buttonBuscarHistorico
            // 
            this.buttonBuscarHistorico.Location = new System.Drawing.Point(64, 25);
            this.buttonBuscarHistorico.Name = "buttonBuscarHistorico";
            this.buttonBuscarHistorico.Size = new System.Drawing.Size(152, 43);
            this.buttonBuscarHistorico.TabIndex = 0;
            this.buttonBuscarHistorico.Text = "Buscar Historico de Encomendas";
            this.buttonBuscarHistorico.UseVisualStyleBackColor = true;
            this.buttonBuscarHistorico.Click += new System.EventHandler(this.buttonBuscarHistorico_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idEncomenda,
            this.idEquipa,
            this.Entregue});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(24, 89);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(234, 195);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // idEncomenda
            // 
            this.idEncomenda.Text = "idEncomenda";
            // 
            // idEquipa
            // 
            this.idEquipa.Text = "idEquipa";
            // 
            // Entregue
            // 
            this.Entregue.Text = "Entregue";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(339, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID Encomenda:";
            // 
            // buttonDetalhesEncomenda
            // 
            this.buttonDetalhesEncomenda.Location = new System.Drawing.Point(438, 12);
            this.buttonDetalhesEncomenda.Name = "buttonDetalhesEncomenda";
            this.buttonDetalhesEncomenda.Size = new System.Drawing.Size(140, 43);
            this.buttonDetalhesEncomenda.TabIndex = 3;
            this.buttonDetalhesEncomenda.Text = "Pesquisar Detalhes Encomenda ";
            this.buttonDetalhesEncomenda.UseVisualStyleBackColor = true;
            this.buttonDetalhesEncomenda.Click += new System.EventHandler(this.buttonDetalhesEncomenda_Click);
            // 
            // textBoxIdEnc
            // 
            this.textBoxIdEnc.Location = new System.Drawing.Point(438, 61);
            this.textBoxIdEnc.Name = "textBoxIdEnc";
            this.textBoxIdEnc.Size = new System.Drawing.Size(140, 23);
            this.textBoxIdEnc.TabIndex = 4;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idProduto,
            this.Quantidade});
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(350, 90);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(227, 194);
            this.listView2.TabIndex = 5;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            // 
            // idProduto
            // 
            this.idProduto.Text = "idProduto";
            // 
            // Quantidade
            // 
            this.Quantidade.Text = "Quantidade";
            // 
            // PainelEncomendasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 296);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.textBoxIdEnc);
            this.Controls.Add(this.buttonDetalhesEncomenda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.buttonBuscarHistorico);
            this.Name = "PainelEncomendasForm";
            this.Text = "PainelEncomendasForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBuscarHistorico;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader idEncomenda;
        private System.Windows.Forms.ColumnHeader idEquipa;
        private System.Windows.Forms.ColumnHeader Entregue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDetalhesEncomenda;
        private System.Windows.Forms.TextBox textBoxIdEnc;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader idProduto;
        private System.Windows.Forms.ColumnHeader Quantidade;
    }
}