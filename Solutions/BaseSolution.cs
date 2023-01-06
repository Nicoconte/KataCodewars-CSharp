using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    public abstract class BaseSolution<TResponse>
    {
        public abstract TResponse Handle(object obj);
    }
}
