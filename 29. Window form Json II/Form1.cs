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
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _29.Window_form_Json_II
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
                        MessageBox.Show("Error found: " + ex.Message);
                    }
                }
            }
            List<Info> sortedInfoList = new List<Info>();
            if (information != null)
            {
                sortedInfoList = information.OrderBy(info => info.Name).ToList();
            }
            return sortedInfoList;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InfoAdder newForm = new InfoAdder (this);
            newForm.Show();
        }


    }
}
