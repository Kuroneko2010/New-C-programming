﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;


namespace _29.Phonebook_I
{
    public partial class Info_Editor : Form
    {
        public class Info
        {
            public string Name { get; set; }
            public string PhoneNumber { get; set; }
            public string Address { get; set; }
            public string Relationship { get; set; }
            public Info(string name, string phoneNumber, string address, string relationship)
            {
                Name = name;
                PhoneNumber = phoneNumber;
                Address = address;
                Relationship = relationship;
            }
        }

        public static List<string> phoneNumbersHistory = new List<string>();   
        public Info_Editor()
        {
            InitializeComponent();        
        }


        private void Info_Editor_Load(object sender, EventArgs e)
        {
            RelationshipTextBox.AppendText("User's relationship here");
            RelationshipTextBox.Visible = false;
        }
        public bool IsValidName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return false;
            }
            return true;
        }
        public bool IsValidPhoneNumber(string phoneNumber)
        {

            char[] phoneDigit = phoneNumber.ToCharArray();
            if (string.IsNullOrEmpty(phoneNumber))
            {
                return false;
            }
            if (phoneDigit.Length == 11 && phoneNumber.StartsWith("84"))
            {
                return true;
            }
            if (phoneDigit.Length != 10)
            {
                return false;
            }
            else if (phoneDigit.Length == 10 && !(phoneNumber.StartsWith("0")))
            {
                return false;
            }

            int intPhoneDigit;
            foreach (char digit in phoneDigit)
            {
                if (!int.TryParse(digit.ToString(), out intPhoneDigit))
                {
                    return false;
                }
            }
            return true;
        }
        private bool IsPhoneNumberExisted(string phoneNumber, string filePath)
        {
            List<Info> information = new List<Info>();
            if (File.Exists(filePath))
            {
                string jsonContent = File.ReadAllText(filePath);
                information = JsonConvert.DeserializeObject<List<Info>>(jsonContent);
            }
            if (information != null)
            {
                bool isExisted = information.Exists(p => p.PhoneNumber == phoneNumber);
                return isExisted;
            }
            return false;
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

        private bool familyBlue = false;
        private bool friendBlue = false;
        private bool classmateBlue = false;
        private bool customerBlue = false;
        private bool colleagueBlue = false;
        private bool teacherBlue = false;
        private bool assistantBlue = false;
        private bool otherBlue = false;

        private void FamilyButton_Click(object sender, EventArgs e)
        {
            RelationshipTextBox.Visible = false;
            FamilyButton.BackColor = Color.CornflowerBlue;
            FriendButton.BackColor = DefaultBackColor;
            ClassmateButton.BackColor = DefaultBackColor;
            CustomerButton.BackColor = DefaultBackColor;
            ColleagueButton.BackColor = DefaultBackColor;
            TeacherButton.BackColor = DefaultBackColor;
            AssistantButton.BackColor = DefaultBackColor;
            OtherButton.BackColor = DefaultBackColor;
            familyBlue = true;
        }

        private void FriendButton_Click(object sender, EventArgs e)
        {
            RelationshipTextBox.Visible = false;
            FamilyButton.BackColor = DefaultBackColor;
            FriendButton.BackColor = Color.CornflowerBlue;
            ClassmateButton.BackColor = DefaultBackColor;
            CustomerButton.BackColor = DefaultBackColor;
            ColleagueButton.BackColor = DefaultBackColor;
            TeacherButton.BackColor = DefaultBackColor;
            AssistantButton.BackColor = DefaultBackColor;
            OtherButton.BackColor = DefaultBackColor;
            friendBlue = true;
        }

        private void ClassmateButton_Click(object sender, EventArgs e)
        {
            RelationshipTextBox.Visible = false;
            FamilyButton.BackColor = DefaultBackColor;
            FriendButton.BackColor = DefaultBackColor;
            ClassmateButton.BackColor = Color.CornflowerBlue;
            CustomerButton.BackColor = DefaultBackColor;
            ColleagueButton.BackColor = DefaultBackColor;
            TeacherButton.BackColor = DefaultBackColor;
            AssistantButton.BackColor = DefaultBackColor;
            OtherButton.BackColor = DefaultBackColor;
            classmateBlue = true;
        }

        private void CustomerButton_Click(object sender, EventArgs e)
        {
            RelationshipTextBox.Visible = false;
            FamilyButton.BackColor = DefaultBackColor;
            FriendButton.BackColor = DefaultBackColor;
            ClassmateButton.BackColor = DefaultBackColor;
            CustomerButton.BackColor = Color.CornflowerBlue;
            ColleagueButton.BackColor = DefaultBackColor;
            TeacherButton.BackColor = DefaultBackColor;
            AssistantButton.BackColor = DefaultBackColor;
            OtherButton.BackColor = DefaultBackColor;
            customerBlue = true;
        }

        private void ColleagueButton_Click(object sender, EventArgs e)
        {
            RelationshipTextBox.Visible = false;
            FamilyButton.BackColor = DefaultBackColor;
            FriendButton.BackColor = DefaultBackColor;
            ClassmateButton.BackColor = DefaultBackColor;
            CustomerButton.BackColor = DefaultBackColor;
            ColleagueButton.BackColor = Color.CornflowerBlue;
            TeacherButton.BackColor = DefaultBackColor;
            AssistantButton.BackColor = DefaultBackColor;
            OtherButton.BackColor = DefaultBackColor;
            colleagueBlue = true;
        }

        private void TeacherButton_Click(object sender, EventArgs e)
        {
            RelationshipTextBox.Visible = false;
            FamilyButton.BackColor = DefaultBackColor;
            FriendButton.BackColor = DefaultBackColor;
            ClassmateButton.BackColor = DefaultBackColor;
            CustomerButton.BackColor = DefaultBackColor;
            ColleagueButton.BackColor = DefaultBackColor;
            TeacherButton.BackColor = Color.CornflowerBlue;
            AssistantButton.BackColor = DefaultBackColor;
            OtherButton.BackColor = DefaultBackColor;
            teacherBlue = true;
        }

        private void AssistantButton_Click(object sender, EventArgs e)
        {
            RelationshipTextBox.Visible = false;
            FamilyButton.BackColor = DefaultBackColor;
            FriendButton.BackColor = DefaultBackColor;
            ClassmateButton.BackColor = DefaultBackColor;
            CustomerButton.BackColor = DefaultBackColor;
            ColleagueButton.BackColor = DefaultBackColor;
            TeacherButton.BackColor = DefaultBackColor;
            AssistantButton.BackColor = Color.CornflowerBlue;
            OtherButton.BackColor = DefaultBackColor;
            assistantBlue = true;
        }

        private void OtherButton_Click(object sender, EventArgs e)
        {
            RelationshipTextBox.Visible = true;
            FamilyButton.BackColor = DefaultBackColor;
            FriendButton.BackColor = DefaultBackColor;
            ClassmateButton.BackColor = DefaultBackColor;
            CustomerButton.BackColor = DefaultBackColor;
            ColleagueButton.BackColor = DefaultBackColor;
            TeacherButton.BackColor = DefaultBackColor;
            AssistantButton.BackColor = DefaultBackColor;
            OtherButton.BackColor = Color.CornflowerBlue;
            otherBlue = true;
        }

        private string RelationshipChoice()
        {
            if (familyBlue)
            {
                return "Family";
            }

            if (friendBlue)
            {
                return "Friend";
            }

            if (classmateBlue)
            {
                return "Classmate";
            }
            if (customerBlue)
            {
                return "Customer";
            }
            if (colleagueBlue)
            {
                return "Colleague";
            }
            if (teacherBlue)
            {
                return "Teacher";
            }
            if (assistantBlue)
            {
                return "Assistant";
            }
            if (otherBlue)
            {
                return RelationshipTextBox.Text;
            }
            return "Not chosen";
        }

        private bool IsValidRelationship(string choice)
        {
            if (choice == "Not chosen")
            {
                return false;
            }
            return true;
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            string filePath = "info.json";
            NameErrorLabel.Visible = false;
            PhoneNumberErrorLabel.Visible = false;
            PhoneNumberInvalidError.Visible = false;
            RelationshipErrorLabel.Visible = false;
            if (string.IsNullOrEmpty(RelationshipTextBox.Text))
            {
                RelationshipTextBox.AppendText("Please choose a relationship");
                RelationshipTextBox.ForeColor = Color.Red;
            }
            List<Info> currentInfoList = LoadInfo(filePath);
            if (IsValidName(NameTextBox.Text) && IsValidPhoneNumber(PhoneNumberTextBox.Text) && !IsPhoneNumberExisted(PhoneNumberTextBox.Text, filePath) && IsValidRelationship(RelationshipChoice()))
            {
                List<Info> newInfo = new List<Info>();
                newInfo.Add(new Info(NameTextBox.Text, PhoneNumberTextBox.Text, AddressTextBox.Text, RelationshipChoice()));
                currentInfoList.AddRange(newInfo);

                try
                {
                    var sortedInfoList = currentInfoList.OrderBy(info => info.Name).ToList();
                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                        string jsonString = JsonConvert.SerializeObject(sortedInfoList, Formatting.Indented);
                        writer.Write(jsonString);
                        phoneNumbersHistory.Add(PhoneNumberTextBox.Text);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error found: " + ex.Message);
                }
                MessageBox.Show("The contact has been updated");
                Form1 form1 = new Form1();
                form1.Show();
                form1.RefreshForm1();
                form1.DisplayInfo(filePath);
                this.Close();
                
            }
            else
            {
                if (!IsValidName(NameTextBox.Text))
                {
                    NameErrorLabel.Visible = true;
                    NameTextBox.Text = "";
                }

                if (!IsValidPhoneNumber(PhoneNumberTextBox.Text))
                {
                    PhoneNumberInvalidError.Visible = true;
                    PhoneNumberTextBox.Text = "";
                }

                if (IsPhoneNumberExisted(PhoneNumberTextBox.Text, filePath))
                {
                    PhoneNumberErrorLabel.Visible = true;
                    PhoneNumberTextBox.Text = "";
                }

                if (!IsValidRelationship(RelationshipChoice()))
                {
                    RelationshipErrorLabel.Visible = true;
                }
            }
        }

        private void RelationshipTextBox_Click(object sender, EventArgs e)
        {
            if (RelationshipTextBox.Text.LastIndexOf("User's relationship here") != -1)
            {
                RelationshipTextBox.Text = RelationshipTextBox.Text.Remove(RelationshipTextBox.Text.LastIndexOf("User's relationship here"));
                RelationshipTextBox.ForeColor = Color.Black;
            }
            if (RelationshipTextBox.Text.LastIndexOf("Please choose a relationship") != -1)
            {
                RelationshipTextBox.Text = RelationshipTextBox.Text.Remove(RelationshipTextBox.Text.LastIndexOf("Please choose a relationship"));
                RelationshipTextBox.ForeColor = Color.Black;
            }
        }
    }
}
