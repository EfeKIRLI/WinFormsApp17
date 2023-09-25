namespace WinFormsApp17
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
            richTextBox1 = new RichTextBox();
            BtnA = new Button();
            BtnB = new Button();
            BtnD = new Button();
            BtnC = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            BtnSonraki = new Button();
            lblYanlis = new Label();
            lblDogru = new Label();
            lblSoru = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            lblCvp = new Label();
            lbl_Cvp_ver = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(1, 2);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(279, 193);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // BtnA
            // 
            BtnA.Location = new Point(24, 279);
            BtnA.Name = "BtnA";
            BtnA.Size = new Size(61, 36);
            BtnA.TabIndex = 1;
            BtnA.Text = "A";
            BtnA.UseVisualStyleBackColor = true;
            BtnA.Click += button1_Click;
            // 
            // BtnB
            // 
            BtnB.Location = new Point(100, 279);
            BtnB.Name = "BtnB";
            BtnB.Size = new Size(61, 36);
            BtnB.TabIndex = 2;
            BtnB.Text = "B";
            BtnB.UseVisualStyleBackColor = true;
            BtnB.Click += BtnB_Click;
            // 
            // BtnD
            // 
            BtnD.Location = new Point(100, 321);
            BtnD.Name = "BtnD";
            BtnD.Size = new Size(61, 36);
            BtnD.TabIndex = 4;
            BtnD.Text = "D";
            BtnD.UseVisualStyleBackColor = true;
            BtnD.Click += BtnD_Click;
            // 
            // BtnC
            // 
            BtnC.Location = new Point(24, 321);
            BtnC.Name = "BtnC";
            BtnC.Size = new Size(61, 36);
            BtnC.TabIndex = 3;
            BtnC.Text = "C";
            BtnC.UseVisualStyleBackColor = true;
            BtnC.Click += BtnC_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(199, 254);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 5;
            label1.Text = "Soru No:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(252, 295);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(209, 280);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 7;
            label3.Text = "Doğru:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(212, 306);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 8;
            label4.Text = "Yanlış:";
            // 
            // BtnSonraki
            // 
            BtnSonraki.Location = new Point(167, 201);
            BtnSonraki.Name = "BtnSonraki";
            BtnSonraki.Size = new Size(113, 28);
            BtnSonraki.TabIndex = 9;
            BtnSonraki.Text = "Sonraki";
            BtnSonraki.UseVisualStyleBackColor = true;
            BtnSonraki.Click += BtnSonraki_Click;
            // 
            // lblYanlis
            // 
            lblYanlis.AutoSize = true;
            lblYanlis.Location = new Point(272, 306);
            lblYanlis.Name = "lblYanlis";
            lblYanlis.Size = new Size(13, 15);
            lblYanlis.TabIndex = 12;
            lblYanlis.Text = "0";
            // 
            // lblDogru
            // 
            lblDogru.AutoSize = true;
            lblDogru.Location = new Point(272, 280);
            lblDogru.Name = "lblDogru";
            lblDogru.Size = new Size(13, 15);
            lblDogru.TabIndex = 11;
            lblDogru.Text = "0";
            // 
            // lblSoru
            // 
            lblSoru.AutoSize = true;
            lblSoru.Location = new Point(272, 254);
            lblSoru.Name = "lblSoru";
            lblSoru.Size = new Size(13, 15);
            lblSoru.TabIndex = 10;
            lblSoru.Text = "0";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(27, 201);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 53);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(100, 201);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 53);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            pictureBox2.Visible = false;
            // 
            // lblCvp
            // 
            lblCvp.AutoSize = true;
            lblCvp.Location = new Point(209, 359);
            lblCvp.Name = "lblCvp";
            lblCvp.Size = new Size(38, 15);
            lblCvp.TabIndex = 15;
            lblCvp.Text = "label5";
            // 
            // lbl_Cvp_ver
            // 
            lbl_Cvp_ver.AutoSize = true;
            lbl_Cvp_ver.Location = new Point(209, 394);
            lbl_Cvp_ver.Name = "lbl_Cvp_ver";
            lbl_Cvp_ver.Size = new Size(38, 15);
            lbl_Cvp_ver.TabIndex = 16;
            lbl_Cvp_ver.Text = "label5";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(312, 444);
            Controls.Add(lbl_Cvp_ver);
            Controls.Add(lblCvp);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(lblYanlis);
            Controls.Add(lblDogru);
            Controls.Add(lblSoru);
            Controls.Add(BtnSonraki);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BtnD);
            Controls.Add(BtnC);
            Controls.Add(BtnB);
            Controls.Add(BtnA);
            Controls.Add(richTextBox1);
            Name = "Form1";
            Text = "A";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button BtnA;
        private Button BtnB;
        private Button BtnD;
        private Button BtnC;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button BtnSonraki;
        private Label lblYanlis;
        private Label lblDogru;
        private Label lblSoru;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label lblCvp;
        private Label lbl_Cvp_ver;
    }
}