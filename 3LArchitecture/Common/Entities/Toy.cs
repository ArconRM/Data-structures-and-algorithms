using System;
using Newtonsoft.Json;

namespace _3LArchitecture.Common.Entities
{
    [Serializable]
    public class Toy : Product
    {
        public string Manufacturer { get; protected set; }
        public string Material { get; protected set; }

        [JsonConstructor]
        public Toy(
            Guid uuid,
            string name,
            double price,
            string manufacturer,
            string material,
            AgeLimit ageLimit
        ) : base(uuid, name, price, ageLimit)
        {
            Manufacturer = manufacturer;
            Material = material;
        }
        
        public Toy(
            string name,
            double price,
            string manufacturer,
            string material,
            AgeLimit ageLimit
        ) : base(name, price, ageLimit)
        {
            Manufacturer = manufacturer;
            Material = material;
        }

        public Toy(Toy toy) : base(toy)
        {
            Manufacturer = toy.Manufacturer;
            Material = toy.Material;
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
            return
                $"{UUID} Игрушка {Name}; Цена {Price}; Производитель: {Manufacturer}; Материал: {Material}; Целевой возраст: {AgeLimit}";
        }
    }
}