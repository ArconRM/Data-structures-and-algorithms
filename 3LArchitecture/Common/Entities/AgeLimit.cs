using System;
using Newtonsoft.Json;

namespace _3LArchitecture.Common.Entities
{
    public struct AgeLimit
    {
        public int MaxAge;
        public int MinAge;
        
        [JsonConstructor]
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

