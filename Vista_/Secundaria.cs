using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista_
{
    public partial class Secundaria : Form
    {
        public Secundaria()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            DiseñoBotones();
        }

        private void DiseñoBotones()
        {
            btnAtras.Image = Image.FromFile(@"Icon/Previous.png");
            btnSiguiente.Image = Image.FromFile(@"Icon/Next.png");
            btnRefresh.Image = Image.FromFile(@"Icon/Refresh.png");
            btnStop.Image = Image.FromFile(@"Icon/Stop.png");
            btnEnter.Image = Image.FromFile(@"Icon/Enter.png");
            btnHome.Image = Image.FromFile(@"Icon/Home.png");
            btnfav.Image = Image.FromFile(@"Icon/fav.png");

        }

    }
}
