
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
            // ProdutosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 275);
            this.Controls.Add(this.listViewProdutos);
            this.Controls.Add(this.buttonListarProdutos);
            this.Name = "ProdutosForm";
            this.Text = "ProdutosForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonListarProdutos;
        private System.Windows.Forms.ListView listViewProdutos;
        private System.Windows.Forms.ColumnHeader idcolumn;
        private System.Windows.Forms.ColumnHeader descricaocolumn;
    }
}