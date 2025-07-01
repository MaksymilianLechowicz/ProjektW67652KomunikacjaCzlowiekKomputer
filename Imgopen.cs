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
    public partial class Imgopen : Form
    {
        public PictureBox pb1;
        public static Imgopen instance;
        public Imgopen()
        {
            InitializeComponent();
            instance = this;
            pb1 = pictureBox1;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
