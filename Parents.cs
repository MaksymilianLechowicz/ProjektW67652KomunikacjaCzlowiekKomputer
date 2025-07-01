using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Krzyzak
{
    internal abstract class Parents
    {
        public TextBox TB {  get; set; }
        public PictureBox PB1Import { get; set; }
        public PictureBox PB2G { get; set; }
        public Button BTTrigger { get; set; }
        


        public Parents(TextBox TB, PictureBox PB1Import, PictureBox PB2G, Button BTTrigger) 
        {
            this.TB = TB;
            this.PB1Import = PB1Import;
            this.PB2G = PB2G;
            this.BTTrigger = BTTrigger;
            //PB1Import.Click += PicBoxClick2;
        }
        string pathForDirectory;
        public virtual void openNScale()
        {

            string file_name_img;
            string pathrefinde;
            

            if (Form1.instance.Open_graphics.ShowDialog() == DialogResult.OK)
            {
                if (Strings.Right(Path.GetDirectoryName(Path.GetFullPath(Form1.instance.Open_graphics.FileName)),9) != "Cultivars"/*!= Environment.CurrentDirectory + "\\Cultivars\\" + Path.GetFileName(Form1.instance.Open_graphics.FileName)*/)
                {
                    file_name_img = Form1.instance.Open_graphics.FileName;
                    Form1.instance.pathmessage = file_name_img;
                    PB1Import.Image = Image.FromFile(file_name_img);
                    
                    string pathfinder = "Cultivars\\" + Path.GetFileName(file_name_img);
                    string pathrefinder = pathfinder;
                    int nr = 0;
                    if (File.Exists(pathfinder))
                    {
                        pathrefinder = "Cultivars\\" + Path.GetFileNameWithoutExtension(file_name_img) + "-" + nr.ToString() + Path.GetExtension(file_name_img);
                        while (File.Exists(pathrefinder))
                        {
                            nr++;
                            pathrefinder = "Cultivars\\" + Path.GetFileNameWithoutExtension(file_name_img) + "-" + nr.ToString() + Path.GetExtension(file_name_img); 
                        }
                        
                    }
                    Form1.instance.pbleft.Image = Image.FromFile(file_name_img);
                    if (Form1.instance.pbleft.Image.Height > 740  || Form1.instance.pbleft.Width > 1080) {
                        pathrefinder = "Cultivars\\" + Path.GetFileNameWithoutExtension(file_name_img) + ".jpg";
                        int hff = Form1.instance.pbleft.Image.Height;
                        int wff = Form1.instance.pbleft.Image.Width;
                        int hh = 740;
                        int ww = 1080;
                        float sc1 = (float)hff / (float)hh;
                        float sc2 = (float)wff / (float)ww;
                        float scaleSupr = 2;
                        if (sc1 > sc2)
                        {
                            scaleSupr = sc1;
                        }
                        else
                        {
                            scaleSupr = sc2;
                        }
                        sc1 = wff / scaleSupr;
                        sc2 = hff / scaleSupr;
                        Bitmap bmpDeste;
                        using (Bitmap bmpOrig = new Bitmap(file_name_img))
                        {
                            bmpDeste = new Bitmap(bmpOrig, new Size((int)sc1,(int)sc2));
                        }
                        bmpDeste.Save(pathrefinder, ImageFormat.Jpeg);
                        pathrefinde = pathrefinder;
                        Form1.instance.FileNamesParents[Form1.instance.helper] = pathrefinde;

                    }
                    else { 
                    Bitmap bmpDeste;
                    using (Bitmap bmpOrig = new Bitmap(file_name_img))
                    {
                        bmpDeste = new Bitmap(bmpOrig.Width, bmpOrig.Height);
                    }
                    
                    File.Copy(file_name_img, pathrefinder);
                    //bmpDeste.Save(pathrefinder,ImageFormat.Jpeg);
                    pathrefinde = pathrefinder;
                    Form1.instance.FileNamesParents[Form1.instance.helper] = pathrefinde;
                    }

                }
                else
                {
                    pathrefinde = "Cultivars\\" + Path.GetFileName(Form1.instance.Open_graphics.FileName);
                    Form1.instance.FileNamesParents[Form1.instance.helper] =pathrefinde;

                }
                file_name_img = Form1.instance.Open_graphics.FileName;
                PB1Import.Image = Image.FromFile(file_name_img);
                /*int hf = PB1Import.Image.Height;
                int wf = PB1Import.Image.Width;
                int h = PB1Import.Height;
                int w = PB1Import.Width;
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
                    scale = 1;*/
                Bitmap bmpDest;
                using (Bitmap bmpOrig = new Bitmap(file_name_img))
                {
                    bmpDest = new Bitmap(bmpOrig.Width, bmpOrig.Height);
                }

                
                //bmpDest.Save("file300.jpg", ImageFormat.Jpeg);
                //pictureBox1.Image = Image.FromFile("file300.jpg");
                //PB1Import.Image = bmpDest;
                if (TB.Text == "")
                    {
                    TB.Text = Path.GetFileNameWithoutExtension(file_name_img);
                    }
                pathForDirectory = Path.GetDirectoryName(Form1.instance.Open_graphics.FileName);
                Form1.instance.Open_graphics.InitialDirectory = Path.GetFullPath(pathForDirectory);

            }
            //Form1.instance.Open_graphics.InitialDirectory = "";
            
        }
        //void PicBoxClick2(object sender, EventArgs e)
        //{
        //   Imgopen.instance.pb1.Image = Image.FromFile(Form1.instance.FileNamesParents[Form1.instance.helper]);

        //}
        
    }
}
