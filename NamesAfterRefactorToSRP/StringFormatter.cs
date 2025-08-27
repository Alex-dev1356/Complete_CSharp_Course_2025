using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace NamesAfterRefactorToSRP
{
    public class StringFormatter
    {
        
        public string Format(List<string> names) =>
            string.Join(Environment.NewLine, names);
    }
}
