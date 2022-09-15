using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    /// <summary>
    /// Concrete creator
    /// </summary>
    public class CodeDiscountFactory : DiscountFactory
    {
        private readonly string _code;

        public CodeDiscountFactory(string code)
        {
            _code = code;
        }

        public override DiscountService CreateDiscountService() 
            => new CodeDiscountService(_code);
    }
}
