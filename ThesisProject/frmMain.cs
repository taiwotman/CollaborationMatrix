using System;
/***
 Author: Taiwo O. Adetiloye, 2012
*****/
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ThesisProject
{
    public partial class frmMain : Form
    {
        private frmData frmData;
        private DialogResult dlgResult;
        private TestCase testcase;
        private Transaction transaction;
        private List<TestCase> testcases;

        public frmMain()
        {
            InitializeComponent();
            testcase = new TestCase();            
            transaction = new Transaction();
        }

        private void dataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmData = new frmData(testcase);
            frmData.ShowDialog();

            if (DialogResult.OK == frmData.DialogResult)
            {
                runTransaction();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dlgResult = MessageBox.Show("Are you sure you want to quit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(dlgResult ==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            runTransaction();
        }

        private void runTransaction()
        {
            dgViewTestCases.Rows.Clear();
            dgViewTestCases.Update();

            testcases = transaction.generateTestCases(testcase);
            trackBarChart.Maximum = testcases.Count;

            DataGridViewColumn column4 = dgViewTestCases.Columns[4];
            column4.Width = 40;

            DataGridViewColumn column8 = dgViewTestCases.Columns[8];
            column8.Width = 40;

            DataGridViewCellStyle dgvcs = new DataGridViewCellStyle();
            dgvcs.BackColor = Color.LightBlue;

            DataGridViewCellStyle dgvcs1 = new DataGridViewCellStyle();
            dgvcs1.BackColor = Color.LightPink;

            if (testcases != null)
            {
                foreach (TestCase item in testcases)
                {
                    dgViewTestCases.Rows.Add();
                    int RowIndex = dgViewTestCases.RowCount - 1;

                    DataGridViewRow row = dgViewTestCases.Rows[RowIndex];

                    DataGridViewCell cell10 = new DataGridViewTextBoxCell();
                    cell10.Value = "B";
                    row.Cells[0] = cell10;

                    DataGridViewCell cell11 = new DataGridViewTextBoxCell();
                    cell11.Style = dgvcs;
                    cell11.Value = item.Business11.S;
                    row.Cells["colS"] = cell11;

                    DataGridViewCell cell12 = new DataGridViewTextBoxCell();
                    cell12.Style = dgvcs;
                    cell12.Value = item.Business11.E;
                    row.Cells["colE"] = cell12;

                    DataGridViewCell cell13 = new DataGridViewTextBoxCell();
                    cell13.Style = dgvcs;
                    cell13.Value = item.Business11.En;
                    row.Cells["colEn"] = cell13;

                    DataGridViewCell cell14 = new DataGridViewTextBoxCell();
                    cell14.Value = item.Customer12.S;
                    cell14.Style = dgvcs1;
                    row.Cells["colS1"] = cell14;

                    DataGridViewCell cell15 = new DataGridViewTextBoxCell();
                    cell15.Value = item.Customer12.E;
                    cell15.Style = dgvcs1;
                    row.Cells["colE1"] = cell15;

                    DataGridViewCell cell16 = new DataGridViewTextBoxCell();
                    cell16.Value = item.Customer12.En;
                    cell16.Style = dgvcs1;
                    row.Cells["colEn1"] = cell16;

                    DataGridViewCell cellCCMatrix = new DataGridViewTextBoxCell();
                    cellCCMatrix.Value = item.MatrixCC;
                    cellCCMatrix.Style = dgvcs1;
                    row.Cells["colMatrix"] = cellCCMatrix;

                    DataGridViewCell cellCCWeight = new DataGridViewTextBoxCell();
                    cellCCWeight.Value = item.TestCaseWeightCC;
                    cellCCWeight.Style = dgvcs1;
                    row.Cells["colWeight"] = cellCCWeight;



                    dgViewTestCases.Rows.Add();
                    RowIndex = dgViewTestCases.RowCount - 1;

                    DataGridViewRow row2 = dgViewTestCases.Rows[RowIndex];

                    DataGridViewCell cell20 = new DataGridViewTextBoxCell();
                    cell20.Value = "C";
                    row2.Cells[0] = cell20;

                    DataGridViewCell cell21 = new DataGridViewTextBoxCell();
                    cell21.Value = item.Customer21.S;
                    cell21.Style = dgvcs1;
                    row2.Cells["colS"] = cell21;

                    DataGridViewCell cell22 = new DataGridViewTextBoxCell();
                    cell22.Value = item.Customer21.E;
                    cell22.Style = dgvcs1;
                    row2.Cells["colE"] = cell22;

                    DataGridViewCell cell23 = new DataGridViewTextBoxCell();
                    cell23.Value = item.Customer21.En;
                    cell23.Style = dgvcs1;
                    row2.Cells["colEn"] = cell23;

                    DataGridViewCell cell24 = new DataGridViewTextBoxCell();
                    cell24.Style = dgvcs;
                    cell24.Value = item.Customer22.S;
                    row2.Cells["colS1"] = cell24;

                    DataGridViewCell cell25 = new DataGridViewTextBoxCell();
                    cell25.Style = dgvcs;
                    cell25.Value = item.Customer22.E;
                    row2.Cells["colE1"] = cell25;

                    DataGridViewCell cell26 = new DataGridViewTextBoxCell();
                    cell26.Value = item.Customer22.En;
                    cell26.Style = dgvcs;
                    row2.Cells["colEn1"] = cell26;

                    DataGridViewCell cellMatrixSN = new DataGridViewTextBoxCell();
                    cellMatrixSN.Style = dgvcs;
                    cellMatrixSN.Value = item.MatrixSN;
                    row2.Cells["colMatrix"] = cellMatrixSN;

                    DataGridViewCell cellWeightSN = new DataGridViewTextBoxCell();
                    cellWeightSN.Style = dgvcs;
                    cellWeightSN.Value = item.TestCaseWeightSN;
                    row2.Cells["colWeight"] = cellWeightSN;

                    dgViewTestCases.Rows.Add();
                }

                chartTransaction.Series[0].ChartType = SeriesChartType.Spline;
                chartTransaction.Series[0].Points.DataBindY(transaction.factorSN);

                chartTransaction.Series[1].ChartType = SeriesChartType.Spline;
                chartTransaction.Series[1].Points.DataBindY(transaction.factorCC);

                trackBarChart.Value = testcases.Count;

                if (tabControlView.SelectedIndex == 0)
                {
                    pnlLegend.Visible = true;
                }
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dlgResult = MessageBox.Show("This action will erase any existing test data.\nDo you want to continue", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlgResult ==DialogResult.Yes)
            {
                testcase = new TestCase();
                MessageBox.Show("Please enter new test data", "Test Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tabControlView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlView.SelectedIndex ==1)
            {
                pnlLegend.Visible = false;
                labelMin.Visible = true;
                labelMax.Visible = true;
                trackBarChart.Visible = true;               
            }
            else if (tabControlView.SelectedIndex == 0)
            {
                trackBarChart.Visible = false;
                labelMin.Visible = false;
                labelMax.Visible = false;
                pnlLegend.Visible = true;
            }
        }

        private void trackBarChart_Scroll(object sender, EventArgs e)
        {
            int count = trackBarChart.Value;
            chartTransaction.Series[0].ChartType = SeriesChartType.Spline;
            chartTransaction.Series[0].Points.DataBindY(transaction.factorSN.GetRange(0, count));

            chartTransaction.Series[1].ChartType = SeriesChartType.Spline;
            chartTransaction.Series[1].Points.DataBindY(transaction.factorCC.GetRange(0, count));
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutBox().ShowDialog();
        }
    }
}
