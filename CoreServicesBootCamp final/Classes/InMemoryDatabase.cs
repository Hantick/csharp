using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreServicesBootCamp
{
    #region request class
    public class request
    {
        
        public String clientId { get; set; }       //alfanumeryczne bez spacji, nie dłuższe niż 6 znaków
        public ulong requestId { get; set; }
        public String name { get; set; }            //alfanumeryczne ze spacjami, nie dłuższe niz 255 znaków
        public uint quantity { get; set; }
        public double price { get; set; }

        public request(){ }
        public request(String clientId, ulong requestId, String name, uint quantity, double price)
        {
            this.clientId = clientId;
            this.requestId = requestId;
            this.name = name;
            this.quantity = quantity;
            this.price = price;
        }
        public String getClientId()
        {
            return clientId;
        }
        public ulong getRequestId()
        {
            return requestId;
        }
        public String getName()
        {
            return name;
        }
        public uint getQuantity()
        {
            return quantity;
        }
        public double getPrice()
        {
            return price;
        }

    }
    #endregion
    #region InMemoryDatabase class
    public class InMemoryDatabase
    {
        private
        List<request> orders;

        public InMemoryDatabase()
        {
            orders = new List<request>();
        }
        /// <summary>
        /// Dodaj baze do bazy
        /// </summary>
        /// <param name="inMemoryDatabase"></param>
        internal void addOrders(InMemoryDatabase inMemoryDatabase)
        {
            orders.AddRange(inMemoryDatabase.getOrders());
        }
        /// <summary>
        /// Przypisz obiekt typu request do listy request.
        /// </summary>
        /// <param name="order"></param>
        public void createOrder(request order)
        {
            
            orders.Add(order);

        }
        /// <summary>
        /// Stwórz obiekt typu request i dodaj do listy request.
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="requestId"></param>
        /// <param name="name"></param>
        /// <param name="quantity"></param>
        /// <param name="price"></param>
        public void createOrder(String clientId, ulong requestId, String name, uint quantity, double price)
        {
           
            orders.Add(new request(clientId, requestId, name, quantity, price));

        }
        /// <summary>
        /// Metoda zwraca ilość zamówień przechowywanych w bazie.
        /// </summary>
        /// <returns>int</returns>
        public int getAmountOfOrders()
        {
            return orders.Count();
        }
        /// <summary>
        /// Zwróć listę obiektów typu request
        /// </summary>
        /// <returns></returns>
        public List<request> getOrders()
        {
            return orders;
        }
        /// <summary>
        /// Ustaw listę obiektów request na inną listę.
        /// </summary>
        /// <param name="orders"></param>
        public void setOrders(List<request> orders)
        {
            this.orders=orders;
        }
        /// <summary>
        /// Wyczyść listę obiektów typu request.
        /// </summary>
        public void clearOrders()
        {
            orders.Clear();
        }
        /// <summary>
        /// Sprawdź, czy klient o podanym Id istnieje w bazie.
        /// </summary>
        /// <param name="clientId"></param>
        /// <returns></returns>
        public bool clientExists(String clientId)
        {
            foreach (request req in orders)
            {
                if (req.getClientId() == clientId)
                    return true;
            }
            return false;
        }
        /// <summary>
        /// Zwróć liczbę zamówień w liście (obiektów typu request).
        /// </summary>
        /// <returns></returns>
        public uint getAmountOfRequests()
        {
            uint count=0;
            foreach(request req in orders)
            {
                count += req.getQuantity();
            }
            return count;
        }
        /// <summary>
        /// Zwróć liczbę zamówień w liście (obiektów typu request) przypisaną do konkretnego id klienta.
        /// </summary>
        /// <param name="clientId"></param>
        /// <returns></returns>
        public uint getClientAmountOfRequests(String clientId)
        {
            uint count = 0;
            foreach (request req in orders)
            {
                if(req.getClientId() == clientId)
                count += req.getQuantity();
            }
            return count;
        }
        /// <summary>
        /// Zlicz całkowitą wartość produktów z zamówienia
        /// </summary>
        /// <returns></returns>
        public double getTotalPrice()
        {
            double price=0;
            foreach(request req in orders)
            {
                price+=req.getQuantity() * req.getPrice();
            }
            return price;
        }
        /// <summary>
        /// Zlicz całkowitą wartość produktów z zamówienia przypisaną do konkretnego id klienta.
        /// </summary>
        /// <param name="clientId"></param>
        /// <returns></returns>
        public double getClientTotalPrice(String clientId)
        {
            double price = 0;
            foreach (request req in orders)
            {
                if(req.getClientId()==clientId)
                price += req.getQuantity() * req.getPrice();
            }
            return price;
        }
        /// <summary>
        /// Sprawdź poprawność danych w bazie, usuń błędy.
        /// </summary>
        public void check()
        {
            String clientId, name;
            foreach (request req in orders)
            {
                clientId = req.getClientId();
                name = req.getName();
                if (clientId == null || name == null)
                {
                    orders.Remove(req);
                    throw new ArgumentNullException("Nie można podawać wartości pustych!");
                }
                if (clientId.Contains(" "))
                {
                    orders.Remove(req);
                    throw new ArgumentException("ClientID zawiera spacje!");
                }
                if (clientId.Length > 6)
                {
                    orders.Remove(req);
                    throw new ArgumentException("ClientID zawiera więcej niż 6 znaków!");
                }
                if (name.Length > 255)
                {
                    orders.Remove(req);
                    throw new ArgumentException("Name zawiera więcej niż 255 znaków!");
                }
            }
        }
    }
#endregion
}
