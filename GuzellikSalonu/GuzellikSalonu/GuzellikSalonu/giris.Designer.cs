namespace GuzellikSalonu
{
    partial class giris
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(giris));
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(576, 58);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(320, 454);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.MistyRose;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(51, 153);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(426, 67);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.MistyRose;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Location = new Point(51, 272);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(426, 68);
            textBox2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Brown;
            label1.Font = new Font("Ravie", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.LightSalmon;
            label1.Location = new Point(1, 30);
            label1.Name = "label1";
            label1.Size = new Size(549, 81);
            label1.TabIndex = 3;
            label1.Text = "HOŞ GELDİNİZ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Handwriting", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.LightCoral;
            label2.Location = new Point(51, 123);
            label2.Name = "label2";
            label2.Size = new Size(206, 27);
            label2.TabIndex = 4;
            label2.Text = "KULLANICI ADI:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Handwriting", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.LightCoral;
            label3.Location = new Point(51, 242);
            label3.Name = "label3";
            label3.Size = new Size(100, 27);
            label3.TabIndex = 5;
            label3.Text = "ŞİFRE  :";
            label3.Click += label3_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Lucida Calligraphy", 11F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.MistyRose;
            button1.Location = new Point(141, 391);
            button1.Name = "button1";
            button1.Size = new Size(234, 79);
            button1.TabIndex = 6;
            button1.Text = "GİRİŞ YAP";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.MistyRose;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Lucida Calligraphy", 11F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.Maroon;
            button2.Location = new Point(141, 491);
            button2.Name = "button2";
            button2.Size = new Size(234, 79);
            button2.TabIndex = 7;
            button2.Text = "MENÜ";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // giris
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Brown;
            ClientSize = new Size(1010, 577);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Name = "giris";
            Text = "giris";
            Load += giris_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
    }
}