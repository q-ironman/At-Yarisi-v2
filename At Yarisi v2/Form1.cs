using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace At_Yarisi_v2
{
    public partial class Form1 : Form
    {
        private Horse[] horses;
        Random rndm = new Random();
        


        
        public Form1()
        {
            InitializeComponent();
            

        }

        private void button_start_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(numericUpDown1.Value);
            for(int i = 0; i<num;i++)
            {
                horses[i].YrissinMi = true;
            }
            
        }
    }
}
