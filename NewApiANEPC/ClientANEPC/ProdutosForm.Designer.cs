
namespace ClientANEPC
{
    partial class ProdutosForm
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
            this.buttonListarProdutos = new System.Windows.Forms.Button();
            this.listViewProdutos = new System.Windows.Forms.ListView();
            this.idcolumn = new System.Windows.Forms.ColumnHeader();
            this.descricaocolumn = new System.Windows.Forms.ColumnHeader();
            this.buttonCriarProduto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDescProduto = new System.Windows.Forms.TextBox();
            this.textBoxPrecoProduto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonListarProdutos
            // 
            this.buttonListarProdutos.Location = new System.Drawing.Point(29, 26);
            this.buttonListarProdutos.Name = "buttonListarProdutos";
            this.buttonListarProdutos.Size = new System.Drawing.Size(131, 28);
            this.buttonListarProdutos.TabIndex = 0;
            this.buttonListarProdutos.Text = "Listar Produtos";
            this.buttonListarProdutos.UseVisualStyleBackColor = true;
            this.buttonListarProdutos.Click += new System.EventHandler(this.buttonListarProdutos_Click);
            // 
            // listViewProdutos
            // 
            this.listViewProdutos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idcolumn,
            this.descricaocolumn});
            this.listViewProdutos.HideSelection = false;
            this.listViewProdutos.Location = new System.Drawing.Point(29, 74);
            this.listViewProdutos.Name = "listViewProdutos";
            this.listViewProdutos.Size = new System.Drawing.Size(131, 188);
            this.listViewProdutos.TabIndex = 1;
            this.listViewProdutos.UseCompatibleStateImageBehavior = false;
            this.listViewProdutos.View = System.Windows.Forms.View.Details;
            this.listViewProdutos.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // idcolumn
            // 
            this.idcolumn.Text = "ID";
            // 
            // descricaocolumn
            // 
            this.descricaocolumn.Text = "Descricao";
            // 
            // buttonCriarProduto
            // 
            this.buttonCriarProduto.Location = new System.Drawing.Point(239, 26);
            this.buttonCriarProduto.Name = "buttonCriarProduto";
            this.buttonCriarProduto.Size = new System.Drawing.Size(115, 28);
            this.buttonCriarProduto.TabIndex = 2;
            this.buttonCriarProduto.Text = "Criar Produto";
            this.buttonCriarProduto.UseVisualStyleBackColor = true;
            this.buttonCriarProduto.Click += new System.EventHandler(this.buttonCriarProduto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Descricao";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Preco";
            // 
            // textBoxDescProduto
            // 
            this.textBoxDescProduto.Location = new System.Drawing.Point(239, 71);
            this.textBoxDescProduto.Name = "textBoxDescProduto";
            this.textBoxDescProduto.Size = new System.Drawing.Size(112, 23);
            this.textBoxDescProduto.TabIndex = 5;
            // 
            // textBoxPrecoProduto
            // 
            this.textBoxPrecoProduto.Location = new System.Drawing.Point(238, 115);
            this.textBoxPrecoProduto.Name = "textBoxPrecoProduto";
            this.textBoxPrecoProduto.Size = new System.Drawing.Size(115, 23);
            this.textBoxPrecoProduto.TabIndex = 6;
            // 
            // ProdutosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 275);
            this.Controls.Add(this.textBoxPrecoProduto);
            this.Controls.Add(this.textBoxDescProduto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCriarProduto);
            this.Controls.Add(this.listViewProdutos);
            this.Controls.Add(this.buttonListarProdutos);
            this.Name = "ProdutosForm";
            this.Text = "ProdutosForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonListarProdutos;
        private System.Windows.Forms.ListView listViewProdutos;
        private System.Windows.Forms.ColumnHeader idcolumn;
        private System.Windows.Forms.ColumnHeader descricaocolumn;
        private System.Windows.Forms.Button buttonCriarProduto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDescProduto;
        private System.Windows.Forms.TextBox textBoxPrecoProduto;
    }
}