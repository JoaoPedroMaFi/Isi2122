
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxIdEquipaRequisitante = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonNovaEncomenda
            // 
            this.buttonNovaEncomenda.Location = new System.Drawing.Point(90, 132);
            this.buttonNovaEncomenda.Name = "buttonNovaEncomenda";
            this.buttonNovaEncomenda.Size = new System.Drawing.Size(110, 81);
            this.buttonNovaEncomenda.TabIndex = 0;
            this.buttonNovaEncomenda.Text = "Nova Encomenda";
            this.buttonNovaEncomenda.UseVisualStyleBackColor = true;
            this.buttonNovaEncomenda.Click += new System.EventHandler(this.buttonNovaEncomenda_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID da equipa requisitante:";
            // 
            // textBoxIdEquipaRequisitante
            // 
            this.textBoxIdEquipaRequisitante.Location = new System.Drawing.Point(177, 30);
            this.textBoxIdEquipaRequisitante.Name = "textBoxIdEquipaRequisitante";
            this.textBoxIdEquipaRequisitante.Size = new System.Drawing.Size(76, 23);
            this.textBoxIdEquipaRequisitante.TabIndex = 2;
            // 
            // EncomendasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 268);
            this.Controls.Add(this.textBoxIdEquipaRequisitante);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonNovaEncomenda);
            this.Name = "EncomendasForm";
            this.Text = "EncomendasForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNovaEncomenda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxIdEquipaRequisitante;
    }
}