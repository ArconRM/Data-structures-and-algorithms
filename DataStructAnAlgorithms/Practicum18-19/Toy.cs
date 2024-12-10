using System;
namespace DataStructAnAlgorithms.Practicum1819
{
    internal class Toy : Product
    {
        protected string Manufacturer;
        protected string Material;

        public Toy() : base()
        {
            Manufacturer = "Прозводитель";
            Material = "Материал";
        }

        public Toy(
            string name,
            double price,
            string manufacturer,
            string material,
            AgeLimit ageLimit) : base(name, price, ageLimit)
        {
            Manufacturer = manufacturer;
            Material = material;
        }

        public Toy(Toy toy) : base(toy)
        {
            Manufacturer = toy.Manufacturer;
            Material = toy.Material;
        }

        public Toy(string[] props)
        {
            Name = props[0];
            Price = double.Parse(props[1]);
            Manufacturer = props[2];
            Material = props[3];
            AgeLimit = new AgeLimit(int.Parse(props[4].Split("-")[1]), int.Parse(props[4].Split("-")[0]));
        }

        public override void PrintInfo()
        {
            Console.WriteLine(ToString());
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (!obj.GetType().Equals(GetType())) return false;

            Toy unboxedObj = (Toy)obj;
            return unboxedObj.Name.Equals(Name) &&
            unboxedObj.Price.Equals(Price) &&
            unboxedObj.Manufacturer.Equals(Manufacturer) &&
            unboxedObj.Material.Equals(Material) &&
            unboxedObj.AgeLimit.Equals(AgeLimit);
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode() + Manufacturer.GetHashCode();
        }

        public override string ToString()
        {
            return $"Игрушка {Name}; Цена {Price}; Производитель: {Manufacturer}; Материал: {Material}; Целевой возраст: {AgeLimit}";
        }
    }
}

