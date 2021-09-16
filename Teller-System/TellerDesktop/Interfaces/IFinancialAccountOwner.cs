using System;
using System.Collections.Generic;
using System.Text;

namespace TellerDesktop
{
    public interface IFinancialAccountOwner
    {
        public FinancialAccount FinancialAccount { get; set; }
        public string TypeName { get; set; }
        public string Name { get; set; }
    }
}
