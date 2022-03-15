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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Feels_Like = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cityBox = new System.Windows.Forms.TextBox();
            this.feelsBox = new System.Windows.Forms.TextBox();
            this.fCast = new System.Windows.Forms.Label();
            this.foreCast = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(230, 390);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(310, 60);
            this.button1.TabIndex = 0;
            this.button1.Text = "Fetch Data";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_ClickAsync);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(424, 361);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(249, 364);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Zipcode:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Feels_Like
            // 
            this.Feels_Like.AutoSize = true;
            this.Feels_Like.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Feels_Like.Location = new System.Drawing.Point(94, 164);
            this.Feels_Like.Name = "Feels_Like";
            this.Feels_Like.Size = new System.Drawing.Size(90, 21);
            this.Feels_Like.TabIndex = 4;
            this.Feels_Like.Text = "Feels Like:";
            this.Feels_Like.Click += new System.EventHandler(this.Feels_Like_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(94, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "City:";
            // 
            // cityBox
            // 
            this.cityBox.Location = new System.Drawing.Point(207, 84);
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(100, 23);
            this.cityBox.TabIndex = 6;
            // 
            // feelsBox
            // 
            this.feelsBox.BackColor = System.Drawing.SystemColors.Control;
            this.feelsBox.Location = new System.Drawing.Point(207, 162);
            this.feelsBox.Name = "feelsBox";
            this.feelsBox.Size = new System.Drawing.Size(100, 23);
            this.feelsBox.TabIndex = 7;
            // 
            // fCast
            // 
            this.fCast.AutoSize = true;
            this.fCast.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fCast.Location = new System.Drawing.Point(94, 128);
            this.fCast.Name = "fCast";
            this.fCast.Size = new System.Drawing.Size(79, 21);
            this.fCast.TabIndex = 8;
            this.fCast.Text = "Forecast:";
            // 
            // foreCast
            // 
            this.foreCast.Location = new System.Drawing.Point(207, 126);
            this.foreCast.Name = "foreCast";
            this.foreCast.Size = new System.Drawing.Size(100, 23);
            this.foreCast.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.foreCast);
            this.Controls.Add(this.fCast);
            this.Controls.Add(this.feelsBox);
            this.Controls.Add(this.cityBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Feels_Like);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "The Best Weather Applicaton";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private PictureBox pictureBox1;
        private ToolTip toolTip1;
        private Label Feels_Like;
        private Label label2;
        private TextBox cityBox;
        private TextBox feelsBox;
        private Label fCast;
        private TextBox foreCast;
    }
}