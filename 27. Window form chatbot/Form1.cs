using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _27.Window_form_chatbot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            richTextBox2.ReadOnly = true;
           
        }    
        private async void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            string text = richTextBox1.Text;
            if (e.KeyCode == Keys.Enter)
            {
                if (e.Shift)
                {
                    richTextBox1.AppendText(Environment.NewLine);
                    e.Handled = true;
                }
                else
                {
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                    richTextBox1.Clear();
                    richTextBox2.AppendText("User: ");
                    richTextBox2.AppendText(text + "\n");
                    richTextBox2.AppendText("Loading...");
                    string response = await ContentGenerator(text);
                    richTextBox2.Text = richTextBox2.Text.Remove(richTextBox2.Text.LastIndexOf("Loading..."));
                    richTextBox2.AppendText("Chad skibidi: ");
                    richTextBox2.AppendText(response + "\n");
                    richTextBox2.AppendText("\n");
                    
                }
            }
        }

        private async void Send_Click(object sender, EventArgs e)
        {
            string text = richTextBox1.Text;
            richTextBox1.Clear();
            richTextBox2.AppendText("User: ");
            richTextBox2.AppendText(text + "\n");         
            richTextBox2.AppendText("Loading...");
            string response = await ContentGenerator(text);
            richTextBox2.Text = richTextBox2.Text.Remove(richTextBox2.Text.LastIndexOf("Loading..."));
            richTextBox2.AppendText("Chad skibidi: ");
            richTextBox2.AppendText(response + "\n");
            richTextBox2.AppendText("\n");
        }
        private static async Task<string> ContentGenerator(string message)
        {
            try
            {
                string apiKey = "AIzaSyDXogq2fDFilb85AjKk-hBrDpbl_S32kSM";
                string url = "https://generativelanguage.googleapis.com/v1beta/models/gemini-pro:generateContent?key=" + apiKey;

                var requestBody = new
                {
                    contents = new[]
                    {
                        new
                        {
                            parts = new[]
                            {
                                new
                                {
                                    text = message
                                }
                            }
                        }
                    }
                };

                using (HttpClient client = new HttpClient())
                {
                    var json = JsonConvert.SerializeObject(requestBody);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");

                    var response = await client.PostAsync(url, content);

                    if (response.IsSuccessStatusCode)
                    {
                        var responseContent = await response.Content.ReadAsStringAsync();
                        dynamic jsonResponse = JObject.Parse(responseContent);
                        string responseText = jsonResponse.candidates[0].content.parts[0].text;
                        return responseText;
                    }
                    else
                    {
                        Console.WriteLine($"Failed to generate content. Status code: {response.StatusCode}");
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                return null;
            }
        }

    }
}

