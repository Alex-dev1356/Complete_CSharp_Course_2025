using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Exercises
{
    public class Properties_PropertiesOfTheOrderClass
    {
        /*
         The goal of this exercise is to finish the implementation of the Order class. 
         It represents a simple Order made in a store, and it needs to have two properties:
         The goal of this exercise is to finish the implementation of the Order class. 
         It represents a simple Order made in a store, and it needs to have two properties:
         Date (DateTime), which should be both gettable and settable. Its setter should validate 
         if the given value has the same year as the current year. If not, the value of the 
         Date property should not be changed. Your job is only to add the definitions of those 
         two properties. If needed, you can add backing fields as well.
        */


    }

    public class Order
    {
        //your code goes here
        public string Item { get; }
        private DateTime _date;
        public DateTime Date { 
            get { return _date; }
            set { 
                    if (value.Year == DateTime.Now.Year)
                    {
                        _date = value;
                    }
                }
            }

        public Order(string item, DateTime date)
        {
            Item = item;
            Date = date;
        }
    }
}
