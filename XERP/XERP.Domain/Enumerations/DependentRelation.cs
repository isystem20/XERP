using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XERP.Domain.Enumerations
{
    public enum DependentRelation
    {
        GrandParent = 100,
        Spouse = 50,
        Sibling = 40,
        Child = 10,
        GrandChild = 5
    }
}
