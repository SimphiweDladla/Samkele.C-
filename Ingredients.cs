using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samkele.C_
{
    class Ingredients
    {
        public string? Name { get; internal set; }
        public double Quantity { get; internal set; }
        public string? Unit { get; internal set; }

        internal static void Add(Ingredients ingredient)
        {
            throw new NotImplementedException();
        }
    }
}
