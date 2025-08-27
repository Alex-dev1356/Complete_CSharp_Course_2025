using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamesAfterRefactorToSRP
{
    public class Names
    {
        public readonly List<string> _names = new List<string>();
        private readonly NameValidator _nameValidator = new NameValidator();

        public List<string> AddNames(string name)
        {
            AddName(name);
            return _names;
        }
        public void AddName(string name)
        {
            if (_nameValidator.IsValid(name))
            {
                _names.Add(name);
            }
        }              
    }
}
