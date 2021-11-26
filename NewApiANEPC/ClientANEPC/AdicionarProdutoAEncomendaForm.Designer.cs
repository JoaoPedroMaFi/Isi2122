
namespace ClientANEPC
{
    partial class AdicionarProdutoAEncomendaForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxIdProduto = new System.Windows.Forms.TextBox();
            this.textBoxQuantidadeProduto = new System.Windows.Forms.TextBox();
            this.buttonAdicionarARequisicao = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.labelIdEq = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Produto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quantidade";
            // 
            // textBoxIdProduto
            // 
            this.textBoxIdProduto.Location = new System.Drawing.Point(90, 22);
            this.textBoxIdProduto.Name = "textBoxIdProduto";
            this.textBoxIdProduto.Size = new System.Drawing.Size(93, 23);
            this.textBoxIdProduto.TabIndex = 2;
            // 
            // textBoxQuantidadeProduto
            // 
            this.textBoxQuantidadeProduto.Location = new System.Drawing.Point(90, 76);
            this.textBoxQuantidadeProduto.Name = "textBoxQuantidadeProduto";
            this.textBoxQuantidadeProduto.Size = new System.Drawing.Size(93, 23);
            this.textBoxQuantidadeProduto.TabIndex = 3;
            // 
            // buttonAdicionarARequisicao
            // 
            this.buttonAdicionarARequisicao.Location = new System.Drawing.Point(46, 118);
            this.buttonAdicionarARequisicao.Name = "buttonAdicionarARequisicao";
            this.buttonAdicionarARequisicao.Size = new System.Drawing.Size(116, 41);
            this.buttonAdicionarARequisicao.TabIndex = 4;
            this.buttonAdicionarARequisicao.Text = "Adicionar a requisicao";
            this.buttonAdicionarARequisicao.UseVisualStyleBackColor = true;
            this.buttonAdicionarARequisicao.Click += new System.EventHandler(this.buttonAdicionarARequisicao_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "ID Equipa:";
            // 
            // labelIdEq
            // 
            this.labelIdEq.AutoSize = true;
            this.labelIdEq.Location = new System.Drawing.Point(187, 167);
            this.labelIdEq.Name = "labelIdEq";
            this.labelIdEq.Size = new System.Drawing.Size(38, 15);
            this.labelIdEq.TabIndex = 6;
            this.labelIdEq.Text = "label4";
            // 
            // AdicionarProdutoAEncomendaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(205, 181);
            this.Controls.Add(this.labelIdEq);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonAdicionarARequisicao);
            this.Controls.Add(this.textBoxQuantidadeProduto);
            this.Controls.Add(this.textBoxIdProduto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AdicionarProdutoAEncomendaForm";
            this.Text = "AdicionarProdutoAEncomendaForm";
            this.Load += new System.EventHandler(this.AdicionarProdutoAEncomendaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxIdProduto;
        private System.Windows.Forms.TextBox textBoxQuantidadeProduto;
        private System.Windows.Forms.Button buttonAdicionarARequisicao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelIdEq;
    }
}