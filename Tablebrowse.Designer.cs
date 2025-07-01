namespace Krzyzak
{
    partial class Tablebrowse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tablebrowse));
            pictureBox2 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            groupBox1 = new GroupBox();
            pictureBox14 = new PictureBox();
            pictureBox9 = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(376, 22);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(300, 200);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 235);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 3;
            label2.Text = "Placeholder";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(376, 235);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 4;
            label3.Text = "Placeholder";
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(538, 12);
            button1.Name = "button1";
            button1.Size = new Size(47, 46);
            button1.TabIndex = 5;
            button1.TabStop = false;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_ClickLeft;
            button1.PreviewKeyDown += button1_PreviewKeyDown;
            // 
            // button2
            // 
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(657, 12);
            button2.Name = "button2";
            button2.Size = new Size(46, 46);
            button2.TabIndex = 6;
            button2.TabStop = false;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_ClickRight;
            button2.PreviewKeyDown += button2_PreviewKeyDown;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(5, 348);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(698, 133);
            textBox1.TabIndex = 7;
            textBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox14);
            groupBox1.Controls.Add(pictureBox9);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Location = new Point(12, 64);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(691, 265);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Rodzice";
            // 
            // pictureBox14
            // 
            pictureBox14.Image = (Image)resources.GetObject("pictureBox14.Image");
            pictureBox14.Location = new Point(376, 22);
            pictureBox14.Name = "pictureBox14";
            pictureBox14.Size = new Size(23, 23);
            pictureBox14.TabIndex = 17;
            pictureBox14.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.ErrorImage = null;
            pictureBox9.Image = (Image)resources.GetObject("pictureBox9.Image");
            pictureBox9.Location = new Point(38, 22);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(21, 34);
            pictureBox9.TabIndex = 11;
            pictureBox9.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(38, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(300, 200);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(50, 28);
            label1.Name = "label1";
            label1.Size = new Size(80, 19);
            label1.TabIndex = 9;
            label1.Text = "Krzyzowka:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(591, 31);
            label4.Name = "label4";
            label4.Size = new Size(24, 15);
            label4.TabIndex = 10;
            label4.Text = "1/1";
            // 
            // Tablebrowse
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(714, 493);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Tablebrowse";
            StartPosition = FormStartPosition.CenterParent;
            KeyDown += Tablebrowse_KeyDown;
            PreviewKeyDown += Tablebrowse_PreviewKeyDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox2;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label4;
        private PictureBox pictureBox9;
        private PictureBox pictureBox14;
    }
}