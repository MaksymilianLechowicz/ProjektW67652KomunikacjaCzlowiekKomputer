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
    public partial class Tablebrowse : Form
    {
        public static Tablebrowse instance;
        public Label titleofbrowse;
        public Label MotherLab;
        public Label FatherLab;
        public GroupBox browsebox;
        public PictureBox motbox;
        public PictureBox fatbox;
        public TextBox browstexbox;
        public Label outof;
        public int position;
        public string lablange;
        public Tablebrowse()
        {
            instance = this;
            InitializeComponent();
            titleofbrowse = label1;
            MotherLab = label2;
            FatherLab = label3;
            browsebox = groupBox1;
            motbox = pictureBox1;
            fatbox = pictureBox2;
            browstexbox = textBox1;
            outof = label4;
            position = 0;
            lablange = "Krzyzowka:  ";
        }

        private void button1_ClickLeft(object sender, EventArgs e)
        {
            Left();

        }

        private void button2_ClickRight(object sender, EventArgs e)
        {
            Right();
        }

        private void Tablebrowse_KeyDown(object sender, KeyEventArgs e)
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




        private void Left()
        {
            if (position != 0)
            {
                position--;
                Form1.instance.DGV1.Rows[position + 1].Selected = false;
                Form1.instance.DGV1.Rows[position].Selected = true;
                string filename = Form1.instance.DGV1[12, position].Value.ToString();
                StreamReader srtb = new StreamReader("Crossings_def\\" + filename);
                int rowminus = Form1.instance.DGV1.RowCount;
                label4.Text = position + 1 + "/" + rowminus;
                string canc = srtb.ReadLine();
                if (canc == "@1")
                {
                    titleofbrowse.Text = lablange + srtb.ReadLine();
                    MotherLab.Text = srtb.ReadLine();
                }
                else
                {
                    titleofbrowse.Text = lablange + canc;
                    MotherLab.Text = srtb.ReadLine();
                }
                try
                {
                    motbox.Image = Image.FromFile(srtb.ReadLine());
                }
                catch (Exception FileNotFoundException)
                {
                    motbox.Image = Image.FromFile("Conf\\zgubiony.jpg");
                }
                FatherLab.Text = srtb.ReadLine();
                try
                {
                    fatbox.Image = Image.FromFile(srtb.ReadLine());
                }
                catch (Exception FileNotFoundException)
                {
                    fatbox.Image = Image.FromFile("Conf\\zgubiony.jpg");
                }
                srtb.ReadLine();
                srtb.ReadLine();
                srtb.ReadLine();
                srtb.ReadLine();
                srtb.ReadLine();
                srtb.ReadLine();
                srtb.ReadLine();
                srtb.ReadLine();
                browstexbox.Text = "";
                int loop = Convert.ToInt32(srtb.ReadLine());
                for (int i = 0; i < loop; i++)
                {
                    browstexbox.Text += srtb.ReadLine();
                }
                srtb.Close();

            }
        }
        private void Right()
        {
            if (position != Form1.instance.DGV1.RowCount - 1)
            {
                position++;
                Form1.instance.DGV1.Rows[position - 1].Selected = false;
                Form1.instance.DGV1.Rows[position].Selected = true; //(position).Selected = true;
                string filename = Form1.instance.DGV1[12, position].Value.ToString();
                StreamReader srtb = new StreamReader("Crossings_def\\" + filename);
                int rowminus = Form1.instance.DGV1.RowCount;
                label4.Text = position + 1 + "/" + rowminus;
                string canc = srtb.ReadLine();
                if (canc == "@1")
                {
                    titleofbrowse.Text = lablange + srtb.ReadLine();
                    MotherLab.Text = srtb.ReadLine();
                }
                else
                {
                    titleofbrowse.Text = lablange + canc;
                    MotherLab.Text = srtb.ReadLine();
                }
                try
                {
                    motbox.Image = Image.FromFile(srtb.ReadLine());
                }
                catch (Exception FileNotFoundException)
                {
                    motbox.Image = Image.FromFile("Conf\\zgubiony.jpg");
                }
                FatherLab.Text = srtb.ReadLine();
                try
                {
                    fatbox.Image = Image.FromFile(srtb.ReadLine());
                }
                catch (Exception FileNotFoundException)
                {
                    fatbox.Image = Image.FromFile("Conf\\zgubiony.jpg");
                }
                srtb.ReadLine();
                srtb.ReadLine();
                srtb.ReadLine();
                srtb.ReadLine();
                srtb.ReadLine();
                srtb.ReadLine();
                srtb.ReadLine();
                srtb.ReadLine();
                browstexbox.Text = "";
                int loop = Convert.ToInt32(srtb.ReadLine());
                for (int i = 0; i < loop; i++)
                {
                    browstexbox.Text += srtb.ReadLine();
                }
                srtb.Close();
            }
        }

        private void Tablebrowse_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
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
