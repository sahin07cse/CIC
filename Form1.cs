using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CompoundInterestCalculator
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        //bool cflag = false;
        private BindingSource bindingSource1 = new BindingSource();

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(loanAmount.Text) || String.IsNullOrEmpty(interestRate.Text))
            {
                MessageBox.Show("Enter Valid Amount of Loan & Interest rate !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                this.dataGridView1.Visible = true;
                this.dividerLabel.Visible = true;

                double lAmount = double.Parse(loanAmount.Text);
                double rate = double.Parse(interestRate.Text);
                double newLoanAmount, totalInterest;

                bool issSlot_1 = false;
                bool issSlot_2 = false;
                bool issSlot_3 = false;
                bool issSlot_4 = false;


                bool iseSlot_1 = false;
                bool iseSlot_2 = false;
                bool iseSlot_3 = false;
                bool iseSlot_4 = false;

                int sPadding = 0;
                int ePadding = 0;

                DateTime sDate = startDate.Value;
                int sMonth = sDate.Month;
                int sYear = sDate.Year;

                DateTime eDate = endDate.Value;
                int eMonth = eDate.Month;
                int eYear = eDate.Year;

                if (sMonth >= 1 && sMonth <= 3) issSlot_1 = true;
                if (sMonth >= 4 && sMonth <= 6) issSlot_2 = true;
                if (sMonth >= 7 && sMonth <= 9) issSlot_3 = true;
                if (sMonth >= 10 && sMonth <= 12) issSlot_4 = true;

                if (eMonth >= 1 && eMonth <= 3) iseSlot_1 = true;
                if (eMonth >= 4 && eMonth <= 6) iseSlot_2 = true;
                if (eMonth >= 7 && eMonth <= 9) iseSlot_3 = true;
                if (eMonth >= 10 && eMonth <= 12) iseSlot_4 = true;

                if (issSlot_2) sPadding = 1;
                else if (issSlot_3) sPadding = 2;
                else if (issSlot_4) sPadding = 3;

                if (iseSlot_3) ePadding = 1;
                else if (iseSlot_2) ePadding = 2;
                else if (iseSlot_1) ePadding = 3;

                int maxSlot = ((eYear - sYear) + 1) * 4 - sPadding - ePadding;

                int offset = 0;
                double grossInterest = 0.0, grossLoan = 0.0;
                DateTime fromDate;
                DateTime toDate;

                fromDate = sDate;

                if (sMonth <= 3) offset = 3 - sMonth;
                else if (sMonth > 3 && sMonth <= 6) offset = 6 - sMonth;
                else if (sMonth > 6 && sMonth <= 9) offset = 9 - sMonth;
                else if (sMonth > 9 && sMonth <= 12) offset = 12 - sMonth;

                bool flag = true;
                double nDays;

                newLoanAmount = lAmount;

                for (int i = 1; i <= maxSlot; i++)
                {
                    toDate = fromDate.AddMonths(flag ? offset : 2);
                    flag = false;

                    int lastDayOfMonth = DateTime.DaysInMonth(toDate.Year, toDate.Month);
                    int tDay = toDate.Day;

                    toDate = toDate.AddDays(lastDayOfMonth - tDay);

                    if (toDate > eDate) toDate = eDate;

                    TimeSpan timeSpan = toDate - fromDate;
                    nDays = (timeSpan.Days + 1);

                    totalInterest = newLoanAmount * (nDays / 360) * (rate / 100);

                    grossInterest += totalInterest;

                    //String.Format("{0:0.00}", totalInterest);
                    totalInterest = System.Math.Round(totalInterest, 3);

                    //MessageBox.Show("From : " + fromDate + " To : " + toDate + " Days : " + nDays + " Loan Amount : " + newLoanAmount + " Total Interest : " + totalInterest, "DateTimePicker", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.Rows.Add(fromDate.ToString("dd / MM / yyyy") + " - " + toDate.ToString("dd / MM / yyyy"), newLoanAmount, nDays, rate + "%", totalInterest);
                    fromDate = toDate.AddDays(1);
                    newLoanAmount = newLoanAmount + totalInterest;
                }

                grossLoan = lAmount + grossInterest;

                interestTextbox.Text = grossInterest.ToString("0.0000");
                totalLoanTextbox.Text = grossLoan.ToString("0.00");
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void noDaysTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void interestTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void loanAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void interestRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            this.dataGridView1.Visible = false;
            this.dividerLabel.Visible = false;

            ProjectNameTextBox.Text = String.Empty;
            interestTextbox.Text = String.Empty;
            totalLoanTextbox.Text = String.Empty;
            loanAmount.Text = String.Empty;
            interestRate.Text = String.Empty;

            //startDate.Value = DateTime.Now;
            endDate.Value = DateTime.Now;
        }

        private void ExportToExcel()
        {
            // Creating a Excel object. 
            //Microsoft.Office.Interop.Excel._Application excel = new Microsoft.Office.Interop.Excel.Application();
            //Microsoft.Office.Interop.Excel._Workbook workbook = excel.Workbooks.Add(Type.Missing);
            //Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            //try
            //{

            //    worksheet = workbook.ActiveSheet;

            //    worksheet.Name = "ExportedFromDatGrid";

            //    int cellRowIndex = 1;
            //    int cellColumnIndex = 1;

            //    //Loop through each row and read value from each column. 
            //    for (int i = 0; i < 5; i++)
            //    {
            //        for (int j = 0; j < 5; j++)
            //        {
            //            // Excel index starts from 1,1. As first Row would have the Column headers, adding a condition check. 
            //            if (cellRowIndex == 1)
            //            {
            //                worksheet.Cells[cellRowIndex, cellColumnIndex] = "Hello";
            //            }
            //            else
            //            {
            //                worksheet.Cells[cellRowIndex, cellColumnIndex] = "World";
            //            }
            //            cellColumnIndex++;
            //        }
            //        cellColumnIndex = 1;
            //        cellRowIndex++;
            //    }

            //    //Getting the location and file name of the excel to save from user. 
            //    SaveFileDialog saveDialog = new SaveFileDialog();
            //    saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            //    saveDialog.FilterIndex = 2;

            //    if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //    {
            //        workbook.SaveAs(saveDialog.FileName);
            //        MessageBox.Show("Export Successful");
            //    }
            //}
            //catch (System.Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //finally
            //{
            //    excel.Quit();
            //    workbook = null;
            //    excel = null;
            //}

        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            ExportToExcel();
        }

        Bitmap bitmap;

        private void printButton_Click(object sender, EventArgs e)
        {
            bindingSource1.Add(ProjectNameTextBox.Text);
            int height = dataGridView1.Height;
            dataGridView1.Height = dataGridView1.RowCount * dataGridView1.RowTemplate.Height;

            //Create a Bitmap and draw the DataGridView on it.
            bitmap = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            dataGridView1.DrawToBitmap(bitmap, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));

            //Resize DataGridView back to original height.
            dataGridView1.Height = height;

            //Show the Print Preview Dialog.
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
        }

        private void PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Print the contents.
            e.Graphics.DrawString(this.ProjectNameTextBox.Text, this.ProjectNameTextBox.Font, Brushes.Black, 10, 25);
            //e.Graphics.DrawImage(this.dataGridView1.Text, this.dataGridView1.Font, Brushes.Black, 10, 25);
        }
    }
}
