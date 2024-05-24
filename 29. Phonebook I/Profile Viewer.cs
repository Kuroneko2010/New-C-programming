using Newtonsoft.Json;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;


namespace _29.Phonebook_I
{
    public partial class Profile_Viewer : Form
    {
        public Profile_Viewer(Info profile)
        {
            InitializeComponent();
            PhoneNumberStorerLabel.Text = profile.PhoneNumber;
            DisplayViewInfo(profile);
        }

        public class Info
        {
            public string Name { get; set; }
            public string PhoneNumber { get; set; }
            public string Address { get; set; }
            public string Relationship { get; set; }
        }

        public void DisplayViewInfo(Info profile)
        {
            NameLabel.Text = profile.Name;
            PhoneNumberLabel.Text = profile.PhoneNumber;
            AddressLabel.Text = profile.Address;
            RelationshipLabel.Text = profile.Relationship;
        }

        private void Profile_Viewer_Load(object sender, EventArgs e)
        {

        }

        private void GetBackButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            string filePath = "info.json";
            string phoneNumber = PhoneNumberStorerLabel.Text;
            List<Info> information = new List<Info>();
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
                        MessageBox.Show("Error found: " + ex.Message);
                    }
                }
            }
            information.RemoveAll(info => info.PhoneNumber == phoneNumber);
            try
            {
                var sortedInfoList = information.OrderBy(info => info.Name).ToList();
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    string jsonString = JsonConvert.SerializeObject(sortedInfoList, Formatting.Indented);
                    writer.Write(jsonString);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error found: " + ex.Message);
            }
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
            form1.RefreshForm1();
            form1.DisplayInfo(filePath);
        }

        public List<Info> LoadInfo(string filePath)
        {
            List<Info> information = new List<Info>();
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
            List<Info> sortedInfoList = new List<Info>(information);
            if (information != null)
            {
                sortedInfoList = information.OrderBy(info => info.Name).ToList();
            }
            return sortedInfoList;
        }
        private void EditButton_Click(object sender, EventArgs e)
        {
            string filePath = "info.json";
            string phoneNumber = PhoneNumberStorerLabel.Text;
            List<Info> information = new List<Info>();
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
                        MessageBox.Show("Error found: " + ex.Message);
                    }
                }
            }
            
            try
            {
                var sortedInfoList = information.OrderBy(info => info.Name).ToList();
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    string jsonString = JsonConvert.SerializeObject(sortedInfoList, Formatting.Indented);
                    writer.Write(jsonString);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error found: " + ex.Message);
            }
            Info_Editor editor = new Info_Editor(new Info_Editor.Info
            {
                Name = NameLabel.Text,
                PhoneNumber = PhoneNumberLabel.Text,
                Address = AddressLabel.Text,
                Relationship = RelationshipLabel.Text,
            },this);
            editor.Show();                      
        }
    }
}
