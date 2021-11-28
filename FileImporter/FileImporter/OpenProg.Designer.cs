
namespace FileImporter
{
    partial class OpenProg
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnViewData = new System.Windows.Forms.Button();
            this.BtnImportFiles = new System.Windows.Forms.Button();
            this.Off = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(36, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(408, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "File Importer";
            // 
            // BtnViewData
            // 
            this.BtnViewData.Location = new System.Drawing.Point(36, 169);
            this.BtnViewData.Name = "BtnViewData";
            this.BtnViewData.Size = new System.Drawing.Size(100, 39);
            this.BtnViewData.TabIndex = 1;
            this.BtnViewData.Text = "View Data";
            this.BtnViewData.UseVisualStyleBackColor = true;
            this.BtnViewData.Click += new System.EventHandler(this.BtnViewData_Click);
            // 
            // BtnImportFiles
            // 
            this.BtnImportFiles.Location = new System.Drawing.Point(344, 169);
            this.BtnImportFiles.Name = "BtnImportFiles";
            this.BtnImportFiles.Size = new System.Drawing.Size(100, 39);
            this.BtnImportFiles.TabIndex = 2;
            this.BtnImportFiles.Text = "Import Files";
            this.BtnImportFiles.UseVisualStyleBackColor = true;
            this.BtnImportFiles.Click += new System.EventHandler(this.BtnImportFiles_Click);
            // 
            // Off
            // 
            this.Off.Location = new System.Drawing.Point(185, 169);
            this.Off.Name = "Off";
            this.Off.Size = new System.Drawing.Size(100, 39);
            this.Off.TabIndex = 3;
            this.Off.Text = "Exit";
            this.Off.UseVisualStyleBackColor = true;
            this.Off.Click += new System.EventHandler(this.Off_Click);
            // 
            // OpenProg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 258);
            this.Controls.Add(this.Off);
            this.Controls.Add(this.BtnImportFiles);
            this.Controls.Add(this.BtnViewData);
            this.Controls.Add(this.panel1);
            this.Name = "OpenProg";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnViewData;
        private System.Windows.Forms.Button BtnImportFiles;
        private System.Windows.Forms.Button Off;
    }
}

