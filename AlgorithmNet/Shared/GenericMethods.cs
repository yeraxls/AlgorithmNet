using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmNet.Shared
{
    public class GenericMethods
    {
        public bool HasProperty<T>(List<T> instance, string propertyName)
        {
            return instance[0].GetType().GetProperty(propertyName) != null;
        }
        public bool HasProperty<T>(T instance, string propertyName)
        {
            return instance.GetType().GetProperty(propertyName) != null;
        }
        public string GetPropertyValue<T>(T obj, string propertyName) where T : class
        {
            if(!HasProperty<T>(obj, propertyName))
                return string.Empty;
            var result = obj.GetType().GetProperty(propertyName).GetValue(obj);
            //var a = (T)(propertyInfo.GetValue(obj));

            return result.ToString();
        }
    }
}
