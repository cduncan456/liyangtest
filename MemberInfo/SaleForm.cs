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
        private int isAdmin;
        public SaleForm(int isAnAdmin, string userName)
        {
            isAdmin = isAnAdmin;
            InitializeComponent();
            if (isAdmin == 1)
            {
                sqlButton.Visible = true;
            }
            welcomeLabel.Text += userName;
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
                String searchBy = comboBox1.Text.ToString();                

                OdbcCommand getType = new OdbcCommand("SELECT `" + searchBy + "` FROM FURNITURE", MyConnection);
                OdbcDataReader getTypeReader = getType.ExecuteReader();
                while (getTypeReader.Read())
                {
                    if(!searchCategoriesComboBox.Items.Contains(getTypeReader.GetString(0))){
                         searchCategoriesComboBox.Items.Add(getTypeReader.GetString(0));
                    }
                }
                String searchType = searchCategoriesComboBox.Text.ToString();
                OdbcCommand getSelectedCategory = new OdbcCommand("SELECT `furniture_Id`, Description, " + searchBy + " FROM FURNITURE WHERE " + searchBy + " = '" + searchType + "'", MyConnection);

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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            itemsListBox.Items.Clear();
            searchCategoriesComboBox.Items.Clear();
            connectToDb();
        }

        private void completeSaleButton_Click(object sender, EventArgs e)
        {

        }

        private void memberSearchButton_Click(object sender, EventArgs e)
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

                OdbcCommand getMemberID = new OdbcCommand("SELECT member_Id, fname, lname, address, member_date FROM MEMBER WHERE " + memberPhoneSearch.Text + " = phone_number", MyConnection);

                OdbcDataReader getMemberIDReader = getMemberID.ExecuteReader();

                String test = "";

                while (getMemberIDReader.Read())
                {
                    memberIdResult.Text = getMemberIDReader.GetString(0);
                    test = getMemberIDReader.GetString(0);
                    memberNameResult.Text = getMemberIDReader.GetString(1);
                    memberNameResult.Text += " " + getMemberIDReader.GetString(2);
                    memberAddressResult.Text = getMemberIDReader.GetString(3);
                    memberSinceResult.Text = getMemberIDReader.GetString(4);

                }

                if (test.Length < 1)
                {
                    throw new System.ArgumentException("Empty");
                }

                //Close all resources
                getMemberIDReader.Close();
                MyConnection.Close();

                
                resultLabelMember.Visible = true;
                memberIdResult.Visible = true;
                resultLabelName.Visible = true;
                memberNameResult.Visible = true;
                resultLabelAddress.Visible = true;
                memberAddressResult.Visible = true;
                resultLabelMemberSince.Visible = true;
                memberSinceResult.Visible = true;

            }
            catch (Exception ex)
            {
                resultLabelMember.Visible = false;
                memberIdResult.Visible = false;
                resultLabelName.Visible = false;
                memberNameResult.Visible = false;
                resultLabelAddress.Visible = false;
                memberAddressResult.Visible = false;
                resultLabelMemberSince.Visible = false;
                memberSinceResult.Visible = false;

                MessageBox.Show("Member's Phone number is invalid");
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void sqlButton_Click(object sender, EventArgs e)
        {
            adminQueryInterface inst = new adminQueryInterface();
            inst.Show();
        }
    }
}
