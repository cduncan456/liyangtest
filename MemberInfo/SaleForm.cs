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
    }
}
