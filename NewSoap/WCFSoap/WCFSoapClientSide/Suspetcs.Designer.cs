
namespace WCFSoapClientSide
{
    partial class Suspetcs
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
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.firstNameSuspeito = new System.Windows.Forms.TextBox();
            this.lastNameSuspeito = new System.Windows.Forms.TextBox();
            this.BtnInsereSuspeito = new System.Windows.Forms.Button();
            this.idInfLabel = new System.Windows.Forms.Label();
            this.TxIdInf = new System.Windows.Forms.TextBox();
            this.BtnBack = new System.Windows.Forms.Button();
            this.ListViewInfectados1 = new System.Windows.Forms.ListView();
            this.id_Inf = new System.Windows.Forms.ColumnHeader();
            this.Nome = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Nome";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 15);
            this.label8.TabIndex = 13;
            this.label8.Text = "Apelido";
            // 
            // firstNameSuspeito
            // 
            this.firstNameSuspeito.Location = new System.Drawing.Point(108, 79);
            this.firstNameSuspeito.Name = "firstNameSuspeito";
            this.firstNameSuspeito.Size = new System.Drawing.Size(100, 23);
            this.firstNameSuspeito.TabIndex = 14;
            // 
            // lastNameSuspeito
            // 
            this.lastNameSuspeito.Location = new System.Drawing.Point(108, 129);
            this.lastNameSuspeito.Name = "lastNameSuspeito";
            this.lastNameSuspeito.Size = new System.Drawing.Size(100, 23);
            this.lastNameSuspeito.TabIndex = 15;
            // 
            // BtnInsereSuspeito
            // 
            this.BtnInsereSuspeito.Location = new System.Drawing.Point(108, 175);
            this.BtnInsereSuspeito.Name = "BtnInsereSuspeito";
            this.BtnInsereSuspeito.Size = new System.Drawing.Size(100, 23);
            this.BtnInsereSuspeito.TabIndex = 16;
            this.BtnInsereSuspeito.Text = "Inserir Suspeito";
            this.BtnInsereSuspeito.UseVisualStyleBackColor = true;
            this.BtnInsereSuspeito.Click += new System.EventHandler(this.BtnInsereSuspeito_Click);
            // 
            // idInfLabel
            // 
            this.idInfLabel.AutoSize = true;
            this.idInfLabel.Location = new System.Drawing.Point(26, 39);
            this.idInfLabel.Name = "idInfLabel";
            this.idInfLabel.Size = new System.Drawing.Size(34, 15);
            this.idInfLabel.TabIndex = 17;
            this.idInfLabel.Text = "Id inf";
            // 
            // TxIdInf
            // 
            this.TxIdInf.Location = new System.Drawing.Point(108, 36);
            this.TxIdInf.Name = "TxIdInf";
            this.TxIdInf.Size = new System.Drawing.Size(100, 23);
            this.TxIdInf.TabIndex = 18;
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(108, 215);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(100, 23);
            this.BtnBack.TabIndex = 19;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // ListViewInfectados1
            // 
            this.ListViewInfectados1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id_Inf,
            this.Nome});
            this.ListViewInfectados1.HideSelection = false;
            this.ListViewInfectados1.Location = new System.Drawing.Point(277, 36);
            this.ListViewInfectados1.Name = "ListViewInfectados1";
            this.ListViewInfectados1.Size = new System.Drawing.Size(164, 174);
            this.ListViewInfectados1.TabIndex = 20;
            this.ListViewInfectados1.UseCompatibleStateImageBehavior = false;
            this.ListViewInfectados1.View = System.Windows.Forms.View.Details;
            // 
            // id_Inf
            // 
            this.id_Inf.Text = "Id_inf";
            // 
            // Nome
            // 
            this.Nome.Text = "Nome";
            this.Nome.Width = 120;
            // 
            // Suspetcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 250);
            this.Controls.Add(this.ListViewInfectados1);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.TxIdInf);
            this.Controls.Add(this.idInfLabel);
            this.Controls.Add(this.BtnInsereSuspeito);
            this.Controls.Add(this.lastNameSuspeito);
            this.Controls.Add(this.firstNameSuspeito);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Name = "Suspetcs";
            this.Text = "Suspetcs";
            this.Load += new System.EventHandler(this.Suspetcs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox firstNameSuspeito;
        private System.Windows.Forms.TextBox lastNameSuspeito;
        private System.Windows.Forms.Button BtnInsereSuspeito;
        private System.Windows.Forms.Label idInfLabel;
        private System.Windows.Forms.TextBox TxIdInf;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.ListView ListViewInfectados1;
        private System.Windows.Forms.ColumnHeader id_Inf;
        private System.Windows.Forms.ColumnHeader Nome;
    }
}