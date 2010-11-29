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
        private DataTable currentTable;
        public SaleForm(int isAnAdmin, string userName)
        {
            currentTable = new DataTable();
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
                string sqlStatement = "SELECT * FROM FURNITURE WHERE " + searchBy + " = '" + searchType + "'";
                OdbcDataAdapter a = new OdbcDataAdapter(
                    sqlStatement, MyConnection);
                DataTable t = new DataTable();
                a.Fill(t);
                queryResultGrid.DataSource = t;
                MyConnection.Close();
            }
            catch (Exception e)
            {
                
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchCategoriesComboBox.Items.Clear();
            connectToDb();
        }

        private void completeSaleButton_Click(object sender, EventArgs e)
        {

        }

        private void memberSearchButton_Click(object sender, EventArgs e)
        {

        }

        private void sqlButton_Click(object sender, EventArgs e)
        {
            adminQueryInterface inst = new adminQueryInterface();
            inst.Show();
        }

        private void searchCategoriesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            connectToDb();
        }

        private void memberSearchButton_Click_1(object sender, EventArgs e)
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
                String searchType = searchCategoriesComboBox.Text.ToString();
                string sqlStatement = "SELECT member_Id, fname, lname, address, member_date FROM MEMBER WHERE " + memberPhoneSearch.Text + " = phone_number";
                OdbcDataAdapter a = new OdbcDataAdapter(
                    sqlStatement, MyConnection);
                DataTable t = new DataTable();
                a.Fill(t);
                memberResultGrid.DataSource = t;

                //Close all resources
                MyConnection.Close();


            }
            catch (Exception ex)
            {
            }
        }

        private void queryResultGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("HEY");
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
                String searchType = searchCategoriesComboBox.Text.ToString();
                string sqlStatement = "SELECT furniture_Id, Description FROM furniture WHERE " + queryResultGrid.CurrentCell.Value + " = furniture_Id";
                OdbcDataAdapter a = new OdbcDataAdapter(
                    sqlStatement, MyConnection);
                
                DataTable t = new DataTable();
                a.Fill(t);
                for (int currentRow = 0; currentRow < currentTable.Rows.Count; currentRow++)
                {
                    t.ImportRow(currentTable.Rows[currentRow]);
                }
                currentTable = t;
                rentalDataGrid.DataSource = t;

                //Close all resources
                MyConnection.Close();


            }
            catch (OdbcException o)
            {
                MessageBox.Show(o.ToString());
            }
        }

        private void memberResultGrid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("HEY");
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
                String searchType = searchCategoriesComboBox.Text.ToString();
                string sqlStatement = "SELECT member_Id, fname, lname FROM member WHERE " + memberResultGrid.CurrentCell.Value + " = member_Id";
                OdbcDataAdapter a = new OdbcDataAdapter(
                    sqlStatement, MyConnection);

                DataTable t = new DataTable();
                a.Fill(t);
                if (currentTable.Rows.Count < 1)
                {
                    //MessageBox.Show(t.Rows[0].ItemArray[2].ToString());
                    rentalDataGrid.DataSource = t;
                }
                else
                {
                    for (int i = 0; i < currentTable.Rows.Count; i++)
                    {
                        //currentTable.Columns.Add("fname");
                        currentTable.Rows[i].ItemArray[0] = t.Rows[i].ItemArray[2].ToString();
                        MessageBox.Show(currentTable.Rows[i].ItemArray[0].ToString());
                    }
                }
                //currentTable = t;
                rentalDataGrid.DataSource = t;

                //Close all resources
                MyConnection.Close();


            }
            catch (OdbcException o)
            {
                MessageBox.Show(o.ToString());
            }
        }
    }
}
