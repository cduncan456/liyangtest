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
    public partial class NewMemberForm : Form
    {

        String firstName;
        String lastName;
        long ssn;
        String address;
        String state;
        int zipCode;
        String city;
        String email;
        long phoneNumber;
        String date;
        long memberId;
        Boolean validated = true;

        public void connection(String memberInfo)
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

                OdbcCommand getHighestMemberId = new OdbcCommand("SELECT MAX(member_Id) as Highest_Number from MEMBER", MyConnection);
                OdbcCommand getAllSsn = new OdbcCommand("Select ssn from Member", MyConnection);

                //OdbcDataReader MyDataReader;
                OdbcDataReader MyDataReader = getHighestMemberId.ExecuteReader();
                OdbcDataReader MySsnReader = getAllSsn.ExecuteReader();

                //generate memberId based on highest memberId, if the table is null throw a InvaildCastException
                //and set the memberId to the default value 100000
                while (MyDataReader.Read())
                {
                    try
                    {
                        memberId = Convert.ToInt32(MyDataReader.GetString(0)) + 1;
                    }
                    catch (InvalidCastException ICE)
                    {
                        memberId = 100000;
                    }
                }

                while (MySsnReader.Read())
                {
                    if (MySsnReader.GetString(0) == ssn.ToString())
                    {
                        MessageBox.Show("Duplicate SSN already in database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        validated = false;
                    }
                }

                //SQL statement to add a member to the member table
                OdbcCommand checkSSN = new OdbcCommand("select ssn from MEMBER WHERE ssn = " + ssn, MyConnection);
                OdbcDataReader MySSNDataReader = checkSSN.ExecuteReader();
                String sqlString = "INSERT INTO MEMBER (member_Id, ssn, phone_Number, fname, lname, address, member_Date) " + "VALUES (" + memberId + "," + memberInfo + ")";
                if (validated == true)
                {
                    OdbcCommand MyCommand = new OdbcCommand(sqlString, MyConnection);
                    MyCommand.ExecuteNonQuery();
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

        public NewMemberForm()
        {
            InitializeComponent();
        }

        public long getMemberIdNumber()
        {
            return memberId;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            memberInfoReader();
        }

        private void memberInfoReader()
        {
            address = "'" + addressTextBox.Text;
            state = stateComboBox.SelectedText;
            try
            {
                zipCode = Convert.ToInt32(zipCodeTextBox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Invaild Input for zip code field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                validated = false;
            }
            try
            {
                city = Convert.ToString(cityTextBox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Invaild Input for city field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                validated = false;
            }
            email = emailTextBox.Text;
            try
            {
                phoneNumber = Convert.ToInt64(phoneNumberTextBox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Invaild Input for phone number field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                validated = false;
            }
            try
            {
                ssn = Convert.ToInt32(ssnTextBox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Invaild Input for snn field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                validated = false;
            }

            firstName = Convert.ToString(firstNameTextBox.Text);
            lastName = lastNameTextBox.Text;

            date = dateTextBox.Text;
            String memberInfo = ssn + ", " + "'" + phoneNumber + "'" + ", " + "'" + firstName + "'" + ", " + "'" + lastName + "'" + ", " + address + " " + city + " " + state + " " + zipCode + "', " + "'" + date + "'";
            connection(memberInfo);
            if (validated == true)
            {
                memberIdTextBox.Text = "" + getMemberIdNumber();
                MessageBox.Show(firstName + " " + lastName + " has been added as a member. MemberId: " + getMemberIdNumber());
            }
            else
            {
                MessageBox.Show("Did not add any member info to database.","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            validated = true;
        }

    }
}
