using System;
using System.Drawing;
using System.Windows.Forms;
using vista_informacion;

namespace vista_informacion
{
    public partial class info_form : Form
    {
        public info_form()
        {
            InitializeComponent();
        }



        private void info_form_Load(object sender, EventArgs e)
        {
            DiseñoBotones();

        }

        private void DiseñoBotones()
        {
            button1.Image = Image.FromFile(@"Icon/Previous.png");
            button2.Image = Image.FromFile(@"Icon/Next.png");
            button3.Image = Image.FromFile(@"Icon/Refresh.png");
            button4.Image = Image.FromFile(@"Icon/Stop.png");
            button5.Image = Image.FromFile(@"Icon/Enter.png");
            button6.Image = Image.FromFile(@"Icon/Home.png");
            button7.Image = Image.FromFile(@"Icon/fav.png");
        }

        
    }
}
