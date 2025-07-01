using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Krzyzak
{
    public partial class Konfiguracja : Form
    {
        public static Konfiguracja instance;
        public System.Windows.Forms.RadioButton rb1;
        public System.Windows.Forms.RadioButton rb2;
        public System.Windows.Forms.RadioButton rb3;
        public System.Windows.Forms.TextBox tbpar1;
        public System.Windows.Forms.TextBox tbpar2;
        public System.Windows.Forms.TextBox tbpar3;
        public System.Windows.Forms.TextBox tbpar4;
        public System.Windows.Forms.TextBox tbpar5;
        public System.Windows.Forms.TextBox tbpar6;
        public System.Windows.Forms.TextBox tbpar7;
        public System.Windows.Forms.TextBox tbpar8;
        public System.Windows.Forms.Label csvsep;
        public Konfiguracja()
        {
            InitializeComponent();
            instance = this;
            rb1 = radioButton1;
            rb2 = radioButton2;
            rb3 = radioButton3;
            tbpar1 = textBox44;
            tbpar2 = textBox9;
            tbpar3 = textBox11;
            tbpar4 = textBox10;
            tbpar5 = textBox13;
            tbpar6 = textBox12;
            tbpar7 = textBox16;
            tbpar8 = textBox15;
            csvsep = label1;
        }

        private string textHolder;
        public string ResultText
        {
            get => textHolder;
            set
            {
                textHolder = value;

            }
        }
        
        private void changlang(string path, int len)
        {
            string bufor;
            StreamReader file = new StreamReader(path);
            bufor = file.ReadLine();           // flaga
            Form1.instance.pbflag.Image = Image.FromFile("Conf\\" + bufor);
            bufor = file.ReadLine();
            Form1.instance.tp1.Text = bufor;
            Form1.instance.DGV1.Columns[0].HeaderText = bufor;
            Tablebrowse.instance.lablange = bufor + ":  ";
            bufor = file.ReadLine(); // table
            Form1.instance.tp2.Text = bufor;
            bufor = file.ReadLine();
            Form1.instance.par.Text = bufor;
            Tablebrowse.instance.browsebox.Text = bufor;
            bufor = file.ReadLine();
            Form1.instance.gparM.Text = bufor;
            bufor = file.ReadLine();
            Form1.instance.gparF.Text = bufor;
            bufor = file.ReadLine();
            Form1.instance.tbcross.PlaceholderText = bufor;
            bufor = file.ReadLine();
            Form1.instance.tb111.PlaceholderText = bufor;
            Form1.instance.tb211.PlaceholderText = bufor;
            Form1.instance.tb311.PlaceholderText = bufor;
            Form1.instance.tb411.PlaceholderText = bufor;
            Form1.instance.tb511.PlaceholderText = bufor;
            Form1.instance.tb611.PlaceholderText = bufor;
            bufor = file.ReadLine();
            Form1.instance.tbDesci.PlaceholderText = bufor;
            Form1.instance.DGV1.Columns[3].HeaderText = bufor;
            bufor = file.ReadLine();
            Form1.instance.Seed.Text = bufor;
            bufor = file.ReadLine();
            Form1.instance.langseed1 = bufor;
            for (int i = 0; i < Form1.instance.counter; i++)
            {
                Form1.instance.TexCounter[i].PlaceholderText = bufor;
            }
            bufor = file.ReadLine();
            Form1.instance.langseed2 = bufor;
            for (int i = 0; i < Form1.instance.counter; i++)
            {
                Form1.instance.DesCounter[i].PlaceholderText = bufor;
            }
            textBox44.PlaceholderText = file.ReadLine();
            textBox9.PlaceholderText = file.ReadLine();
            textBox11.PlaceholderText = file.ReadLine();
            textBox10.PlaceholderText = file.ReadLine();
            textBox13.PlaceholderText = file.ReadLine();
            textBox12.PlaceholderText = file.ReadLine();
            textBox16.PlaceholderText = file.ReadLine();
            textBox15.PlaceholderText = file.ReadLine();
            label1.Text = file.ReadLine();
            Form1.instance.tb4nametable.PlaceholderText = file.ReadLine();
            Form1.instance.DGV1.Columns[12].HeaderText = file.ReadLine();
            Form1.instance.DGV1.Columns[1].HeaderText = file.ReadLine();
            Form1.instance.DGV1.Columns[2].HeaderText = file.ReadLine();
            bufor = file.ReadLine();
            Form1.instance.mess = bufor;
            //Form1.groupBox2.Text = bufor;
            file.Close();
            //radioButton1.Checked = true;
            //radioButton2.Checked = false;
            //radioButton3.Checked = false;
            Form1.instance.lengudg = len;

        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            changlang("Conf\\Polski.lng", 0);
            
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
            changlang("Conf\\English.lng",1);
            
        }


        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            changlang("Conf\\українська.lng", 2);
        }

        private void Nazwa_krzyzowki_TextChanged(object sender, EventArgs e)
        {

        }

        private void SaveConfig_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter("Conf\\Config.ini"))
            {
                sw.WriteLine(Form1.instance.lengudg);
                sw.WriteLine(textBox44.Text);
                sw.WriteLine(textBox9.Text);
                sw.WriteLine(textBox11.Text);
                sw.WriteLine(textBox10.Text);
                sw.WriteLine(textBox13.Text);
                sw.WriteLine(textBox12.Text);
                sw.WriteLine(textBox16.Text);
                sw.WriteLine(textBox15.Text);
                sw.WriteLine(textBox1.Text);
                sw.Close();
            }
            Form1.instance.tbpar11.PlaceholderText = textBox44.Text;
            Form1.instance.tbpar21.PlaceholderText = textBox9.Text;
            Form1.instance.tbpar31.PlaceholderText = textBox11.Text;
            Form1.instance.tbpar41.PlaceholderText = textBox10.Text;
            Form1.instance.tbpar51.PlaceholderText = textBox13.Text;
            Form1.instance.tbpar61.PlaceholderText = textBox12.Text;
            Form1.instance.tbpar71.PlaceholderText = textBox16.Text;
            Form1.instance.tbpar81.PlaceholderText = textBox15.Text;
            if(Form1.instance.tbpar11.PlaceholderText == "")
            {
                Form1.instance.tbpar11.PlaceholderText = textBox44.PlaceholderText;
            }
            if (Form1.instance.tbpar21.PlaceholderText == "")
            {
                Form1.instance.tbpar21.PlaceholderText = textBox9.PlaceholderText;
            }
            if (Form1.instance.tbpar31.PlaceholderText == "")
            {
                Form1.instance.tbpar31.PlaceholderText = textBox11.PlaceholderText;
            }
            if (Form1.instance.tbpar41.PlaceholderText == "")
            {
                Form1.instance.tbpar41.PlaceholderText = textBox10.PlaceholderText;
            }
            if (Form1.instance.tbpar51.PlaceholderText == "")
            {
                Form1.instance.tbpar51.PlaceholderText = textBox13.PlaceholderText;
            }
            if (Form1.instance.tbpar61.PlaceholderText == "")
            {
                Form1.instance.tbpar61.PlaceholderText = textBox12.PlaceholderText;
            }
            if (Form1.instance.tbpar71.PlaceholderText == "")
            {
                Form1.instance.tbpar71.PlaceholderText = textBox16.PlaceholderText;
            }
            if (Form1.instance.tbpar81.PlaceholderText == "")
            {
                Form1.instance.tbpar81.PlaceholderText = textBox15.PlaceholderText;
            }
            Form1.instance.K1.Hide();
        }
    }
}
