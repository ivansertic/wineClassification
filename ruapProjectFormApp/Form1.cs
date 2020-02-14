using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ruapProjectFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private String wineType;
        private float residualShugars;
        private float alcohol;

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void btnSendData_Click(object sender, EventArgs e)
        {
            this.wineType = cbType.Text.ToString();

            String residualShugar = tbResidualShugar.Text.ToString();
            residualShugar = residualShugar.Replace(',', '.');
            bool valid = float.TryParse(residualShugar, out this.residualShugars);

            if(!valid)
            {
                MessageBox.Show("Input residual shugar is not a number!");
                Application.Exit();
            }

            String alcoholPercent = tbAlcohol.Text.ToString();
            alcoholPercent = alcoholPercent.Replace(',', '.');
            bool alcoholValid = float.TryParse(alcoholPercent, out this.alcohol);

            if(!alcoholValid)
            {
                MessageBox.Show("Input alcohol is not a number!");
                Application.Exit();
            }

            using (var client = new HttpClient())
            {
                var scoreRequest = new
                {
                    Inputs = new Dictionary<string, List<Dictionary<string, string>>>() {
                        {
                            "input1",
                            new List<Dictionary<string, string>>(){new Dictionary<string, string>(){
                                            {
                                                "type", this.wineType.ToString()
                                            },
                                            {
                                                "residual sugar", this.residualShugars.ToString()
                                            },
                                            {
                                                "alcohol", this.alcohol.ToString()
                                            },
                                }
                            }
                        },
                    },
                    GlobalParameters = new Dictionary<string, string>()
                    {
                    }
                };

                const string apiKey = "KdmwGM+K5JSSFK7CBiy6gPlmGM5ChZMnjxNyd3v74h+hnqf5G9Tuot0kvh6FtgylElzkVAMEwgHs0rzzmKuUIg==";
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiKey);
                client.BaseAddress = new Uri("https://ussouthcentral.services.azureml.net/workspaces/7fe579a4046e4762a82c2e35ed3b4fd0/services/0681a2249a5849e0828dc7dfd5b79609/execute?api-version=2.0&format=swagger");

                HttpResponseMessage response = await client.PostAsJsonAsync("", scoreRequest);

                if (response.IsSuccessStatusCode)
                {
                    string result = await response.Content.ReadAsStringAsync();
                    dynamic jsonResult = JValue.Parse(result);

                    string wineTypeOutput = jsonResult.Results.output1[0].type.ToString();

                    if (jsonResult.Results.output1[0]["Scored Labels"] == 1)
                    {
                        float badWine = jsonResult.Results.output1[0]["Scored Probabilities for Class \"1\""];
                        badWine *= 100;
                        MessageBox.Show("It's a bad "+ wineTypeOutput+ " wine and I'm " + badWine + " % sure of it", "Results");
                    }

                    if (jsonResult.Results.output1[0]["Scored Labels"] == 2)
                    {
                        float goodWine = jsonResult.Results.output1[0]["Scored Probabilities for Class \"2\""];
                        goodWine *= 100;
                        MessageBox.Show("It's a good " + wineTypeOutput + " wine and I'm " + goodWine + " % sure of it" , "Results");
                    }

                    if (jsonResult.Results.output1[0]["Scored Labels"] == 3)
                    {
                        float veryGoodWine = jsonResult.Results.output1[0]["Scored Probabilities for Class \"3\""];
                        veryGoodWine *= 100;
                        MessageBox.Show("It's a very good "+ wineTypeOutput + " wine and I'm "+ veryGoodWine + " sure of it", "Results");
                    }
                }
                else
                {
                    string responseContent = await response.Content.ReadAsStringAsync();
                    MessageBox.Show("The request failed with status code: {0}" + response.StatusCode, "Error", MessageBoxButtons.OK);
                }
            }

            

        }
    }
}
