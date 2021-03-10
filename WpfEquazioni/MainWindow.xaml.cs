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
using EquazioniLibrary;
namespace WpfEquazioni
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void lblCalcola_Click(object sender, RoutedEventArgs e)
        {
            if (rdbDeterminata.IsChecked == true)
            {
                int a = int.Parse(txtA.Text);
                bool risposta = Equazioni.IsDetermined(a);
                if (risposta == true)
                {
                    txtRisultato.Text = "L'equazione è Determinata";
                }
                else
                {
                    txtRisultato.Text = "L'equazione non è Determinata";
                }
            }
            if (rdbInconsisted.IsChecked == true)
            {
                int a = int.Parse(txtA.Text);
                int b = int.Parse(txtB.Text);
                bool risposta = Equazioni.IsInconsisted(a, b);
                if (risposta == true)
                {
                    txtRisultato.Text = "L'equazione è Impossibile";
                }
                else
                {
                    txtRisultato.Text = "L'equazione non è Impossibile";
                }
            }
            if (rdbDegree2.IsChecked == true)
            {
                int x = int.Parse(txtX.Text);
                bool risposta = Equazioni.IsDegree2(x);
                if (risposta == true)
                {
                    txtRisultato.Text = "Equazione di secondo grado";
                }
                else
                {
                    txtRisultato.Text = "l'equazione non è di secondo grado";
                }
            }
            if (rdbDelta.IsChecked == true)
            {
                double a = double.Parse(txtA.Text);
                double b = double.Parse(txtB.Text);
                double c = double.Parse(txtC.Text);
                double risposta = Equazioni.Delta(a, b, c);
                txtRisultato.Text = ($"{risposta}");
            }
            if (rdbIndetermined.IsChecked == true)
            {
                int a = int.Parse(txtA.Text);
                int b = int.Parse(txtB.Text);
                bool risposta = Equazioni.IsIndetermined(a, b);
                if (risposta == true)
                {
                    txtRisultato.Text = "L'equazione è Indeterminata";
                }
                else
                {
                    txtRisultato.Text = "L'equazione non è Indeterminata";
                }
            }
            if (rdbResult.IsChecked == true)
            {
                double a = double.Parse(txtA.Text);
                double b = double.Parse(txtB.Text);
                double c = double.Parse(txtC.Text);
                txtRisultato.Text = Equazioni.EquationDegree1(a, b, c);

            }
        }
    }
}
