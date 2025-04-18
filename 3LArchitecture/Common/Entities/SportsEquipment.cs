using System;
using Newtonsoft.Json;

namespace _3LArchitecture.Common.Entities
{
    [Serializable]
    public class SportsEquipment : Product
    {
        public string Manufacturer { get; protected set; }

        [JsonConstructor]
        public SportsEquipment(
            Guid uuid,
            string name,
            double price,
            string manufacturer,
            AgeLimit ageLimit) : base(uuid, name, price, ageLimit)
        {
            Manufacturer = manufacturer;
        }
        
        public SportsEquipment(
            string name,
            double price,
            string manufacturer,
            AgeLimit ageLimit) : base(name, price, ageLimit)
        {
            Manufacturer = manufacturer;
        }

        public SportsEquipment(SportsEquipment sportsEquipment) : base(sportsEquipment)
        {
            Manufacturer = sportsEquipment.Manufacturer;
        }

        public override void PrintInfo()
        {
            Console.WriteLine(ToString());
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (!obj.GetType().Equals(GetType())) return false;

            SportsEquipment unboxedObj = (SportsEquipment)obj;
            return unboxedObj.Name.Equals(Name) &&
            unboxedObj.Price.Equals(Price) &&
            unboxedObj.Manufacturer.Equals(Manufacturer) &&
            unboxedObj.AgeLimit.Equals(AgeLimit);
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode() + Manufacturer.GetHashCode();
        }

        public override string ToString()
        {
            return $"{UUID} Спорт-инвентарь {Name}; Цена {Price}; Производитель: {Manufacturer}; Целевой возраст: {AgeLimit}";
        }
    }
}

