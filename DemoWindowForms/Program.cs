using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Azure.AI.OpenAI;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Chatbot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            richTextBox2.ReadOnly = true;
        }

        private async void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string text = richTextBox1.Text;
                richTextBox2.AppendText("User : ");
                richTextBox2.AppendText(text + "\n");
                richTextBox1.Clear();
                string response = await GenerateContent(text);
                richTextBox2.AppendText("Chatbot : ");
                richTextBox2.AppendText(response + "\n");
                richTextBox2.AppendText("\n");


            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string text = richTextBox1.Text;
            richTextBox2.AppendText("User : ");
            richTextBox2.AppendText(text + "\n");
            richTextBox1.Clear();
            string response = await GenerateContent(text);
            richTextBox2.AppendText("Chatbot : ");
            richTextBox2.AppendText(response + "\n");
            richTextBox2.AppendText("\n");
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private async Task<string> GenerateContent(string message)
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
                    var json = Newtonsoft.Json.JsonConvert.SerializeObject(requestBody);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");

                    var response = await client.PostAsync(url, content);
                    if (response.IsSuccessStatusCode)
                    {
                        var responseContent = await response.Content.ReadAsStringAsync();

                        // Parse JSON response
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

        private void richTextBox2_VScroll(object sender, EventArgs e)
        {

        }
    }
}