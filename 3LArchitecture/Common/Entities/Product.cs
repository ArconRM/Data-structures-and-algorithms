using System;

namespace _3LArchitecture.Common.Entities
{
    public abstract class Product : IComparable<Product>
    {
        public Guid UUID { get; protected set; }
        
        public string Name { get; protected set; }
        
        public double Price { get; protected set; }
        
        public AgeLimit AgeLimit { get; protected set; }

        protected Product(Guid uuid, string name, double price, AgeLimit ageLimit)
        {
            UUID = uuid;
            Name = name;
            Price = price;
            AgeLimit = ageLimit;
        }
        
        protected Product(string name, double price, AgeLimit ageLimit)
        {
            UUID = Guid.NewGuid();
            Name = name;
            Price = price;
            AgeLimit = ageLimit;
        }

        protected Product(Product product)
        {
            UUID = product.UUID;
            Name = product.Name;
            Price = product.Price;
            AgeLimit = product.AgeLimit;
        }
        
        public bool MathesType(Type typeToCompare)
        {
            return GetType() == typeToCompare;
        }

        abstract public void PrintInfo();

        public abstract override bool Equals(object obj);
        
        public abstract override int GetHashCode();
        
        public abstract override string ToString();
        

        public int CompareTo(Product other)
        {
            return AgeLimit.MinAge.CompareTo(other.AgeLimit.MinAge);
        }
    }
}

