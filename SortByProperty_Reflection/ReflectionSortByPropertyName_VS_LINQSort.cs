using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace SortByProperty_Reflection
{
    public class ReflectionSortByPropertyName_VS_LINQSort
    {
        private const int _dataSetSize = 100000;
        private readonly List<User> _dataSet;

        public ReflectionSortByPropertyName_VS_LINQSort()
        {
            _dataSet = new List<User>();

            for (int i = 0; i < _dataSetSize; ++i)
            {
                _dataSet.Add(new User());
            }
        }

        [Benchmark]
        //public static List<T> SortByPropertyName<T>(string propName, List<T> items)
        public void SortByPropertyName()
        {
            string propName = "FirstName";

            Type type = _dataSet[0].GetType();

            PropertyInfo[] props = type.GetProperties();

            PropertyInfo prop;

            try
            {
                prop = props.First(p => p.Name.Equals(propName.ToString()));
            }
            catch (Exception)
            {
                return; // no property with that name
                //return null;
            }

            var sortedItems = _dataSet.OrderBy(x => prop.GetValue(x)).ToList();

            //return sortedItems;
        }

        [Benchmark]
        public void StandardSort()
        {
            _dataSet.OrderBy(x => x.FirstName).ToList();
        }
    }
}
