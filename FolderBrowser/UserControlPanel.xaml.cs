using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;

using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FolderBrowser
{
    /// <summary>
    /// Lógica de interacción para UserControlPanel.xaml
    /// </summary>

    public partial class UserControlPanel : UserControl
    {
        public UserControlPanel()
        {
            InitializeComponent();
            this.DataContext = this;
        }


        public bool SoloLectura
        {
            get { return (bool)GetValue(SoloLecturaProperty); }
            set { SetValue(SoloLecturaProperty, value); }
        }

        // Using a DependencyProperty as the backing store for SoloLectura.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SoloLecturaProperty =
            DependencyProperty.Register("SoloLectura", typeof(bool), typeof(UserControlPanel), new PropertyMetadata(false));

        public bool NuevaCarpeta
        {
            get { return (bool)GetValue(NuevaCarpetaProperty); }
            set { SetValue(NuevaCarpetaProperty, value); }
        }

        // Using a DependencyProperty as the backing store for NuevaCarpeta.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty NuevaCarpetaProperty =
            DependencyProperty.Register("NuevaCarpeta", typeof(bool), typeof(UserControlPanel), new PropertyMetadata(false));



        public string Titulo
        {
            get { return (string)GetValue(TituloProperty); }
            set { SetValue(TituloProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Titulo.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TituloProperty =
            DependencyProperty.Register("Titulo", typeof(string), typeof(UserControlPanel), new PropertyMetadata(""));



        public string RutaSeleccionada
        {
            get { return (string)GetValue(RutaSeleccionadaProperty); }
            set { SetValue(RutaSeleccionadaProperty, value); }
        }

        // Using a DependencyProperty as the backing store for RutaSeleccionada.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty RutaSeleccionadaProperty =
            DependencyProperty.Register("RutaSeleccionada", typeof(string), typeof(UserControlPanel), new PropertyMetadata(""));



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.FolderBrowserDialog dialogo = new System.Windows.Forms.FolderBrowserDialog();
            dialogo.ShowNewFolderButton = NuevaCarpeta;
            //Mostramos el diálogo
            System.Windows.Forms.DialogResult resultado = dialogo.ShowDialog();

            //Comprobamos si el usuario ha pulsado el botón Aceptar
            if (resultado == System.Windows.Forms.DialogResult.OK)
            {
                //Accedemos a la ruta seleccionada por el usuario
                string ruta = dialogo.SelectedPath;
                RutaSeleccionada = ruta;
            }
        }


    }
}
