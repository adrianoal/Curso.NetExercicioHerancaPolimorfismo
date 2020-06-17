using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Course.Entities
{
    class ImporteProduct : Product
    {
        public double customsFee { get; set; }

        public ImporteProduct()
        {
        }

        public ImporteProduct(string name, double price, double customsFree)
            : base(name, price)
        {
            this.customsFee = customsFree;
        }

        public double TotalPrice()
        {
            return Price + customsFee;
        }

        public override string PriceTag() // PriceTag --> Etiqueta de preco.
        {
            return Name
                + " R$"
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + "(Customs fee: R$"
                + customsFee.ToString("F2", CultureInfo.InvariantCulture)
                + ")";
        }


    }
}
