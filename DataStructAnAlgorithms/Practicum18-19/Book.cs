using System;
namespace DataStructAnAlgorithms.Practicum1819
{
    internal class Book : Product
    {
        protected string Author;
        protected string Publisher;

        public Book() : base()
        {
            Author = "Автор";
            Publisher = "Издатель";
        }

        public Book(
            string name,
            string author,
            string publisher,
            double price,
            AgeLimit ageLimit) : base(name, price, ageLimit)
        {
            Author = author;
            Publisher = publisher;
        }

        public Book(Book book) : base(book)
        {
            Author = book.Author;
            Publisher = book.Publisher;
        }

        public Book(string[] props)
        {
            Name = props[0];
            Author = props[1];
            Price = double.Parse(props[2]);
            Publisher = props[3];
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

            Book unboxedObj = (Book)obj;
            return unboxedObj.Name.Equals(Name) &&
            unboxedObj.Price.Equals(Price) &&
            unboxedObj.Publisher.Equals(Publisher) &&
            unboxedObj.AgeLimit.Equals(AgeLimit);
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode() + Publisher.GetHashCode();
        }

        public override string ToString()
        {
            return $"Книга {Name}; От издательства {Publisher}; Цена: {Price}; Целевой возраст: {AgeLimit}";
        }
    }
}

