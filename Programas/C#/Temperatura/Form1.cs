using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temperatura
{
    public partial class Form1 : Form
    {
        byte temp;
        string clima;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            temp = Convert.ToByte(txtTemp.Text);
            // ----- | Proceso. | ----- //
            /* Condición que establece que, si la variable "temp" tiene un
            valor menor a 10, el clima
            será "Frío". */
            if (temp < 10) clima = "Frío";
            /* En caso de que la temperatura se encuentre en el rango de
            "10" a "20", el clima será "Nublado". */
            else if (temp >= 10 && temp <= 20) clima = "Nublado";
            /* En caso de que la temperatura sea mayor a 20 pero menor o
            igual a 30, el clima será
            "Calor". */
            else if (temp > 20 && temp <= 30) clima = "Caluroso";
            /* En caso de que la temperatura sea mayor a 30, el clima
            detectado será "Tropical". */
            else clima = "Tropical";
            txtClima.Text = clima;
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtTemp.Text = string.Empty;
            txtClima.Text = string.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
