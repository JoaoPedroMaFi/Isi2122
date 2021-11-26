
namespace ClientANEPC
{
    partial class NovaEncomendaForm
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
            this.buttonRequisitar = new System.Windows.Forms.Button();
            this.buttonEscolherProds = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelIdEq = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(181, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nova Encomenda";
            // 
            // buttonRequisitar
            // 
            this.buttonRequisitar.Location = new System.Drawing.Point(35, 149);
            this.buttonRequisitar.Name = "buttonRequisitar";
            this.buttonRequisitar.Size = new System.Drawing.Size(124, 50);
            this.buttonRequisitar.TabIndex = 3;
            this.buttonRequisitar.Text = "Requisitar";
            this.buttonRequisitar.UseVisualStyleBackColor = true;
            this.buttonRequisitar.Click += new System.EventHandler(this.buttonRequisitar_Click);
            // 
            // buttonEscolherProds
            // 
            this.buttonEscolherProds.Location = new System.Drawing.Point(318, 149);
            this.buttonEscolherProds.Name = "buttonEscolherProds";
            this.buttonEscolherProds.Size = new System.Drawing.Size(129, 49);
            this.buttonEscolherProds.TabIndex = 4;
            this.buttonEscolherProds.Text = "Escolher Produtos";
            this.buttonEscolherProds.UseVisualStyleBackColor = true;
            this.buttonEscolherProds.Click += new System.EventHandler(this.buttonEscolherProds_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "ID da Equipa:";
            // 
            // labelIdEq
            // 
            this.labelIdEq.AutoSize = true;
            this.labelIdEq.Location = new System.Drawing.Point(265, 95);
            this.labelIdEq.Name = "labelIdEq";
            this.labelIdEq.Size = new System.Drawing.Size(38, 15);
            this.labelIdEq.TabIndex = 6;
            this.labelIdEq.Text = "label3";
            // 
            // NovaEncomendaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 254);
            this.Controls.Add(this.labelIdEq);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonEscolherProds);
            this.Controls.Add(this.buttonRequisitar);
            this.Controls.Add(this.label1);
            this.Name = "NovaEncomendaForm";
            this.Text = "NovaEncomendaForm";
            this.Load += new System.EventHandler(this.NovaEncomendaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonRequisitar;
        private System.Windows.Forms.Button buttonEscolherProds;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelIdEq;
    }
}