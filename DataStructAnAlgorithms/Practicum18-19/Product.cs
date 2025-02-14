using System;
namespace DataStructAnAlgorithms.Practicum1819
{
    [Serializable]
    internal abstract class Product : IComparable<Product>
    {
        protected string Name;
        protected double Price;
        protected AgeLimit AgeLimit;

        protected Product()
        {
            Name = "Имя";
            Price = -1;
            AgeLimit = new AgeLimit(0, 100);
        }

        protected Product(string name, double price, AgeLimit ageLimit)
        {
            Name = name;
            Price = price;
            AgeLimit = ageLimit;
        }

        protected Product(Product product)
        {
            Name = product.Name;
            Price = product.Price;
            AgeLimit = product.AgeLimit;
        }

        abstract public void PrintInfo();
        public bool MathesType(Type typeToCompare)
        {
            return GetType() == typeToCompare;
        }

        public abstract override bool Equals(object obj);
        public abstract override int GetHashCode();
        public abstract override string ToString();

        public int CompareTo(Product other)
        {
            return AgeLimit.MinAge.CompareTo(other.AgeLimit.MinAge);
        }
    }
}

