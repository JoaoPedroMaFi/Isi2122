
namespace ClientANEPC
{
    partial class EncomendasForm
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
            this.buttonNovaEncomenda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonNovaEncomenda
            // 
            this.buttonNovaEncomenda.Location = new System.Drawing.Point(25, 65);
            this.buttonNovaEncomenda.Name = "buttonNovaEncomenda";
            this.buttonNovaEncomenda.Size = new System.Drawing.Size(110, 81);
            this.buttonNovaEncomenda.TabIndex = 0;
            this.buttonNovaEncomenda.Text = "Nova Encomenda";
            this.buttonNovaEncomenda.UseVisualStyleBackColor = true;
            this.buttonNovaEncomenda.Click += new System.EventHandler(this.buttonNovaEncomenda_Click);
            // 
            // EncomendasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 268);
            this.Controls.Add(this.buttonNovaEncomenda);
            this.Name = "EncomendasForm";
            this.Text = "EncomendasForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonNovaEncomenda;
    }
}