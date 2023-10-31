using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data MySql

namespace EXAPRACTICO3
{
    public partial class Form1 : Form
    {
        private readonly bool ledEncendido;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {
            
        }

       
        private void textBoxFecha_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void buttonControlLED_Click(object sender, EventArgs e)
        {
            if (ledEncendido)
            {
                labelLEDStatus.Text = "LED: Apagado";
            }
            else
            {
                labelLEDStatus.Text = "LED: Encendido";
            }
    }

    private void MostrarTemperatura(double temperaturaCelsius, double temperaturaFahrenheit)
    {
        lblCelsius.Text = $"Temperatura (C): {temperaturaCelsius}°C";
        labelFahrenheit.Text = $"Temperatura (F): {temperaturaFahrenheit}°F";
    }

        private void labelEncendido_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    }

