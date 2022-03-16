namespace WeatherAPP
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.FetchWeather = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.L_zipcode = new System.Windows.Forms.Label();
            this.L_Feels_Like = new System.Windows.Forms.Label();
            this.L_CITYNAME = new System.Windows.Forms.Label();
            this.T_cityBox = new System.Windows.Forms.TextBox();
            this.feelsBox = new System.Windows.Forms.TextBox();
            this.L_Forecast = new System.Windows.Forms.Label();
            this.foreCast = new System.Windows.Forms.TextBox();
            this.L_FEELSLIKE = new System.Windows.Forms.Label();
            this.L_HUMIDITY = new System.Windows.Forms.Label();
            this.T_HUMIDITY = new System.Windows.Forms.TextBox();
            this.testlabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // FetchWeather
            // 
            this.FetchWeather.BackColor = System.Drawing.Color.Transparent;
            this.FetchWeather.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FetchWeather.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.FetchWeather.FlatAppearance.BorderSize = 0;
            this.FetchWeather.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FetchWeather.Image = global::WeatherAPP.Properties.Resources.GreenButton;
            this.FetchWeather.Location = new System.Drawing.Point(233, 387);
            this.FetchWeather.Name = "FetchWeather";
            this.FetchWeather.Size = new System.Drawing.Size(310, 60);
            this.FetchWeather.TabIndex = 0;
            this.FetchWeather.Text = "Get Weather!";
            this.FetchWeather.UseVisualStyleBackColor = false;
            this.FetchWeather.Click += new System.EventHandler(this.FetchWeather_ClickAsync);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(380, 363);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 19);
            this.textBox1.TabIndex = 1;
            // 
            // L_zipcode
            // 
            this.L_zipcode.AutoSize = true;
            this.L_zipcode.BackColor = System.Drawing.Color.Transparent;
            this.L_zipcode.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.L_zipcode.Location = new System.Drawing.Point(242, 358);
            this.L_zipcode.Name = "L_zipcode";
            this.L_zipcode.Size = new System.Drawing.Size(120, 21);
            this.L_zipcode.TabIndex = 2;
            this.L_zipcode.Text = "Enter Zipcode:";
            // 
            // L_Feels_Like
            // 
            this.L_Feels_Like.AutoSize = true;
            this.L_Feels_Like.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.L_Feels_Like.Location = new System.Drawing.Point(282, 163);
            this.L_Feels_Like.Name = "L_Feels_Like";
            this.L_Feels_Like.Size = new System.Drawing.Size(0, 21);
            this.L_Feels_Like.TabIndex = 4;
            // 
            // L_CITYNAME
            // 
            this.L_CITYNAME.AutoSize = true;
            this.L_CITYNAME.BackColor = System.Drawing.Color.Transparent;
            this.L_CITYNAME.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.L_CITYNAME.Location = new System.Drawing.Point(251, 85);
            this.L_CITYNAME.Name = "L_CITYNAME";
            this.L_CITYNAME.Size = new System.Drawing.Size(45, 21);
            this.L_CITYNAME.TabIndex = 5;
            this.L_CITYNAME.Text = "City:";
            // 
            // T_cityBox
            // 
            this.T_cityBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.T_cityBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.T_cityBox.Location = new System.Drawing.Point(380, 90);
            this.T_cityBox.Name = "T_cityBox";
            this.T_cityBox.ReadOnly = true;
            this.T_cityBox.Size = new System.Drawing.Size(124, 19);
            this.T_cityBox.TabIndex = 6;
            // 
            // feelsBox
            // 
            this.feelsBox.BackColor = System.Drawing.SystemColors.Control;
            this.feelsBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.feelsBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.feelsBox.Location = new System.Drawing.Point(380, 171);
            this.feelsBox.Name = "feelsBox";
            this.feelsBox.ReadOnly = true;
            this.feelsBox.Size = new System.Drawing.Size(124, 19);
            this.feelsBox.TabIndex = 7;
            // 
            // L_Forecast
            // 
            this.L_Forecast.AutoSize = true;
            this.L_Forecast.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.L_Forecast.Location = new System.Drawing.Point(251, 127);
            this.L_Forecast.Name = "L_Forecast";
            this.L_Forecast.Size = new System.Drawing.Size(79, 21);
            this.L_Forecast.TabIndex = 8;
            this.L_Forecast.Text = "Forecast:";
            // 
            // foreCast
            // 
            this.foreCast.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.foreCast.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.foreCast.Location = new System.Drawing.Point(380, 132);
            this.foreCast.Name = "foreCast";
            this.foreCast.ReadOnly = true;
            this.foreCast.Size = new System.Drawing.Size(124, 19);
            this.foreCast.TabIndex = 9;
            // 
            // L_FEELSLIKE
            // 
            this.L_FEELSLIKE.AutoSize = true;
            this.L_FEELSLIKE.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.L_FEELSLIKE.Location = new System.Drawing.Point(251, 166);
            this.L_FEELSLIKE.Name = "L_FEELSLIKE";
            this.L_FEELSLIKE.Size = new System.Drawing.Size(90, 21);
            this.L_FEELSLIKE.TabIndex = 10;
            this.L_FEELSLIKE.Text = "Feels Like:";
            // 
            // L_HUMIDITY
            // 
            this.L_HUMIDITY.AutoSize = true;
            this.L_HUMIDITY.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.L_HUMIDITY.Location = new System.Drawing.Point(251, 211);
            this.L_HUMIDITY.Name = "L_HUMIDITY";
            this.L_HUMIDITY.Size = new System.Drawing.Size(82, 21);
            this.L_HUMIDITY.TabIndex = 11;
            this.L_HUMIDITY.Text = "Humidity:";
            // 
            // T_HUMIDITY
            // 
            this.T_HUMIDITY.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.T_HUMIDITY.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.T_HUMIDITY.Location = new System.Drawing.Point(380, 215);
            this.T_HUMIDITY.Name = "T_HUMIDITY";
            this.T_HUMIDITY.ReadOnly = true;
            this.T_HUMIDITY.Size = new System.Drawing.Size(124, 19);
            this.T_HUMIDITY.TabIndex = 12;
            // 
            // testlabel
            // 
            this.testlabel.AutoSize = true;
            this.testlabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.testlabel.Location = new System.Drawing.Point(378, 248);
            this.testlabel.Name = "testlabel";
            this.testlabel.Size = new System.Drawing.Size(0, 22);
            this.testlabel.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.testlabel);
            this.Controls.Add(this.T_HUMIDITY);
            this.Controls.Add(this.L_HUMIDITY);
            this.Controls.Add(this.L_FEELSLIKE);
            this.Controls.Add(this.foreCast);
            this.Controls.Add(this.L_Forecast);
            this.Controls.Add(this.feelsBox);
            this.Controls.Add(this.T_cityBox);
            this.Controls.Add(this.L_CITYNAME);
            this.Controls.Add(this.L_Feels_Like);
            this.Controls.Add(this.L_zipcode);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.FetchWeather);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Best Weather Applicaton";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button FetchWeather;
        private TextBox textBox1;
        private Label L_zipcode;
        private Label L_Feels_Like;
        private Label L_CITYNAME;
        private TextBox T_cityBox;
        private TextBox feelsBox;
        private Label L_Forecast;
        private TextBox foreCast;
        private Label L_FEELSLIKE;
        private Label L_HUMIDITY;
        private TextBox T_HUMIDITY;
        private Label testlabel;
        private PictureBox pictureBox1;
    }
}