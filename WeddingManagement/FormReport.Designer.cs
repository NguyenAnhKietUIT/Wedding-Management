﻿namespace WeddingManagement
{
    partial class FormReport
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
            this.labelRReport = new System.Windows.Forms.Label();
            this.comboBoxMonth = new System.Windows.Forms.ComboBox();
            this.labelmonth = new System.Windows.Forms.Label();
            this.textBoxAOW = new System.Windows.Forms.TextBox();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.labelAOW = new System.Windows.Forms.Label();
            this.labelYear = new System.Windows.Forms.Label();
            this.textBoxDayRevenue = new System.Windows.Forms.TextBox();
            this.comboBoxDay = new System.Windows.Forms.ComboBox();
            this.labelDayRevenue = new System.Windows.Forms.Label();
            this.labelDay = new System.Windows.Forms.Label();
            this.dataRPD = new System.Windows.Forms.DataGridView();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_search_rpDay = new System.Windows.Forms.Button();
            this.tb_seacrh_rpDay = new System.Windows.Forms.TextBox();
            this.rBtn_amount = new System.Windows.Forms.RadioButton();
            this.rBtn_day = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataRPD)).BeginInit();
            this.SuspendLayout();
            // 
            // labelRReport
            // 
            this.labelRReport.AutoSize = true;
            this.labelRReport.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRReport.ForeColor = System.Drawing.Color.Black;
            this.labelRReport.Location = new System.Drawing.Point(265, 9);
            this.labelRReport.Name = "labelRReport";
            this.labelRReport.Size = new System.Drawing.Size(345, 40);
            this.labelRReport.TabIndex = 2;
            this.labelRReport.Text = "REVENUE REPORT DAY";
            // 
            // comboBoxMonth
            // 
            this.comboBoxMonth.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxMonth.FormattingEnabled = true;
            this.comboBoxMonth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.comboBoxMonth.Location = new System.Drawing.Point(320, 165);
            this.comboBoxMonth.Name = "comboBoxMonth";
            this.comboBoxMonth.Size = new System.Drawing.Size(161, 32);
            this.comboBoxMonth.TabIndex = 10;
            // 
            // labelmonth
            // 
            this.labelmonth.AutoSize = true;
            this.labelmonth.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelmonth.ForeColor = System.Drawing.Color.Black;
            this.labelmonth.Location = new System.Drawing.Point(255, 168);
            this.labelmonth.Name = "labelmonth";
            this.labelmonth.Size = new System.Drawing.Size(59, 24);
            this.labelmonth.TabIndex = 9;
            this.labelmonth.Text = "Month";
            // 
            // textBoxAOW
            // 
            this.textBoxAOW.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAOW.Location = new System.Drawing.Point(622, 236);
            this.textBoxAOW.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAOW.Name = "textBoxAOW";
            this.textBoxAOW.Size = new System.Drawing.Size(223, 30);
            this.textBoxAOW.TabIndex = 7;
            // 
            // textBoxYear
            // 
            this.textBoxYear.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxYear.Location = new System.Drawing.Point(569, 165);
            this.textBoxYear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(161, 30);
            this.textBoxYear.TabIndex = 6;
            // 
            // labelAOW
            // 
            this.labelAOW.AutoSize = true;
            this.labelAOW.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAOW.ForeColor = System.Drawing.Color.Black;
            this.labelAOW.Location = new System.Drawing.Point(422, 239);
            this.labelAOW.Name = "labelAOW";
            this.labelAOW.Size = new System.Drawing.Size(166, 24);
            this.labelAOW.TabIndex = 5;
            this.labelAOW.Text = "Amount Of Wedding";
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelYear.ForeColor = System.Drawing.Color.Black;
            this.labelYear.Location = new System.Drawing.Point(515, 168);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(44, 24);
            this.labelYear.TabIndex = 4;
            this.labelYear.Text = "Year";
            // 
            // textBoxDayRevenue
            // 
            this.textBoxDayRevenue.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDayRevenue.Location = new System.Drawing.Point(147, 236);
            this.textBoxDayRevenue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxDayRevenue.Name = "textBoxDayRevenue";
            this.textBoxDayRevenue.ReadOnly = true;
            this.textBoxDayRevenue.Size = new System.Drawing.Size(223, 30);
            this.textBoxDayRevenue.TabIndex = 3;
            // 
            // comboBoxDay
            // 
            this.comboBoxDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDay.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDay.FormattingEnabled = true;
            this.comboBoxDay.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.comboBoxDay.Location = new System.Drawing.Point(55, 165);
            this.comboBoxDay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxDay.Name = "comboBoxDay";
            this.comboBoxDay.Size = new System.Drawing.Size(161, 32);
            this.comboBoxDay.TabIndex = 8;
            // 
            // labelDayRevenue
            // 
            this.labelDayRevenue.AutoSize = true;
            this.labelDayRevenue.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDayRevenue.ForeColor = System.Drawing.Color.Black;
            this.labelDayRevenue.Location = new System.Drawing.Point(9, 239);
            this.labelDayRevenue.Name = "labelDayRevenue";
            this.labelDayRevenue.Size = new System.Drawing.Size(113, 24);
            this.labelDayRevenue.TabIndex = 1;
            this.labelDayRevenue.Text = "Day Revenue";
            // 
            // labelDay
            // 
            this.labelDay.AutoSize = true;
            this.labelDay.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDay.ForeColor = System.Drawing.Color.Black;
            this.labelDay.Location = new System.Drawing.Point(9, 168);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(40, 24);
            this.labelDay.TabIndex = 0;
            this.labelDay.Text = "Day";
            // 
            // dataRPD
            // 
            this.dataRPD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataRPD.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataRPD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataRPD.Location = new System.Drawing.Point(13, 286);
            this.dataRPD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataRPD.Name = "dataRPD";
            this.dataRPD.RowHeadersWidth = 51;
            this.dataRPD.Size = new System.Drawing.Size(832, 205);
            this.dataRPD.TabIndex = 4;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.DimGray;
            this.buttonAdd.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(767, 162);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(78, 38);
            this.buttonAdd.TabIndex = 8;
            this.buttonAdd.Text = "ADD";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Gray;
            this.label6.Font = new System.Drawing.Font("Copperplate Gothic Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(829, -1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 25);
            this.label6.TabIndex = 72;
            this.label6.Text = "X";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // btn_search_rpDay
            // 
            this.btn_search_rpDay.BackColor = System.Drawing.Color.DimGray;
            this.btn_search_rpDay.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search_rpDay.ForeColor = System.Drawing.Color.White;
            this.btn_search_rpDay.Location = new System.Drawing.Point(770, 70);
            this.btn_search_rpDay.Name = "btn_search_rpDay";
            this.btn_search_rpDay.Size = new System.Drawing.Size(78, 38);
            this.btn_search_rpDay.TabIndex = 76;
            this.btn_search_rpDay.Text = "SEARCH";
            this.btn_search_rpDay.UseVisualStyleBackColor = false;
            this.btn_search_rpDay.Click += new System.EventHandler(this.btn_search_rpDay_Click);
            // 
            // tb_seacrh_rpDay
            // 
            this.tb_seacrh_rpDay.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_seacrh_rpDay.Location = new System.Drawing.Point(549, 73);
            this.tb_seacrh_rpDay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_seacrh_rpDay.Name = "tb_seacrh_rpDay";
            this.tb_seacrh_rpDay.Size = new System.Drawing.Size(215, 30);
            this.tb_seacrh_rpDay.TabIndex = 11;
            // 
            // rBtn_amount
            // 
            this.rBtn_amount.AutoSize = true;
            this.rBtn_amount.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtn_amount.Location = new System.Drawing.Point(635, 108);
            this.rBtn_amount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rBtn_amount.Name = "rBtn_amount";
            this.rBtn_amount.Size = new System.Drawing.Size(174, 28);
            this.rBtn_amount.TabIndex = 78;
            this.rBtn_amount.TabStop = true;
            this.rBtn_amount.Text = "Amount of wedding";
            this.rBtn_amount.UseVisualStyleBackColor = true;
            // 
            // rBtn_day
            // 
            this.rBtn_day.AutoSize = true;
            this.rBtn_day.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtn_day.Location = new System.Drawing.Point(569, 108);
            this.rBtn_day.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rBtn_day.Name = "rBtn_day";
            this.rBtn_day.Size = new System.Drawing.Size(61, 28);
            this.rBtn_day.TabIndex = 80;
            this.rBtn_day.TabStop = true;
            this.rBtn_day.Text = "Day";
            this.rBtn_day.UseVisualStyleBackColor = true;
            // 
            // FormReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(857, 506);
            this.Controls.Add(this.rBtn_day);
            this.Controls.Add(this.comboBoxMonth);
            this.Controls.Add(this.rBtn_amount);
            this.Controls.Add(this.labelmonth);
            this.Controls.Add(this.textBoxAOW);
            this.Controls.Add(this.tb_seacrh_rpDay);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.btn_search_rpDay);
            this.Controls.Add(this.labelAOW);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.textBoxDayRevenue);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxDay);
            this.Controls.Add(this.labelDayRevenue);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelDay);
            this.Controls.Add(this.dataRPD);
            this.Controls.Add(this.labelRReport);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximumSize = new System.Drawing.Size(857, 577);
            this.Name = "FormReport";
            this.Text = "FormReport";
            this.Load += new System.EventHandler(this.ReportDay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataRPD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelRReport;
        private System.Windows.Forms.TextBox textBoxAOW;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.Label labelAOW;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.TextBox textBoxDayRevenue;
        private System.Windows.Forms.ComboBox comboBoxDay;
        private System.Windows.Forms.Label labelDayRevenue;
        private System.Windows.Forms.Label labelDay;
        private System.Windows.Forms.DataGridView dataRPD;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ComboBox comboBoxMonth;
        private System.Windows.Forms.Label labelmonth;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_search_rpDay;
        private System.Windows.Forms.TextBox tb_seacrh_rpDay;
        private System.Windows.Forms.RadioButton rBtn_amount;
        private System.Windows.Forms.RadioButton rBtn_day;
    }
}