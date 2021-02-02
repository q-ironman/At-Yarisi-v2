using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace At_Yarisi_v2
{
    class Horse
    {
        Random rndm = new Random();
        int _speed;
        public int speed {

            get
            {
                return _speed;

            }
            set
            {
                _speed = rndm.Next(10, 40);
            }
        
        }
        public bool YrissinMi { get; set; }
        
        
    }
}
