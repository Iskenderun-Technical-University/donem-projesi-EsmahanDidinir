namespace GuzellikSalonu
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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.WhiteSmoke;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(22, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 200);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.None;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(784, 349);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(200, 200);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.LightCoral;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Lucida Calligraphy", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Bisque;
            button1.Location = new Point(63, 372);
            button1.Name = "button1";
            button1.Size = new Size(274, 110);
            button1.TabIndex = 4;
            button1.Text = "GİRİŞ YAP";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.PeachPuff;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Lucida Calligraphy", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.DarkSlateGray;
            button2.Location = new Point(410, 372);
            button2.Name = "button2";
            button2.Size = new Size(274, 110);
            button2.TabIndex = 5;
            button2.Text = "KAYIT OL";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tekton Pro Ext", 35.9999962F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(239, 49);
            label1.Name = "label1";
            label1.Size = new Size(770, 88);
            label1.TabIndex = 6;
            label1.Text = "GÜZELLİK SALONU";
            label1.Click += label1_Click_1;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.MistyRose;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe Script", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(257, 140);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(738, 125);
            textBox1.TabIndex = 7;
            textBox1.Text = "\"Kendime bakmanın rahatına düşkün olmadığına inanmaya başladım. Kendime bakmak bir hayatta kalma eylemidir. \" Audre Lorde";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Brown;
            ClientSize = new Size(1019, 587);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button button1;
        private Button button2;
        private Label label1;
        private TextBox textBox1;
    }
}