
namespace ClientANEPC
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cidadesButton = new System.Windows.Forms.Button();
            this.buttonEncomendas = new System.Windows.Forms.Button();
            this.buttonEquipas = new System.Windows.Forms.Button();
            this.buttonProdutos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(237, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "ANEPC Control Panel";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cidadesButton
            // 
            this.cidadesButton.Location = new System.Drawing.Point(38, 155);
            this.cidadesButton.Name = "cidadesButton";
            this.cidadesButton.Size = new System.Drawing.Size(141, 54);
            this.cidadesButton.TabIndex = 1;
            this.cidadesButton.Text = "Cidades";
            this.cidadesButton.UseVisualStyleBackColor = true;
            this.cidadesButton.Click += new System.EventHandler(this.cidadesButton_Click);
            // 
            // buttonEncomendas
            // 
            this.buttonEncomendas.Location = new System.Drawing.Point(210, 155);
            this.buttonEncomendas.Name = "buttonEncomendas";
            this.buttonEncomendas.Size = new System.Drawing.Size(146, 54);
            this.buttonEncomendas.TabIndex = 2;
            this.buttonEncomendas.Text = "Encomendas";
            this.buttonEncomendas.UseVisualStyleBackColor = true;
            this.buttonEncomendas.Click += new System.EventHandler(this.buttonEncomendas_Click);
            // 
            // buttonEquipas
            // 
            this.buttonEquipas.Location = new System.Drawing.Point(387, 155);
            this.buttonEquipas.Name = "buttonEquipas";
            this.buttonEquipas.Size = new System.Drawing.Size(144, 54);
            this.buttonEquipas.TabIndex = 3;
            this.buttonEquipas.Text = "Equipas";
            this.buttonEquipas.UseVisualStyleBackColor = true;
            this.buttonEquipas.Click += new System.EventHandler(this.buttonEquipas_Click);
            // 
            // buttonProdutos
            // 
            this.buttonProdutos.Location = new System.Drawing.Point(561, 155);
            this.buttonProdutos.Name = "buttonProdutos";
            this.buttonProdutos.Size = new System.Drawing.Size(132, 54);
            this.buttonProdutos.TabIndex = 4;
            this.buttonProdutos.Text = "Produtos";
            this.buttonProdutos.UseVisualStyleBackColor = true;
            this.buttonProdutos.Click += new System.EventHandler(this.buttonProdutos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 280);
            this.Controls.Add(this.buttonProdutos);
            this.Controls.Add(this.buttonEquipas);
            this.Controls.Add(this.buttonEncomendas);
            this.Controls.Add(this.cidadesButton);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cidadesButton;
        private System.Windows.Forms.Button buttonEncomendas;
        private System.Windows.Forms.Button buttonEquipas;
        private System.Windows.Forms.Button buttonProdutos;
    }
}

