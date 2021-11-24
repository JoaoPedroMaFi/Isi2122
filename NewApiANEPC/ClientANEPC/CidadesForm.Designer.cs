
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
            this.buttonAddCity = new System.Windows.Forms.Button();
            this.textBoxAddCity = new System.Windows.Forms.TextBox();
            this.buttonEditarCidade = new System.Windows.Forms.Button();
            this.textBoxEditarCidadeId = new System.Windows.Forms.TextBox();
            this.textBoxEditarCidadeNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxApagarCidade = new System.Windows.Forms.TextBox();
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
            this.listViewCidades.Location = new System.Drawing.Point(143, 73);
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
            // buttonAddCity
            // 
            this.buttonAddCity.Location = new System.Drawing.Point(304, 12);
            this.buttonAddCity.Name = "buttonAddCity";
            this.buttonAddCity.Size = new System.Drawing.Size(115, 27);
            this.buttonAddCity.TabIndex = 3;
            this.buttonAddCity.Text = "Adicionar Cidade";
            this.buttonAddCity.UseVisualStyleBackColor = true;
            this.buttonAddCity.Click += new System.EventHandler(this.buttonAddCity_Click);
            // 
            // textBoxAddCity
            // 
            this.textBoxAddCity.Location = new System.Drawing.Point(304, 58);
            this.textBoxAddCity.Name = "textBoxAddCity";
            this.textBoxAddCity.Size = new System.Drawing.Size(114, 23);
            this.textBoxAddCity.TabIndex = 4;
            this.textBoxAddCity.TextChanged += new System.EventHandler(this.textBoxAddCity_TextChanged);
            // 
            // buttonEditarCidade
            // 
            this.buttonEditarCidade.Location = new System.Drawing.Point(550, 12);
            this.buttonEditarCidade.Name = "buttonEditarCidade";
            this.buttonEditarCidade.Size = new System.Drawing.Size(110, 25);
            this.buttonEditarCidade.TabIndex = 5;
            this.buttonEditarCidade.Text = "Editar Cidade";
            this.buttonEditarCidade.UseVisualStyleBackColor = true;
            this.buttonEditarCidade.Click += new System.EventHandler(this.buttonEditarCidade_Click);
            // 
            // textBoxEditarCidadeId
            // 
            this.textBoxEditarCidadeId.Location = new System.Drawing.Point(550, 52);
            this.textBoxEditarCidadeId.Name = "textBoxEditarCidadeId";
            this.textBoxEditarCidadeId.Size = new System.Drawing.Size(109, 23);
            this.textBoxEditarCidadeId.TabIndex = 6;
            // 
            // textBoxEditarCidadeNome
            // 
            this.textBoxEditarCidadeNome.Location = new System.Drawing.Point(550, 90);
            this.textBoxEditarCidadeNome.Name = "textBoxEditarCidadeNome";
            this.textBoxEditarCidadeNome.Size = new System.Drawing.Size(108, 23);
            this.textBoxEditarCidadeNome.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(526, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(474, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Novo nome";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(431, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 29);
            this.button1.TabIndex = 10;
            this.button1.Text = "Apagar Cidade";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(407, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "ID";
            // 
            // textBoxApagarCidade
            // 
            this.textBoxApagarCidade.Location = new System.Drawing.Point(431, 245);
            this.textBoxApagarCidade.Name = "textBoxApagarCidade";
            this.textBoxApagarCidade.Size = new System.Drawing.Size(112, 23);
            this.textBoxApagarCidade.TabIndex = 12;
            // 
            // CidadesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 285);
            this.Controls.Add(this.textBoxApagarCidade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxEditarCidadeNome);
            this.Controls.Add(this.textBoxEditarCidadeId);
            this.Controls.Add(this.buttonEditarCidade);
            this.Controls.Add(this.textBoxAddCity);
            this.Controls.Add(this.buttonAddCity);
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
        private System.Windows.Forms.Button buttonAddCity;
        private System.Windows.Forms.TextBox textBoxAddCity;
        private System.Windows.Forms.Button buttonEditarCidade;
        private System.Windows.Forms.TextBox textBoxEditarCidadeId;
        private System.Windows.Forms.TextBox textBoxEditarCidadeNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxApagarCidade;
    }
}