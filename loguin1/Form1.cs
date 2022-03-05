using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace loguin1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btniniciar_Click(object sender, EventArgs e)
        {
            if (txtuser.Text == "uriel" && (txtpas.Text == "2727"))
            { Form formulario = new Form2();
                formulario.Show();
            }
            else
            { MessageBox.Show("ERROR"); }
        }
        }
    }

