using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int turno = 0;

        public void Reiniciar()
        {
            imagen1.Visible = false;
            imagen2.Visible = false;
            imagen3.Visible = false;
            imagen4.Visible = false;
            imagen5.Visible = false;
            imagen6.Visible = false;
            imagen7.Visible = false;
            imagen8.Visible = false;
            imagen9.Visible = false;
            imagen10.Visible = false;
            imagen11.Visible = false;
            imagen12.Visible = false;
            imagen13.Visible = false;
            imagen14.Visible = false;
            imagen15.Visible = false;
            imagen16.Visible = false;
            imagen17.Visible = false;
            imagen18.Visible = false;
        }

        private void Form1_Load_(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (turno % 2 == 0)
            {
                imagen2.Visible = true;
                imagen1.Visible = false;
            }
            else
            {
                imagen2.Visible = false;
                imagen1.Visible = true;
                
            }
            turno++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (turno % 2 == 0)
            {
                imagen4.Visible = true;
                imagen3.Visible = false;
            }
            else
            {
                imagen4.Visible = false;
                imagen3.Visible = true;
               
            }
            turno++;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (turno % 2 == 0)
            {
                imagen6.Visible = true;
                imagen5.Visible = false;
            }
            else
            {
                imagen6.Visible = false;
                imagen5.Visible = true;
                
            }
            turno++;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (turno % 2 == 0)
            {
                imagen8.Visible = true;
                imagen7.Visible = false;
            }
            else
            {
                imagen8.Visible = false;
                imagen7.Visible = true;
                
            }
            turno++;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (turno % 2 == 0)
            {
                imagen10.Visible = true;
                imagen9.Visible = false;
            }
            else
            {
                imagen10.Visible = false;
                imagen9.Visible = true;
                
            }
            turno++;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (turno % 2 == 0)
            {
                imagen12.Visible = true;
                imagen11.Visible = false;
            }
            else
            {
                imagen12.Visible = false;
                imagen11.Visible = true;
                
            }
            turno++;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (turno % 2 == 0)
            {
                imagen14.Visible = true;
                imagen13.Visible = false;
            }
            else
            {
                imagen14.Visible = false;
                imagen13.Visible = true;
                
            }
            turno++;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (turno % 2 == 0)
            {
                imagen16.Visible = true;
                imagen15.Visible = false;
            }
            else
            {
                imagen16.Visible = false;
                imagen15.Visible = true;
                
            }
            turno++;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (turno % 2 == 0)
            {
                imagen18.Visible = true;
                imagen17.Visible = false;
            }
            else
            {
                imagen18.Visible = false;
                imagen17.Visible = true;
                
            }
            turno++;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Reiniciar();
        }


    }

        
}
