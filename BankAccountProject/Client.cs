using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    class Client
    {
        //FIELDS
        protected string clientName;
        protected int clientID;
        protected string clientPhone;

        //PROPERTIES
        public string ClientName
        {
            get { return this.clientName; }
            set { clientName = value; }
        }

        public int ClientID
        {
            get { return this.clientID; }
            set { clientID = value; }
        }

        public string ClientPhone
        {
            get { return this.clientPhone; }
            set { clientPhone = value; }

        }

        //METHODS
        public void DisplayClient(string clientName)
        {
            this.ClientName = clientName;
            Console.WriteLine("\n\t{0}\n\tCustomer ID: {1}\n\t{2}\n\n\n", clientName, clientID, clientPhone);
        }

        //CONSTRUCTOR
        public Client()
        {
        }
    }
}
