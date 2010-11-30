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
        private String searchByStr;
        private LogInForm theLoginForm;
        private int employeeId;
        private int member_Id;
        private OdbcDataAdapter memberDataAdapter;
        public SaleForm(int isAnAdmin, string userName, int employeeId, LogInForm theLoginForm)
        {

            currentTable = new DataTable();
            isAdmin = isAnAdmin;
            this.employeeId = employeeId;
            this.theLoginForm = theLoginForm;
            member_Id = 0;
            InitializeComponent();
            if (isAdmin == 1)
            {
                sqlButton.Visible = true;
            }
            welcomeLabel.Text += userName;

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

                OdbcCommand getType = new OdbcCommand("SELECT Max(rental_number) FROM rental", MyConnection);
                OdbcDataReader getTypeReader = getType.ExecuteReader();
                OdbcDataAdapter ap = new OdbcDataAdapter("Select * from furniture", MyConnection);
                DataTable table = new DataTable();
                ap.Fill(table);
                queryResultGrid.DataSource = table;
                int currentRentalNum = 0;
                while (getTypeReader.Read())
                {
                    currentRentalNum = int.Parse(getTypeReader.GetString(0));
                }
                currentRentalNum++;
                rentalDataGrid.Rows[0].Cells[0].Value = currentRentalNum;
                rentalDataGrid.Rows[0].Cells[1].Value = employeeId;

                MyConnection.Close();
            }
            catch (Exception e)
            {

            }
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
                searchByStr = comboBox1.Text.ToString();

                OdbcCommand getType = new OdbcCommand("SELECT `" + searchByStr + "` FROM FURNITURE", MyConnection);
                OdbcDataReader getTypeReader = getType.ExecuteReader();
                while (getTypeReader.Read())
                {
                    if (!searchCategoriesComboBox.Items.Contains(getTypeReader.GetString(0)))
                    {
                        searchCategoriesComboBox.Items.Add(getTypeReader.GetString(0));
                    }
                }
                getTypeReader.Close();
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
            theLoginForm.Show();
            SaleForm.ActiveForm.Close();
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

                OdbcCommand insertRentalCommand = new OdbcCommand("INSERT INTO Rental (rental_Number, out_Employee_Id, member_Id, due_Date, start_Date) " + "VALUES (" + rentalDataGrid.Rows[0].Cells[0].Value + ", " + rentalDataGrid.Rows[0].Cells[1].Value + ", '" + rentalDataGrid.Rows[0].Cells[2].Value + "', '" + rentalDataGrid.Rows[0].Cells[3].Value + "', '" + rentalDataGrid.Rows[0].Cells[4].Value + "')", MyConnection);
                insertRentalCommand.ExecuteNonQuery();
                for (int i = 0; i < furnitureItemsDataGrid.Rows.Count - 1; i++)
                {
                    OdbcCommand insertFurnitureCommand = new OdbcCommand("INSERT INTO `In` (furniture_Id, rental_Number, in_Employee_Id, date_returned) " + "VALUES (" + furnitureItemsDataGrid.Rows[i].Cells[0].Value.ToString() + ", " + rentalDataGrid.Rows[0].Cells[0].Value + ", 'Null', 'Null')", MyConnection);
                    insertFurnitureCommand.ExecuteNonQuery();
                }
                MyConnection.Close();
            }
            catch (OdbcException o)
            {
                MessageBox.Show(o.ToString());
            }
            int currentRentalNum = int.Parse(rentalDataGrid.Rows[0].Cells[0].Value.ToString());
            currentRentalNum++;
            rentalDataGrid.Rows[0].Cells[0].Value = currentRentalNum;
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

            try
            {
                string MyConString = "DRIVER={MySQL ODBC 5.1 Driver};" +
                         "SERVER=turing.cs.westga.edu;" +
                         "PORT=3306;" +
                         "DATABASE=vwilson1;" +
                         "UID=vwilson1;" +
                         "PASSWORD=vw881376";

                OdbcConnection MyConnection = new OdbcConnection(MyConString);
                String searchType = searchCategoriesComboBox.Text.ToString();
                string sqlStatement = "SELECT * FROM FURNITURE WHERE " + searchByStr + " = '" + searchType + "'";
                OdbcDataAdapter a = new OdbcDataAdapter(
                    sqlStatement, MyConnection);
                DataTable t = new DataTable();
                a.Fill(t);
                queryResultGrid.DataSource = t;
                MyConnection.Close();
            }
            catch (OdbcException o)
            {
                MessageBox.Show(o.ToString());
            }
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
                string sqlStatement = "SELECT furniture_Id, Description, color, style FROM furniture WHERE " + queryResultGrid.CurrentCell.Value + " = furniture_Id";
                OdbcDataAdapter a = new OdbcDataAdapter(
                    sqlStatement, MyConnection);

                DataTable t = new DataTable();
                a.Fill(t);
                for (int currentRow = 0; currentRow < currentTable.Rows.Count; currentRow++)
                {
                    t.ImportRow(currentTable.Rows[currentRow]);
                }
                currentTable = t;
                furnitureItemsDataGrid.DataSource = t;

                //Close all resources
                MyConnection.Close();


            }
            catch (OdbcException o)
            {
                MessageBox.Show(o.ToString());
            }
        }

        private void returnQueryResultDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView currentDataGrid = (DataGridView)sender;

            String date_Returned = dateTimePicker1.Text.ToString();

            if (currentDataGrid.CurrentCell.ColumnIndex == 0)
            {
                int rental_Number = int.Parse(currentDataGrid.CurrentCell.Value.ToString());
                int furniture_Id = int.Parse(currentDataGrid.Rows[currentDataGrid.CurrentCell.RowIndex].Cells[currentDataGrid.CurrentCell.ColumnIndex + 1].Value.ToString());
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

                    string sqlStatement = "Update `in`set in_Employee_Id = '" + employeeId + "', date_returned = '" + date_Returned + "' where `furniture_Id` = " + furniture_Id + " and `rental_Number` = " + rental_Number;
                    OdbcCommand updateCommand = new OdbcCommand(sqlStatement, MyConnection);
                    updateCommand.ExecuteNonQuery();
                    MessageBox.Show("Furniture Item Number " + furniture_Id + " and Rental Number " + rental_Number + " has been checked in.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    DataTable table2 = new DataTable();
                    memberDataAdapter.Fill(table2);
                    returnQueryResultDataGrid.DataSource = table2;
                    

                    OdbcCommand getFine = new OdbcCommand("SELECT fine_Rate from furniture where furniture_Id = " + furniture_Id, MyConnection);
                    OdbcDataReader getFineReader = getFine.ExecuteReader();
                    double fineRate = 0;
                    while (getFineReader.Read())
                    {
                        fineRate = double.Parse(getFineReader.GetString(0));
                    }

                    OdbcCommand getDueDate = new OdbcCommand("SELECT due_Date from rental where rental_Number = " + rental_Number, MyConnection);
                    OdbcDataReader getDueDateReader = getDueDate.ExecuteReader();
                    String due_Date = "";
                    while (getDueDateReader.Read())
                    {
                        due_Date = getDueDateReader.GetString(0);
                    }

                    DateTime d1 = new DateTime(int.Parse(date_Returned.Substring(0, 4)), int.Parse(date_Returned.Substring(5, 2)), int.Parse(date_Returned.Substring(8, 2)));
                    MessageBox.Show(d1.ToString());
                    DateTime d2 = new DateTime(int.Parse(due_Date.Substring(0, 4)), int.Parse(due_Date.Substring(5, 2)), int.Parse(due_Date.Substring(8, 2)));

                    double dateDiff = (d1 - d2).TotalDays;
                    double totalFines = 0;
                    if (dateDiff > 0)
                    {
                        totalFines += dateDiff * fineRate;
                    }

                    getDueDateReader.Close();
                    getFineReader.Close();

                    //Close all resources
                    MyConnection.Close();


                }
                catch (OdbcException o)
                {
                    MessageBox.Show(o.ToString());
                }
            }
        }

        private void rentalDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void returnQueryResultDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void memberResultGrid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView currentDataGrid = (DataGridView)sender;
            if (currentDataGrid.CurrentCell.ColumnIndex == 0)
            {
                member_Id = int.Parse(currentDataGrid.CurrentCell.Value.ToString());
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
                    string sqlQuery = "select r.rental_Number, furniture_Id from rental r, `in` i where member_Id = " + member_Id + " and r.rental_Number = i.rental_Number and in_Employee_Id = 0 ";
                    memberDataAdapter = new OdbcDataAdapter(
                        sqlQuery, MyConnection);
                    DataTable t = new DataTable();
                    memberDataAdapter.Fill(t);
                    returnQueryResultDataGrid.DataSource = t;

                    //Close all resources
                    MyConnection.Close();

                    MessageBox.Show("Member " + member_Id + "has been logined in");
                }
                catch (OdbcException o)
                {
                    MessageBox.Show(o.ToString());
                }
            }
        }

    }
}
