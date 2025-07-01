using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krzyzak
{
    
internal class scaler
    {
        public string pather {  get; set; }
        public PictureBox arber { get; set; }

    public scaler(string pather, PictureBox arber) 
        { 
            this.pather = pather;
            this.arber = arber;
        }
        public void scale()
        {
            try { 
            arber.Image = Image.FromFile(pather);
            /*int hf = arber.Image.Height;
            int wf = arber.Image.Width;
            int h = arber.Height;
            int w = arber.Width;
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
            Bitmap bmpDest;
            using (Bitmap bmpOrig = new Bitmap(pather))
            {
                bmpDest = new Bitmap(bmpOrig, new Size(wf / scale, hf / scale));
            }
            //bmpDest.Save("file300.jpg", ImageFormat.Jpeg);
            //pictureBox1.Image = Image.FromFile("file300.jpg");
            arber.Image = bmpDest;*/
            }
            catch (System.IO.FileNotFoundException)
            {
                arber.Image = Image.FromFile("Conf\\zgubiony.jpg");
            }
        }

    }
}
