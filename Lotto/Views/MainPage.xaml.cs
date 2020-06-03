using Lotto.Class;
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
    // Klasy abstrakcyjne początek
    /// <summary>
    /// Klasa polimorficzna która zawiera metode typu integer o nazwie Liczba
    /// </summary>
    public abstract class Liczby
    {
        /// Metoda abstrakcyjna
        public abstract int Liczba();
    }
    /// <summary>
    /// Klasa która dziedziczy po klasie Liczby, przyjmuje wartość 1
    /// </summary>
    public class Jeden : Liczby
    {
        /// Metoda wirtualna 1
        public override int Liczba()
        {
            int a = 1;
            return a;
        }
    }
    /// <summary>
    /// Klasa która dziedziczy po klasie Liczby, przyjmuje wartość 2
    /// </summary>
    public class Dwa : Liczby
    {
        /// Metoda wirtualna 2
        public override int Liczba()
        {
            int a = 2;
            return a;
        }
    }
    /// <summary>
    /// Klasa która dziedziczy po klasie Liczby, przyjmuje wartość 3
    /// </summary>
    public class Trzy : Liczby
    {
        /// Metoda wirtualna 3
        public override int Liczba()
        {
            int a = 3;
            return a;
        }
    }
    /// <summary>
    /// Klasa która dziedziczy po klasie Liczby, przyjmuje wartość 4
    /// </summary>
    public class Cztery : Liczby
    {
        /// Metoda wirtualna 4
        public override int Liczba()
        {
            int a = 4;
            return a;
        }
    }
    /// <summary>
    /// Klasa która dziedziczy po klasie Liczby, przyjmuje wartość 5
    /// </summary>
    public class Piec : Liczby
    {
        /// Metoda wirtualna 5
        public override int Liczba()
        {
            int a = 5;
            return a;
        }
    }
    /// <summary>
    /// Klasa która dziedziczy po klasie Liczby, przyjmuje wartość 6
    /// </summary>
    public class Szesc : Liczby
    {
        /// Metoda wirtualna 6
        public override int Liczba()
        {
            int a = 6;
            return a;
        }
    }
    /// <summary>
    /// Klasa która dziedziczy po klasie Liczby, przyjmuje wartość 7
    /// </summary>
    public class Siedem : Liczby
    {
        /// Metoda wirtualna 7
        public override int Liczba()
        {
            int a = 7;
            return a;
        }
    }
    /// <summary>
    /// Klasa która dziedziczy po klasie Liczby, przyjmuje wartość 8
    /// </summary>
    public class Osiem : Liczby
    {
        /// Metoda wirtualna 8
        public override int Liczba()
        {
            int a = 8;
            return a;
        }
    }
    /// <summary>
    /// Klasa która dziedziczy po klasie Liczby, przyjmuje wartość 9
    /// </summary>
    public class Dziewiec : Liczby
    {
        /// Metoda wirtualna 9
        public override int Liczba()
        {
            int a = 9;
            return a;
        }
    }
    /// <summary>
    /// Klasa która dziedziczy po klasie Liczby, przyjmuje wartość 10
    /// </summary>
    public class Dziesiec : Liczby
    {
        /// Metoda wirtualna 10
        public override int Liczba()
        {
            int a = 10;
            return a;
        }
    }
    /// <summary>
    /// Klasa która dziedziczy po klasie Liczby, przyjmuje wartość 11
    /// </summary>
    public class Jedenascie : Liczby
    {
        /// Metoda wirtualna 11
        public override int Liczba()
        {
            int a = 11;
            return a;
        }
    }
    /// <summary>
    /// Klasa która dziedziczy po klasie Liczby, przyjmuje wartość 12
    /// </summary>
    public class Dwanascie : Liczby
    {
        /// Metoda wirtualna 12
        public override int Liczba()
        {
            int a = 12;
            return a;
        }
    }
    // Klasy abstrakcyjne koniec

    /// <summary>
    /// Klasa odpowiedzialna za utworzenie okna
    /// </summary>
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void Euro_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new EuroJackPot_Mod();
        }

        private void Multi_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new Multi_Mod();
        }

        private void Lotto_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new Lotto_Mod();
        }

        private void Mini_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new Lotto_Mod();
        }
    }
}
