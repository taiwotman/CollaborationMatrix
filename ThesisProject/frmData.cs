using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ThesisProject
{
    public partial class frmData : Form
    {
        private TestCase testcase;
        private bool isValidated;

        public frmData()
        {
            InitializeComponent();
            isValidated = true;
        }

        public frmData(TestCase testcase)
        {
            InitializeComponent();

            this.testcase = testcase;
            isValidated = true;

            if (testcase != null)
            {
                txtBxB11.Text = Convert.ToString(testcase.Business11.S);
                txtBxB12.Text = Convert.ToString(testcase.Business11.E);
                txtBxB13.Text = Convert.ToString(testcase.Business11.En);

                txtBxC14.Text = Convert.ToString(testcase.Customer12.S);
                txtBxC15.Text = Convert.ToString(testcase.Customer12.E);
                txtBxC16.Text = Convert.ToString(testcase.Customer12.En);

                txtBxC21.Text = Convert.ToString(testcase.Customer21.S);
                txtBxC22.Text = Convert.ToString(testcase.Customer21.E);
                txtBxC23.Text = Convert.ToString(testcase.Customer21.En);

                txtBxC24.Text = Convert.ToString(testcase.Customer22.S);
                txtBxC25.Text = Convert.ToString(testcase.Customer22.E);
                txtBxC26.Text = Convert.ToString(testcase.Customer22.En);
            }
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            isValidated = true;
            errorPrompt.Clear();

            testcase.Business11.S = String.IsNullOrEmpty(txtBxB11.Text) ? 0 : Convert.ToInt32(txtBxB11.Text);
            testcase.Business11.E = String.IsNullOrEmpty(txtBxB12.Text) ? 0 : Convert.ToInt32(txtBxB12.Text); 
            testcase.Business11.En = String.IsNullOrEmpty(txtBxB13.Text) ? 0 : Convert.ToInt32(txtBxB13.Text);

            testcase.Customer12.S = String.IsNullOrEmpty(txtBxC14.Text) ? 0 : Convert.ToInt32(txtBxC14.Text);
            testcase.Customer12.E = String.IsNullOrEmpty(txtBxC15.Text) ? 0 : Convert.ToInt32(txtBxC15.Text);
            testcase.Customer12.En= String.IsNullOrEmpty(txtBxC16.Text) ? 0 : Convert.ToInt32(txtBxC16.Text);

            testcase.Customer21.S = String.IsNullOrEmpty(txtBxC21.Text) ? 0 : Convert.ToInt32(txtBxC21.Text);
            testcase.Customer21.E = String.IsNullOrEmpty(txtBxC22.Text) ? 0 : Convert.ToInt32(txtBxC22.Text);
            testcase.Customer21.En = String.IsNullOrEmpty(txtBxC23.Text) ? 0 : Convert.ToInt32(txtBxC23.Text);

            testcase.Customer22.S = String.IsNullOrEmpty(txtBxC24.Text) ? 0 : Convert.ToInt32(txtBxC24.Text);
            testcase.Customer22.E = String.IsNullOrEmpty(txtBxC25.Text) ? 0 : Convert.ToInt32(txtBxC25.Text);
            testcase.Customer22.En= String.IsNullOrEmpty(txtBxC26.Text) ? 0 : Convert.ToInt32(txtBxC26.Text);

            String errMsg ="Row must add up to 100";
            if (!testcase.Business11.validate())
            {
                errorPrompt.SetError(txtBxB13, errMsg);
                isValidated = false;
            }

            if (!testcase.Customer12.validate())
            {
                errorPrompt.SetError(txtBxC16, errMsg);
                isValidated = false;
            }

            if (!testcase.Customer21.validate())
            {
                errorPrompt.SetError(txtBxC23, errMsg);
                isValidated = false;
            }

            if (!testcase.Customer22.validate())
            {
                errorPrompt.SetError(txtBxC26, errMsg);
                isValidated = false;
            }

            if (isValidated)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (var item in panel1.Controls)
            {
                if (item is MaskedTextBox)
                {
                    ((MaskedTextBox)item).Clear();
                }
            }
        }
    }
}
