using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoreServicesBootCamp.UnitTests
{
    [TestClass]
    public class InMemoryDatabaseTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException),
         "Nie można podawać wartości pustych!")]
        public void ArgumentNullException()
        {
            //Arrange
            var database = new InMemoryDatabase();
            //Act
            database.createOrder(null, 0, null, 0, 0);
            database.createOrder(null, 0, "test", 0, 0);
            database.createOrder("test", 0, null, 0, 0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
        "ClientID zawiera spacje!")]
        public void ArgumentExceptionClientIdContainsSpaces()
        {
            //Arrange
            var database = new InMemoryDatabase();
            //Act
            database.createOrder("MK 12", 0, "nazwa", 0, 0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
        "ClientID zawiera więcej niż 6 znaków!")]
        public void ArgumentExceptionClientIdLengthLongerThan6()
        {
            //Arrange
            var database = new InMemoryDatabase();
            //Act
            database.createOrder("MichaelK12", 0, "nazwa", 0, 0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ArgumentExceptionClientIdTooLongWithSpaces()
        {
            //Arrange
            var database = new InMemoryDatabase();
            //Act
            database.createOrder("MichaelK 12", 0, "nazwa", 0, 0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ArgumentExceptionNameTooLong()
        {
            //Arrange
            var database = new InMemoryDatabase();
            //Act
            database.createOrder("MK12", 32323232, "Nazwa jest po prostu za dług4, pozdrawiam cieplutko wszystkich z Core Services i życzę miłego dnia/wieczoru. 12343442. Muszę coś jeszcze dopisać, bo chyba nie osiagnalem 255 znaków. RATATATATATAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", 0, 0);
        }
    }
}
