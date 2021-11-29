
namespace Dashboard
{
    partial class Final_dash
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Bx_response = new System.Windows.Forms.RichTextBox();
            this.dateTimeBegin = new System.Windows.Forms.DateTimePicker();
            this.dateTimeEnd = new System.Windows.Forms.DateTimePicker();
            this.data_entry_1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.show_dates = new System.Windows.Forms.Button();
            this.Bx_One_Date = new System.Windows.Forms.RichTextBox();
            this.dateTimePickerOnlyDate = new System.Windows.Forms.DateTimePicker();
            this.buttonOnlyDate = new System.Windows.Forms.Button();
            this.BoxOnlyDate = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerBeginCounties = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEndCounties = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonTwoCounties = new System.Windows.Forms.Button();
            this.Bx_TwoCounties = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpOnecountyBegin = new System.Windows.Forms.DateTimePicker();
            this.dtpOnecountyEnd = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.OnEspecificCounty = new System.Windows.Forms.Button();
            this.Bx_OneCounty = new System.Windows.Forms.RichTextBox();
            this.bx_county = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.Bx_statusApi = new System.Windows.Forms.RichTextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 16);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Concelhos";
            // 
            // Bx_response
            // 
            this.Bx_response.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Bx_response.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Bx_response.Location = new System.Drawing.Point(14, 55);
            this.Bx_response.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Bx_response.Name = "Bx_response";
            this.Bx_response.Size = new System.Drawing.Size(287, 927);
            this.Bx_response.TabIndex = 2;
            this.Bx_response.Text = "";
            // 
            // dateTimeBegin
            // 
            this.dateTimeBegin.CustomFormat = "dd-MM-yyyy";
            this.dateTimeBegin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeBegin.Location = new System.Drawing.Point(378, 55);
            this.dateTimeBegin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimeBegin.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dateTimeBegin.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dateTimeBegin.Name = "dateTimeBegin";
            this.dateTimeBegin.Size = new System.Drawing.Size(182, 27);
            this.dateTimeBegin.TabIndex = 3;
            this.dateTimeBegin.Value = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            // 
            // dateTimeEnd
            // 
            this.dateTimeEnd.CustomFormat = "dd-MM-yyyy";
            this.dateTimeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeEnd.Location = new System.Drawing.Point(378, 115);
            this.dateTimeEnd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimeEnd.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dateTimeEnd.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dateTimeEnd.Name = "dateTimeEnd";
            this.dateTimeEnd.Size = new System.Drawing.Size(182, 27);
            this.dateTimeEnd.TabIndex = 4;
            this.dateTimeEnd.Value = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            // 
            // data_entry_1
            // 
            this.data_entry_1.AutoSize = true;
            this.data_entry_1.Location = new System.Drawing.Point(378, 16);
            this.data_entry_1.Name = "data_entry_1";
            this.data_entry_1.Size = new System.Drawing.Size(203, 20);
            this.data_entry_1.TabIndex = 5;
            this.data_entry_1.Text = "Indique o intervalo de tempo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(568, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Fim\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(568, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Inicio";
            // 
            // show_dates
            // 
            this.show_dates.Location = new System.Drawing.Point(419, 153);
            this.show_dates.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.show_dates.Name = "show_dates";
            this.show_dates.Size = new System.Drawing.Size(86, 31);
            this.show_dates.TabIndex = 8;
            this.show_dates.Text = "Mostrar";
            this.show_dates.UseVisualStyleBackColor = true;
            this.show_dates.Click += new System.EventHandler(this.show_dates_Click);
            // 
            // Bx_One_Date
            // 
            this.Bx_One_Date.BackColor = System.Drawing.SystemColors.Window;
            this.Bx_One_Date.Location = new System.Drawing.Point(325, 192);
            this.Bx_One_Date.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Bx_One_Date.Name = "Bx_One_Date";
            this.Bx_One_Date.ReadOnly = true;
            this.Bx_One_Date.Size = new System.Drawing.Size(284, 367);
            this.Bx_One_Date.TabIndex = 10;
            this.Bx_One_Date.Text = "";
            // 
            // dateTimePickerOnlyDate
            // 
            this.dateTimePickerOnlyDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dateTimePickerOnlyDate.CustomFormat = "dd-MM-yyyy";
            this.dateTimePickerOnlyDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerOnlyDate.Location = new System.Drawing.Point(325, 565);
            this.dateTimePickerOnlyDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePickerOnlyDate.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerOnlyDate.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerOnlyDate.Name = "dateTimePickerOnlyDate";
            this.dateTimePickerOnlyDate.Size = new System.Drawing.Size(182, 27);
            this.dateTimePickerOnlyDate.TabIndex = 11;
            this.dateTimePickerOnlyDate.Value = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            // 
            // buttonOnlyDate
            // 
            this.buttonOnlyDate.Location = new System.Drawing.Point(523, 564);
            this.buttonOnlyDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonOnlyDate.Name = "buttonOnlyDate";
            this.buttonOnlyDate.Size = new System.Drawing.Size(86, 31);
            this.buttonOnlyDate.TabIndex = 12;
            this.buttonOnlyDate.Text = "Mostrar";
            this.buttonOnlyDate.UseVisualStyleBackColor = true;
            this.buttonOnlyDate.Click += new System.EventHandler(this.ButtonOnlyDate_Click);
            // 
            // BoxOnlyDate
            // 
            this.BoxOnlyDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.BoxOnlyDate.BackColor = System.Drawing.SystemColors.Window;
            this.BoxOnlyDate.Location = new System.Drawing.Point(325, 601);
            this.BoxOnlyDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BoxOnlyDate.Name = "BoxOnlyDate";
            this.BoxOnlyDate.ReadOnly = true;
            this.BoxOnlyDate.Size = new System.Drawing.Size(284, 380);
            this.BoxOnlyDate.TabIndex = 13;
            this.BoxOnlyDate.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(695, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 40);
            this.label4.TabIndex = 14;
            this.label4.Text = "Indique o intervalo de tempo\r\nEntre Cidades\r\n";
            // 
            // dateTimePickerBeginCounties
            // 
            this.dateTimePickerBeginCounties.CustomFormat = "dd-MM-yyyy";
            this.dateTimePickerBeginCounties.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerBeginCounties.Location = new System.Drawing.Point(695, 59);
            this.dateTimePickerBeginCounties.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePickerBeginCounties.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerBeginCounties.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerBeginCounties.Name = "dateTimePickerBeginCounties";
            this.dateTimePickerBeginCounties.Size = new System.Drawing.Size(182, 27);
            this.dateTimePickerBeginCounties.TabIndex = 15;
            this.dateTimePickerBeginCounties.Value = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            // 
            // dateTimePickerEndCounties
            // 
            this.dateTimePickerEndCounties.CustomFormat = "dd-MM-yyyy";
            this.dateTimePickerEndCounties.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerEndCounties.Location = new System.Drawing.Point(695, 115);
            this.dateTimePickerEndCounties.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePickerEndCounties.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerEndCounties.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerEndCounties.Name = "dateTimePickerEndCounties";
            this.dateTimePickerEndCounties.Size = new System.Drawing.Size(182, 27);
            this.dateTimePickerEndCounties.TabIndex = 16;
            this.dateTimePickerEndCounties.Value = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(885, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Inicio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(885, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Fim\r\n";
            // 
            // buttonTwoCounties
            // 
            this.buttonTwoCounties.Location = new System.Drawing.Point(742, 153);
            this.buttonTwoCounties.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonTwoCounties.Name = "buttonTwoCounties";
            this.buttonTwoCounties.Size = new System.Drawing.Size(86, 31);
            this.buttonTwoCounties.TabIndex = 19;
            this.buttonTwoCounties.Text = "Mostrar";
            this.buttonTwoCounties.UseVisualStyleBackColor = true;
            this.buttonTwoCounties.Click += new System.EventHandler(this.ButtonTwoCounties_Click);
            // 
            // Bx_TwoCounties
            // 
            this.Bx_TwoCounties.BackColor = System.Drawing.SystemColors.Window;
            this.Bx_TwoCounties.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Bx_TwoCounties.Location = new System.Drawing.Point(654, 192);
            this.Bx_TwoCounties.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Bx_TwoCounties.Name = "Bx_TwoCounties";
            this.Bx_TwoCounties.ReadOnly = true;
            this.Bx_TwoCounties.Size = new System.Drawing.Size(284, 367);
            this.Bx_TwoCounties.TabIndex = 20;
            this.Bx_TwoCounties.Text = "";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(654, 568);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(203, 40);
            this.label7.TabIndex = 21;
            this.label7.Text = "Indique o intervalo de tempo\r\nNuma determinada cidade\r\n";
            // 
            // dtpOnecountyBegin
            // 
            this.dtpOnecountyBegin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpOnecountyBegin.CustomFormat = "dd-MM-yyyy";
            this.dtpOnecountyBegin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpOnecountyBegin.Location = new System.Drawing.Point(654, 612);
            this.dtpOnecountyBegin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpOnecountyBegin.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dtpOnecountyBegin.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dtpOnecountyBegin.Name = "dtpOnecountyBegin";
            this.dtpOnecountyBegin.Size = new System.Drawing.Size(182, 27);
            this.dtpOnecountyBegin.TabIndex = 22;
            this.dtpOnecountyBegin.Value = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            // 
            // dtpOnecountyEnd
            // 
            this.dtpOnecountyEnd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpOnecountyEnd.CustomFormat = "dd-MM-yyyy";
            this.dtpOnecountyEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpOnecountyEnd.Location = new System.Drawing.Point(654, 651);
            this.dtpOnecountyEnd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpOnecountyEnd.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dtpOnecountyEnd.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dtpOnecountyEnd.Name = "dtpOnecountyEnd";
            this.dtpOnecountyEnd.Size = new System.Drawing.Size(182, 27);
            this.dtpOnecountyEnd.TabIndex = 23;
            this.dtpOnecountyEnd.Value = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(843, 623);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 20);
            this.label8.TabIndex = 24;
            this.label8.Text = "Inicio";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(843, 661);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 20);
            this.label9.TabIndex = 25;
            this.label9.Text = "Fim\r\n";
            // 
            // OnEspecificCounty
            // 
            this.OnEspecificCounty.Location = new System.Drawing.Point(843, 577);
            this.OnEspecificCounty.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OnEspecificCounty.Name = "OnEspecificCounty";
            this.OnEspecificCounty.Size = new System.Drawing.Size(86, 31);
            this.OnEspecificCounty.TabIndex = 26;
            this.OnEspecificCounty.Text = "Mostrar";
            this.OnEspecificCounty.UseVisualStyleBackColor = true;
            this.OnEspecificCounty.Click += new System.EventHandler(this.OnEspecificCounty_Click);
            // 
            // Bx_OneCounty
            // 
            this.Bx_OneCounty.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Bx_OneCounty.BackColor = System.Drawing.SystemColors.Window;
            this.Bx_OneCounty.Location = new System.Drawing.Point(654, 727);
            this.Bx_OneCounty.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Bx_OneCounty.Name = "Bx_OneCounty";
            this.Bx_OneCounty.ReadOnly = true;
            this.Bx_OneCounty.Size = new System.Drawing.Size(284, 255);
            this.Bx_OneCounty.TabIndex = 27;
            this.Bx_OneCounty.Text = "";
            // 
            // bx_county
            // 
            this.bx_county.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.bx_county.Location = new System.Drawing.Point(654, 689);
            this.bx_county.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bx_county.Name = "bx_county";
            this.bx_county.Size = new System.Drawing.Size(182, 27);
            this.bx_county.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(843, 700);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 20);
            this.label10.TabIndex = 29;
            this.label10.Text = "Cidade";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.Location = new System.Drawing.Point(974, 893);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(187, 31);
            this.button2.TabIndex = 30;
            this.button2.Text = "Mostrar Estado da Api";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ShowStatusApi_Click);
            // 
            // Bx_statusApi
            // 
            this.Bx_statusApi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Bx_statusApi.BackColor = System.Drawing.SystemColors.Window;
            this.Bx_statusApi.Location = new System.Drawing.Point(974, 932);
            this.Bx_statusApi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Bx_statusApi.Name = "Bx_statusApi";
            this.Bx_statusApi.ReadOnly = true;
            this.Bx_statusApi.Size = new System.Drawing.Size(284, 49);
            this.Bx_statusApi.TabIndex = 31;
            this.Bx_statusApi.Text = "";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1000, 27);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 29);
            this.button3.TabIndex = 32;
            this.button3.Text = "Voltar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Final_dash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1336, 999);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Bx_statusApi);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.bx_county);
            this.Controls.Add(this.Bx_OneCounty);
            this.Controls.Add(this.OnEspecificCounty);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtpOnecountyEnd);
            this.Controls.Add(this.dtpOnecountyBegin);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Bx_TwoCounties);
            this.Controls.Add(this.buttonTwoCounties);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePickerEndCounties);
            this.Controls.Add(this.dateTimePickerBeginCounties);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BoxOnlyDate);
            this.Controls.Add(this.buttonOnlyDate);
            this.Controls.Add(this.dateTimePickerOnlyDate);
            this.Controls.Add(this.Bx_One_Date);
            this.Controls.Add(this.show_dates);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.data_entry_1);
            this.Controls.Add(this.dateTimeEnd);
            this.Controls.Add(this.dateTimeBegin);
            this.Controls.Add(this.Bx_response);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Final_dash";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox Bx_response;
        private System.Windows.Forms.DateTimePicker dateTimeBegin;
        private System.Windows.Forms.DateTimePicker dateTimeEnd;
        private System.Windows.Forms.Label data_entry_1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button show_dates;
        private System.Windows.Forms.RichTextBox Bx_One_Date;
        private System.Windows.Forms.DateTimePicker dateTimePickerOnlyDate;
        private System.Windows.Forms.Button buttonOnlyDate;
        private System.Windows.Forms.RichTextBox BoxOnlyDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerBeginCounties;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndCounties;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonTwoCounties;
        private System.Windows.Forms.RichTextBox Bx_TwoCounties;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpOnecountyBegin;
        private System.Windows.Forms.DateTimePicker dtpOnecountyEnd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button OnEspecificCounty;
        private System.Windows.Forms.RichTextBox Bx_OneCounty;
        private System.Windows.Forms.TextBox bx_county;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox Bx_statusApi;
        private System.Windows.Forms.Button button3;
    }
}

