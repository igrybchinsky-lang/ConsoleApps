using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Project2_Monkey
{
    class Product
    {
        private string _id, _model, _brand, _price;
         

    public Product(string id, string model, string brand, string price)
    {
            Id = id;
            Model = model;
            Brand = brand;
            Price = price;    
    }
        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public string Brand
        {
            get { return _brand; }
            set { _brand = value; }
        }

        public string Price
        {
            get { return _price; }
            set { _price = value; }
        }






    }

}
