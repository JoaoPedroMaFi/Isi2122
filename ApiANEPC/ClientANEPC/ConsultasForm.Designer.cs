
namespace ClientANEPC.Models
{
    partial class ConsultasForm
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
            this.listBoxCidades = new System.Windows.Forms.ListBox();
            this.buttonListarCidades = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxCidades
            // 
            this.listBoxCidades.FormattingEnabled = true;
            this.listBoxCidades.ItemHeight = 15;
            this.listBoxCidades.Location = new System.Drawing.Point(15, 49);
            this.listBoxCidades.Name = "listBoxCidades";
            this.listBoxCidades.Size = new System.Drawing.Size(142, 229);
            this.listBoxCidades.TabIndex = 1;
            this.listBoxCidades.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // buttonListarCidades
            // 
            this.buttonListarCidades.Location = new System.Drawing.Point(15, 12);
            this.buttonListarCidades.Name = "buttonListarCidades";
            this.buttonListarCidades.Size = new System.Drawing.Size(142, 27);
            this.buttonListarCidades.TabIndex = 2;
            this.buttonListarCidades.Text = "Listar cidades registadas";
            this.buttonListarCidades.UseVisualStyleBackColor = true;
            this.buttonListarCidades.Click += new System.EventHandler(this.button1_Click);
            // 
            // ConsultasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 290);
            this.Controls.Add(this.buttonListarCidades);
            this.Controls.Add(this.listBoxCidades);
            this.Name = "ConsultasForm";
            this.Text = "ConsultasForm";
            this.Load += new System.EventHandler(this.ConsultasForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxCidades;
        private System.Windows.Forms.Button buttonListarCidades;
    }
}