using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Hashtable myHashTable = new Hashtable();
        

        private void Form1_Load(object sender, EventArgs e)
        {

            myHashTable.Add("123456", "Derin Deniz");
            myHashTable.Add("131234", "Mavi Gezegen");
            myHashTable.Add("145678", "Yıldız Tozu");
            myHashTable.Add("121212", "Mavi Balina");
            myHashTable.Add("120001", "Sarı Kanat");
        }
        
        public void deleteRecord(string s)
        {
            myHashTable.Remove(s);
            MessageBox.Show("The record was deleted in hashtable");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string studentNo = txtStudentNo.Text;
            string studentName = txtName.Text;

            if (studentNo.Length != 6)
            {
                MessageBox.Show("Please enter 6-digit number");
            }
            else
            {
                if (String.IsNullOrEmpty(studentNo) == false && String.IsNullOrEmpty(studentName) == false)
                {
                    if (myHashTable.ContainsKey(studentNo))
                        MessageBox.Show("Student number " + studentNo + " is also exist in the hashtable.\n " +
                            "Please enter another student number.");
                    else
                    {
                        myHashTable.Add(studentNo, studentName);
                        txtStudentNo.Text = "";
                        txtName.Text = "";
                        MessageBox.Show("Student number " + studentNo + " was added");
                    }
                }
                else
                    MessageBox.Show("Please fill both of textboxes");
            }
           
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (DictionaryEntry element in myHashTable) //DictionaryEntry is a struct
            {
                listBox1.Items.Add(element.Value + "\t:\t" + element.Key);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string searchHashKey = txtSearchHashKey.Text;
            string searchHashValue = txtSearchHashValue.Text;

            if (searchHashKey == "" && searchHashValue == "")
            {
                MessageBox.Show("Please enter student number, name or both");
            }
            else if (myHashTable.ContainsKey(searchHashKey) == true && searchHashValue == "")
            {
                listBox1.Items.Add(myHashTable[searchHashKey] + "\t:\t" + searchHashKey);
            }

            else if (myHashTable.ContainsValue(searchHashValue) == true && searchHashKey == "")
            {
                foreach (DictionaryEntry element in myHashTable) 
                {
                    if (searchHashValue == element.Value.ToString())
                    {
                        listBox1.Items.Add(element.Value + "\t:\t" + element.Key);
                    }

                }

            }

            else if (myHashTable.ContainsKey(searchHashKey) && myHashTable.ContainsValue(searchHashValue))
            {
                foreach (DictionaryEntry element in myHashTable) 
                {
                    if (searchHashKey == element.Key.ToString() && searchHashValue == element.Value.ToString())
                    {
                        listBox1.Items.Add(element.Value + "\t:\t" + element.Key);
                    }

                }

            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string deleteHashKey = txtDeleteHashKey.Text;
            string deleteHashValue = txtDeleteHashValue.Text;

            if (deleteHashKey == "" && deleteHashValue == "")
            {
                MessageBox.Show("Please enter student number, name or both");
            }
            else if (myHashTable.ContainsKey(deleteHashKey) == true && deleteHashValue == "")
            {
                deleteRecord(deleteHashKey);
            }

            else if (myHashTable.ContainsValue(deleteHashValue) == true && deleteHashKey == "")
            {
                ICollection keysColl = myHashTable.Keys;
                foreach (String key in keysColl)
                {
                    if (myHashTable[key].ToString() == deleteHashValue)
                    {
                        deleteHashKey = key;
                    }
                }

                deleteRecord(deleteHashKey);
            }

            else if (myHashTable.ContainsKey(deleteHashKey) && myHashTable[deleteHashKey].ToString() == deleteHashValue)
            {
                deleteRecord(deleteHashKey);
            }
            else
                MessageBox.Show("The record does not found");
        }

        private void btnListByYear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string listByYear = txtRange.Text;

            ICollection keysColl = myHashTable.Keys;
            foreach (String key in keysColl)
            {
                if (listByYear.Remove(2) == key.Remove(2))
                {
                    listBox1.Items.Add(myHashTable[key] + "\t:\t" + key);
                }
            }
            
        }

        private void txtStudentNo_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtStudentNo.Text,"[^0-9]"))
            {
                MessageBox.Show("Please only enter numbers");
                txtStudentNo.Clear();
            }
        }
    }
}
