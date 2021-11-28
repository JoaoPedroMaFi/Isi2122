
namespace WCFSoapClientSide
{
    partial class Infecteds
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
            this.BtnShow = new System.Windows.Forms.Button();
            this.ListViewInfectados = new System.Windows.Forms.ListView();
            this.Id_pessoa = new System.Windows.Forms.ColumnHeader();
            this.firstname = new System.Windows.Forms.ColumnHeader();
            this.lastname = new System.Windows.Forms.ColumnHeader();
            this.id_equipa = new System.Windows.Forms.ColumnHeader();
            this.BtnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(41, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista de Todas as Pessoas Infectadas";
            // 
            // BtnShow
            // 
            this.BtnShow.Location = new System.Drawing.Point(481, 25);
            this.BtnShow.Name = "BtnShow";
            this.BtnShow.Size = new System.Drawing.Size(75, 23);
            this.BtnShow.TabIndex = 2;
            this.BtnShow.Text = "Show";
            this.BtnShow.UseVisualStyleBackColor = true;
            this.BtnShow.Click += new System.EventHandler(this.button1_Click);
            // 
            // ListViewInfectados
            // 
            this.ListViewInfectados.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id_pessoa,
            this.firstname,
            this.lastname,
            this.id_equipa});
            this.ListViewInfectados.HideSelection = false;
            this.ListViewInfectados.Location = new System.Drawing.Point(41, 80);
            this.ListViewInfectados.Name = "ListViewInfectados";
            this.ListViewInfectados.Size = new System.Drawing.Size(719, 323);
            this.ListViewInfectados.TabIndex = 3;
            this.ListViewInfectados.UseCompatibleStateImageBehavior = false;
            this.ListViewInfectados.View = System.Windows.Forms.View.Details;
            // 
            // Id_pessoa
            // 
            this.Id_pessoa.Text = "Id pessoa";
            this.Id_pessoa.Width = 150;
            // 
            // firstname
            // 
            this.firstname.Text = "Firstname";
            this.firstname.Width = 150;
            // 
            // lastname
            // 
            this.lastname.Text = "Lastname";
            this.lastname.Width = 150;
            // 
            // id_equipa
            // 
            this.id_equipa.Text = "Id equipa";
            this.id_equipa.Width = 150;
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(581, 25);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(75, 23);
            this.BtnBack.TabIndex = 4;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // Infecteds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.ListViewInfectados);
            this.Controls.Add(this.BtnShow);
            this.Controls.Add(this.label1);
            this.Name = "Infecteds";
            this.Text = "Infecteds";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnShow;
        private System.Windows.Forms.ListView ListViewInfectados;
        private System.Windows.Forms.ColumnHeader Id_pessoa;
        private System.Windows.Forms.ColumnHeader firstname;
        private System.Windows.Forms.ColumnHeader lastname;
        private System.Windows.Forms.ColumnHeader id_equipa;
        private System.Windows.Forms.Button BtnBack;
    }
}