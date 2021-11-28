
namespace FileImporter
{
    partial class ViewData
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
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("");
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnShowData = new System.Windows.Forms.Button();
            this.ListViewFile = new System.Windows.Forms.ListView();
            this.FirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Utent_Number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Respeitou = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Equipa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 61);
            this.panel1.TabIndex = 0;
            this.panel1.Tag = "Dados da Base de Dados";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(180, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dados da base de Dados";
            // 
            // btnShowData
            // 
            this.btnShowData.Location = new System.Drawing.Point(12, 349);
            this.btnShowData.Name = "btnShowData";
            this.btnShowData.Size = new System.Drawing.Size(75, 23);
            this.btnShowData.TabIndex = 2;
            this.btnShowData.Text = "Show Data";
            this.btnShowData.UseVisualStyleBackColor = true;
            this.btnShowData.Click += new System.EventHandler(this.btnShowData_Click);
            // 
            // ListViewFile
            // 
            this.ListViewFile.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Data,
            this.FirstName,
            this.LastName,
            this.Utent_Number,
            this.Respeitou,
            this.Equipa});
            this.ListViewFile.HideSelection = false;
            listViewItem4.Tag = "Data";
            listViewItem5.Tag = "FirstName";
            listViewItem6.Tag = "LastName";
            this.ListViewFile.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem4,
            listViewItem5,
            listViewItem6});
            this.ListViewFile.Location = new System.Drawing.Point(12, 91);
            this.ListViewFile.Name = "ListViewFile";
            this.ListViewFile.Size = new System.Drawing.Size(640, 239);
            this.ListViewFile.TabIndex = 3;
            this.ListViewFile.UseCompatibleStateImageBehavior = false;
            this.ListViewFile.View = System.Windows.Forms.View.Details;
            // 
            // FirstName
            // 
            this.FirstName.Text = "FirstName";
            this.FirstName.Width = 100;
            // 
            // LastName
            // 
            this.LastName.Text = "LastName";
            this.LastName.Width = 123;
            // 
            // Utent_Number
            // 
            this.Utent_Number.Text = "Utent Number";
            this.Utent_Number.Width = 136;
            // 
            // Data
            // 
            this.Data.Text = "Data";
            this.Data.Width = 82;
            // 
            // Respeitou
            // 
            this.Respeitou.Text = "Respeitou";
            this.Respeitou.Width = 107;
            // 
            // Equipa
            // 
            this.Equipa.Text = "Equipa";
            this.Equipa.Width = 205;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(577, 349);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ViewData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 379);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ListViewFile);
            this.Controls.Add(this.btnShowData);
            this.Controls.Add(this.panel1);
            this.Name = "ViewData";
            this.Text = "ViewData";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShowData;
        private System.Windows.Forms.ListView ListViewFile;
        private System.Windows.Forms.ColumnHeader Data;
        private System.Windows.Forms.ColumnHeader FirstName;
        private System.Windows.Forms.ColumnHeader LastName;
        private System.Windows.Forms.ColumnHeader Utent_Number;
        private System.Windows.Forms.ColumnHeader Respeitou;
        private System.Windows.Forms.ColumnHeader Equipa;
        private System.Windows.Forms.Button button1;
    }
}