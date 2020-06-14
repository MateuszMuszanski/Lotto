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
    /// Logika interakcji dla klasy Lotto_Lotto.xaml
    /// </summary>
    public partial class Lotto_Lotto : UserControl
    {
        /// <summary>
        /// Konstruktor który inicjalizuje wartości początkowe tablicy o nazwie tablica1 i wywołuje pierwsze losowanie bez powtórzeń w tej klasie istnieje możliwości modyfikowania ilości kul zgodnie z wytycznymi
        /// Mamy tablice typu TextBlock odpowiedzialna za liczby od 1 do 49 oraz tablice typu Border o nazwie tablica2, która jest odpowiedzialna za ukrywanie nadmiarowych kul wartość startowa jest równa 6
        /// </summary>
        public Lotto_Lotto()
        {
            InitializeComponent();
            /// Ukrywanie nadmiarowych kul
            Border[] tablica2 = new Border[] { bor0, bor1, bor2, bor3, bor4, bor5, bor6, bor7, bor8, bor9, bor10, bor11 };
            for (int i = tablica2.Length - 1; i > int.Parse(Liczba.Text)-1; i--)
            {
                tablica2[i].Visibility = Visibility.Hidden;
            }
            Liczby licz = null;
            switch (Liczba.Text)
            {
                case "6":
                    licz = new Szesc();
                    licz.Liczba();
                    break;
            }
            int[] tablica = new int[licz.Liczba()];
            TextBlock[] tablica1 = new TextBlock[] { kula0, kula1, kula2, kula3, kula4, kula5, kula6, kula7, kula8, kula9, kula10, kula11 };
            Random rand = new Random();

            /// Algorytm losujący
            for (int i = 0; i < Convert.ToInt32(Liczba.Text); i++)
            {
                tablica[i] = rand.Next(1, 50);

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
            ///Algorytm sortowania bombelkowego
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
        /// Metoda ta jest odpowiedzialna za zmianę ilości widocznych kul poprzez zmianę wartoścli pola typu TextBlock o nazwie Liczba na 6
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <param name="sender"> Nadawca zdarzenia </param>
        /// <param name="e"> Przekazuje informacje związane ze zdarzeniami </param>
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
        /// <param name="sender"> Nadawca zdarzenia </param>
        /// <param name="e"> Przekazuje informacje związane ze zdarzeniami </param>
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
        /// <param name="sender"> Nadawca zdarzenia </param>
        /// <param name="e"> Przekazuje informacje związane ze zdarzeniami </param>
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
        /// <param name="sender"> Nadawca zdarzenia </param>
        /// <param name="e"> Przekazuje informacje związane ze zdarzeniami </param>
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
        /// <param name="sender"> Nadawca zdarzenia </param>
        /// <param name="e"> Przekazuje informacje związane ze zdarzeniami </param>
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
        /// <param name="sender"> Nadawca zdarzenia </param>
        /// <param name="e"> Przekazuje informacje związane ze zdarzeniami </param>
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
        /// metody ustawiające wartości na odpowiednią poprzez pobieranie liczby z pola TextBlock'a ustawianego w Metodach od Jeden do Dwanaście
        /// Dzięki mechanizmowi polimorfizmu można ustawić ile elementów tablicy tablica1 ma zostać wykorzystanych w losowaniu
        /// </summary>
        /// <param name="sender"> Nadawca zdarzenia </param>
        /// <param name="e"> Przekazuje informacje związane ze zdarzeniami </param>
        private void Klik(object sender, RoutedEventArgs e)
        {

            Liczby licz = null;
            switch (Liczba.Text)
            {
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
                tablica[i] = rand.Next(1, 50);

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
            ///Algorytm sortowania bombelkowego
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
            for (int i = 11; i > Convert.ToInt32(Liczba.Text) - 1; i--)
            {
                tablica1[i].Text = string.Empty;
            }
        }
    }
}
