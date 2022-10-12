using Acme.Common;
using System.Net.Mail;

namespace ACM.BL
{
    public class Product : EntityBase, ILoggable
    {
        public Product()
        {

        }
        public Product(int productId)
        {
            ProductId = productId;
        }
        public int ProductId { get; private set; }
        public string Description { get; set; }
        public decimal? Price { get; set; }
        public string _name;
        public string Name
        {
            get
            {
                return _name.InsertSpaces();
            }
            set
            {
                _name = value;
            }
        }
        public override bool Validate()
        {
            var isValid = true;
            if(string.IsNullOrEmpty(Name)) isValid = false;
            if(Price == null) isValid = false;
            return isValid;
        }
        public override string ToString() => Name;

        public string Log() =>
            $"{ProductId}: {Name} Detail: {Description} Status: {EntityState}";
    }
}
