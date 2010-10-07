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
    public partial class NewMemberForm : Form
    {           
            List<String> firstNameList = new List<string>();
            List<String> lastNameList = new List<string>();
            List<long> ssnList = new List<long>();
            List<String> addressList = new List<string>();
            List<String> stateList = new List<string>();
            List<int> zipCodeList = new List<int>();
            List<String> cityList = new List<string>();
            List<String> emailList = new List<string>();
            List<long> phoneNumberList = new List<long>();
            List<String> dateList = new List<string>();
            List<long> memberIdList = new List<long>();
            Dictionary<long, long> nameAndMemberId = new Dictionary<long, long>();

        public NewMemberForm()
        {
            InitializeComponent();
            memberIdList.Add(123456);
            memberIdList.Add(111111);
            memberIdList.Add(222222);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            addressList.Add(addressTextBox.Text);
            stateList.Add(stateComboBox.SelectedText);
            try
            {
                zipCodeList.Add(Convert.ToInt32(zipCodeTextBox.Text));
            }
            catch (Exception)
            {
                MessageBox.Show("Invaild Input for zip code field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                cityList.Add(Convert.ToString(cityTextBox.Text));
            }
            catch (Exception)
            {
                MessageBox.Show("Invaild Input for city field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            emailList.Add(emailTextBox.Text);
            try
            {
                phoneNumberList.Add(Convert.ToInt64(phoneNumberTextBox.Text));
                
            }
            catch (Exception)
            {
                MessageBox.Show("Invaild Input for phone number field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (!ssnList.Contains(Convert.ToInt64(ssnTextBox.Text)))
            {
                try
                {
                    ssnList.Add(Convert.ToInt32(ssnTextBox.Text));
                }
                catch (Exception)
                {
                    MessageBox.Show("Invaild Input for snn field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                memberIdTextBox.Clear();
                String name = firstNameTextBox.Text;
                long memberId = memberIdList.ElementAt(0);
                firstNameList.Add(name);
                lastNameList.Add(lastNameTextBox.Text);
                nameAndMemberId.Add(Convert.ToInt64(ssnTextBox.Text), memberId);
                memberIdTextBox.Text = Convert.ToString(memberId);
                memberIdList.RemoveAt(0);
            }

            dateList.Add(dateTimePicker.Text);
            }
        }
    }
