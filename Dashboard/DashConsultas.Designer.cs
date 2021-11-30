
namespace Dashboard
{
    partial class DashConsultas
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
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.top5lstview = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.top10lstView = new System.Windows.Forms.ListView();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.visitaslstView = new System.Windows.Forms.ListView();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader10 = new System.Windows.Forms.ColumnHeader();
            this.btnback = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(44, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Top 5 mais encomendados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(44, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Top 10 equipas mais caras";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(427, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(273, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantidade de visitas GNR e PSP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(416, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(301, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Percentagem de irregularidades/Dia";
            // 
            // top5lstview
            // 
            this.top5lstview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.top5lstview.HideSelection = false;
            this.top5lstview.Location = new System.Drawing.Point(44, 60);
            this.top5lstview.Name = "top5lstview";
            this.top5lstview.Size = new System.Drawing.Size(266, 195);
            this.top5lstview.TabIndex = 5;
            this.top5lstview.UseCompatibleStateImageBehavior = false;
            this.top5lstview.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Descrição";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Total";
            this.columnHeader3.Width = 80;
            // 
            // top10lstView
            // 
            this.top10lstView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.top10lstView.HideSelection = false;
            this.top10lstView.Location = new System.Drawing.Point(44, 296);
            this.top10lstView.Name = "top10lstView";
            this.top10lstView.Size = new System.Drawing.Size(266, 195);
            this.top10lstView.TabIndex = 6;
            this.top10lstView.UseCompatibleStateImageBehavior = false;
            this.top10lstView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "ID";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Nome";
            this.columnHeader5.Width = 120;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Total (€)";
            this.columnHeader6.Width = 80;
            // 
            // visitaslstView
            // 
            this.visitaslstView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.visitaslstView.HideSelection = false;
            this.visitaslstView.Location = new System.Drawing.Point(364, 68);
            this.visitaslstView.Name = "visitaslstView";
            this.visitaslstView.Size = new System.Drawing.Size(381, 451);
            this.visitaslstView.TabIndex = 7;
            this.visitaslstView.UseCompatibleStateImageBehavior = false;
            this.visitaslstView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Data";
            this.columnHeader7.Width = 100;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Visitas";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Irregularidades";
            this.columnHeader9.Width = 100;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "(%) Irregularidades";
            this.columnHeader10.Width = 100;
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(44, 503);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(100, 32);
            this.btnback.TabIndex = 8;
            this.btnback.Text = "Voltar";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // DashConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 540);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.visitaslstView);
            this.Controls.Add(this.top10lstView);
            this.Controls.Add(this.top5lstview);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DashConsultas";
            this.Text = "DashConsultas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DashConsultas_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView top5lstview;
        private System.Windows.Forms.ListView top10lstView;
        private System.Windows.Forms.ListView visitaslstView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.Button btnback;
    }
}