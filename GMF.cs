using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krzyzak
{
    internal class GMF : Parents
    {
        public GMF(TextBox TB, PictureBox PB1Import, PictureBox PB2G, Button BTTrigger) : base(TB, PB1Import, PB2G, BTTrigger)
        {

        }

        public override void openNScale()
        {
            Form1.instance.helper = 1;
            base.openNScale();
        }
    }
}
