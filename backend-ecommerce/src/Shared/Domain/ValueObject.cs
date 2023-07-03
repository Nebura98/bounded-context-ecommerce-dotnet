﻿namespace backend_ecommerce.Src.Shared.Domain
{
    public abstract class ValueObject
    {
        public abstract IEnumerable<object> GetEqualityComponents();
        public static bool operator ==(ValueObject left, ValueObject right)=> Equals(left, right);
        public static bool operator !=(ValueObject left, ValueObject right)=> !Equals(left, right);

        public override bool Equals(object? obj)
        {
            if (obj is null || obj.GetType() != GetType())
            {
                return false;
            }

            var other = (ValueObject)obj;

            return GetEqualityComponents().SequenceEqual(other.GetEqualityComponents());
        }

        public override int GetHashCode()
        {
            return GetEqualityComponents()
                .Select(x => x?.GetHashCode() ?? 0)
                .Aggregate((x, y) => x ^ y);
        }
    }
}
