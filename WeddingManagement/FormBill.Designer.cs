using System;

namespace WeddingManagement
{
    partial class FormBill
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
            this.label_tittle_bill = new System.Windows.Forms.Label();
            this.invoiceDTP = new System.Windows.Forms.DateTimePicker();
            this.label_invoice_date = new System.Windows.Forms.Label();
            this.label_service_price = new System.Windows.Forms.Label();
            this.label_money_left = new System.Windows.Forms.Label();
            this.label_payment_date = new System.Windows.Forms.Label();
            this.label_total = new System.Windows.Forms.Label();
            this.label_table_total_price = new System.Windows.Forms.Label();
            this.label_rule_fl = new System.Windows.Forms.Label();
            this.label_penalty_rate = new System.Windows.Forms.Label();
            this.paymentDTP = new System.Windows.Forms.DateTimePicker();
            this.tb_serviceTotal = new WeddingManagement.CustomBorderTextbox();
            this.tb_lobby_price = new WeddingManagement.CustomBorderTextbox();
            this.tb_moneyLeft = new WeddingManagement.CustomBorderTextbox();
            this.tb_tableTotal = new WeddingManagement.CustomBorderTextbox();
            this.tb_penalty = new WeddingManagement.CustomBorderTextbox();
            this.rBtn_yes = new System.Windows.Forms.RadioButton();
            this.rBtn_no = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_representative = new WeddingManagement.CustomBorderTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbb_staff = new System.Windows.Forms.ComboBox();
            this.tb_phone = new WeddingManagement.CustomBorderTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_total = new WeddingManagement.CustomBorderTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pay_no = new System.Windows.Forms.RadioButton();
            this.pay_yes = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_tittle_bill
            // 
            this.label_tittle_bill.AutoSize = true;
            this.label_tittle_bill.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tittle_bill.ForeColor = System.Drawing.Color.Black;
            this.label_tittle_bill.Location = new System.Drawing.Point(589, 14);
            this.label_tittle_bill.Margin = new System.Windows.Forms.Padding(0);
            this.label_tittle_bill.Name = "label_tittle_bill";
            this.label_tittle_bill.Size = new System.Drawing.Size(77, 35);
            this.label_tittle_bill.TabIndex = 19;
            this.label_tittle_bill.Text = "BILL ";
            // 
            // invoiceDTP
            // 
            this.invoiceDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.invoiceDTP.Location = new System.Drawing.Point(1043, 59);
            this.invoiceDTP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.invoiceDTP.Name = "invoiceDTP";
            this.invoiceDTP.Size = new System.Drawing.Size(140, 30);
            this.invoiceDTP.TabIndex = 21;
            // 
            // label_invoice_date
            // 
            this.label_invoice_date.AutoSize = true;
            this.label_invoice_date.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_invoice_date.ForeColor = System.Drawing.Color.Black;
            this.label_invoice_date.Location = new System.Drawing.Point(927, 64);
            this.label_invoice_date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_invoice_date.Name = "label_invoice_date";
            this.label_invoice_date.Size = new System.Drawing.Size(108, 24);
            this.label_invoice_date.TabIndex = 22;
            this.label_invoice_date.Text = "Invoice date:";
            // 
            // label_service_price
            // 
            this.label_service_price.AutoSize = true;
            this.label_service_price.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_service_price.ForeColor = System.Drawing.Color.Black;
            this.label_service_price.Location = new System.Drawing.Point(14, 110);
            this.label_service_price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_service_price.Name = "label_service_price";
            this.label_service_price.Size = new System.Drawing.Size(119, 24);
            this.label_service_price.TabIndex = 28;
            this.label_service_price.Text = "Services price";
            // 
            // label_money_left
            // 
            this.label_money_left.AutoSize = true;
            this.label_money_left.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_money_left.ForeColor = System.Drawing.Color.Black;
            this.label_money_left.Location = new System.Drawing.Point(396, 170);
            this.label_money_left.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_money_left.Name = "label_money_left";
            this.label_money_left.Size = new System.Drawing.Size(90, 24);
            this.label_money_left.TabIndex = 29;
            this.label_money_left.Text = "Money left";
            // 
            // label_payment_date
            // 
            this.label_payment_date.AutoSize = true;
            this.label_payment_date.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_payment_date.ForeColor = System.Drawing.Color.Black;
            this.label_payment_date.Location = new System.Drawing.Point(396, 114);
            this.label_payment_date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_payment_date.Name = "label_payment_date";
            this.label_payment_date.Size = new System.Drawing.Size(115, 24);
            this.label_payment_date.TabIndex = 30;
            this.label_payment_date.Text = "Payment date";
            // 
            // label_total
            // 
            this.label_total.AutoSize = true;
            this.label_total.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_total.ForeColor = System.Drawing.Color.Black;
            this.label_total.Location = new System.Drawing.Point(14, 170);
            this.label_total.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_total.Name = "label_total";
            this.label_total.Size = new System.Drawing.Size(94, 24);
            this.label_total.TabIndex = 31;
            this.label_total.Text = "Lobby rent";
            // 
            // label_table_total_price
            // 
            this.label_table_total_price.AutoSize = true;
            this.label_table_total_price.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_table_total_price.ForeColor = System.Drawing.Color.Black;
            this.label_table_total_price.Location = new System.Drawing.Point(14, 50);
            this.label_table_total_price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_table_total_price.Name = "label_table_total_price";
            this.label_table_total_price.Size = new System.Drawing.Size(107, 24);
            this.label_table_total_price.TabIndex = 32;
            this.label_table_total_price.Text = "Dishes Price";
            // 
            // label_rule_fl
            // 
            this.label_rule_fl.AutoSize = true;
            this.label_rule_fl.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_rule_fl.ForeColor = System.Drawing.Color.Black;
            this.label_rule_fl.Location = new System.Drawing.Point(892, 433);
            this.label_rule_fl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_rule_fl.Name = "label_rule_fl";
            this.label_rule_fl.Size = new System.Drawing.Size(129, 24);
            this.label_rule_fl.TabIndex = 35;
            this.label_rule_fl.Text = "Rules following";
            // 
            // label_penalty_rate
            // 
            this.label_penalty_rate.AutoSize = true;
            this.label_penalty_rate.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_penalty_rate.ForeColor = System.Drawing.Color.Black;
            this.label_penalty_rate.Location = new System.Drawing.Point(892, 376);
            this.label_penalty_rate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_penalty_rate.Name = "label_penalty_rate";
            this.label_penalty_rate.Size = new System.Drawing.Size(106, 24);
            this.label_penalty_rate.TabIndex = 36;
            this.label_penalty_rate.Text = "Penalty rate:";
            // 
            // paymentDTP
            // 
            this.paymentDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.paymentDTP.Location = new System.Drawing.Point(519, 105);
            this.paymentDTP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.paymentDTP.Name = "paymentDTP";
            this.paymentDTP.Size = new System.Drawing.Size(212, 30);
            this.paymentDTP.TabIndex = 35;
            // 
            // tb_serviceTotal
            // 
            this.tb_serviceTotal.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_serviceTotal.Location = new System.Drawing.Point(141, 111);
            this.tb_serviceTotal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_serviceTotal.Name = "tb_serviceTotal";
            this.tb_serviceTotal.ReadOnly = true;
            this.tb_serviceTotal.Size = new System.Drawing.Size(233, 30);
            this.tb_serviceTotal.TabIndex = 27;
            this.tb_serviceTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_lobby_price
            // 
            this.tb_lobby_price.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_lobby_price.Location = new System.Drawing.Point(141, 167);
            this.tb_lobby_price.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_lobby_price.Name = "tb_lobby_price";
            this.tb_lobby_price.ReadOnly = true;
            this.tb_lobby_price.Size = new System.Drawing.Size(233, 30);
            this.tb_lobby_price.TabIndex = 33;
            this.tb_lobby_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_moneyLeft
            // 
            this.tb_moneyLeft.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_moneyLeft.Location = new System.Drawing.Point(519, 167);
            this.tb_moneyLeft.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_moneyLeft.Name = "tb_moneyLeft";
            this.tb_moneyLeft.ReadOnly = true;
            this.tb_moneyLeft.Size = new System.Drawing.Size(210, 30);
            this.tb_moneyLeft.TabIndex = 25;
            // 
            // tb_tableTotal
            // 
            this.tb_tableTotal.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_tableTotal.Location = new System.Drawing.Point(141, 47);
            this.tb_tableTotal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_tableTotal.Name = "tb_tableTotal";
            this.tb_tableTotal.ReadOnly = true;
            this.tb_tableTotal.Size = new System.Drawing.Size(233, 30);
            this.tb_tableTotal.TabIndex = 24;
            this.tb_tableTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_penalty
            // 
            this.tb_penalty.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_penalty.Location = new System.Drawing.Point(1006, 373);
            this.tb_penalty.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_penalty.Name = "tb_penalty";
            this.tb_penalty.ReadOnly = true;
            this.tb_penalty.Size = new System.Drawing.Size(177, 30);
            this.tb_penalty.TabIndex = 23;
            // 
            // rBtn_yes
            // 
            this.rBtn_yes.AutoSize = true;
            this.rBtn_yes.Checked = true;
            this.rBtn_yes.Location = new System.Drawing.Point(0, 0);
            this.rBtn_yes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rBtn_yes.Name = "rBtn_yes";
            this.rBtn_yes.Size = new System.Drawing.Size(59, 28);
            this.rBtn_yes.TabIndex = 37;
            this.rBtn_yes.TabStop = true;
            this.rBtn_yes.Text = "Yes";
            this.rBtn_yes.UseVisualStyleBackColor = true;
            this.rBtn_yes.Click += new System.EventHandler(this.RBtn_yes_Click);
            // 
            // rBtn_no
            // 
            this.rBtn_no.AutoSize = true;
            this.rBtn_no.Location = new System.Drawing.Point(89, 0);
            this.rBtn_no.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rBtn_no.Name = "rBtn_no";
            this.rBtn_no.Size = new System.Drawing.Size(52, 28);
            this.rBtn_no.TabIndex = 38;
            this.rBtn_no.Text = "No";
            this.rBtn_no.UseVisualStyleBackColor = true;
            this.rBtn_no.Click += new System.EventHandler(this.RBtn_no_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_representative);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbb_staff);
            this.groupBox1.Controls.Add(this.tb_phone);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 91);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(430, 238);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information";
            // 
            // tb_representative
            // 
            this.tb_representative.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_representative.Location = new System.Drawing.Point(149, 111);
            this.tb_representative.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_representative.Name = "tb_representative";
            this.tb_representative.ReadOnly = true;
            this.tb_representative.Size = new System.Drawing.Size(271, 30);
            this.tb_representative.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(16, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 24);
            this.label3.TabIndex = 50;
            this.label3.Text = "Representative";
            // 
            // cbb_staff
            // 
            this.cbb_staff.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_staff.FormattingEnabled = true;
            this.cbb_staff.Location = new System.Drawing.Point(149, 48);
            this.cbb_staff.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbb_staff.Name = "cbb_staff";
            this.cbb_staff.Size = new System.Drawing.Size(271, 32);
            this.cbb_staff.TabIndex = 49;
            this.cbb_staff.Visible = false;
            // 
            // tb_phone
            // 
            this.tb_phone.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_phone.Location = new System.Drawing.Point(149, 175);
            this.tb_phone.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_phone.Name = "tb_phone";
            this.tb_phone.ReadOnly = true;
            this.tb_phone.Size = new System.Drawing.Size(271, 30);
            this.tb_phone.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(16, 178);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 24);
            this.label2.TabIndex = 47;
            this.label2.Text = "Phone number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(16, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 24);
            this.label1.TabIndex = 46;
            this.label1.Text = "Made by";
            this.label1.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_total);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tb_serviceTotal);
            this.groupBox2.Controls.Add(this.label_service_price);
            this.groupBox2.Controls.Add(this.label_table_total_price);
            this.groupBox2.Controls.Add(this.tb_tableTotal);
            this.groupBox2.Controls.Add(this.tb_lobby_price);
            this.groupBox2.Controls.Add(this.label_total);
            this.groupBox2.Controls.Add(this.label_payment_date);
            this.groupBox2.Controls.Add(this.label_money_left);
            this.groupBox2.Controls.Add(this.paymentDTP);
            this.groupBox2.Controls.Add(this.tb_moneyLeft);
            this.groupBox2.Location = new System.Drawing.Point(454, 91);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(748, 238);
            this.groupBox2.TabIndex = 61;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Payment";
            // 
            // tb_total
            // 
            this.tb_total.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_total.Location = new System.Drawing.Point(519, 47);
            this.tb_total.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_total.Name = "tb_total";
            this.tb_total.ReadOnly = true;
            this.tb_total.Size = new System.Drawing.Size(212, 30);
            this.tb_total.TabIndex = 66;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(396, 51);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 24);
            this.label4.TabIndex = 67;
            this.label4.Text = "Total";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(15, 338);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Size = new System.Drawing.Size(421, 280);
            this.groupBox3.TabIndex = 62;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dishes";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 32);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(414, 240);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView2);
            this.groupBox4.Location = new System.Drawing.Point(454, 338);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Size = new System.Drawing.Size(421, 280);
            this.groupBox4.TabIndex = 63;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Service";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 32);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(414, 240);
            this.dataGridView2.TabIndex = 0;
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_exit.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.Color.White;
            this.btn_exit.Location = new System.Drawing.Point(1077, 557);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(0);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(106, 43);
            this.btn_exit.TabIndex = 64;
            this.btn_exit.Text = "EXIT";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_save.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(940, 557);
            this.btn_save.Margin = new System.Windows.Forms.Padding(0);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(106, 43);
            this.btn_save.TabIndex = 65;
            this.btn_save.Text = "SAVE";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(892, 497);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 24);
            this.label5.TabIndex = 66;
            this.label5.Text = "Pay up";
            // 
            // pay_no
            // 
            this.pay_no.AutoSize = true;
            this.pay_no.Checked = true;
            this.pay_no.Location = new System.Drawing.Point(89, 0);
            this.pay_no.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pay_no.Name = "pay_no";
            this.pay_no.Size = new System.Drawing.Size(52, 28);
            this.pay_no.TabIndex = 68;
            this.pay_no.TabStop = true;
            this.pay_no.Text = "No";
            this.pay_no.UseVisualStyleBackColor = true;
            this.pay_no.Click += new System.EventHandler(this.pay_no_Click);
            // 
            // pay_yes
            // 
            this.pay_yes.AutoSize = true;
            this.pay_yes.Location = new System.Drawing.Point(0, 0);
            this.pay_yes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pay_yes.Name = "pay_yes";
            this.pay_yes.Size = new System.Drawing.Size(59, 28);
            this.pay_yes.TabIndex = 67;
            this.pay_yes.Text = "Yes";
            this.pay_yes.UseVisualStyleBackColor = true;
            this.pay_yes.Click += new System.EventHandler(this.pay_yes_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rBtn_yes);
            this.groupBox5.Controls.Add(this.rBtn_no);
            this.groupBox5.Location = new System.Drawing.Point(1030, 433);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox5.Size = new System.Drawing.Size(165, 40);
            this.groupBox5.TabIndex = 69;
            this.groupBox5.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.pay_yes);
            this.groupBox6.Controls.Add(this.pay_no);
            this.groupBox6.Location = new System.Drawing.Point(1030, 497);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox6.Size = new System.Drawing.Size(165, 42);
            this.groupBox6.TabIndex = 70;
            this.groupBox6.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Gray;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(1191, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 27);
            this.label6.TabIndex = 71;
            this.label6.Text = "X";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // FormBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1216, 630);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tb_penalty);
            this.Controls.Add(this.label_tittle_bill);
            this.Controls.Add(this.label_invoice_date);
            this.Controls.Add(this.invoiceDTP);
            this.Controls.Add(this.label_penalty_rate);
            this.Controls.Add(this.label_rule_fl);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximumSize = new System.Drawing.Size(2500, 662);
            this.Name = "FormBill";
            this.Text = "Bill";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_tittle_bill;
        private System.Windows.Forms.DateTimePicker invoiceDTP;
        private System.Windows.Forms.Label label_invoice_date;
        private CustomBorderTextbox tb_penalty;
        private CustomBorderTextbox tb_tableTotal;
        private CustomBorderTextbox tb_moneyLeft;
        private CustomBorderTextbox tb_serviceTotal;
        private System.Windows.Forms.Label label_service_price;
        private System.Windows.Forms.Label label_money_left;
        private System.Windows.Forms.Label label_payment_date;
        private System.Windows.Forms.Label label_total;
        private System.Windows.Forms.Label label_table_total_price;
        private CustomBorderTextbox tb_lobby_price;
        private System.Windows.Forms.DateTimePicker paymentDTP;
        private System.Windows.Forms.Label label_rule_fl;
        private System.Windows.Forms.Label label_penalty_rate;
        private System.Windows.Forms.RadioButton rBtn_no;
        private System.Windows.Forms.RadioButton rBtn_yes;
        private System.Windows.Forms.GroupBox groupBox1;
        private CustomBorderTextbox tb_representative;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbb_staff;
        private CustomBorderTextbox tb_phone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_save;
        private CustomBorderTextbox tb_total;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton pay_no;
        private System.Windows.Forms.RadioButton pay_yes;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label6;
    }
}