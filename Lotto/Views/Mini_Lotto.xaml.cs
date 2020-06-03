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
    /// Logika interakcji dla klasy Mini_Lotto.xaml
    /// </summary>
   
    public partial class Mini_Lotto : UserControl
    {
        /// <summary>
        /// Konstruktor który inicjalizuje wartości początkowe tablicy o nazwie tablica1 i wywołuje pierwsze losowanie bez powtórzeń w tej klasie istnieje możliwości modyfikowania ilości kul zgodnie z wytycznymi
        /// Mamy tablice typu TextBlock odpowiedzialna za liczby od 1 do 42 oraz tablice typu Border o nazwie tablica2, która jest odpowiedzialna za ukrywanie nadmiarowych kul wartość startowa jest równa 5
        /// </summary>
        public Mini_Lotto()
        {
            InitializeComponent();
            /// Ukrywanie nadmiarowych kul
            Border[] tablica2 = new Border[] { bor0, bor1, bor2, bor3, bor4, bor5, bor6, bor7, bor8, bor9, bor10, bor11 };
            for (int i = tablica2.Length - 1; i > 4; i--)
            {
                tablica2[i].Visibility = Visibility.Hidden;
            }
            Liczby licz = null;
            switch (Liczba.Text)
            {
                case "5":
                    licz = new Piec();
                    licz.Liczba();
                    break;
            }
            int[] tablica = new int[licz.Liczba()];
            TextBlock[] tablica1 = new TextBlock[] { kula0, kula1, kula2, kula3, kula4, kula5, kula6, kula7, kula8, kula9, kula10, kula11 };
            Random rand = new Random();

            /// Algorytm losujący
            for (int i = 0; i < Convert.ToInt32(Liczba.Text); i++)
            {
                tablica[i] = rand.Next(1, 43);

                for (int j = 0; j < i; j++)
                {
                    /// Algorytm zapewniający brak powtórzeń
                    if (tablica[i] == tablica[j])
                    {
                        i--;
                        break;
                    }
                }
            }
            /// Algorytm sortowania bombelkowego
            int zmienna = tablica.Length;
            do
            {
                for (int j = 0; j < zmienna - 1; j++)
                {
                    if (tablica[j] > tablica[j + 1])
                    {
                        int temp = tablica[j];
                        tablica[j] = tablica[j + 1];
                        tablica[j + 1] = temp;
                    }
                }
                zmienna--;
            } while (zmienna > 1);
            /// Algorytm przypisywania tablicy int do tablicy TexBlock
            for (int i = 0; i < Convert.ToInt32(Liczba.Text); i++)
            {
                tablica1[i].Text = tablica[i].ToString();
            }

            /// Usuwa nadmiarowe wartości z tablicy
            for (int i = tablica1.Length - 1; i > Convert.ToInt32(Liczba.Text) - 1; i--)
            {
                tablica1[i].Text = string.Empty;
            }
        }
        /// <summary>
        /// Metoda ta jest odpowiedzialna za zmianę ilości widocznych kul poprzez zmianę wartoścli pola typu TextBlock o nazwie Liczba na 5
        /// </summary>
        private void Piec(object sender, RoutedEventArgs e)
        {
            Liczba.Text = "5";
            Border[] tablica2 = new Border[] { bor0, bor1, bor2, bor3, bor4, bor5, bor6, bor7, bor8, bor9, bor10, bor11 };
            for (int i = 0; i < tablica2.Length; i++)
            {
                tablica2[i].Visibility = Visibility.Hidden;
            }

            for (int i = 0; i < Convert.ToInt16(Liczba.Text); i++)
            {
                tablica2[i].Visibility = Visibility.Visible;
            }
        }
        /// <summary>
        /// Metoda ta jest odpowiedzialna za zmianę ilości widocznych kul poprzez zmianę wartoścli pola typu TextBlock o nazwie Liczba na 6
        /// </summary>
        private void Szesc(object sender, RoutedEventArgs e)
        {
            Liczba.Text = "6";
            Border[] tablica2 = new Border[] { bor0, bor1, bor2, bor3, bor4, bor5, bor6, bor7, bor8, bor9, bor10, bor11 };
            for (int i = 0; i < tablica2.Length; i++)
            {
                tablica2[i].Visibility = Visibility.Hidden;
            }

            for (int i = 0; i < Convert.ToInt16(Liczba.Text); i++)
            {
                tablica2[i].Visibility = Visibility.Visible;
            }
        }
        /// <summary>
        /// Metoda ta jest odpowiedzialna za zmianę ilości widocznych kul poprzez zmianę wartoścli pola typu TextBlock o nazwie Liczba na 7
        /// </summary>
        private void Siedem(object sender, RoutedEventArgs e)
        {
            Liczba.Text = "7";
            Border[] tablica2 = new Border[] { bor0, bor1, bor2, bor3, bor4, bor5, bor6, bor7, bor8, bor9, bor10, bor11 };
            for (int i = 0; i < tablica2.Length; i++)
            {
                tablica2[i].Visibility = Visibility.Hidden;
            }

            for (int i = 0; i < Convert.ToInt16(Liczba.Text); i++)
            {
                tablica2[i].Visibility = Visibility.Visible;
            }
        }
        /// <summary>
        /// Metoda ta jest odpowiedzialna za zmianę ilości widocznych kul poprzez zmianę wartoścli pola typu TextBlock o nazwie Liczba na 8
        /// </summary>
        private void Osiem(object sender, RoutedEventArgs e)
        {
            Liczba.Text = "8";
            Border[] tablica2 = new Border[] { bor0, bor1, bor2, bor3, bor4, bor5, bor6, bor7, bor8, bor9, bor10, bor11 };
            for (int i = 0; i < tablica2.Length; i++)
            {
                tablica2[i].Visibility = Visibility.Hidden;
            }

            for (int i = 0; i < Convert.ToInt16(Liczba.Text); i++)
            {
                tablica2[i].Visibility = Visibility.Visible;
            }
        }
        /// <summary>
        /// Metoda ta jest odpowiedzialna za zmianę ilości widocznych kul poprzez zmianę wartoścli pola typu TextBlock o nazwie Liczba na 9
        /// </summary>
        private void Dziewiec(object sender, RoutedEventArgs e)
        {
            Liczba.Text = "9";
            Border[] tablica2 = new Border[] { bor0, bor1, bor2, bor3, bor4, bor5, bor6, bor7, bor8, bor9, bor10, bor11 };
            for (int i = 0; i < tablica2.Length; i++)
            {
                tablica2[i].Visibility = Visibility.Hidden;
            }
            for (int i = 0; i < Convert.ToInt16(Liczba.Text); i++)
            {
                tablica2[i].Visibility = Visibility.Visible;
            }
        }
        /// <summary>
        /// Metoda ta jest odpowiedzialna za zmianę ilości widocznych kul poprzez zmianę wartoścli pola typu TextBlock o nazwie Liczba na 10
        /// </summary>
        private void Dziesiec(object sender, RoutedEventArgs e)
        {
            Liczba.Text = "10";
            Border[] tablica2 = new Border[] { bor0, bor1, bor2, bor3, bor4, bor5, bor6, bor7, bor8, bor9, bor10, bor11 };
            for (int i = 0; i < tablica2.Length; i++)
            {
                tablica2[i].Visibility = Visibility.Hidden;
            }

            for (int i = 0; i < Convert.ToInt16(Liczba.Text); i++)
            {
                tablica2[i].Visibility = Visibility.Visible;
            }
        }
        /// <summary>
        /// Metoda ta jest odpowiedzialna za zmianę ilości widocznych kul poprzez zmianę wartoścli pola typu TextBlock o nazwie Liczba na 11
        /// </summary>
        private void Jedenascie(object sender, RoutedEventArgs e)
        {
            Liczba.Text = "11";
            Border[] tablica2 = new Border[] { bor0, bor1, bor2, bor3, bor4, bor5, bor6, bor7, bor8, bor9, bor10, bor11 };
            for (int i = 0; i < tablica2.Length; i++)
            {
                tablica2[i].Visibility = Visibility.Hidden;
            }

            for (int i = 0; i < Convert.ToInt16(Liczba.Text); i++)
            {
                tablica2[i].Visibility = Visibility.Visible;
            }
        }
        /// <summary>
        /// Metoda ta jest odpowiedzialna za zmianę ilości widocznych kul poprzez zmianę wartoścli pola typu TextBlock o nazwie Liczba na 12
        /// </summary>
        private void Dwanascie(object sender, RoutedEventArgs e)
        {
            Liczba.Text = "12";
            Border[] tablica2 = new Border[] { bor0, bor1, bor2, bor3, bor4, bor5, bor6, bor7, bor8, bor9, bor10, bor11 };
            for (int i = 0; i < tablica2.Length; i++)
            {
                tablica2[i].Visibility = Visibility.Hidden;
            }

            for (int i = 0; i < Convert.ToInt16(Liczba.Text); i++)
            {
                tablica2[i].Visibility = Visibility.Visible;
            }
        }
        /// <summary>
        /// Przycisk odpowiedzialny za losowanie liczb, zawiera switch case ze zmienną typu Liczby która jest klasą polimorficzną zawierającą
        /// metody ustawiające wartości na odpowiednią poprzez pobieranie liczby z pola TextBlock'a ustawianego w Metodach od Pięć do Dwanaście
        /// Dzięki mechanizmowi polimorfizmu można ustawić ile elementów tablicy tablica1 ma zostać wykorzystanych w losowaniu
        /// </summary>
        private void Mini_Klik(object sender, RoutedEventArgs e)
        {
            Liczby licz = null;
            switch (Liczba.Text)
            {
                case "5":
                    licz = new Piec();
                    licz.Liczba();
                    break;
                case "6":
                    licz = new Szesc();
                    licz.Liczba();
                    break;
                case "7":
                    licz = new Siedem();
                    break;
                case "8":
                    licz = new Osiem();
                    licz.Liczba();
                    break;
                case "9":
                    licz = new Dziewiec();
                    licz.Liczba();
                    break;
                case "10":
                    licz = new Dziesiec();
                    licz.Liczba();
                    break;
                case "11":
                    licz = new Jedenascie();
                    licz.Liczba();
                    break;
                case "12":
                    licz = new Dwanascie();
                    licz.Liczba();
                    break;
            }
            int[] tablica = new int[licz.Liczba()];
            TextBlock[] tablica1 = new TextBlock[] { kula0, kula1, kula2, kula3, kula4, kula5, kula6, kula7, kula8, kula9, kula10, kula11 };
            Random rand = new Random();

            /// Algorytm losujący
            for (int i = 0; i < Convert.ToInt32(Liczba.Text); i++)
            {
                tablica[i] = rand.Next(1, 43);

                for (int j = 0; j < i; j++)
                {
                    /// Algorytm zapewniający brak powtórzeń
                    if (tablica[i] == tablica[j])
                    {
                        i--;
                        break;
                    }
                }
            }
            /// Algorytm sortowania bombelkowego
            int zmienna = tablica.Length;
            do
            {
                for (int j = 0; j < zmienna - 1; j++)
                {
                    if (tablica[j] > tablica[j + 1])
                    {
                        int temp = tablica[j];
                        tablica[j] = tablica[j + 1];
                        tablica[j + 1] = temp;
                    }
                }
                zmienna--;
            } while (zmienna > 1);
            /// Algorytm przypisywania tablicy int do tablicy TexBlock
            for (int i = 0; i < Convert.ToInt32(Liczba.Text); i++)
            {
                tablica1[i].Text = tablica[i].ToString();
            }

            /// Usuwa nadmiarowe wartości z tablicy
            for (int i = tablica1.Length - 1; i > Convert.ToInt32(Liczba.Text) - 1; i--)
            {
                tablica1[i].Text = string.Empty;
            }
        }
    }
}
