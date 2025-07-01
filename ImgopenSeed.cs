using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Krzyzak
{
    public partial class ImgopenSeed : Form
    {
        public static ImgopenSeed instance;
        public Label lab1;
        public Label lab2;
        public Label lab3;
        public Label lab4;
        public Label lab5;
        public Label lab6;
        public Label lab7;
        public Label lab8;
        public PictureBox ispb1;
        public PictureBox ispb2;
        public PictureBox ispb3;
        public PictureBox ispb4;
        public PictureBox ispb5;
        public PictureBox ispb6;
        public PictureBox ispb7;
        public int counthere;
        public int countend;


        public ImgopenSeed()
        {
            InitializeComponent();
            instance = this;
            lab1 = label1;
            lab2 = label2;
            lab3 = label3;
            lab4 = label4;
            lab5 = label5;
            lab6 = label6;
            lab7 = label7;
            lab8 = label8;
            ispb1 = pictureBox1;
            ispb2 = pictureBox2;
            ispb3 = pictureBox10;
            ispb4 = pictureBox9;
            ispb5 = pictureBox5;
            ispb6 = pictureBox15;
            ispb7 = pictureBox7;
            counthere = 0;
            countend = 0;
        }


        private void button1_ClickLeft(object sender, EventArgs e)
        {
            Left();
        }

        private void button2_ClickRight(object sender, EventArgs e)
        {
            Right();
        }
        private void Left()
        {
            if (counthere != 0)
            {
                label8.Text = counthere + "/" + countend;
                counthere--;

            }
            else
            {
                label8.Text = countend + "/" + countend;
                counthere = countend - 1;

            }
            pictureBox7.Image = Image.FromFile(Form1.instance.FileNames[counthere]);
            label7.Text = Form1.instance.TexCounter[counthere].Text;
        }
        private void Right()
        {
            counthere++;
            if (counthere < countend)
            {
                label8.Text = counthere + 1 + "/" + countend;

            }
            else
            {
                label8.Text = 1 + "/" + countend;
                counthere = 0;

            }
            pictureBox7.Image = Image.FromFile(Form1.instance.FileNames[counthere]);
            label7.Text = Form1.instance.TexCounter[counthere].Text;

        }

        private void ImgopenSeed_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                Left();
            }
            if (e.KeyCode == Keys.Right)
            {
                Right();
            }
            if (e.KeyCode == Keys.Down)
            {
                Left();
            }
            if (e.KeyCode == Keys.Up)
            {
                Right();
            }
        }

        private void button1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                Left();
            }
            if (e.KeyCode == Keys.Right)
            {
                Right();
            }
            if (e.KeyCode == Keys.Down)
            {
                Left();
            }
            if (e.KeyCode == Keys.Up)
            {
                Right();
            }
        }

        private void button2_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                Left();
            }
            if (e.KeyCode == Keys.Right)
            {
                Right();
            }
            if (e.KeyCode == Keys.Down)
            {
                Left();
            }
            if (e.KeyCode == Keys.Up)
            {
                Right();
            }
        }
    }
}
