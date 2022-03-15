using Newtonsoft.Json;
using RestSharp;

using System.Text.Json;

namespace WeatherAPP
{
    public partial class Form1 : Form
    {
        public Form1()
        {			        
            InitializeComponent();
            /*
             * Section for Clear Labels since winforms is terrible
             * 
             * 
            */
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
            label2.Parent = pictureBox1;
            label2.BackColor = Color.Transparent;
            Feels_Like.Parent = pictureBox1;
            Feels_Like.BackColor = Color.Transparent;
            fCast.Parent = pictureBox1;
            fCast.BackColor = Color.Transparent;


        }

        private async void button1_ClickAsync(object sender, EventArgs e)
        {



            Console.WriteLine("Please enter a zipe code: ");
            string address = textBox1.Text;
            

            string API_KEY = "25cbe3a84ded6fe6ba107e9ed503ed6d";
            string BASE_URL = "http://api.openweathermap.org/data/2.5/weather";
            string MAIN_URL = $"{BASE_URL}?zip={address}&units=imperial&lang=en&appid={API_KEY}";

            var request = new RestRequest(MAIN_URL);
            var client = new RestClient(MAIN_URL);
            

            // If the field is blank and bad request is sent back.
            if (textBox1.Text == "")
            {
                MessageBox.Show("You've entered an incorrect zipcode!", "Error!");

            }
            // Error checking to see if zipcode is valid
            
            else
            {
                var response = await client.GetAsync(request);
                if (response.Content.Contains("\"cod\":\"404\""))
                {
                    MessageBox.Show("You've entered an incorrect zipcode!", "Error!");
                    // Resets the text box to blank.
                    textBox1.Text = null;

                }
                // Main API Calling
                else
                {
                    Weather.root inf = JsonConvert.DeserializeObject<Weather.root>(response.Content.ToString());
                  //  Weather tst = JsonConvert.DeserializeObject<Weather.root>(response.Content.ToString());
                    //MessageBox.Show(response.Content);
                    feelsBox.Text = $"{inf.main.temp.ToString()} Degrees!";
                    cityBox.Text = inf.name;
                    foreCast.Text = inf.Weather[0].description;
                    Bitmap img1 = Properties.Resources.ClearSkies;
                   
                    
                    if (inf.Weather[0].description == "clear sky")
                    {
                        pictureBox1.Image = img1;
                    }


                    
                }

            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // place holder 
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Feels_Like_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        
        }
    }
}