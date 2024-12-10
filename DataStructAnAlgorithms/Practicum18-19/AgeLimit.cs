using System;
namespace DataStructAnAlgorithms.Practicum1819
{
    internal struct AgeLimit
    {
        public int MaxAge;
        public int MinAge;

        public AgeLimit(int maxAge, int minAge)
        {
            MaxAge = maxAge;
            MinAge = minAge;
        }

        public override string ToString()
        {
            return $"{MinAge}-{MaxAge}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (!obj.GetType().Equals(GetType())) return false;

            AgeLimit unboxedObj = (AgeLimit)obj;
            return unboxedObj.MaxAge.Equals(MaxAge) && unboxedObj.MinAge.Equals(MinAge);
        }

        public override int GetHashCode()
        {
            return MaxAge.GetHashCode() + MinAge.GetHashCode();
        }
    }
}

