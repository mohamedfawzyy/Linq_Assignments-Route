using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAssignments
{
    internal class CustomeWordSort : IComparer<string>
    {
        public int Compare(string? x, string? y)
        {
            return x?.ToLower().CompareTo(y.ToLower())??(y is null?0:-1);
        }
    }
}
