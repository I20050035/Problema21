using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumeroPefecto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            operacion clase = new operacion();
            //ingresar el numero
            clase.Num_set(int.Parse(textBox1.Text));
            //llamar el metodo para calcular
            clase.calcular();
            //mostrar resultado
           
        }
    }
}
