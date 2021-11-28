
namespace WCFSoapClientSide
{
    partial class SuspectsView
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
            this.button1 = new System.Windows.Forms.Button();
            this.ListViewSuspeitos = new System.Windows.Forms.ListView();
            this.firstname = new System.Windows.Forms.ColumnHeader();
            this.lastname = new System.Windows.Forms.ColumnHeader();
            this.BtnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(37, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista de Todas as Pessoas Suspeitas";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(447, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Show";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ListViewSuspeitos
            // 
            this.ListViewSuspeitos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.firstname,
            this.lastname});
            this.ListViewSuspeitos.HideSelection = false;
            this.ListViewSuspeitos.Location = new System.Drawing.Point(37, 82);
            this.ListViewSuspeitos.Name = "ListViewSuspeitos";
            this.ListViewSuspeitos.Size = new System.Drawing.Size(485, 260);
            this.ListViewSuspeitos.TabIndex = 4;
            this.ListViewSuspeitos.UseCompatibleStateImageBehavior = false;
            this.ListViewSuspeitos.View = System.Windows.Forms.View.Details;
            // 
            // firstname
            // 
            this.firstname.Text = "Firstname";
            this.firstname.Width = 200;
            // 
            // lastname
            // 
            this.lastname.Text = "Lastname";
            this.lastname.Width = 200;
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(543, 32);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(75, 23);
            this.BtnBack.TabIndex = 5;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // SuspectsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 351);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.ListViewSuspeitos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "SuspectsView";
            this.Text = "SuspectsView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView ListViewSuspeitos;
        private System.Windows.Forms.ColumnHeader firstname;
        private System.Windows.Forms.ColumnHeader lastname;
        private System.Windows.Forms.Button BtnBack;
    }
}