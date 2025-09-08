using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Exercises
{
    public class IsOperatorAndNullobject_NumericTypesDescriber
    {

    }
    public static class NumericTypesDescriber
    {
        public static string Describe(object someObjectType)
        {
            //your code goes here
            if (someObjectType is int || someObjectType is double || someObjectType is decimal)
            {
                var value = someObjectType.ToString();
                var objectType = someObjectType.GetType().Name.Contains("Int") ?
                                "Int" : 
                                someObjectType.GetType().Name;

                return $"{objectType} of value {value}";
            }


            return null;

        }
    }
}
