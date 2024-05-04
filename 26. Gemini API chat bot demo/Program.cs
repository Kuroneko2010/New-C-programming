using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace ChadSkibidi
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Please ask anything: ");
            string userRequest = Console.ReadLine();
            string responseText = await GenerateContent(userRequest);
            Console.WriteLine("Response: " + responseText);
        }

        static async Task<string> GenerateContent(string message)
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





