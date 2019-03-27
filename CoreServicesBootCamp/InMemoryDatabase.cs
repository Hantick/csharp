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
       /*     if(clientId==null || name==null)
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
            }*/
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
        public bool clientExists(String clientId)
        {
            foreach (request req in orders)
            {
                if (req.getClientId() == clientId)
                    return true;
            }
            return false;
        }
        public uint getAmountOfRequests()
        {
            uint count=0;
            foreach(request req in orders)
            {
                count += req.getQuantity();
            }
            return count;
        }
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
        public double getTotalPrice()
        {
            double price=0;
            foreach(request req in orders)
            {
                price+=req.getQuantity() * req.getPrice();
            }
            return price;
        }
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
}
