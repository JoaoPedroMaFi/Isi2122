
namespace WCFSoapClientSide
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nomeEquipa = new System.Windows.Forms.TextBox();
            this.firstNameInfetado = new System.Windows.Forms.TextBox();
            this.lastNameInfetado = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ButtonAllInfecteds = new System.Windows.Forms.Button();
            this.BtnInsertListSuspects = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.ListViewEquipas = new System.Windows.Forms.ListView();
            this.id = new System.Windows.Forms.ColumnHeader();
            this.Nome = new System.Windows.Forms.ColumnHeader();
            this.iDEquipa = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.BtnViewEquipas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ocorrencia de infetados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Equipa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(440, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Infectado";
            // 
            // nomeEquipa
            // 
            this.nomeEquipa.Location = new System.Drawing.Point(48, 105);
            this.nomeEquipa.Name = "nomeEquipa";
            this.nomeEquipa.Size = new System.Drawing.Size(100, 23);
            this.nomeEquipa.TabIndex = 4;
            // 
            // firstNameInfetado
            // 
            this.firstNameInfetado.Location = new System.Drawing.Point(428, 152);
            this.firstNameInfetado.Name = "firstNameInfetado";
            this.firstNameInfetado.Size = new System.Drawing.Size(100, 23);
            this.firstNameInfetado.TabIndex = 6;
            // 
            // lastNameInfetado
            // 
            this.lastNameInfetado.Location = new System.Drawing.Point(428, 203);
            this.lastNameInfetado.Name = "lastNameInfetado";
            this.lastNameInfetado.Size = new System.Drawing.Size(100, 23);
            this.lastNameInfetado.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Nome";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(379, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "Nome";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(371, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 15);
            this.label8.TabIndex = 12;
            this.label8.Text = "Apelido";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(422, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Inserir Infetado";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ButtonAllInfecteds
            // 
            this.ButtonAllInfecteds.Location = new System.Drawing.Point(48, 313);
            this.ButtonAllInfecteds.Name = "ButtonAllInfecteds";
            this.ButtonAllInfecteds.Size = new System.Drawing.Size(92, 23);
            this.ButtonAllInfecteds.TabIndex = 14;
            this.ButtonAllInfecteds.Text = "Ver Infectados";
            this.ButtonAllInfecteds.UseVisualStyleBackColor = true;
            this.ButtonAllInfecteds.Click += new System.EventHandler(this.ButtonAllInfecteds_Click);
            // 
            // BtnInsertListSuspects
            // 
            this.BtnInsertListSuspects.Location = new System.Drawing.Point(422, 313);
            this.BtnInsertListSuspects.Name = "BtnInsertListSuspects";
            this.BtnInsertListSuspects.Size = new System.Drawing.Size(112, 23);
            this.BtnInsertListSuspects.TabIndex = 15;
            this.BtnInsertListSuspects.Text = "Inserir Suspeitos";
            this.BtnInsertListSuspects.UseVisualStyleBackColor = true;
            this.BtnInsertListSuspects.Click += new System.EventHandler(this.BtnInsertListSuspects_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(226, 313);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Ver Suspeitos";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(48, 134);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 23);
            this.button3.TabIndex = 17;
            this.button3.Text = "Criar equipa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ListViewEquipas
            // 
            this.ListViewEquipas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.Nome});
            this.ListViewEquipas.HideSelection = false;
            this.ListViewEquipas.Location = new System.Drawing.Point(178, 96);
            this.ListViewEquipas.Name = "ListViewEquipas";
            this.ListViewEquipas.Size = new System.Drawing.Size(168, 157);
            this.ListViewEquipas.TabIndex = 18;
            this.ListViewEquipas.UseCompatibleStateImageBehavior = false;
            this.ListViewEquipas.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "id";
            // 
            // Nome
            // 
            this.Nome.Text = "Nome";
            this.Nome.Width = 120;
            // 
            // iDEquipa
            // 
            this.iDEquipa.Location = new System.Drawing.Point(428, 105);
            this.iDEquipa.Name = "iDEquipa";
            this.iDEquipa.Size = new System.Drawing.Size(100, 23);
            this.iDEquipa.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(362, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 15);
            this.label9.TabIndex = 20;
            this.label9.Text = "ID Equipa";
            // 
            // BtnViewEquipas
            // 
            this.BtnViewEquipas.Location = new System.Drawing.Point(212, 259);
            this.BtnViewEquipas.Name = "BtnViewEquipas";
            this.BtnViewEquipas.Size = new System.Drawing.Size(106, 23);
            this.BtnViewEquipas.TabIndex = 21;
            this.BtnViewEquipas.Text = "Listar Equipas";
            this.BtnViewEquipas.UseVisualStyleBackColor = true;
            this.BtnViewEquipas.Click += new System.EventHandler(this.BtnViewEquipas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 450);
            this.Controls.Add(this.BtnViewEquipas);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.iDEquipa);
            this.Controls.Add(this.ListViewEquipas);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BtnInsertListSuspects);
            this.Controls.Add(this.ButtonAllInfecteds);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lastNameInfetado);
            this.Controls.Add(this.firstNameInfetado);
            this.Controls.Add(this.nomeEquipa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Ocorrencia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nomeEquipa;
        private System.Windows.Forms.TextBox firstNameInfetado;
        private System.Windows.Forms.TextBox lastNameInfetado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ButtonAllInfecteds;
        private System.Windows.Forms.Button BtnInsertListSuspects;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListView ListViewEquipas;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader Nome;
        private System.Windows.Forms.TextBox iDEquipa;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BtnViewEquipas;
    }
}