using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Odbc;

namespace MemberInfo
{
    public partial class SaleForm : Form
    {
        public SaleForm()
        {
            InitializeComponent();
        }

        public void connectToDb()
        {
            try
            {
                string MyConString = "DRIVER={MySQL ODBC 5.1 Driver};" +
                     "SERVER=turing.cs.westga.edu;" +
                     "PORT=3306;" +
                     "DATABASE=vwilson1;" +
                     "UID=vwilson1;" +
                     "PASSWORD=vw881376";

                OdbcConnection MyConnection = new OdbcConnection(MyConString);

                MyConnection.Open();
                //MessageBox.Show("!!! success, connected successfully !!!");

                OdbcCommand getSelectedCategory = new OdbcCommand("SELECT `furniture_Id`, Description, category FROM FURNITURE WHERE category = " + "'" +searchCategoriesComboBox.Text.ToString() + "'", MyConnection);

                //OdbcDataReader MyDataReader;
                OdbcDataReader MyDataReader = getSelectedCategory.ExecuteReader();

                //generate memberId based on highest memberId, if the table is null throw a InvaildCastException
                //and set the memberId to the default value 100000
                while (MyDataReader.Read())
                {
                    itemsListBox.Items.
                        Add(MyDataReader.GetString(0) + "\t" + MyDataReader.GetString(1));
                }

                //Close all resources
                MyDataReader.Close();
                MyConnection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
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

        private void SaleForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LogInForm.ActiveForm.Show();
        }

        private void searchCategoriesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            itemsListBox.Items.Clear();
            connectToDb();
            if (itemsListBox.Items.Count == 0)
            {
                itemsListBox.Items.Add("There are no furniture items of that category in the database");
            }
        }

    }
}
