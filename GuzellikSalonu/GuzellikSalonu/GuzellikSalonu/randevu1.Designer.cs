namespace GuzellikSalonu
{
    partial class randevu1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(randevu1));
            pictureBox1 = new PictureBox();
            button2 = new Button();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            maskedTextBox1 = new MaskedTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            pictureBox2 = new PictureBox();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(825, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(265, 471);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.RosyBrown;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Lucida Handwriting", 11F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.LavenderBlush;
            button2.Location = new Point(419, 358);
            button2.Name = "button2";
            button2.Size = new Size(270, 74);
            button2.TabIndex = 2;
            button2.Text = "RANDEVU OLUŞTUR";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(534, 91);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 3;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(534, 153);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(182, 33);
            comboBox2.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(534, 214);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(182, 31);
            dateTimePicker1.TabIndex = 5;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(534, 267);
            maskedTextBox1.Mask = "90:00";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(182, 31);
            maskedTextBox1.TabIndex = 6;
            maskedTextBox1.ValidatingType = typeof(DateTime);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Brown;
            label1.Font = new Font("Tekton Pro", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(364, 91);
            label1.Name = "label1";
            label1.Size = new Size(82, 29);
            label1.TabIndex = 7;
            label1.Text = "İŞLEM:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Brown;
            label2.Font = new Font("Tekton Pro", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(343, 154);
            label2.Name = "label2";
            label2.Size = new Size(128, 29);
            label2.TabIndex = 8;
            label2.Text = "PERSONEL:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Brown;
            label3.Font = new Font("Tekton Pro", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(366, 214);
            label3.Name = "label3";
            label3.Size = new Size(80, 29);
            label3.TabIndex = 9;
            label3.Text = "TARİH:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Brown;
            label4.Font = new Font("Tekton Pro", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.WhiteSmoke;
            label4.Location = new Point(372, 268);
            label4.Name = "label4";
            label4.Size = new Size(74, 29);
            label4.TabIndex = 10;
            label4.Text = "SAAT:";
            label4.Click += label4_Click;
            // 
            // button1
            // 
            button1.ForeColor = Color.Crimson;
            button1.Location = new Point(404, 438);
            button1.Name = "button1";
            button1.Size = new Size(148, 76);
            button1.TabIndex = 11;
            button1.Text = "RANDEVU TABLOSU";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 25);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(263, 502);
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // button3
            // 
            button3.ForeColor = Color.Crimson;
            button3.Location = new Point(568, 438);
            button3.Name = "button3";
            button3.Size = new Size(148, 76);
            button3.TabIndex = 13;
            button3.Text = "ÇIKIŞ";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // randevu1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Brown;
            ClientSize = new Size(1139, 539);
            Controls.Add(button3);
            Controls.Add(pictureBox2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(maskedTextBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(button2);
            Controls.Add(pictureBox1);
            Name = "randevu1";
            Text = "randevu1";
            Load += randevu1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button2;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private DateTimePicker dateTimePicker1;
        private MaskedTextBox maskedTextBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private PictureBox pictureBox2;
        private Button button3;
    }
}