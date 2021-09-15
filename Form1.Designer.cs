
namespace EatWhat
{
    partial class EatWhat
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
            this.title = new System.Windows.Forms.Label();
            this.locationTitle = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.restLabel = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Segoe UI", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.title.Location = new System.Drawing.Point(116, 33);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(555, 46);
            this.title.TabIndex = 0;
            this.title.Text = "What do you want to eat tonight?";
            this.title.Click += new System.EventHandler(this.label1_Click);
            // 
            // locationTitle
            // 
            this.locationTitle.AutoSize = true;
            this.locationTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.locationTitle.Location = new System.Drawing.Point(123, 129);
            this.locationTitle.Name = "locationTitle";
            this.locationTitle.Size = new System.Drawing.Size(150, 28);
            this.locationTitle.TabIndex = 1;
            this.locationTitle.Text = "Where are you?";
            this.locationTitle.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.LightSlateGray;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Brisbane"});
            this.comboBox1.Location = new System.Drawing.Point(124, 180);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(547, 28);
            this.comboBox1.TabIndex = 2;
            // 
            // restLabel
            // 
            this.restLabel.AutoSize = true;
            this.restLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.restLabel.Location = new System.Drawing.Point(124, 226);
            this.restLabel.Name = "restLabel";
            this.restLabel.Size = new System.Drawing.Size(73, 28);
            this.restLabel.TabIndex = 3;
            this.restLabel.Text = "Suburb";
            this.restLabel.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Brisbane City",
            "Sunnybank",
            "Toowong",
            "Garden City"});
            this.comboBox2.Location = new System.Drawing.Point(124, 267);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(547, 28);
            this.comboBox2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(124, 314);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "Restaurant";
            this.label1.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // comboBox3
            // 
            this.comboBox3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Genkotsu Ramen",
            "Jackpot"});
            this.comboBox3.Location = new System.Drawing.Point(124, 355);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(271, 28);
            this.comboBox3.TabIndex = 6;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(401, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(270, 26);
            this.button1.TabIndex = 7;
            this.button1.Text = "DON\'T ASK ME, CHOOSE FOR ME!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EatWhat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.restLabel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.locationTitle);
            this.Controls.Add(this.title);
            this.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Name = "EatWhat";
            this.Text = "EatWhat v1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label locationTitle;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label restLabel;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button button1;
    }
}

