using System;
using System.Collections.Generic;

namespace EasyCrud.Shared.DomainObjects
{
    public class Validation
    {
        public static void IsEmpty(string value, string mensage)
        {
            if (value == null || value.Trim().Length == 0)
                throw new DomainException(mensage);
        }

        public static void IsEquals(object obj1, object obj2, string mensagem)
        {
            if (obj1.Equals(obj2))
                throw new DomainException(mensagem);
        }

        public static void IsNull(object obj, string mensage)
        {
            if (obj == null)
                throw new DomainException(mensage);
        }

        public static void LessThan(DateTime value, DateTime minimum, string mensage)
        {
            if (value < minimum)
                throw new DomainException(mensage);
        }

        public static void GreaterThan(DateTime value, DateTime maximum, string mensage)
        {
            if (value > maximum)
                throw new DomainException(mensage);
        }

        public static void ExistsBetween(object obj, List<object> array, string mensage)  
        {
            if(!array.Contains(obj))
                throw new DomainException(mensage);
        }
    }
}
