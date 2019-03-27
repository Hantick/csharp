using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreServicesBootCamp
{
   public class request
    {
        
        public String clientId { get; set; }       //alfanumeryczne bez spacji, nie dłuższe niż 6 znaków
        public ulong requestId { get; set; }
        public String name { get; set; }            //alfanumeryczne ze spacjami, nie dłuższe niz 255 znaków
        public uint quantity { get; set; }
        public double price { get; set; }

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
        public request(){ }
        public request(String clientId, ulong requestId, String name, uint quantity, double price)
        {
            if(clientId==null || name==null)
            {
                throw new ArgumentNullException("Nie można podawać wartości pustych!");
            }
            if(clientId.Contains(" "))
            {
                throw new ArgumentException("ClientID zawiera spacje!");
            }
            if(clientId.Length>6)
            {
                throw new ArgumentException("ClientID zawiera więcej niż 6 znaków!");
            }
            if(name.Length>255)
            {
                throw new ArgumentException("Name zawiera więcej niż 255 znaków!");
            }
            this.clientId = clientId;
            this.requestId = requestId;
            this.name = name;
            this.quantity = quantity;
            this.price = price;
        }
    /*   public class OrderMapper : ClassMap<Order>
        {
            public OrderMapper()
            {
                Map(x => x.clientId).Name("Client_Id").Index(0);
                Map(x => x.requestId).Name("Request_id").Index(1);
                Map(x => x.name).Name("Name").Index(2);
                Map(x => x.quantity).Name("Quantity").Index(3);
                Map(x => x.price).Name("Price").Index(4);
            }
        }*/

    }

    public class InMemoryDatabase
    {
        private
        List<request> orders;

        public InMemoryDatabase()
        {
            orders = new List<request>();
        }
        public void createOrder(request order)
        {
            
            orders.Add(order);

        }
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
        public List<request> getOrders()
        {
            return orders;
        }
        public void setOrders(List<request> orders)
        {
            this.orders=orders;
        }
        public void clearOrders()
        {
            orders.Clear();
        }
    }
}
