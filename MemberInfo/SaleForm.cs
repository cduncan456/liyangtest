using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MemberInfo
{
    public partial class SaleForm : Form
    {
        public SaleForm()
        {
            InitializeComponent();
        }

        private void createNewMemButton_Click(object sender, EventArgs e)
        {
           NewMemberForm theMemberForm = new NewMemberForm();
           theMemberForm.Show();
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            LogInForm theLogIn = new LogInForm();
            SaleForm.ActiveForm.Close();
            theLogIn.Show();
        }

        private void SaleForm_Load(object sender, EventArgs e)
        {

        }

        private void SaleForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
 
            LogInForm.ActiveForm.Show();
        }
    }
}
