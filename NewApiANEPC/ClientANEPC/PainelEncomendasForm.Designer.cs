
namespace ClientANEPC
{
    partial class PainelEncomendasForm
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
            this.buttonBuscarHistorico = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.idEncomenda = new System.Windows.Forms.ColumnHeader();
            this.idEquipa = new System.Windows.Forms.ColumnHeader();
            this.Entregue = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // buttonBuscarHistorico
            // 
            this.buttonBuscarHistorico.Location = new System.Drawing.Point(64, 25);
            this.buttonBuscarHistorico.Name = "buttonBuscarHistorico";
            this.buttonBuscarHistorico.Size = new System.Drawing.Size(152, 43);
            this.buttonBuscarHistorico.TabIndex = 0;
            this.buttonBuscarHistorico.Text = "Buscar Historico de Encomendas";
            this.buttonBuscarHistorico.UseVisualStyleBackColor = true;
            this.buttonBuscarHistorico.Click += new System.EventHandler(this.buttonBuscarHistorico_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idEncomenda,
            this.idEquipa,
            this.Entregue});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(24, 89);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(234, 195);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // PainelEncomendasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 296);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.buttonBuscarHistorico);
            this.Name = "PainelEncomendasForm";
            this.Text = "PainelEncomendasForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBuscarHistorico;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader idEncomenda;
        private System.Windows.Forms.ColumnHeader idEquipa;
        private System.Windows.Forms.ColumnHeader Entregue;
    }
}