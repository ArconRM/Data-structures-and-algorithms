using System;
namespace DataStructAnAlgorithms.Practicum1819
{
    [Serializable]
    internal class SportsEquipment : Product
    {
        protected string Manufacturer;

        public SportsEquipment() : base()
        {
            Manufacturer = "Производитель";
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

        public SportsEquipment(string[] props)
        {
            Name = props[0];
            Price = double.Parse(props[1]);
            Manufacturer = props[2];
            AgeLimit = new AgeLimit(int.Parse(props[3].Split("-")[1]), int.Parse(props[3].Split("-")[0]));
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
            return $"Спорт-инвентарь {Name}; Цена {Price}; Производитель: {Manufacturer}; Целевой возраст: {AgeLimit}";
        }
    }
}

