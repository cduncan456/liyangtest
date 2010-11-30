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
    public partial class LogInForm : Form
    {
        List<int> employeeNumberList = new List<int>();
        List<String> employeePassList = new List<String>();
        List<int> employeeAdmin = new List<int>();

        int employeeNumberLoggedin;
        String employeePasswordLoggedin;
        int adminBoolean;
        String employeeName;

        public LogInForm()
        {
            InitializeComponent();
            //fillEmployeeInfo();
        }

        private void fillEmployeeInfo()
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

                OdbcCommand MyCommand = new OdbcCommand("select `employee_Id`, `password`, `Admin`, `fname`, `lname` from EMPLOYEE where `employee_Id` = " + Convert.ToInt32(employeeIdBox.Text.ToString()) + " and `password`= '" + passwordBox.Text + "'", MyConnection);

                OdbcDataReader MyDataReader;
                MyDataReader = MyCommand.ExecuteReader();
                while (MyDataReader.Read())
                {

                    employeeNumberLoggedin = Convert.ToInt32(MyDataReader.GetString(0));
                    employeePasswordLoggedin = MyDataReader.GetString(1);
                    adminBoolean = Convert.ToInt32(MyDataReader.GetString(2));
                    employeeName = MyDataReader.GetString(3);
                    employeeName += " " +  MyDataReader.GetString(4);
                }

                //Close all resources
                MyDataReader.Close();
                MyConnection.Close();
            }
            catch (Exception e)
            {
                //Console.WriteLine(e.ToString());
                MessageBox.Show("Could not connect to SQL Server for Employee Info.", "Important Note", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
        }
        /*
        public int getEmployeeNumber()
        {
            return employeeNumberLoggedin;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void employeeIdBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int x = Convert.ToInt32(employeeIdBox.Text.ToString());

                for (int i = 0; i < employeeNumberList.Count; i++)
                {
                    if (x == employeeNumberList[i]) 
                    {
                        passwordBox.Visible = true;
                        label2.Visible = true;
                        break;
                    }
                    else
                    {

                        label2.Visible = false;
                        passwordBox.Visible = false;
                        loginButton.Visible = false;

                    }
                }
            }
            catch
            {

                label2.Visible = false;
                passwordBox.Visible = false;
            }
           
        }

        private void passwordBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int x = Convert.ToInt32(employeeIdBox.Text.ToString());
                String s = passwordBox.Text;

                for (int i = 0; i < employeeNumberList.Count; i++)
                {
                    if (x == employeeNumberList[i] && s == employeePassList[i])
                    {
                        loginButton.Visible = true;
                        employeeNumberLoggedin = employeeNumberList[i];
                        employeePasswordLoggedin = employeePassList[i];
                        break;
                    }
                    else
                    {
                        employeeNumberLoggedin = 0;
                        employeePasswordLoggedin = "";
                        loginButton.Visible = false;
                    }
                }
            }
            catch
            {
                loginButton.Visible = false;
            }
        }
        */
        private void loginButton_Click(object sender, EventArgs e)
        {
            
            fillEmployeeInfo();
            if (employeeNumberLoggedin == Convert.ToInt32(employeeIdBox.Text.ToString()) && passwordBox.Text == employeePasswordLoggedin)
            {
                LogInForm.ActiveForm.Visible = false;
                SaleForm sale1 = new SaleForm(adminBoolean, employeeName, int.Parse(employeeIdBox.Text.ToString()), this);
                sale1.Activate();
                sale1.Show();
            }
            else
            {
                MessageBox.Show("Input correct id or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

    }
}
