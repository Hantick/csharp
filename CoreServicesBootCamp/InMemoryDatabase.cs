using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreServicesBootCamp
{
   public class Order
    {
        private
        String clientId;        //alfanumeryczne bez spacji, nie dłuższe niż 6 znaków
        ulong requestId;
        String name;            //alfanumeryczne ze spacjami, nie dłuższe niz 255 znaków
        uint quantity;
        double price;

        public
        Order(String clientId, ulong requestId, String name, uint quantity, double price)
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
    }
   public class InMemoryDatabase
    {
        private
        List<Order> orders;

        public
        InMemoryDatabase()
        {
            orders = new List<Order>();
        }
        public
        void createOrder(String clientId, ulong requestId, String name, uint quantity, double price)
        {
            var tmp = new Order(clientId, requestId, name, quantity, price);
            orders.Add(tmp);

        }
    }
}
