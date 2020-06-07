using Lotto.Class;
using Lotto.Views;
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

namespace Lotto
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // Fragment kodu potrzebny do możliwości powiększania i pomniejszania do maksymalnej rozdzielczości ekranu
            this.MaxHeight = SystemParameters.MaximizedPrimaryScreenHeight;
        }
        /// <summary>
        /// Metoda odpowiedzialna za wyłączenie programu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Exit_button (object sender,RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        /// <summary>
        /// Metoda umożliwiająca poruszanie oknem programu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Moving_Window(object sender, RoutedEventArgs e)
        {
            DragMove();
        }
        /// <summary>
        /// Metoda odpowiedzialna za powiększanie i pomniejszanie okna programu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Max_View(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Normal)
            {
                this.WindowState = WindowState.Maximized;
            }
            else if (this.WindowState == WindowState.Maximized)
            {
                this.WindowState = WindowState.Normal;
            }
        }
        /// <summary>
        /// Metoda odpowiedzialna za minimalizacje okna programu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Min_View(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Normal)
            {
                this.WindowState = WindowState.Minimized;
            }
            else if (this.WindowState == WindowState.Maximized)
            {
                this.WindowState = WindowState.Minimized;
            }
        }

        /// <summary>
        /// Metoda odpowiedzialna za przejście do okienka EuroJackPot
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Euro_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new EuroJackPot_Mod();
        }
        /// <summary>
        /// Metoda odpowiedzialna za przejście do okienka Multi Multi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Multi_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new Multi_Mod();
        }
        /// <summary>
        /// Metoda odpowiedzialna za przejście do okienka Lotto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Lotto_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new Lotto_Mod();
        }
        /// <summary>
        /// Metoda odpowiedzialna za przejście do okienka Mini Lotto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Mini_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new Mini_Mod();
        }
        /// <summary>
        /// Metoda odpowiedzialna za powrót do głównego menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Home_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new MainPage();
        }
    }
}
