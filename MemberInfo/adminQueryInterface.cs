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
    public partial class adminQueryInterface : Form
    {
        private string sqlStatement;
        public adminQueryInterface()
        {
            InitializeComponent();
        }

        public void connectDb()
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

                sqlStatement = sqlStatementBox.Text;
                OdbcDataAdapter a = new OdbcDataAdapter(
                    sqlStatement, MyConnection);
                DataTable t = new DataTable();
                a.Fill(t);
                resultDataGrid.DataSource = t;
                MyConnection.Close();

            }
            catch (OdbcException odbce)
            {
                errorTextBox.Visible = true;
                errorTextBox.Text = odbce.ToString();
            }
        }

        private void parseSqlStatement()
        {
            string[] test = sqlStatement.Split(',');
        }

        private void runQueryButton_Click(object sender, EventArgs e)
        {
            connectDb();
        }
    }
}
