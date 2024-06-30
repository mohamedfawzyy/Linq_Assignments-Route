using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAssignments
{
    internal class CustomeWordCompaere : IEqualityComparer<string>

    {
        public bool Equals(string? x, string? y)
        {
        
            return  this.Sort(x) == this.Sort(y);
        }

        public int GetHashCode([DisallowNull] string obj)
        {
            return Sort(obj).GetHashCode();
        }
        private string Sort(string word) { 
                var array=word.ToCharArray();
                 Array.Sort(array);
            return new string(array);
        }
    }
}
