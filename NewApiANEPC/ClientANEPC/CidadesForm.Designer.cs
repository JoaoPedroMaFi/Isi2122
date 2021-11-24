
namespace ClientANEPC
{
    partial class CidadesForm
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonListarCidades = new System.Windows.Forms.Button();
            this.listViewCidades = new System.Windows.Forms.ListView();
            this.Id = new System.Windows.Forms.ColumnHeader();
            this.Nome = new System.Windows.Forms.ColumnHeader();
            this.labelCidadeNome = new System.Windows.Forms.TextBox();
            this.labelCidadeId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(22, 57);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(115, 199);
            this.listBox1.TabIndex = 0;
            // 
            // buttonListarCidades
            // 
            this.buttonListarCidades.Location = new System.Drawing.Point(22, 12);
            this.buttonListarCidades.Name = "buttonListarCidades";
            this.buttonListarCidades.Size = new System.Drawing.Size(115, 39);
            this.buttonListarCidades.TabIndex = 1;
            this.buttonListarCidades.Text = "Listar Cidades";
            this.buttonListarCidades.UseVisualStyleBackColor = true;
            this.buttonListarCidades.Click += new System.EventHandler(this.buttonListarCidades_Click);
            // 
            // listViewCidades
            // 
            this.listViewCidades.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Nome});
            this.listViewCidades.FullRowSelect = true;
            this.listViewCidades.HideSelection = false;
            this.listViewCidades.Location = new System.Drawing.Point(236, 38);
            this.listViewCidades.Name = "listViewCidades";
            this.listViewCidades.Size = new System.Drawing.Size(145, 183);
            this.listViewCidades.TabIndex = 2;
            this.listViewCidades.UseCompatibleStateImageBehavior = false;
            this.listViewCidades.View = System.Windows.Forms.View.Details;
            this.listViewCidades.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listViewCidades_MouseClick);
            // 
            // Id
            // 
            this.Id.Text = "Id";
            // 
            // Nome
            // 
            this.Nome.Text = "Nome";
            this.Nome.Width = 100;
            // 
            // labelCidadeNome
            // 
            this.labelCidadeNome.Location = new System.Drawing.Point(468, 56);
            this.labelCidadeNome.Name = "labelCidadeNome";
            this.labelCidadeNome.Size = new System.Drawing.Size(100, 23);
            this.labelCidadeNome.TabIndex = 3;
            // 
            // labelCidadeId
            // 
            this.labelCidadeId.Location = new System.Drawing.Point(468, 122);
            this.labelCidadeId.Name = "labelCidadeId";
            this.labelCidadeId.Size = new System.Drawing.Size(100, 23);
            this.labelCidadeId.TabIndex = 4;
            // 
            // CidadesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 285);
            this.Controls.Add(this.labelCidadeId);
            this.Controls.Add(this.labelCidadeNome);
            this.Controls.Add(this.listViewCidades);
            this.Controls.Add(this.buttonListarCidades);
            this.Controls.Add(this.listBox1);
            this.Name = "CidadesForm";
            this.Text = "CidadesForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonListarCidades;
        private System.Windows.Forms.ListView listViewCidades;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Nome;
        private System.Windows.Forms.TextBox labelCidadeNome;
        private System.Windows.Forms.TextBox labelCidadeId;
    }
}