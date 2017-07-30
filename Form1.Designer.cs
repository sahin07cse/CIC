namespace CompoundInterestCalculator
{
    partial class Form1
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
            System.Windows.Forms.Label headerLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.loanAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.interestRate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.calculate = new System.Windows.Forms.Button();
            this.lAmoutlabel = new System.Windows.Forms.Label();
            this.ratelabel = new System.Windows.Forms.Label();
            this.iratelabel = new System.Windows.Forms.Label();
            this.sDatelabel = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.interestTextbox = new System.Windows.Forms.TextBox();
            this.totalLoanTextbox = new System.Windows.Forms.TextBox();
            this.totalInterestlabel = new System.Windows.Forms.Label();
            this.totalLoanLabel = new System.Windows.Forms.Label();
            this.SummaryLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.interestPeriod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tInterest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resetButton = new System.Windows.Forms.Button();
            this.dividerLabel = new System.Windows.Forms.Label();
            this.developerLabel = new System.Windows.Forms.Label();
            this.copyrigthtLabel = new System.Windows.Forms.Label();
            this.ProjectNameLabel = new System.Windows.Forms.Label();
            this.ProjectNameTextBox = new System.Windows.Forms.TextBox();
            this.printButton = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            headerLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new System.Drawing.Font("Script MT Bold", 35.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            headerLabel.ForeColor = System.Drawing.Color.DarkOliveGreen;
            headerLabel.Location = new System.Drawing.Point(75, -6);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new System.Drawing.Size(666, 57);
            headerLabel.TabIndex = 22;
            headerLabel.Text = "Salam Construction Company Ltd.";
            // 
            // loanAmount
            // 
            this.loanAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loanAmount.Location = new System.Drawing.Point(148, 88);
            this.loanAmount.Name = "loanAmount";
            this.loanAmount.Size = new System.Drawing.Size(137, 24);
            this.loanAmount.TabIndex = 0;
            this.loanAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.loanAmount_KeyPress);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 8;
            // 
            // interestRate
            // 
            this.interestRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.interestRate.Location = new System.Drawing.Point(148, 118);
            this.interestRate.Name = "interestRate";
            this.interestRate.Size = new System.Drawing.Size(90, 24);
            this.interestRate.TabIndex = 0;
            this.interestRate.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.interestRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.interestRate_KeyPress);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 7;
            // 
            // startDate
            // 
            this.startDate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.startDate.CustomFormat = "dd/MM/yyyy";
            this.startDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startDate.Location = new System.Drawing.Point(148, 148);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(137, 24);
            this.startDate.TabIndex = 2;
            this.startDate.Value = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            // 
            // endDate
            // 
            this.endDate.CustomFormat = "dd/MM/yyyy";
            this.endDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endDate.Location = new System.Drawing.Point(148, 179);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(137, 24);
            this.endDate.TabIndex = 2;
            // 
            // calculate
            // 
            this.calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculate.Location = new System.Drawing.Point(344, 88);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(121, 31);
            this.calculate.TabIndex = 3;
            this.calculate.Text = "Calculate";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // lAmoutlabel
            // 
            this.lAmoutlabel.AutoSize = true;
            this.lAmoutlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lAmoutlabel.Location = new System.Drawing.Point(41, 88);
            this.lAmoutlabel.Name = "lAmoutlabel";
            this.lAmoutlabel.Size = new System.Drawing.Size(96, 18);
            this.lAmoutlabel.TabIndex = 9;
            this.lAmoutlabel.Text = "Total Amount";
            // 
            // ratelabel
            // 
            this.ratelabel.AutoSize = true;
            this.ratelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.ratelabel.Location = new System.Drawing.Point(46, 118);
            this.ratelabel.Name = "ratelabel";
            this.ratelabel.Size = new System.Drawing.Size(91, 18);
            this.ratelabel.TabIndex = 10;
            this.ratelabel.Text = "Interest Rate";
            // 
            // iratelabel
            // 
            this.iratelabel.AutoSize = true;
            this.iratelabel.Location = new System.Drawing.Point(244, 123);
            this.iratelabel.Name = "iratelabel";
            this.iratelabel.Size = new System.Drawing.Size(15, 13);
            this.iratelabel.TabIndex = 10;
            this.iratelabel.Text = "%";
            // 
            // sDatelabel
            // 
            this.sDatelabel.AutoSize = true;
            this.sDatelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.sDatelabel.Location = new System.Drawing.Point(46, 148);
            this.sDatelabel.Name = "sDatelabel";
            this.sDatelabel.Size = new System.Drawing.Size(74, 18);
            this.sDatelabel.TabIndex = 11;
            this.sDatelabel.Text = "Start Date";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label.Location = new System.Drawing.Point(46, 179);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(69, 18);
            this.label.TabIndex = 12;
            this.label.Text = "End Date";
            // 
            // interestTextbox
            // 
            this.interestTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.interestTextbox.Location = new System.Drawing.Point(632, 111);
            this.interestTextbox.Name = "interestTextbox";
            this.interestTextbox.Size = new System.Drawing.Size(127, 24);
            this.interestTextbox.TabIndex = 13;
            this.interestTextbox.TextChanged += new System.EventHandler(this.interestTextbox_TextChanged);
            // 
            // totalLoanTextbox
            // 
            this.totalLoanTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLoanTextbox.Location = new System.Drawing.Point(632, 141);
            this.totalLoanTextbox.Name = "totalLoanTextbox";
            this.totalLoanTextbox.Size = new System.Drawing.Size(127, 24);
            this.totalLoanTextbox.TabIndex = 14;
            this.totalLoanTextbox.TextChanged += new System.EventHandler(this.noDaysTextBox_TextChanged);
            // 
            // totalInterestlabel
            // 
            this.totalInterestlabel.AutoSize = true;
            this.totalInterestlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalInterestlabel.Location = new System.Drawing.Point(533, 111);
            this.totalInterestlabel.Name = "totalInterestlabel";
            this.totalInterestlabel.Size = new System.Drawing.Size(93, 18);
            this.totalInterestlabel.TabIndex = 16;
            this.totalInterestlabel.Text = "Total Interest";
            // 
            // totalLoanLabel
            // 
            this.totalLoanLabel.AutoSize = true;
            this.totalLoanLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLoanLabel.Location = new System.Drawing.Point(533, 141);
            this.totalLoanLabel.Name = "totalLoanLabel";
            this.totalLoanLabel.Size = new System.Drawing.Size(78, 18);
            this.totalLoanLabel.TabIndex = 17;
            this.totalLoanLabel.Text = "Total Loan";
            // 
            // SummaryLabel
            // 
            this.SummaryLabel.AutoSize = true;
            this.SummaryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SummaryLabel.Location = new System.Drawing.Point(568, 72);
            this.SummaryLabel.Name = "SummaryLabel";
            this.SummaryLabel.Size = new System.Drawing.Size(155, 24);
            this.SummaryLabel.TabIndex = 18;
            this.SummaryLabel.Text = "Interest Summary";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.date,
            this.loan,
            this.interestPeriod,
            this.rate,
            this.tInterest});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(47, 236);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(10);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.RowHeadersWidth = 34;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(710, 291);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.Visible = false;
            // 
            // date
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            this.date.DefaultCellStyle = dataGridViewCellStyle1;
            this.date.DividerWidth = 2;
            this.date.HeaderText = "Date";
            this.date.MinimumWidth = 200;
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Width = 200;
            // 
            // loan
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loan.DefaultCellStyle = dataGridViewCellStyle2;
            this.loan.HeaderText = "Loan Amount";
            this.loan.MinimumWidth = 150;
            this.loan.Name = "loan";
            this.loan.ReadOnly = true;
            this.loan.Width = 150;
            // 
            // interestPeriod
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.interestPeriod.DefaultCellStyle = dataGridViewCellStyle3;
            this.interestPeriod.HeaderText = "Interest Period";
            this.interestPeriod.MinimumWidth = 30;
            this.interestPeriod.Name = "interestPeriod";
            this.interestPeriod.ReadOnly = true;
            // 
            // rate
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rate.DefaultCellStyle = dataGridViewCellStyle4;
            this.rate.HeaderText = "Rate";
            this.rate.MinimumWidth = 15;
            this.rate.Name = "rate";
            this.rate.ReadOnly = true;
            this.rate.Width = 55;
            // 
            // tInterest
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tInterest.DefaultCellStyle = dataGridViewCellStyle5;
            this.tInterest.HeaderText = "Interest";
            this.tInterest.MinimumWidth = 150;
            this.tInterest.Name = "tInterest";
            this.tInterest.ReadOnly = true;
            this.tInterest.Width = 150;
            // 
            // resetButton
            // 
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.Location = new System.Drawing.Point(344, 169);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(121, 31);
            this.resetButton.TabIndex = 21;
            this.resetButton.Text = "Clear";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // dividerLabel
            // 
            this.dividerLabel.AutoSize = true;
            this.dividerLabel.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dividerLabel.Location = new System.Drawing.Point(18, 204);
            this.dividerLabel.Name = "dividerLabel";
            this.dividerLabel.Size = new System.Drawing.Size(770, 22);
            this.dividerLabel.TabIndex = 23;
            this.dividerLabel.Text = "-----------------------------------------------------------------------Details---" +
    "--------------------------------------------------------------------";
            this.dividerLabel.Visible = false;
            // 
            // developerLabel
            // 
            this.developerLabel.AutoSize = true;
            this.developerLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.developerLabel.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.developerLabel.Location = new System.Drawing.Point(512, 526);
            this.developerLabel.Name = "developerLabel";
            this.developerLabel.Size = new System.Drawing.Size(291, 17);
            this.developerLabel.TabIndex = 24;
            this.developerLabel.Text = "Developer @Mohammad Sahinur Hossen (+8801710321734)";
            // 
            // copyrigthtLabel
            // 
            this.copyrigthtLabel.AutoSize = true;
            this.copyrigthtLabel.Font = new System.Drawing.Font("Brush Script MT", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyrigthtLabel.Location = new System.Drawing.Point(2, 528);
            this.copyrigthtLabel.Name = "copyrigthtLabel";
            this.copyrigthtLabel.Size = new System.Drawing.Size(252, 15);
            this.copyrigthtLabel.TabIndex = 25;
            this.copyrigthtLabel.Text = "All rights reserved by @Salam Construction Company Ltd.";
            // 
            // ProjectNameLabel
            // 
            this.ProjectNameLabel.AutoSize = true;
            this.ProjectNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.ProjectNameLabel.Location = new System.Drawing.Point(41, 56);
            this.ProjectNameLabel.Name = "ProjectNameLabel";
            this.ProjectNameLabel.Size = new System.Drawing.Size(99, 18);
            this.ProjectNameLabel.TabIndex = 27;
            this.ProjectNameLabel.Text = "Project Name";
            // 
            // ProjectNameTextBox
            // 
            this.ProjectNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectNameTextBox.Location = new System.Drawing.Point(148, 53);
            this.ProjectNameTextBox.Name = "ProjectNameTextBox";
            this.ProjectNameTextBox.Size = new System.Drawing.Size(317, 24);
            this.ProjectNameTextBox.TabIndex = 26;
            // 
            // printButton
            // 
            this.printButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printButton.Location = new System.Drawing.Point(344, 127);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(121, 31);
            this.printButton.TabIndex = 28;
            this.printButton.Text = "Print";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.button1_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintPage);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(804, 545);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.ProjectNameLabel);
            this.Controls.Add(this.ProjectNameTextBox);
            this.Controls.Add(this.copyrigthtLabel);
            this.Controls.Add(this.developerLabel);
            this.Controls.Add(this.dividerLabel);
            this.Controls.Add(headerLabel);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.SummaryLabel);
            this.Controls.Add(this.totalLoanLabel);
            this.Controls.Add(this.totalInterestlabel);
            this.Controls.Add(this.totalLoanTextbox);
            this.Controls.Add(this.interestTextbox);
            this.Controls.Add(this.label);
            this.Controls.Add(this.sDatelabel);
            this.Controls.Add(this.iratelabel);
            this.Controls.Add(this.ratelabel);
            this.Controls.Add(this.lAmoutlabel);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.interestRate);
            this.Controls.Add(this.endDate);
            this.Controls.Add(this.startDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loanAmount);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Salam Construction Company Ltd.";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox loanAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox interestRate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.DateTimePicker endDate;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Label lAmoutlabel;
        private System.Windows.Forms.Label ratelabel;
        private System.Windows.Forms.Label iratelabel;
        private System.Windows.Forms.Label sDatelabel;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox interestTextbox;
        private System.Windows.Forms.TextBox totalLoanTextbox;
        private System.Windows.Forms.Label totalInterestlabel;
        private System.Windows.Forms.Label totalLoanLabel;
        private System.Windows.Forms.Label SummaryLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn loan;
        private System.Windows.Forms.DataGridViewTextBoxColumn interestPeriod;
        private System.Windows.Forms.DataGridViewTextBoxColumn rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn tInterest;
        private System.Windows.Forms.Label dividerLabel;
        private System.Windows.Forms.Label developerLabel;
        private System.Windows.Forms.Label copyrigthtLabel;
        private System.Windows.Forms.Label ProjectNameLabel;
        private System.Windows.Forms.TextBox ProjectNameTextBox;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}

