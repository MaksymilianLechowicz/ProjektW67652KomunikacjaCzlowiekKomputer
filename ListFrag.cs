using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics.Metrics;
using System.Drawing.Imaging;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.ComponentModel.Com2Interop;

namespace Krzyzak
{
    internal class ListFrag
    {
        
        
        public ListFrag()
        {
            
        }
        private int ctnr = Form1.instance.counter;
        string pathForDirectory;
        public void CreateBox()
        {
            int xd = ctnr % 5;
            int yd = ctnr / 5;
            string abeca = "Conf\\NN.jpg";
            Array.Resize(ref Form1.instance.FileNames, ctnr + 1);
            Form1.instance.FileNames[ctnr] = abeca;
            PictureBox LFPicBox = new PictureBox
            {
                Size = new Size(170, 115),
                Location = new Point(Form1.instance.l * (xd), 0 + Form1.instance.l * (yd)),
                Image = Image.FromFile("Conf\\NN.jpg"),
                SizeMode = PictureBoxSizeMode.Zoom
                
            };
            LFPicBox.Click += PicBoxClick2;
            void PicBoxClick2(object sender, EventArgs e)
            {
                try { 
                ImgopenSeed.instance.ispb1.Image = Image.FromFile(Form1.instance.FileNamesParents[0]);
                }
                catch (System.IO.FileNotFoundException)
                {
                    ImgopenSeed.instance.ispb1.Image = Image.FromFile("Conf\\zgubiony.jpg");
                }
                try { 
                ImgopenSeed.instance.ispb2.Image = Image.FromFile(Form1.instance.FileNamesParents[1]);
                }
                catch (System.IO.FileNotFoundException)
                {
                ImgopenSeed.instance.ispb2.Image = Image.FromFile("Conf\\zgubiony.jpg");
                }
                try { 
                ImgopenSeed.instance.ispb3.Image = Image.FromFile(Form1.instance.FileNamesParents[5]);
                }
                catch (System.IO.FileNotFoundException)
                {
                ImgopenSeed.instance.ispb3.Image = Image.FromFile("Conf\\zgubiony.jpg");
                }
                try { 
                ImgopenSeed.instance.ispb4.Image = Image.FromFile(Form1.instance.FileNamesParents[4]);
                }
                catch (System.IO.FileNotFoundException)
                {
                ImgopenSeed.instance.ispb4.Image = Image.FromFile("Conf\\zgubiony.jpg");
                }
                try { 
                ImgopenSeed.instance.ispb5.Image = Image.FromFile(Form1.instance.FileNamesParents[2]);
                }
                catch (System.IO.FileNotFoundException)
                {
                ImgopenSeed.instance.ispb5.Image = Image.FromFile("Conf\\zgubiony.jpg");
                }
                try { 
                ImgopenSeed.instance.ispb6.Image = Image.FromFile(Form1.instance.FileNamesParents[3]);
                }
                catch (System.IO.FileNotFoundException)
                {
                ImgopenSeed.instance.ispb6.Image = Image.FromFile("Conf\\zgubiony.jpg");
                }
                try { 
                ImgopenSeed.instance.ispb7.Image = Image.FromFile(Form1.instance.FileNames[ctnr]);
                }
                catch (System.IO.FileNotFoundException)
                {
                ImgopenSeed.instance.ispb7.Image = Image.FromFile("Conf\\zgubiony.jpg");
                }
                ImgopenSeed.instance.lab1.Text = Form1.instance.tb311.Text;
                ImgopenSeed.instance.lab2.Text = Form1.instance.tb511.Text;
                ImgopenSeed.instance.lab3.Text = Form1.instance.tb611.Text;
                ImgopenSeed.instance.lab4.Text = Form1.instance.tb411.Text;
                ImgopenSeed.instance.lab5.Text = Form1.instance.tb111.Text;
                ImgopenSeed.instance.lab6.Text = Form1.instance.tb211.Text;
                ImgopenSeed.instance.lab7.Text = Form1.instance.TexCounter[ctnr].Text;
                ImgopenSeed.instance.counthere = ctnr;
                ImgopenSeed.instance.countend = Form1.instance.counter;
                ImgopenSeed.instance.lab8.Text = ctnr+1+"/"+Form1.instance.counter;
                Form1.instance.IO2.ShowDialog();
            }
            Array.Resize(ref Form1.instance.PicCounter, ctnr + 1);
            Form1.instance.PicCounter[ctnr] = LFPicBox;
            TextBox LFTexBox = new TextBox
            {
                Location = new Point(Form1.instance.l * (xd), 100 + Form1.instance.l * (yd)),
                Size = new Size(170, 25),
                PlaceholderText = Form1.instance.langseed1,
            };
            LFTexBox.Leave += TexLeave;
            LFTexBox.Enter += TexEnter;
            void TexLeave(object sender, EventArgs e)
            {
                LFTexBox.BackColor = Color.White;
            }
            void TexEnter(object sender, EventArgs e)
            {
                LFTexBox.BackColor = Color.Yellow;
            }
            Array.Resize(ref Form1.instance.TexCounter, ctnr + 1);
            Form1.instance.TexCounter[ctnr] = LFTexBox;
            TextBox LFDes = new TextBox
            {
                Location = new Point(Form1.instance.l * (xd), 125 + Form1.instance.l * (yd)),
                Size = new Size(170, 50),
                PlaceholderText = Form1.instance.langseed2,
                Multiline = true,
            };
            LFDes.Leave += DesLeave;
            LFDes.Enter += DesEnter;
            void DesLeave(object sender, EventArgs e)
            {
                LFDes.BackColor = Color.White;
            }
            void DesEnter(object sender, EventArgs e)
            {
                LFDes.BackColor = Color.Yellow;
            }
            Array.Resize(ref Form1.instance.DesCounter, ctnr + 1);
            Form1.instance.DesCounter[ctnr] = LFDes;
            Button LFButt = new Button

            {
                Size = new Size(20, 20),
                Location = new Point(Form1.instance.l * (xd), 80 + Form1.instance.l * (yd)),
                BackgroundImage = Image.FromFile("Conf\\open_pic.jpg"),
                BackgroundImageLayout = ImageLayout.Zoom

            };
            LFButt.Click += ButtonChangeImage;
            void ButtonChangeImage(object sender, EventArgs e)
            {
                
                        string file_name_img;
                //Form1.instance.Open_graphics.InitialDirectory = Environment.CurrentDirectory;
                if (Form1.instance.Open_graphics_Seed.ShowDialog() == DialogResult.OK)
                {
                    if (Strings.Right(Path.GetDirectoryName(Path.GetFullPath(Form1.instance.Open_graphics_Seed.FileName)),9) != "Seedlings" /*!= Environment.CurrentDirectory + "\\Seedlings\\" + Path.GetFileName(Form1.instance.Open_graphics_Seed.FileName)*/)
                    {
                        file_name_img = Form1.instance.Open_graphics_Seed.FileName;
                        Form1.instance.PicCounter[ctnr].Image = Image.FromFile(file_name_img);
                        
                        Bitmap bmpDeste;
                        using (Bitmap bmpOrig = new Bitmap(file_name_img))
                        {
                            bmpDeste = new Bitmap(bmpOrig.Width, bmpOrig.Height);
                        }
                        string pathfinder = "Seedlings\\" + Path.GetFileName(file_name_img);
                        string pathrefinder = pathfinder;
                        int nr = 0;
                        if (File.Exists(pathfinder))
                        {
                            pathrefinder = "Seedlings\\" + Path.GetFileNameWithoutExtension(file_name_img) + "-" + nr.ToString() + ".jpg";
                            while (File.Exists(pathrefinder))
                            {
                                nr++;
                                pathrefinder = "Seedlings\\" + Path.GetFileNameWithoutExtension(file_name_img) + "-" + nr.ToString() + ".jpg";
                            }

                        }
                        Form1.instance.pbleft.Image = Image.FromFile(file_name_img);
                        if (Form1.instance.pbleft.Image.Height > 740 || Form1.instance.pbleft.Width > 1080)
                        {
                            pathrefinder = "Seedlings\\" + Path.GetFileNameWithoutExtension(file_name_img) + ".jpg";
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
                            Bitmap bmpDesten;
                            using (Bitmap bmpOrige = new Bitmap(file_name_img))
                            {
                                bmpDesten = new Bitmap(bmpOrige, new Size((int)sc1, (int)sc2));
                            }
                            bmpDesten.Save(pathrefinder, ImageFormat.Jpeg);
                            abeca = pathrefinder;
                            Form1.instance.FileNames[ctnr] = abeca;

                        }
                        else
                        {
                            File.Copy(file_name_img, pathrefinder);
                            //bmpDeste.Save(pathrefinder, ImageFormat.Jpeg);
                            abeca = pathrefinder;
                            Form1.instance.FileNames[ctnr] = abeca;
                        }
                    }
                    else
                    {
                        abeca = "Seedlings\\" + Path.GetFileName(Form1.instance.Open_graphics_Seed.FileName);
                        Form1.instance.FileNames[ctnr] = abeca;
                    }

                
                        file_name_img = Form1.instance.Open_graphics_Seed.FileName;
                            Form1.instance.PicCounter[ctnr].Image = Image.FromFile(file_name_img);
                   
                        Bitmap bmpDest;
                        using (Bitmap bmpOrig = new Bitmap(file_name_img))
                    {
                        bmpDest = new Bitmap(bmpOrig.Width, bmpOrig.Height);
                    }
                    //Form1.instance.PicCounter[ctnr].Image = bmpDest;
                    if (LFTexBox.Text == "")
                    {
                        LFTexBox.Text = Path.GetFileNameWithoutExtension(file_name_img);
                    }
                    pathForDirectory = Path.GetDirectoryName(Form1.instance.Open_graphics_Seed.FileName);
                    Form1.instance.Open_graphics_Seed.InitialDirectory = Path.GetFullPath(pathForDirectory);
                }
                //file_name_img = abeca;


             }
            Array.Resize(ref Form1.instance.ButtCounter, ctnr + 1);
            Form1.instance.ButtCounter[ctnr] = LFButt;
            Form1.instance.p1.Controls.Add(LFPicBox);
            Form1.instance.p1.Controls.Add(LFTexBox);
            Form1.instance.p1.Controls.Add(LFDes);
            Form1.instance.p1.Controls.Add(LFButt);
            LFPicBox.BringToFront();
            LFTexBox.BringToFront();
            LFDes.BringToFront();
            LFButt.BringToFront();
            Array.Resize(ref Form1.instance.FileNames, ctnr + 1);
            
        }

    }
}
