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

namespace Lotto.Views
{
    /// <summary>
    /// Logika interakcji dla klasy EuroJackpot.xaml
    /// </summary>
    public partial class EuroJackPot : UserControl
    {
        /// <summary>
        /// Konstruktor który inicjalizuje wartości początkowe tablic i wywołuje pierwsze losowanie bez powtórzeń w tej klasie nie ma możliwości modyfikowania ilości kul zgodnie z zaleceniami
        /// Mamy dwie tablice typu TextBlock, pierwsza odpowiedzialna za liczby od 1 do 50 tablica1 która zawiera w sobie elementy kula0...kula4
        /// tablica2 zawiera dwa elementy kula11 oraz kula12 która przyjmuje wartości od 1 do 10
        /// </summary>
        public EuroJackPot()
        {
            InitializeComponent();

            TextBlock[] tablica1 = new TextBlock[] { kula0, kula1, kula2, kula3, kula4 };
            TextBlock[] tablica2 = new TextBlock[] { kula11, kula12 };
            int[] tablicaZestaw1 = new int[5];
            int[] tablicaZestaw2 = new int[2];
            Random rand = new Random();
            /// Algorytm losowania liczb zestawu pierwszego
            for (int i = 0; i < tablicaZestaw1.Length; i++)
            {
                tablicaZestaw1[i] = rand.Next(1, 51);

                for (int j = 0; j < i; j++)
                {
                    /// Algorytm zapewniający brak powtórzeń
                    if (tablicaZestaw1[i] == tablicaZestaw1[j])
                    {
                        i--;
                        break;
                    }
                }
            }
            /// Algorytm sortowania bombelkowego pierwszego zestawu liczb
            int zmienna = tablicaZestaw1.Length;
            do
            {
                for (int j = 0; j < zmienna - 1; j++)
                {
                    if (tablicaZestaw1[j] > tablicaZestaw1[j + 1])
                    {
                        int temp = tablicaZestaw1[j];
                        tablicaZestaw1[j] = tablicaZestaw1[j + 1];
                        tablicaZestaw1[j + 1] = temp;
                    }
                }
                zmienna--;
            } while (zmienna > 1);
            /// Algorytm losowania liczb zestawu drugiego
            for (int i = 0; i < tablica2.Length; i++)
            {
                tablicaZestaw2[i] = rand.Next(1, 11);

                for (int j = 0; j < i; j++)
                {
                    /// Algorytm zapewniający brak powtórzeń
                    if (tablicaZestaw2[i] == tablicaZestaw2[j])
                    {
                        i--;
                        break;
                    }
                }
            }
            /// Algorytm przypisywania tablicy int do tablicy TexBlock
            for (int i = 0; i < tablica1.Length; i++)
            {
                tablica1[i].Text = tablicaZestaw1[i].ToString();
            }
            /// Algorytm sortowania bombelkowego drugiego zestawu liczb
            int zmiennA = tablica2.Length;
            do
            {
                for (int j = 0; j < zmiennA - 1; j++)
                {
                    if (tablicaZestaw2[j] > tablicaZestaw2[j + 1])
                    {
                        int temp = tablicaZestaw2[j];
                        tablicaZestaw2[j] = tablicaZestaw2[j + 1];
                        tablicaZestaw2[j + 1] = temp;
                    }
                }
                zmiennA--;
            } while (zmiennA > 1);
            /// Algorytm przypisywania tablicy int do tablicy TexBlock
            for (int i = 0; i < tablica2.Length; i++)
            {
                tablica2[i].Text = tablicaZestaw2[i].ToString();
            }
        }
        /// <summary>
        /// Ta metoda powoduje ponowne losowanie liczb, zawiera te same tablice oraz algorytmy losujące co konstruktor
        /// </summary>
        private void Klik(object sender, RoutedEventArgs e)
        {
            TextBlock[] tablica1 = new TextBlock[] { kula0, kula1, kula2, kula3, kula4 };
            TextBlock[] tablica2 = new TextBlock[] { kula11, kula12 };
            int[] tablicaZestaw1 = new int[5];
            int[] tablicaZestaw2 = new int[2];
            Random rand = new Random();
            /// Algorytm losowania liczb zestawu pierwszego
            for (int i = 0; i < tablicaZestaw1.Length; i++)
            {
                tablicaZestaw1[i] = rand.Next(1, 51);

                for (int j = 0; j < i; j++)
                {
                    /// Algorytm zapewniający brak powtórzeń
                    if (tablicaZestaw1[i] == tablicaZestaw1[j])
                    {
                        i--;
                        break;
                    }
                }
            }
            ///Algorytm sortowania bombelkowego pierwszego zestawu liczb
            int zmienna = tablicaZestaw1.Length;
            do
            {
                for (int j = 0; j < zmienna - 1; j++)
                {
                    if (tablicaZestaw1[j] > tablicaZestaw1[j + 1])
                    {
                        int temp = tablicaZestaw1[j];
                        tablicaZestaw1[j] = tablicaZestaw1[j + 1];
                        tablicaZestaw1[j + 1] = temp;
                    }
                }
                zmienna--;
            } while (zmienna > 1);
            /// Algorytm losowania liczb zestawu drugiego
            for (int i = 0; i < tablica2.Length; i++)
            {
                tablicaZestaw2[i] = rand.Next(1, 11);

                for (int j = 0; j < i; j++)
                {
                    /// Algorytm zapewniający brak powtórzeń
                    if (tablicaZestaw2[i] == tablicaZestaw2[j])
                    {
                        i--;
                        break;
                    }
                }
            }
            /// Algorytm przypisywania tablicy int do tablicy TexBlock
            for (int i = 0; i < tablica1.Length; i++)
            {
                tablica1[i].Text = tablicaZestaw1[i].ToString();
            }
            /// Algorytm sortowania bombelkowego drugiego zestawu liczb
            int zmiennA = tablica2.Length;
            do
            {
                for (int j = 0; j < zmiennA - 1; j++)
                {
                    if (tablicaZestaw2[j] > tablicaZestaw2[j + 1])
                    {
                        int temp = tablicaZestaw2[j];
                        tablicaZestaw2[j] = tablicaZestaw2[j + 1];
                        tablicaZestaw2[j + 1] = temp;
                    }
                }
                zmiennA--;
            } while (zmiennA > 1);
            /// Algorytm przypisywania tablicy int do tablicy TexBlock
            for (int i = 0; i < tablica2.Length; i++)
            {
                tablica2[i].Text = tablicaZestaw2[i].ToString();
            }
        }
    }
}
