using System;
using Lotto.Views;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Metody testujace składają się z Arrange, Act oraz Assert. 
        /// Testują poprawność działania metod polimorficznych niezbędnych do poprawnego działania programu
        /// </summary>

        /// <summary>
        /// Metoda Czy_Zwraca_Jeden() sprawdza czy poprawnie następuje przypisanie metody polimorficznej i wartość zwracana jest równa 1
        /// </summary>
        [TestMethod]
        public void Czy_Zwraca_Jeden()
        {
            //Arrange
            Liczby losowanie;
            losowanie = new Jeden();
            int spodzewana = 1;
            //Act
            var rezultat = losowanie.Liczba().Equals(spodzewana);
            //Assert
            Assert.IsTrue(rezultat);
        }
        /// <summary>
        /// Metoda Czy_Nie_Zwraca_Jeden() sprawdza czy metoda polimorficzna Dwa() nie zwraca innej wartości niż ta którą powinna zwracać czyli 2
        /// </summary>
        [TestMethod]
        public void Czy_Nie_Zwraca_Jeden()
        {
            //Arrange
            Liczby losowanie;
            losowanie = new Dwa();
            int spodzewana = 1;
            //Act
            var rezultat = losowanie.Liczba().Equals(spodzewana);
            //Assert
            Assert.IsFalse(rezultat);
        }
    }
}
