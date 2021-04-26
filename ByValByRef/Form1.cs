using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ByValByRef
{
    public partial class frmByValByRef : Form
    {
        public frmByValByRef()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtAIn.Text);
            int b = Convert.ToInt32(txtBIn.Text);
            MessageBox.Show("Passing A and B to the function ChangeValue");
            ChangeValue(a, ref b);
            txtAOut.Text = a.ToString();
            txtBOut.Text = b.ToString();
        }

        private Tuple<int, int> ChangeValue (int A, ref int B)
        {
            MessageBox.Show("Changing a to " + (A * 2).ToString());
            A = A * 2;
            txtAinMethod.Text = A.ToString();
            MessageBox.Show("Changing b to " + (B * 2).ToString());
            B = B * 2;
            txtBInMethod.Text = B.ToString();
            MessageBox.Show("Returning values to Main() method");
            return new Tuple<int, int> (A, B);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAIn.Clear();
            txtAinMethod.Clear();
            txtAOut.Clear();
            txtBIn.Clear();
            txtBInMethod.Clear();
            txtBOut.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
