using System;
using Newtonsoft.Json;

namespace _3LArchitecture.Common.Entities
{
    public class Book : Product
    {
        public string Author { get; protected set; }
        public string Publisher { get; protected set; }
        
        [JsonConstructor]
        public Book(
            Guid uuid,
            string name,
            string author,
            string publisher,
            double price,
            AgeLimit ageLimit) : base(uuid, name, price, ageLimit)
        {
            Author = author;
            Publisher = publisher;
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
            return $"{UUID} Книга {Name}; От издательства {Publisher}; Цена: {Price}; Целевой возраст: {AgeLimit}";
        }
    }
}

