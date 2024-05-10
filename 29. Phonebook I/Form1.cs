using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static _29.Phonebook_I.Form1;
using Newtonsoft.Json;
using System.Net;

namespace _29.Phonebook_I
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string filePath = "info.json";
            DisplayInfo(filePath);
        }
        public class Info
        {
            public string Name { get; set; }
            public string PhoneNumber { get; set; }
            public string Address { get; set; }
            public string Relationship { get; set; }    
        }
        public List <Info> LoadInfo (string filePath)
        {
            List<Info> information = new List<Info> ();
            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    try
                    {
                        string jsonContent = reader.ReadToEnd();
                        information = JsonConvert.DeserializeObject<List<Info>>(jsonContent);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error found:" + ex.Message);
                    }
                }
            }
            List<Info> sortedInfoList = new List<Info> (information);
            if(information!=null)
            {
                sortedInfoList = information.OrderBy (info => info.Name).ToList();
            }
            return sortedInfoList;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Info_Adder newForm = new Info_Adder(this);
            newForm.Show();           
        }
        public void DisplayInfo (string filePath)
        {
            List<Info>information = LoadInfo(filePath);
            int i = 0;
            foreach (Info info in information) 
            {
                User_Interface userControl = new User_Interface(new User_Interface.Info
                {
                    Name = info.Name,
                    PhoneNumber = info.PhoneNumber,
                    Address = info.Address,
                    Relationship = info.Relationship
                },this);
                userControl.Size = new Size(514, 41);
                userControl.Location = new Point(0, i * userControl.Height);
                flowLayoutPanel1.Controls.Add(userControl);
                i++;
            }
        }
        public void RefreshForm1()
        {
            flowLayoutPanel1.Controls.Clear();
            Refresh();
        }
        public void BackUpAddressBook(List<Info> information, string backUpFilePath)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(backUpFilePath))
                {
                    string jsonString = JsonConvert.SerializeObject(information, Formatting.Indented);
                    writer.Write(jsonString);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error found: " + ex.Message);
            }
        }
        public List<Info> RestoreAddressBook(string backUpFilePath)
        {
            List<Info> restoredInformation = new List<Info>();
            try
            {
                using (StreamReader reader = new StreamReader(backUpFilePath))
                {
                    string jsonContent = reader.ReadToEnd();
                    restoredInformation = JsonConvert.DeserializeObject<List<Info>>(jsonContent);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error found: " + ex.Message);
            }
            return restoredInformation;
        }
        private void BackUpButton_Click(object sender, EventArgs e)
        {
            string filePath = "info.json";
            string backUpFilePath = "backupinfo.json";                  
            Form1 form1 = new Form1();
            List<Info> information = form1.LoadInfo(filePath);
            form1.BackUpAddressBook(information, backUpFilePath);
            MessageBox.Show("The contact has been backed up to another file");
        }
        private void RecoverButton_Click(object sender, EventArgs e)
        {
            string backUpFilePath = "backupinfo.json";
            List<Info> restoredInformation = RestoreAddressBook(backUpFilePath);
            RefreshForm1();
            DisplayInfo(backUpFilePath);
            MessageBox.Show("We have recovered your contact from the file successfully");
        }
    }
}
