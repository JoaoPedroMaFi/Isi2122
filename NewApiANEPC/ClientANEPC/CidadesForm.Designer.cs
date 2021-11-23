
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
            // CidadesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 285);
            this.Controls.Add(this.buttonListarCidades);
            this.Controls.Add(this.listBox1);
            this.Name = "CidadesForm";
            this.Text = "CidadesForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonListarCidades;
    }
}