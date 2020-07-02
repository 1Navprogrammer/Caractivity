using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caractivity
{
    public class BMW : Cars
    {
        public override string Name { get; set; }

        public override PictureBox Picture { get; set; }

        public BMW(string tempName, PictureBox tempic)
        {
            Name = tempName;
            Picture = tempic;
        }
        public override void Move(int distance)
        {
            Picture.Location = new Point(Picture.Location.X, Picture.Location.Y + distance);
        }
    }
}

