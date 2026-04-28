using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagement
{
    internal class Product
    {
        private string _name;
        private string _producer;
        private string _id;
        private int _quantity;


        public Product(string[] data)
        {
            _id = data[0];
            Name = data[1];
            Producer = data[2];
            Quantity = Convert.ToInt32(data[3]);

        }

        public Product(string id,string name, string producer, int quantity)
        {
           Name = name;
            Producer = producer;
            Quantity = quantity;
            _id = id;
        }

        public Product( string name, string producer, int quantity)
        {
            Name = name;
            Producer = producer;
            Quantity = quantity;
            _id = GenerateId();
        }

        public string GenerateId()
        {
            Random rnd = new Random();
             return $"{Name[0]}{Name[Name.Length-1]}{rnd.Next(10000, 100000)}";
        }
        public string getData()
        {
            return $"{Id};{Name};{Producer};{Quantity}";
        }

        public string Id
        {
            get
            {
                return _id;
            }
        }



        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentException("the name shorter than 2 characters");
                }
                else
                {
                    _name = value;
                }
            }
        }

        public string Producer
        {
            get
            {
                return _producer;
            }
            set
            {
                if(value.Length < 2)
                {
                    throw new ArgumentException("the name shorter than 2 characters");
                }
                else
                {
                    _producer = value;
                }
            }
        }

        public int Quantity
        {
            get
            {
                return _quantity;
            }
            set
            {
                if(value < 1)
                {
                    throw new ArgumentException("it has to be at least 1 product");
                }
                else
                {
                    _quantity = value;
                }
            }
        }

    }
}
