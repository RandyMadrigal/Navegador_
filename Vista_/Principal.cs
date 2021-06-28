using System;
using System.Drawing;
using System.Windows.Forms;


namespace Vista_
{
    public partial class Principal : Form
    {
        //Instancia de la Clase form1
        Secundaria info = new Secundaria();
        
    
        //Metodos.

        public Principal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Icon = new Icon(@"Icon/navegador.ico");

            DiseñoBotones();

            webBrowser.Navigate("www.google.com");

            Mensajes();
        }

        private void DiseñoBotones()
        {
            btnBack.Image = Image.FromFile(@"Icon\Previous.png");
            
            btnBack.ImageAlign = ContentAlignment.BottomCenter;

            btnNext.Image = Image.FromFile(@"Icon\Next.png");
            btnNext.ImageAlign = ContentAlignment.BottomCenter;

            btnRefresh.Image = Image.FromFile(@"Icon\Refresh.png");

            BtnHome.Image = Image.FromFile(@"Icon\Home.png");

            btnEnter.Image = Image.FromFile(@"Icon\Enter.png");

            btnFavorito.Image = Image.FromFile(@"Icon/fav.png");

            btnCancelar.Image = Image.FromFile(@"Icon/Stop.png");

            btn_info.Image = Image.FromFile(@"Icon/informacion.png");
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            webBrowser.Navigate("www.google.com");
            txtUrl.Text = "Introduce una URL.";
        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            webBrowser.Navigate(txtUrl.Text);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            webBrowser.GoBack();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            webBrowser.GoForward();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            webBrowser.Refresh();
        }

        private void Mensajes()
        {
            ToolTip Cuadro = new ToolTip();

            Cuadro.SetToolTip(btnBack, "Atras");
            Cuadro.SetToolTip(btnNext, "Adelante");
            Cuadro.SetToolTip(btnRefresh, "Refrescar");
            Cuadro.SetToolTip(btnCancelar, "Cancelar");
            Cuadro.SetToolTip(btnEnter, "Buscar");
            Cuadro.SetToolTip(btnFavorito, "Favorito");
            Cuadro.SetToolTip(BtnHome, "Home");
        }

        //Para verificar el progreso de la carga de la pagina.
        private void webBrowser_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            labelValidando.Text = webBrowser.StatusText;
            txtUrl.Text = webBrowser.DocumentTitle;
        }

        private void btnFavorito_Click(object sender, EventArgs e)
        {
            comboboxFav.Items.Add(webBrowser.DocumentTitle); 
        }

        private void comboboxFav_Click(object sender, EventArgs e)
        {
            txtUrl.Text = comboboxFav.SelectedText;
        }

        private void btn_info_Click(object sender, EventArgs e)
        {
            info.Show();
        }
    }
}
