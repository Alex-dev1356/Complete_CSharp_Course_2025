using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamesAfterRefactorToSRP
{
    public class NameValidator
    {
        public bool IsValid(string name)
        {
            return
                name.Length >= 2 &&
                name.Length < 25 &&
                char.IsUpper(name[0]) &&
                name.All(char.IsLetter);
        }
    }
}
