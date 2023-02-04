using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void b1_Click(object sender, EventArgs e)
        {
            int n = 0;
            n = Convert.ToInt32(tx1.Text);

            if (n % 2 == 0 & n >= 0)
            {
                MessageBox.Show("El número: " + n + "  Es un número Par - Positivo");

            }
            else if (n % 2 == 0 & n <= 0)
            {
                MessageBox.Show("El número : " + n + " Es un número Par - Negativo");

            }
            else if (n % 2 != 0 & n >= 0)
            {
                MessageBox.Show("El número : " + n + " Es un número Impar - Positivo");

            }
            else
                MessageBox.Show("El número : " + n + " Es un número Impar - Negativo");

        }

    }
}

