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
using System.Web;
using System.Windows.Forms;

namespace _29.Phonebook_I
{
    public partial class User_Interface : UserControl
    {
        private Form1 parentForm;
        public class Info
        {
            public string Name { get; set; }
            public string PhoneNumber { get; set; }
            public string Address { get; set; }
            public string Relationship { get; set; }
        }
        public User_Interface(Info profile, Form1 parent)
        {
            InitializeComponent();
            parentForm = parent;
            NameLabel.Text = profile.Name;
            PhoneNumberStorerLabel.Text = profile.PhoneNumber;
        }


        private void User_Interface_Load(object sender, EventArgs e)
        {

        }

        private void MoreButton_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(MoreButton, new Point(0, MoreButton.Height));
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
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
                    catch(Exception ex)
                    {
                        MessageBox.Show("Error found: " + ex.Message);
                    }
                }
            }
            information.RemoveAll(info => info.PhoneNumber == phoneNumber);
            try
            {
                var sortedInfoList = information.OrderBy(info => info.Name).ToList();
                using(StreamWriter writer = new StreamWriter(filePath))
                {
                    string jsonString = JsonConvert.SerializeObject(sortedInfoList, Formatting.Indented);
                    writer.Write(jsonString);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error found: " + ex.Message);
            }
            parentForm.RefreshForm1();
            parentForm.DisplayInfo(filePath);
        }
        private void viewProfileToolStripMenuItem_Click(object sender, EventArgs e)
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
            Info profileInfo = information.Find (info => info.PhoneNumber == phoneNumber);
            Profile_Viewer profileViewer = new Profile_Viewer(new Profile_Viewer.Info
            {
                Name = profileInfo.Name,
                PhoneNumber = profileInfo.PhoneNumber,
                Address = profileInfo.Address,
                Relationship = profileInfo.Relationship
            }, this);
            profileViewer.Show();
            parentForm.Hide();
        }
        private void User_Interface_Click (object sender, EventArgs e)
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
            Info profileInfo = information.Find(info => info.PhoneNumber == phoneNumber);
            Profile_Viewer profileViewer = new Profile_Viewer(new Profile_Viewer.Info
            {
                Name = profileInfo.Name,
                PhoneNumber = profileInfo.PhoneNumber,
                Address = profileInfo.Address,
                Relationship = profileInfo.Relationship
            }, this);
            profileViewer.Show();
            parentForm.Hide();
        }

        private void NameLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
