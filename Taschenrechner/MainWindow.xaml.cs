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

namespace Taschenrechner
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int aktuellerWert = 0;
        int letztesErgebnis = 0;
        bool zahleneingabeläuft = true;
        char letzteRechenoperation = '=';

        public MainWindow()
        {
            InitializeComponent();
            Title = "Rechner";
        }

        private void ZifferAnhängen(int z)
        {
            if (zahleneingabeläuft)
            {
                aktuellerWert = aktuellerWert * 10 + z;
            }
            else
            {
               aktuellerWert = z;
                zahleneingabeläuft = true;
            } 
            
          
            txtBlock.Text = aktuellerWert.ToString();
        }

        private void nullen(object sender, RoutedEventArgs e)
        {
            ZifferAnhängen(0);
        }
        private void eins(object sender, RoutedEventArgs e)
        {
            ZifferAnhängen(1);
        }

        private void zwei(object sender, RoutedEventArgs e)
        {
            ZifferAnhängen(2);
        }

        private void drei(object sender, RoutedEventArgs e)
        {
            ZifferAnhängen(3);
        }
        private void vier(object sender, RoutedEventArgs e)
        {
            ZifferAnhängen(4);
        }
        private void fünf(object sender, RoutedEventArgs e)
        {
            ZifferAnhängen(5);
        }
        private void sechs(object sender, RoutedEventArgs e)
        {
            ZifferAnhängen(6);
        }


        private void sieben(object sender, RoutedEventArgs e)
        {
           
            ZifferAnhängen(7);
        }

        private void acht(object sender, RoutedEventArgs e)
        {
            ZifferAnhängen(8);
        }

        private void neun(object sender, RoutedEventArgs e)
        {
            ZifferAnhängen(9);
        }

        private void Rechner(char rechenoperation)
        {
            switch (letzteRechenoperation)
            {
                case '+':
                    letztesErgebnis = letztesErgebnis + aktuellerWert;
                    break;
                case '-':
                    letztesErgebnis = letztesErgebnis - aktuellerWert;
                    break;
                case '*':
                    letztesErgebnis = letztesErgebnis * aktuellerWert;
                    break;
                case '/':
                    letztesErgebnis = letztesErgebnis / aktuellerWert;
                    break;
                case '=':
                    letztesErgebnis = aktuellerWert;
                    break;
            }
            txtBlock.Text = letztesErgebnis.ToString();
            zahleneingabeläuft = false;

            letzteRechenoperation = rechenoperation;
        }












        private void geteilt(object sender, RoutedEventArgs e)
        {
            Rechner('/');
        }

        private void mal(object sender, RoutedEventArgs e)
        {
            Rechner('*');
        }

        private void minus(object sender, RoutedEventArgs e)
        {
            Rechner('-');
        }

      

        private void plus(object sender, RoutedEventArgs e)
        {
            
            Rechner('+');
        }
        
    
    
    private void ergebnis(object sender, RoutedEventArgs e)
    {
            Rechner('=');


    }
    }
}

