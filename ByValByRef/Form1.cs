using System;
using System.Windows.Forms;

namespace ByValByRef
{
    public partial class FrmByValByRef : Form
    {
        public FrmByValByRef()
        {
            InitializeComponent();
        }

        private void BtnTest_Click(object sender, EventArgs e)
        {

            string a = txtAIn.Text;
            string b = txtBIn.Text;

            MessageBox.Show("Passing A and B to the function ChangeValue");
            ChangeValue(a, ref b);
            txtAOut.Text = a.ToString();
            txtBOut.Text = b.ToString();
        }

        private Tuple<string, string> ChangeValue(string A, ref string B)
        {
            MessageBox.Show("Changing a to " + (A + " Hello"));
            A = A + " Hello";
            txtAinMethod.Text = A.ToString();
            MessageBox.Show("Changing b to " + (B + " Hello"));
            B = B + " Hello";
            txtBInMethod.Text = B.ToString();
            MessageBox.Show("Returning values to Main() method");
            return new Tuple<string, string>(A, B);
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            Control frm = this;
            foreach (Control control in frm.Controls)
            {
                if (control is TextBox)
                {
                    control.ResetText();
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
