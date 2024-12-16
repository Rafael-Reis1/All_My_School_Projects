using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_vendas
{
    public class dtoProduct
    {
        private int iD;
        private string productName;
        private float price;
        private float qTDE;

        public int ID { get => iD; set => iD = value; }
        public string ProductName { get => productName; set => productName = value; }
        public float QTDE { get => qTDE; set => qTDE = value; }
        public float Price { get => price; set => price = value; }
    }
}
