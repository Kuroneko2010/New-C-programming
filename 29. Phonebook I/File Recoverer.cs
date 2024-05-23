using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace _29.Phonebook_I
{
    public partial class File_Recoverer : Form
    {
        public Form1 parentForm;
        public File_Recoverer(Form1 parent)
        {
            InitializeComponent();
            parentForm = parent;
            InvalidErrorLabel.Visible = false;            
        }
        private void File_Recoverer_Load(object sender, EventArgs e)
        {

        }
        private void RecoverButton_Click(object sender, EventArgs e)
        {
            InvalidErrorLabel.Visible = false;
            string filePath = URLTextBox.Text;
            if (File.Exists(filePath))
            {
                try
                {
                    string jsonText = File.ReadAllText(filePath);
                    List<dynamic> jsonObjects = JsonConvert.DeserializeObject<List<dynamic>>(jsonText);
                    bool fileHasValidFormat = true;
                    foreach (var jsonObject in jsonObjects)
                    {
                        if (jsonObject.Name == null || jsonObject.PhoneNumber == null || jsonObject.Address == null || jsonObject.Relationship == null)
                        {
                            fileHasValidFormat = false;
                            break;
                        }
                    }
                    if (fileHasValidFormat)
                    {
                        dynamic data = JsonConvert.DeserializeObject(jsonText);
                        string jsonData = JsonConvert.SerializeObject(data, Formatting.Indented);
                        File.WriteAllText("info.json", jsonData);
                        MessageBox.Show("Your file has been recovered successfully");
                        parentForm.RefreshForm1();
                        parentForm.DisplayInfo("info.json");
                        this.Close();
                    }
                    else
                    {
                        InvalidErrorLabel.Visible = true;
                        URLTextBox.Text = "";
                    }
                }
                catch (FileNotFoundException)
                {
                    MessageBox.Show("Json file not found");
                }
                catch (JsonException)
                {
                    InvalidErrorLabel.Visible = true;
                }
            }
            else
            {
                InvalidErrorLabel.Visible = true;
                URLTextBox.Text = "";
            }
        }
        private void ChooseFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chọn tệp để mở";
            openFileDialog.Filter = "Tất cả các tệp|*.*|Tệp văn bản|*.txt|Tệp JSON|*.json";
            openFileDialog.Multiselect = false;
            if(openFileDialog.ShowDialog() == DialogResult.OK) 
            { 
                string selectedFilePath = openFileDialog.FileName;
                URLTextBox.Text = selectedFilePath;
            }
        }
    }
}
