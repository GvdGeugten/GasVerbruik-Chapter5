using System;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace GasVerbruikV3.Entities
{
    public static class NameValueCollectionExtensions
    {
        public static Dictionary<TEnum, int> ToEnumDictionary<TEnum>(this NameValueCollection collection) where TEnum : struct, IConvertible
        {
            var enumDictonary = new Dictionary<TEnum, int>();
            foreach (var k in collection.AllKeys)
            {
                var enumT = (TEnum)Enum.Parse(typeof(TEnum), k);
                var i = Convert.ToInt32(collection[k]);
                enumDictonary.Add(enumT, i);
            }
            return enumDictonary;
        }
    }
}
