using System.Collections.Generic;
using System.Linq;

class SetOperations
{
    public static List<T> Diff<T>(
        IEnumerable<T> a, 
        IEnumerable<T> b, 
        IEnumerable<T> c, 
        bool symmetric = false
    )
    {
        if (symmetric)
        {

            var set = new HashSet<T>(a);
            set.SymmetricExceptWith(b);
            set.SymmetricExceptWith(c);
            return set.ToList();
        }
        else
        {

            var union = new HashSet<T>(b);
            union.UnionWith(c);
            return a.Where(x => !union.Contains(x)).ToList();
        }
    }
}



