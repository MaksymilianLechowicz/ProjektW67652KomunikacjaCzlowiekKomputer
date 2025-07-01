using Microsoft.Win32.SafeHandles;
using System.Diagnostics.Metrics;
using System.Drawing.Imaging;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using System.Text.Json.Nodes;
using GroqApiLibrary;

namespace Krzyzak
{
    public partial class Form1 : Form
    {
        public int counter = 0;
        public static Form1 instance;
        public TabPage tp1;
        public TabPage tp2;
        public Panel p1;
        public PictureBox pbflag;
        public PictureBox pbleft;
        public GroupBox par;
        public GroupBox gparM;
        public GroupBox gparF;
        public TextBox tbcross;
        public TextBox tb111;
        public TextBox tb211;
        public TextBox tb311;
        public TextBox tb411;
        public TextBox tb511;
        public TextBox tb611;
        public TextBox tbpar11;
        public TextBox tbpar21;
        public TextBox tbpar31;
        public TextBox tbpar41;
        public TextBox tbpar51;
        public TextBox tbpar61;
        public TextBox tbpar71;
        public TextBox tbpar81;
        public TextBox tbDesci;
        public TextBox tb4nametable;
        public Label Seed;
        public DataGridView DGV1;
        public PictureBox[] PicCounter = new PictureBox[1];
        public TextBox[] TexCounter = new TextBox[1];
        public TextBox[] DesCounter = new TextBox[1];
        public Button[] ButtCounter = new Button[1];
        public string[] FileNames = new string[1];
        public string[] FileNamesParents = new string[6] { "Conf\\NN.jpg", "Conf\\NN.jpg", "Conf\\NN.jpg", "Conf\\NN.jpg", "Conf\\NN.jpg", "Conf\\NN.jpg" };
        public string langseed1 = "Symbol Siewki";
        public string langseed2 = "Opis Siewki";
        public int lengudg = 0;
        public int helper = 0;
        public string separator;
        public ImgopenSeed IO2 = new ImgopenSeed();
        public Tablebrowse TBB2 = new Tablebrowse();
        public Konfiguracja K1 = new Konfiguracja();

        private static string apiKey = "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";
        private GroqApiClient groqApi = new GroqApiClient(apiKey);
        private string? newImgImgMessage;
        public string? ImgForAI1;
        public string? ImgForAI2;
        public string firstmessage;
        public string secondmessage;
        public string pathmessage;
        public Form1()


        {
            InitializeComponent();
            instance = this;
            tp1 = Krzyzowka;
            tp2 = Tabela;
            p1 = panel1;
            tb111 = textBox6;
            tb211 = textBox5;
            tb311 = textBox1;
            tb411 = textBox3;
            tb511 = textBox2;
            tb611 = textBox8;
            tbDesci = textBox7;
            Seed = label1;
            par = groupBox3;
            gparM = groupBox2;
            gparF = groupBox1;
            tbcross = textBox14;
            pbflag = pictureBox13;
            pbleft = pictureBox16;
            tbpar11 = textBox21;
            tbpar21 = textBox9;
            tbpar31 = textBox11;
            tbpar41 = textBox10;
            tbpar51 = textBox13;
            tbpar61 = textBox12;
            tbpar71 = textBox16;
            tbpar81 = textBox15;
            tb4nametable = textBox4;
            DGV1 = dataGridView1;
            
        }
        public int l = 190;
        public string mess;



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            try
            {
                Imgopen.instance.pb1.Image = Image.FromFile(FileNamesParents[4]);
            }
            catch (System.IO.FileNotFoundException)
            {
                Imgopen.instance.pb1.Image = Image.FromFile("Conf\\zgubiony.jpg");
            }
            IO1.ShowDialog();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            try
            {
                Imgopen.instance.pb1.Image = Image.FromFile(FileNamesParents[2]);
            }
            catch (System.IO.FileNotFoundException)
            {
                Imgopen.instance.pb1.Image = Image.FromFile("Conf\\zgubiony.jpg");
            }
            IO1.ShowDialog();
        }

        private void Krzyzowka_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        Authors A1 = new Authors();
        private void button12_Click(object sender, EventArgs e)
        {

            if (lengudg == 0)
            {
                Konfiguracja.instance.rb1.Checked = true;
                Konfiguracja.instance.rb2.Checked = false;
                Konfiguracja.instance.rb3.Checked = false;
            }
            else if (lengudg == 1)
            {
                Konfiguracja.instance.rb1.Checked = false;
                Konfiguracja.instance.rb2.Checked = true;
                Konfiguracja.instance.rb3.Checked = false;
            }
            else
            {
                Konfiguracja.instance.rb1.Checked = false;
                Konfiguracja.instance.rb2.Checked = false;
                Konfiguracja.instance.rb3.Checked = true;
            }
            StreamReader file21 = new StreamReader("Conf\\Config.ini");
            file21.ReadLine();
            Konfiguracja.instance.tbpar1.Text = file21.ReadLine();
            Konfiguracja.instance.tbpar2.Text = file21.ReadLine();
            Konfiguracja.instance.tbpar3.Text = file21.ReadLine();
            Konfiguracja.instance.tbpar4.Text = file21.ReadLine();
            Konfiguracja.instance.tbpar5.Text = file21.ReadLine();
            Konfiguracja.instance.tbpar6.Text = file21.ReadLine();
            Konfiguracja.instance.tbpar7.Text = file21.ReadLine();
            Konfiguracja.instance.tbpar8.Text = file21.ReadLine();
            file21.Close();
            K1.ShowDialog();
        }


        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            try
            {
                Imgopen.instance.pb1.Image = Image.FromFile(FileNamesParents[3]);
            }
            catch (System.IO.FileNotFoundException)
            {
                Imgopen.instance.pb1.Image = Image.FromFile("Conf\\zgubiony.jpg");
            }
            IO1.ShowDialog();
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            GMM GMM1 = new GMM(textBox1, pictureBox1, pictureBox9, button10);
            GMM1.openNScale();
            //string file_name_img;
            // if (Open_graphics.ShowDialog() == DialogResult.OK)
            //{
            //file_name_img = Open_graphics.FileName;
            //pictureBox1.Image = Image.FromFile(file_name_img);
            //int hf = pictureBox1.Image.Height;
            //int wf = pictureBox1.Image.Width;
            //int h = pictureBox1.Height;
            //int w = pictureBox1.Width;
            //int scale = 0;


            //float s1 = hf / h;
            //float s2 = wf / w;
            //if (s1 < 0)
            //{
            //    s1 = h / hf;
            //}
            //if (s2 < 0)
            //{
            //    s2 = w / wf;
            //}
            //
            //if (s1 > s2)
            //{
            //   scale = (int)Math.Round(s1);
            //}
            //else
            //{
            //    scale = (int)Math.Round(s2);
            //}
            //if (scale == 0)
            //    scale = 1;
            //Bitmap bmpDest;
            //using (Bitmap bmpOrig = new Bitmap(file_name_img))
            //{
            //    bmpDest = new Bitmap(bmpOrig, new Size(wf / scale, hf / scale));
            //}
            //bmpDest.Save("file300.jpg", ImageFormat.Jpeg);
            //pictureBox1.Image = Image.FromFile("file300.jpg");
            //pictureBox1.Image = bmpDest;


            //}
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                Imgopen.instance.pb1.Image = Image.FromFile(FileNamesParents[0]);
            }
            catch (System.IO.FileNotFoundException)
            {
                Imgopen.instance.pb1.Image = Image.FromFile("Conf\\zgubiony.jpg");
            }
            IO1.ShowDialog();

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }




        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

            int ydd = (counter + 1) / 5;
            //Size = new Size(Width,Height+200* ydd);

            //Tabela.Size = new Size(1000, 200 * (ydd + 3));
            panel1.Size = new Size(panel1.Width, 200 * (ydd + 2));
            ListFrag chekc = new ListFrag();
            chekc.CreateBox();
            button13.Location = new Point(l * ((counter + 1) % 5), l * ((counter + 1) / 5));
            counter++;


        }

        private void button7_Click(object sender, EventArgs e)
        {
            GPM GPM1 = new GPM(textBox3, pictureBox6, pictureBox12, button7);
            GPM1.openNScale();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public void PicBoxClick(object sender, EventArgs e)
        {
            Imgopen IO1 = new Imgopen();
            Imgopen.instance.pb1.Image = pictureBox1.Image;
            IO1.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            GMF GMF1 = new GMF(textBox2, pictureBox2, pictureBox10, button9);
            GMF1.openNScale();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            GPF GPF1 = new GPF(textBox8, pictureBox7, pictureBox11, button8);
            GPF1.openNScale();
        }

        private void Clearform(object sender, EventArgs e)
        {
            string message = mess;
            string title = "";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                //Application.Restart();
                //this.Hide();
                //Form1 F2 = new Form1();
                //F2.ShowDialog();
                //this.Close();
                for (int i = 0; i < counter; i++)
                {
                    PicCounter[i].Dispose();
                    TexCounter[i].Dispose();
                    DesCounter[i].Dispose();
                    ButtCounter[i].Dispose();
                }
                button13.Location = new Point(43, 43);
                counter = 0;
                pictureBox1.Image = Image.FromFile("Conf/NN.jpg");
                pictureBox2.Image = Image.FromFile("Conf/NN.jpg");
                pictureBox4.Image = Image.FromFile("Conf/NN.jpg");
                pictureBox5.Image = Image.FromFile("Conf/NN.jpg");
                pictureBox6.Image = Image.FromFile("Conf/NN.jpg");
                pictureBox7.Image = Image.FromFile("Conf/NN.jpg");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
                textBox9.Text = "";
                textBox10.Text = "";
                textBox11.Text = "";
                textBox12.Text = "";
                textBox13.Text = "";
                textBox14.Text = "";
                textBox15.Text = "";
                textBox16.Text = "";
                textBox21.Text = "";
                Array.Resize(ref TexCounter, 1);
                Array.Resize(ref PicCounter, 1);
                Array.Resize(ref DesCounter, 1);
                Array.Resize(ref ButtCounter, 1);
                Array.Resize(ref FileNames, 1);
            }


        }

        private void button6_Click(object sender, EventArgs e)
        {
            Father Fath1 = new Father(textBox5, pictureBox4, pictureBox14, button6);
            Fath1.openNScale();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Mother Moth1 = new Mother(textBox6, pictureBox5, pictureBox15, button5);
            Moth1.openNScale();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Save_Def.InitialDirectory = Environment.CurrentDirectory + "\\Crossings_def";
            Save_Def.FileName = textBox14.Text;
            string file_namesave;
            if (Save_Def.ShowDialog() == DialogResult.OK)

            {
                file_namesave = Save_Def.FileName;


                using (StreamWriter sw = new StreamWriter(file_namesave))
                {
                    sw.WriteLine("@1");
                    sw.WriteLine(textBox14.Text);
                    sw.WriteLine(textBox6.Text);
                    sw.WriteLine(FileNamesParents[2]);
                    sw.WriteLine(textBox5.Text);
                    sw.WriteLine(FileNamesParents[3]);
                    sw.WriteLine(textBox1.Text);
                    sw.WriteLine(FileNamesParents[0]);
                    sw.WriteLine(textBox2.Text);
                    sw.WriteLine(FileNamesParents[1]);
                    sw.WriteLine(textBox3.Text);
                    sw.WriteLine(FileNamesParents[4]);
                    sw.WriteLine(textBox8.Text);
                    sw.WriteLine(FileNamesParents[5]);
                    int tbl = textBox7.Lines.Count();
                    sw.WriteLine(tbl);
                    foreach (string line in textBox7.Lines)
                    {
                        sw.WriteLine(line);
                    }
                    sw.WriteLine(counter);
                    for (int i = 0; i < counter; i++)
                    {
                        sw.WriteLine(TexCounter[i].Text);
                        sw.WriteLine(FileNames[i]);
                        int tbltt = DesCounter[i].Lines.Count();
                        sw.WriteLine(tbltt);
                        foreach (string line in DesCounter[i].Lines)
                        {
                            sw.WriteLine(line);
                        }
                    }
                    sw.WriteLine(textBox21.Text);
                    sw.WriteLine(textBox9.Text);
                    sw.WriteLine(textBox11.Text);
                    sw.WriteLine(textBox10.Text);
                    sw.WriteLine(textBox13.Text);
                    sw.WriteLine(textBox12.Text);
                    sw.WriteLine(textBox16.Text);
                    sw.WriteLine(textBox15.Text);
                    sw.Close();
                }
            }


        }


        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        Imgopen IO1 = new Imgopen();

        private void button2_Click(object sender, EventArgs e)
        {
            Open_definition.InitialDirectory = Environment.CurrentDirectory + "\\Crossings_def";
            string filename;
            if (Open_definition.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < counter; i++)
                {
                    PicCounter[i].Dispose();
                    TexCounter[i].Dispose();
                    DesCounter[i].Dispose();
                    ButtCounter[i].Dispose();
                }
                button13.Location = new Point(43, 43);
                counter = 0;
                Array.Resize(ref TexCounter, 1);
                Array.Resize(ref PicCounter, 1);
                Array.Resize(ref DesCounter, 1);
                Array.Resize(ref ButtCounter, 1);
                Array.Resize(ref FileNames, 1);
                filename = Open_definition.FileName;
                StreamReader file = new StreamReader(filename);
                string ver = file.ReadLine();
                string ehe;
                if (ver == "@1")
                {
                    textBox14.Text = file.ReadLine();
                    textBox6.Text = file.ReadLine();
                    ehe = file.ReadLine();
                    scaler sc1 = new scaler(ehe, pictureBox5);
                    sc1.scale();
                    FileNamesParents[2] = ehe;
                    textBox5.Text = file.ReadLine();
                    ehe = file.ReadLine();
                    scaler sc2 = new scaler(ehe, pictureBox4);
                    sc2.scale();
                    FileNamesParents[3] = ehe;
                    textBox1.Text = file.ReadLine();
                    ehe = file.ReadLine();
                    scaler sc3 = new scaler(ehe, pictureBox1);
                    sc3.scale();
                    FileNamesParents[0] = ehe;
                    textBox2.Text = file.ReadLine();
                    ehe = file.ReadLine();
                    scaler sc4 = new scaler(ehe, pictureBox2);
                    sc4.scale();
                    FileNamesParents[1] = ehe;
                    textBox3.Text = file.ReadLine();
                    ehe = file.ReadLine();
                    scaler sc5 = new scaler(ehe, pictureBox6);
                    sc5.scale();
                    FileNamesParents[4] = ehe;
                    textBox8.Text = file.ReadLine();
                    ehe = file.ReadLine();
                    scaler sc6 = new scaler(ehe, pictureBox7);
                    sc6.scale();
                    FileNamesParents[5] = ehe;
                    int coun = Convert.ToInt32(file.ReadLine());
                    textBox7.Text = "";
                    for (int i = 0; i < coun; i++)
                    {
                        textBox7.Text += file.ReadLine() + "\r\n";
                    }
                    int helpcounter = Convert.ToInt32(file.ReadLine());
                    while (counter < helpcounter)
                    {
                        int ydd = (counter + 1) / 5;

                        panel1.Size = new Size(panel1.Width, 200 * (ydd + 2));
                        ListFrag chekc = new ListFrag();
                        chekc.CreateBox();
                        button13.Location = new Point(l * ((counter + 1) % 5), l * ((counter + 1) / 5));
                        TexCounter[counter].Text = file.ReadLine();
                        string eheh = file.ReadLine();
                        FileNames[counter] = eheh;
                        try
                        {
                            PicCounter[counter].Image = Image.FromFile(eheh);
                        }
                        catch (System.IO.FileNotFoundException)
                        {
                            PicCounter[counter].Image = Image.FromFile("Conf\\zgubiony.jpg");
                        }
                        /*int hf = PicCounter[counter].Image.Height;
                        int wf = PicCounter[counter].Image.Width;
                        int h = PicCounter[counter].Height;
                        int w = PicCounter[counter].Width;
                        int scale = 0;


                        float s1 = hf / h;
                        float s2 = wf / w;
                        if (s1 < 0)
                        {
                            s1 = h / hf;
                        }
                        if (s2 < 0)
                        {
                            s2 = w / wf;
                        }

                        if (s1 > s2)
                        {
                            scale = (int)Math.Round(s1);
                        }
                        else
                        {
                            scale = (int)Math.Round(s2);
                        }
                        if (scale == 0)
                            scale = 1;
                        */
                        //Bitmap bmpDest;
                        //using (Bitmap bmpOrig = new Bitmap(eheh))
                        //{
                        //    bmpDest = new Bitmap(bmpOrig.Width, bmpOrig.Height);
                        //}
                        //PicCounter[counter].Image = bmpDest;
                        int chech = Convert.ToInt32(file.ReadLine());
                        DesCounter[counter].Text = "";
                        for (int j = 0; j < chech; j++)
                        {
                            DesCounter[counter].Text += file.ReadLine() + "\r\n";
                        }
                        counter++;
                    }
                    textBox21.Text = file.ReadLine();
                    textBox9.Text = file.ReadLine();
                    textBox11.Text = file.ReadLine();
                    textBox10.Text = file.ReadLine();
                    textBox13.Text = file.ReadLine();
                    textBox12.Text = file.ReadLine();
                    textBox16.Text = file.ReadLine();
                    textBox15.Text = file.ReadLine();
                    file.Close();
                }
                else
                {
                    textBox14.Text = ver;
                    textBox6.Text = file.ReadLine();
                    ehe = file.ReadLine();
                    scaler sc1 = new scaler(ehe, pictureBox5);
                    sc1.scale();
                    FileNamesParents[2] = ehe;
                    textBox5.Text = file.ReadLine();
                    ehe = file.ReadLine();
                    scaler sc2 = new scaler(ehe, pictureBox4);
                    sc2.scale();
                    FileNamesParents[3] = ehe;
                    textBox1.Text = file.ReadLine();
                    ehe = file.ReadLine();
                    scaler sc3 = new scaler(ehe, pictureBox1);
                    sc3.scale();
                    FileNamesParents[0] = ehe;
                    textBox2.Text = file.ReadLine();
                    ehe = file.ReadLine();
                    scaler sc4 = new scaler(ehe, pictureBox2);
                    sc4.scale();
                    FileNamesParents[1] = ehe;
                    textBox3.Text = file.ReadLine();
                    ehe = file.ReadLine();
                    scaler sc5 = new scaler(ehe, pictureBox6);
                    sc5.scale();
                    FileNamesParents[4] = ehe;
                    textBox8.Text = file.ReadLine();
                    ehe = file.ReadLine();
                    scaler sc6 = new scaler(ehe, pictureBox7);
                    sc6.scale();
                    FileNamesParents[5] = ehe;
                    int coun = Convert.ToInt32(file.ReadLine());
                    textBox7.Text = "";
                    for (int i = 0; i < coun; i++)
                    {
                        textBox7.Text += file.ReadLine() + "\r\n";
                    }
                    int helpcounter = Convert.ToInt32(file.ReadLine());
                    while (counter < helpcounter)
                    {
                        int ydd = (counter + 1) / 5;

                        panel1.Size = new Size(panel1.Width, 200 * (ydd + 2));
                        ListFrag chekc = new ListFrag();
                        chekc.CreateBox();
                        button13.Location = new Point(l * ((counter + 1) % 5), l * ((counter + 1) / 5));
                        TexCounter[counter].Text = file.ReadLine();
                        string eheh = file.ReadLine();
                        FileNames[counter] = eheh;
                        try
                        {
                            PicCounter[counter].Image = Image.FromFile(eheh);
                        }
                        catch (Exception FileNotFoundException)
                        {
                            PicCounter[counter].Image = Image.FromFile("Conf\\zgubiony.jpg");
                        }

                        /*
                        int hf = PicCounter[counter].Image.Height;
                        int wf = PicCounter[counter].Image.Width;
                        int h = PicCounter[counter].Height;
                        int w = PicCounter[counter].Width;
                        int scale = 0;


                        float s1 = hf / h;
                        float s2 = wf / w;
                        if (s1 < 0)
                        {
                            s1 = h / hf;
                        }
                        if (s2 < 0)
                        {
                            s2 = w / wf;
                        }

                        if (s1 > s2)
                        {
                            scale = (int)Math.Round(s1);
                        }
                        else
                        {
                            scale = (int)Math.Round(s2);
                        }
                        if (scale == 0)
                            scale = 1;
                        */
                        //Bitmap bmpDest;
                        //using (Bitmap bmpOrig = new Bitmap(eheh))
                        //{
                        //    bmpDest = new Bitmap(bmpOrig.Width, bmpOrig.Height);
                        //}
                        //PicCounter[counter].Image = bmpDest;
                        int chech = Convert.ToInt32(file.ReadLine());
                        DesCounter[counter].Text = "";
                        for (int j = 0; j < chech; j++)
                        {
                            DesCounter[counter].Text += file.ReadLine() + "\r\n";
                        }
                        counter++;
                    }
                    textBox21.Text = file.ReadLine();
                    textBox9.Text = file.ReadLine();
                    textBox11.Text = file.ReadLine();
                    textBox10.Text = file.ReadLine();
                    file.Close();
                }

            }
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            StreamReader file21 = new StreamReader("Conf\\Config.ini");
            lengudg = Convert.ToInt32(file21.ReadLine());
            string bufor = file21.ReadLine();
            textBox21.PlaceholderText = bufor;
            dataGridView1.Columns[4].HeaderText = bufor;
            bufor = file21.ReadLine();
            textBox9.PlaceholderText = bufor;
            dataGridView1.Columns[5].HeaderText = bufor;
            bufor = file21.ReadLine();
            textBox11.PlaceholderText = bufor;
            dataGridView1.Columns[6].HeaderText = bufor;
            bufor = file21.ReadLine();
            textBox10.PlaceholderText = bufor;
            dataGridView1.Columns[7].HeaderText = bufor;
            bufor = file21.ReadLine();
            textBox13.PlaceholderText = bufor;
            dataGridView1.Columns[8].HeaderText = bufor;
            bufor = file21.ReadLine();
            textBox12.PlaceholderText = bufor;
            dataGridView1.Columns[9].HeaderText = bufor;
            bufor = file21.ReadLine();
            textBox16.PlaceholderText = bufor;
            dataGridView1.Columns[10].HeaderText = bufor;
            bufor = file21.ReadLine();
            textBox15.PlaceholderText = bufor;
            dataGridView1.Columns[11].HeaderText = bufor;
            separator = file21.ReadLine();
            file21.Close();
            if (lengudg == 0)
            {
                loadfrom(0, "Polski.lng");

            }
            else if (lengudg == 1)
            {
                loadfrom(1, "English.lng");

            }
            else if (lengudg == 2)
            {
                loadfrom(2, "українська.lng");

            }
            if (textBox21.PlaceholderText == "")
            {
                textBox21.PlaceholderText = Konfiguracja.instance.tbpar1.PlaceholderText;

            }
            if (textBox9.PlaceholderText == "")
            {
                textBox9.PlaceholderText = Konfiguracja.instance.tbpar2.PlaceholderText;

            }
            if (textBox11.PlaceholderText == "")
            {
                textBox11.PlaceholderText = Konfiguracja.instance.tbpar3.PlaceholderText;

            }
            if (textBox10.PlaceholderText == "")
            {
                textBox10.PlaceholderText = Konfiguracja.instance.tbpar4.PlaceholderText;

            }
            if (textBox13.PlaceholderText == "")
            {
                textBox13.PlaceholderText = Konfiguracja.instance.tbpar5.PlaceholderText;

            }
            if (textBox12.PlaceholderText == "")
            {
                textBox12.PlaceholderText = Konfiguracja.instance.tbpar6.PlaceholderText;

            }
            if (textBox16.PlaceholderText == "")
            {
                textBox16.PlaceholderText = Konfiguracja.instance.tbpar7.PlaceholderText;

            }
            if (textBox15.PlaceholderText == "")
            {
                textBox15.PlaceholderText = Konfiguracja.instance.tbpar8.PlaceholderText;

            }
            // column parameters
            if (dataGridView1.Columns[4].HeaderText == "")
            {
                dataGridView1.Columns[4].HeaderText = Konfiguracja.instance.tbpar1.PlaceholderText;
            }
            if (dataGridView1.Columns[5].HeaderText == "")
            {
                dataGridView1.Columns[5].HeaderText = Konfiguracja.instance.tbpar2.PlaceholderText;
            }
            if (dataGridView1.Columns[6].HeaderText == "")
            {
                dataGridView1.Columns[6].HeaderText = Konfiguracja.instance.tbpar3.PlaceholderText;
            }
            if (dataGridView1.Columns[7].HeaderText == "")
            {
                dataGridView1.Columns[7].HeaderText = Konfiguracja.instance.tbpar4.PlaceholderText;
            }
            if (dataGridView1.Columns[8].HeaderText == "")
            {
                dataGridView1.Columns[8].HeaderText = Konfiguracja.instance.tbpar5.PlaceholderText;
            }
            if (dataGridView1.Columns[9].HeaderText == "")
            {
                dataGridView1.Columns[9].HeaderText = Konfiguracja.instance.tbpar6.PlaceholderText;
            }
            if (dataGridView1.Columns[10].HeaderText == "")
            {
                dataGridView1.Columns[10].HeaderText = Konfiguracja.instance.tbpar7.PlaceholderText;
            }
            if (dataGridView1.Columns[11].HeaderText == "")
            {
                dataGridView1.Columns[11].HeaderText = Konfiguracja.instance.tbpar8.PlaceholderText;
            }


        }
        public void loadfrom(int b, string langg)
        {
            string bufor;
            StreamReader file = new StreamReader("Conf\\" + langg);
            bufor = file.ReadLine();           // flaga
            Form1.instance.pbflag.Image = Image.FromFile("Conf\\" + bufor);
            bufor = file.ReadLine();
            Form1.instance.tp1.Text = bufor;
            dataGridView1.Columns[0].HeaderText = bufor;
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
            dataGridView1.Columns[3].HeaderText = bufor;
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
            Konfiguracja.instance.tbpar1.PlaceholderText = file.ReadLine();
            Konfiguracja.instance.tbpar2.PlaceholderText = file.ReadLine();
            Konfiguracja.instance.tbpar3.PlaceholderText = file.ReadLine();
            Konfiguracja.instance.tbpar4.PlaceholderText = file.ReadLine();
            Konfiguracja.instance.tbpar5.PlaceholderText = file.ReadLine();
            Konfiguracja.instance.tbpar6.PlaceholderText = file.ReadLine();
            Konfiguracja.instance.tbpar7.PlaceholderText = file.ReadLine();
            Konfiguracja.instance.tbpar8.PlaceholderText = file.ReadLine();
            Konfiguracja.instance.csvsep.Text = file.ReadLine();
            textBox4.PlaceholderText = file.ReadLine();
            dataGridView1.Columns[12].HeaderText = file.ReadLine();
            dataGridView1.Columns[1].HeaderText = file.ReadLine();
            dataGridView1.Columns[2].HeaderText = file.ReadLine();
            bufor = file.ReadLine();
            Form1.instance.mess = bufor;
            //Form1.groupBox2.Text = bufor;
            file.Close();
            //radioButton1.Checked = false;
            //radioButton2.Checked = false;
            //radioButton3.Checked = true;
            Form1.instance.lengudg = b;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Table_AddItems.InitialDirectory = Environment.CurrentDirectory + "\\Crossings_def";
            if (Table_AddItems.ShowDialog() == DialogResult.OK)
            {
                int wuj = Table_AddItems.FileNames.Length;
                for (int i = 0; i < wuj; i++)
                {
                    string filenametab = Path.GetFileName(Table_AddItems.FileNames[i]);
                    StreamReader file = new StreamReader(Table_AddItems.FileNames[i]);
                    string vername = file.ReadLine();
                    string crosname;
                    if (vername == "@1")
                    {
                        crosname = file.ReadLine();
                    }
                    else
                    {
                        crosname = vername;

                    }
                    string motname = file.ReadLine();
                    file.ReadLine();
                    string fatname = file.ReadLine();
                    file.ReadLine();
                    file.ReadLine();
                    file.ReadLine();
                    file.ReadLine();
                    file.ReadLine();
                    file.ReadLine();
                    file.ReadLine();
                    file.ReadLine();
                    file.ReadLine();
                    int petla = Convert.ToInt32(file.ReadLine());
                    string opisname = "";
                    if (petla != 0)
                    {
                        opisname = file.ReadLine();
                    }
                    for (int j = 1; j < petla; j++)
                    {
                        file.ReadLine();
                    }
                    petla = Convert.ToInt32(file.ReadLine());
                    for (int j = 0; j < petla; j++)
                    {
                        file.ReadLine();
                        file.ReadLine();
                        int petla2 = Convert.ToInt32(file.ReadLine());
                        for (int k = 0; k < petla2; k++)
                        {
                            file.ReadLine();
                        }
                    }
                    string par1name = file.ReadLine();
                    string par2name = file.ReadLine();
                    string par3name = file.ReadLine();
                    string par4name = file.ReadLine();
                    string par5name = "";
                    string par6name = "";
                    string par7name = "";
                    string par8name = "";
                    if (vername == "@1")
                    {
                        par5name = file.ReadLine();
                        par6name = file.ReadLine();
                        par7name = file.ReadLine();
                        par8name = file.ReadLine();
                    }

                    dataGridView1.Rows.Add(crosname, motname, fatname, opisname, par1name, par2name, par3name, par4name, par5name, par6name, par7name, par8name, filenametab);





                    file.Close();

                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string message = mess;
            string title = "";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                int dGVRC = dataGridView1.Rows.Count;
                for (int i = 0; i < dGVRC; i++)
                {
                    dataGridView1.Rows.RemoveAt(0);
                }
            }
        }

        private void savetabclick(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                Save_Table.InitialDirectory = Environment.CurrentDirectory + "\\Crossings_tab";
                Save_Table.FileName = textBox4.Text;
                if (Save_Table.ShowDialog() == DialogResult.OK)
                {
                    int countrows = dataGridView1.Rows.Count;
                    int countcolumns = dataGridView1.ColumnCount;
                    StreamWriter swtb = new StreamWriter(Save_Table.FileName);
                    for (int i = 0; i < countrows; i++)
                        for (int j = 0; j < countcolumns; j++)
                        {
                            swtb.WriteLine(dataGridView1[j, i].Value);
                        }
                    swtb.Close();
                }
            }
            //else
            //{
            //    string title = "!!!";
            //    DialogResult result = MessageBox.Show(message, title);
            //}
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Open_Table.InitialDirectory = Environment.CurrentDirectory + "\\Crossings_tab";
            if (Open_Table.ShowDialog() == DialogResult.OK)
            {
                textBox4.Text = Path.GetFileNameWithoutExtension(Open_Table.FileName);
                StreamReader srtb = new StreamReader(Open_Table.FileName);
                //int aaaaag = 0;
                //string rowline = "test";
                int countrows = dataGridView1.Rows.Count;
                int countcolumns = dataGridView1.ColumnCount;
                //while( aaaaag > countrows  && rowline != null) {
                //    rowline = srtb.ReadLine();
                //     dataGridView1.Rows.Add();
                //    dataGridView1[0,countrows+aaaaag-1].Value = rowline;
                //     aaaaag++;
                //     for (int i = 1; i < countcolumns; i++)
                //      {
                //         dataGridView1[i, countrows - 1].Value = srtb.ReadLine();
                //    }
                // }


                string crosname;
                string motname;
                string fatname;
                string opisname;
                string par1name;
                string par2name;
                string par3name;
                string par4name;
                string par5name;
                string par6name;
                string par7name;
                string par8name;
                string par9name;

                while ((crosname = srtb.ReadLine()) != null)
                {
                    motname = srtb.ReadLine();
                    fatname = srtb.ReadLine();
                    opisname = srtb.ReadLine();
                    par1name = srtb.ReadLine();
                    par2name = srtb.ReadLine();
                    par3name = srtb.ReadLine();
                    par4name = srtb.ReadLine();
                    par5name = srtb.ReadLine();
                    par6name = srtb.ReadLine();
                    par7name = srtb.ReadLine();
                    par8name = srtb.ReadLine();
                    par9name = srtb.ReadLine();
                    dataGridView1.Rows.Add(crosname, motname, fatname, opisname, par1name, par2name, par3name, par4name, par5name, par6name, par7name, par8name, par9name);
                }
                dataGridView1.Rows.RemoveAt(dataGridView1.Rows.Count - 2);
                srtb.Close();
            }
        }

        private void tocsv_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                Save_csv.InitialDirectory = Environment.CurrentDirectory + "\\Crossings_tab";
                Save_csv.FileName = textBox4.Text;
                if (Save_csv.ShowDialog() == DialogResult.OK)
                {
                    int countrows = dataGridView1.Rows.Count;
                    int countcolumns = dataGridView1.ColumnCount;
                    StreamWriter csvwr = new StreamWriter(Save_csv.FileName);
                    for (int i = 0; i < countcolumns; i++)
                    {
                        csvwr.Write(dataGridView1.Columns[i].Name + separator);
                    }
                    csvwr.Write('\n');
                    for (int i = 0; i < countrows - 1; i++)
                    {
                        for (int j = 0; j < countcolumns; j++)
                        {
                            csvwr.Write(dataGridView1[j, i].Value);
                            csvwr.Write(separator);
                        }
                        csvwr.Write('\n');
                    }
                    csvwr.Close();
                }
            }
        }

        private void fromcsv_Click(object sender, EventArgs e)
        {
            Open_csv.InitialDirectory = Environment.CurrentDirectory + "\\Crossings_tab";

            if (Open_csv.ShowDialog() == DialogResult.OK)
            {

                string crosname;
                string motname;
                string fatname;
                string opisname;
                string par1name;
                string par2name;
                string par3name;
                string par4name;
                string par5name;
                string par6name;
                string par7name;
                string par8name;
                string par9name;
                string headsplitter;
                StreamReader csvrd = new StreamReader(Open_csv.FileName);
                csvrd.ReadLine();
                headsplitter = csvrd.ReadLine();
                while (headsplitter != null)
                {
                    string[] headsplitted = headsplitter.Split(separator);
                    crosname = headsplitted[0];
                    motname = headsplitted[1];
                    fatname = headsplitted[2];
                    opisname = headsplitted[3];
                    par1name = headsplitted[4];
                    par2name = headsplitted[5];
                    par3name = headsplitted[6];
                    par4name = headsplitted[7];
                    par5name = headsplitted[8];
                    par6name = headsplitted[9];
                    par7name = headsplitted[10];
                    par8name = headsplitted[11];
                    par9name = headsplitted[12];
                    dataGridView1.Rows.Add(crosname, motname, fatname, opisname, par1name, par2name, par3name, par4name, par5name, par6name, par7name, par8name, par9name);
                    headsplitter = csvrd.ReadLine();
                }


                csvrd.Close();
                //if (textBox4.Text == "")
                //{ textBox4.Text = Path.GetFileName(Open_csv.FileName); }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                Imgopen.instance.pb1.Image = Image.FromFile(FileNamesParents[1]);
            }
            catch (System.IO.FileNotFoundException)
            {
                Imgopen.instance.pb1.Image = Image.FromFile("Conf\\zgubiony.jpg");
            }
            IO1.ShowDialog();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            try
            {
                Imgopen.instance.pb1.Image = Image.FromFile(FileNamesParents[5]);
            }
            catch (System.IO.FileNotFoundException)
            {
                Imgopen.instance.pb1.Image = Image.FromFile("Conf\\zgubiony.jpg");
            }
            IO1.ShowDialog();
        }

        private void deleterow_Click(object sender, EventArgs e)
        {

            DataGridViewSelectedCellCollection rows = dataGridView1.SelectedCells;
            foreach (DataGridViewCell row in rows)
            {
                try
                {
                    dataGridView1.Rows.RemoveAt(row.RowIndex);
                }
                catch (Exception ArgumentOutOfRangeException)
                {

                }


            }

        }

        private void openfromtable_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count == 1 || dataGridView1.SelectedRows.Count == 1)
            {
                DataGridViewSelectedCellCollection rows = dataGridView1.SelectedCells;
                int index = rows[0].RowIndex;
                string filename = dataGridView1[12, index].Value.ToString();
                for (int i = 0; i < counter; i++)
                {
                    PicCounter[i].Dispose();
                    TexCounter[i].Dispose();
                    DesCounter[i].Dispose();
                    ButtCounter[i].Dispose();
                }
                button13.Location = new Point(43, 43);
                counter = 0;
                Array.Resize(ref TexCounter, 1);
                Array.Resize(ref PicCounter, 1);
                Array.Resize(ref DesCounter, 1);
                Array.Resize(ref ButtCounter, 1);
                Array.Resize(ref FileNames, 1);
                StreamReader file = new StreamReader("Crossings_def\\" + filename);
                string ver = file.ReadLine();
                string ehe;
                if (ver == "@1")
                {
                    textBox14.Text = file.ReadLine();
                    textBox6.Text = file.ReadLine();
                    ehe = file.ReadLine();
                    scaler sc1 = new scaler(ehe, pictureBox5);
                    sc1.scale();
                    FileNamesParents[2] = ehe;
                    textBox5.Text = file.ReadLine();
                    ehe = file.ReadLine();
                    scaler sc2 = new scaler(ehe, pictureBox4);
                    sc2.scale();
                    FileNamesParents[3] = ehe;
                    textBox1.Text = file.ReadLine();
                    ehe = file.ReadLine();
                    scaler sc3 = new scaler(ehe, pictureBox1);
                    sc3.scale();
                    FileNamesParents[0] = ehe;
                    textBox2.Text = file.ReadLine();
                    ehe = file.ReadLine();
                    scaler sc4 = new scaler(ehe, pictureBox2);
                    sc4.scale();
                    FileNamesParents[1] = ehe;
                    textBox3.Text = file.ReadLine();
                    ehe = file.ReadLine();
                    scaler sc5 = new scaler(ehe, pictureBox6);
                    sc5.scale();
                    FileNamesParents[4] = ehe;
                    textBox8.Text = file.ReadLine();
                    ehe = file.ReadLine();
                    scaler sc6 = new scaler(ehe, pictureBox7);
                    sc6.scale();
                    FileNamesParents[5] = ehe;
                    int coun = Convert.ToInt32(file.ReadLine());
                    textBox7.Text = "";
                    for (int i = 0; i < coun; i++)
                    {
                        textBox7.Text += file.ReadLine() + "\r\n";
                    }
                    int helpcounter = Convert.ToInt32(file.ReadLine());
                    while (counter < helpcounter)
                    {
                        int ydd = (counter + 1) / 5;

                        panel1.Size = new Size(panel1.Width, 200 * (ydd + 2));
                        ListFrag chekc = new ListFrag();
                        chekc.CreateBox();
                        button13.Location = new Point(l * ((counter + 1) % 5), l * ((counter + 1) / 5));
                        TexCounter[counter].Text = file.ReadLine();
                        string eheh = file.ReadLine();
                        FileNames[counter] = eheh;
                        PicCounter[counter].Image = Image.FromFile(eheh);

                        int chech = Convert.ToInt32(file.ReadLine());
                        DesCounter[counter].Text = "";
                        for (int j = 0; j < chech; j++)
                        {
                            DesCounter[counter].Text += file.ReadLine() + "\r\n";
                        }
                        counter++;
                    }
                    textBox21.Text = file.ReadLine();
                    textBox9.Text = file.ReadLine();
                    textBox11.Text = file.ReadLine();
                    textBox10.Text = file.ReadLine();
                    textBox13.Text = file.ReadLine();
                    textBox12.Text = file.ReadLine();
                    textBox16.Text = file.ReadLine();
                    textBox15.Text = file.ReadLine();
                    file.Close();
                }
                else
                {
                    textBox14.Text = ver;
                    textBox6.Text = file.ReadLine();
                    ehe = file.ReadLine();
                    scaler sc1 = new scaler(ehe, pictureBox5);
                    sc1.scale();
                    FileNamesParents[2] = ehe;
                    textBox5.Text = file.ReadLine();
                    ehe = file.ReadLine();
                    scaler sc2 = new scaler(ehe, pictureBox4);
                    sc2.scale();
                    FileNamesParents[3] = ehe;
                    textBox1.Text = file.ReadLine();
                    ehe = file.ReadLine();
                    scaler sc3 = new scaler(ehe, pictureBox1);
                    sc3.scale();
                    FileNamesParents[0] = ehe;
                    textBox2.Text = file.ReadLine();
                    ehe = file.ReadLine();
                    scaler sc4 = new scaler(ehe, pictureBox2);
                    sc4.scale();
                    FileNamesParents[1] = ehe;
                    textBox3.Text = file.ReadLine();
                    ehe = file.ReadLine();
                    scaler sc5 = new scaler(ehe, pictureBox6);
                    sc5.scale();
                    FileNamesParents[4] = ehe;
                    textBox8.Text = file.ReadLine();
                    ehe = file.ReadLine();
                    scaler sc6 = new scaler(ehe, pictureBox7);
                    sc6.scale();
                    FileNamesParents[5] = ehe;
                    int coun = Convert.ToInt32(file.ReadLine());
                    textBox7.Text = "";
                    for (int i = 0; i < coun; i++)
                    {
                        textBox7.Text += file.ReadLine() + "\r\n";
                    }
                    int helpcounter = Convert.ToInt32(file.ReadLine());
                    while (counter < helpcounter)
                    {
                        int ydd = (counter + 1) / 5;

                        panel1.Size = new Size(panel1.Width, 200 * (ydd + 2));
                        ListFrag chekc = new ListFrag();
                        chekc.CreateBox();
                        button13.Location = new Point(l * ((counter + 1) % 5), l * ((counter + 1) / 5));
                        TexCounter[counter].Text = file.ReadLine();
                        string eheh = file.ReadLine();
                        FileNames[counter] = eheh;
                        try { PicCounter[counter].Image = Image.FromFile(eheh); }
                        catch (Exception FileNotFoundException)
                        {
                            PicCounter[counter].Image = Image.FromFile("Conf\\zgubiony.jpg");
                        }

                        int chech = Convert.ToInt32(file.ReadLine());
                        DesCounter[counter].Text = "";
                        for (int j = 0; j < chech; j++)
                        {
                            DesCounter[counter].Text += file.ReadLine() + "\r\n";
                        }
                        counter++;
                    }
                    textBox21.Text = file.ReadLine();
                    textBox9.Text = file.ReadLine();
                    textBox11.Text = file.ReadLine();
                    textBox10.Text = file.ReadLine();
                    file.Close();
                }
                tabControl1.SelectedTab = Krzyzowka;
            }
        }

        private void browse_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count == 1 || dataGridView1.SelectedRows.Count == 1)
            {
                DataGridViewSelectedCellCollection rows = dataGridView1.SelectedCells;
                int index = rows[0].RowIndex;
                dataGridView1.Rows[index].Selected = true;
                int rowminus = dataGridView1.RowCount;
                Tablebrowse.instance.outof.Text = index + 1 + "/" + rowminus;
                Tablebrowse.instance.position = index;
                string filename = dataGridView1[12, index].Value.ToString();
                StreamReader srtb = new StreamReader("Crossings_def\\" + filename);
                string canc = srtb.ReadLine();
                if (canc == "@1")
                {
                    Tablebrowse.instance.titleofbrowse.Text = Tablebrowse.instance.lablange + srtb.ReadLine();
                    Tablebrowse.instance.MotherLab.Text = srtb.ReadLine();
                }
                else
                {
                    Tablebrowse.instance.titleofbrowse.Text = Tablebrowse.instance.lablange + canc;
                    Tablebrowse.instance.MotherLab.Text = srtb.ReadLine();
                }
                try
                {
                    Tablebrowse.instance.motbox.Image = Image.FromFile(srtb.ReadLine());
                }
                catch (Exception FileNotFoundException)
                {
                    Tablebrowse.instance.motbox.Image = Image.FromFile("Conf\\zgubiony.jpg");
                }
                Tablebrowse.instance.FatherLab.Text = srtb.ReadLine();
                try
                {
                    Tablebrowse.instance.fatbox.Image = Image.FromFile(srtb.ReadLine());
                }
                catch (Exception FileNotFoundException)
                {
                    Tablebrowse.instance.fatbox.Image = Image.FromFile("Conf\\zgubiony.jpg");
                }
                srtb.ReadLine();
                srtb.ReadLine();
                srtb.ReadLine();
                srtb.ReadLine();
                srtb.ReadLine();
                srtb.ReadLine();
                srtb.ReadLine();
                srtb.ReadLine();
                Tablebrowse.instance.browstexbox.Text = "";
                int loop = Convert.ToInt32(srtb.ReadLine());
                for (int i = 0; i < loop; i++)
                {
                    Tablebrowse.instance.browstexbox.Text += srtb.ReadLine();
                }
                TBB2.ShowDialog();
                srtb.Close();
            }


        }

        private void backup_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
            if (!Directory.Exists("Backup"))
            {
                Directory.CreateDirectory("Backup");
            }
            if (!Directory.Exists("Backup\\Conf"))
            {
                Directory.CreateDirectory("Backup\\Conf");
            }
            File.Copy("Conf\\Config.ini", "Backup\\Conf\\Config.ini", true);
            if (!Directory.Exists("Backup\\Crossings_def"))
            {
                Directory.CreateDirectory("Backup\\Crossings_def");
            }
            if (!Directory.Exists("Backup\\Cultivars"))
            {
                Directory.CreateDirectory("Backup\\Cultivars");
            }
            if (!Directory.Exists("Backup\\Seedlings"))
            {
                Directory.CreateDirectory("Backup\\Seedlings");
            }
            int rowsen = dataGridView1.RowCount;
            string elif;
            string bufor;
            int gup;
            int progress = 0;
            progressBar1.Maximum = rowsen;
            for (int i = 0; i < rowsen; i++)
            {

                progressBar1.Increment(1);
                elif = "Crossings_def\\" + dataGridView1[12, i].Value.ToString();
                File.Copy(elif, "Backup\\Crossings_def\\" + Path.GetFileName(elif), true);
                StreamReader SRI = new StreamReader(elif);
                bufor = SRI.ReadLine();
                if (bufor == "@1")
                {
                    SRI.ReadLine();
                }
                SRI.ReadLine();
                bufor = SRI.ReadLine();
                if (File.Exists(bufor))
                {
                    File.Copy(bufor, "Backup\\" + bufor, true);
                }
                SRI.ReadLine();
                bufor = SRI.ReadLine();
                if (File.Exists(bufor))
                {
                    File.Copy(bufor, "Backup\\" + bufor, true);
                }
                SRI.ReadLine();
                bufor = SRI.ReadLine();
                if (File.Exists(bufor))
                {
                    File.Copy(bufor, "Backup\\" + bufor, true);
                }
                SRI.ReadLine();
                bufor = SRI.ReadLine();
                if (File.Exists(bufor))
                {
                    File.Copy(bufor, "Backup\\" + bufor, true);
                }
                SRI.ReadLine();
                bufor = SRI.ReadLine();
                if (File.Exists(bufor))
                {
                    File.Copy(bufor, "Backup\\" + bufor, true);
                }
                SRI.ReadLine();
                bufor = SRI.ReadLine();
                if (File.Exists(bufor))
                {
                    File.Copy(bufor, "Backup\\" + bufor, true);
                }
                gup = Convert.ToInt32(SRI.ReadLine());
                for (int j = 0; j < gup; j++)
                {
                    SRI.ReadLine();
                }
                gup = Convert.ToInt32(SRI.ReadLine());
                for (int j = 0; j < gup; j++)
                {
                    SRI.ReadLine();
                    bufor = SRI.ReadLine();
                    if (File.Exists(bufor))
                    {
                        File.Copy(bufor, "Backup\\" + bufor, true);
                    }
                    gup = Convert.ToInt32(SRI.ReadLine());
                    for (int k = 0; k < gup; k++)
                    {
                        SRI.ReadLine();
                    }
                }
                SRI.Close();



            }
            progressBar1.Visible = false;


        }

        private void textBox14_Leave(object sender, EventArgs e)
        {
            textBox14.BackColor = Color.White;
        }

        private void textBox14_Enter(object sender, EventArgs e)
        {
            textBox14.BackColor = Color.Yellow;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Yellow;
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.White;
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.Yellow;
        }

        private void textBox6_Leave(object sender, EventArgs e)
        {
            textBox6.BackColor = Color.White;
        }

        private void textBox6_Enter(object sender, EventArgs e)
        {
            textBox6.BackColor = Color.Yellow;
        }

        private void textBox5_Enter(object sender, EventArgs e)
        {
            textBox5.BackColor = Color.Yellow;
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            textBox5.BackColor = Color.White;
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            textBox3.BackColor = Color.White;
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            textBox3.BackColor = Color.Yellow;
        }

        private void textBox8_Leave(object sender, EventArgs e)
        {
            textBox8.BackColor = Color.White;
        }

        private void textBox8_Enter(object sender, EventArgs e)
        {
            textBox8.BackColor = Color.Yellow;
        }
        private void textBox7_Leave(object sender, EventArgs e)
        {
            textBox7.BackColor = Color.White;
        }

        private void textBox7_Enter(object sender, EventArgs e)
        {
            textBox7.BackColor = Color.Yellow;
        }

        private void textBox21_Leave(object sender, EventArgs e)
        {
            textBox21.BackColor = Color.White;
        }

        private void textBox21_Enter(object sender, EventArgs e)
        {
            textBox21.BackColor = Color.Yellow;
        }

        private void textBox9_Leave(object sender, EventArgs e)
        {
            textBox9.BackColor = Color.White;
        }

        private void textBox9_Enter(object sender, EventArgs e)
        {
            textBox9.BackColor = Color.Yellow;
        }

        private void textBox11_Leave(object sender, EventArgs e)
        {
            textBox11.BackColor = Color.White;
        }

        private void textBox11_Enter(object sender, EventArgs e)
        {
            textBox11.BackColor = Color.Yellow;
        }

        private void textBox10_Leave(object sender, EventArgs e)
        {
            textBox10.BackColor = Color.White;
        }

        private void textBox10_Enter(object sender, EventArgs e)
        {
            textBox10.BackColor = Color.Yellow;
        }

        private void textBox13_Leave(object sender, EventArgs e)
        {
            textBox13.BackColor = Color.White;
        }

        private void textBox13_Enter(object sender, EventArgs e)
        {
            textBox13.BackColor = Color.Yellow;
        }

        private void textBox12_Leave(object sender, EventArgs e)
        {
            textBox12.BackColor = Color.White;
        }

        private void textBox12_Enter(object sender, EventArgs e)
        {
            textBox12.BackColor = Color.Yellow;
        }

        private void textBox16_Leave(object sender, EventArgs e)
        {
            textBox16.BackColor = Color.White;
        }

        private void textBox16_Enter(object sender, EventArgs e)
        {
            textBox16.BackColor = Color.Yellow;
        }

        private void textBox15_Leave(object sender, EventArgs e)
        {
            textBox15.BackColor = Color.White;
        }

        private void textBox15_Enter(object sender, EventArgs e)
        {
            textBox15.BackColor = Color.Yellow;
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            textBox4.BackColor = Color.Yellow;
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            textBox4.BackColor = Color.White;
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            A1.ShowDialog();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            ParentForAi ParentToAI1 = new ParentForAi(textBox17, pictureBox18, pictureBox21, button15);
            ParentToAI1.openNScale();
            ImgForAI1 = pathmessage;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            ParentForAi ParentToAI2 = new ParentForAi(textBox18, pictureBox19, pictureBox22, button23);
            ParentToAI2.openNScale();
            ImgForAI2 = pathmessage;
        }

        private async void Generate(object sender, EventArgs e)
        {
            
            var result = await groqApi.CreateVisionCompletionWithBase64ImageAsync(
            ImgForAI1,
            "Describe this image named" + textBox17.Text,
            "meta-llama/llama-4-scout-17b-16e-instruct"
            );
            firstmessage = result?["choices"]?[0]?["message"]?["content"]?.ToString();
            var result2 = await groqApi.CreateVisionCompletionWithBase64ImageAsync(
            ImgForAI2,
            "Describe this image named" + textBox18.Text,
            "meta-llama/llama-4-scout-17b-16e-instruct"
            );
            firstmessage = result?["choices"]?[0]?["message"]?["content"]?.ToString();
            textBox18.Text = secondmessage;


        }

        












            //public void ButtonChangeImage(object sender, EventArgs e)
            //{
            //    string file_name_img;
            //    if (Open_graphics.ShowDialog() == DialogResult.OK)
            //    {
            //        file_name_img = Open_graphics.FileName;
            //     }
            //}


        }
}
