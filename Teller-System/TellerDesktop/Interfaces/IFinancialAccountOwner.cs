using System;
using System.Collections.Generic;
using System.Text;

namespace TellerDesktop
{
    public interface IFinancialAccountOwner
    {
        public FinancialAccount FinancialAccount { get; set; }
    }
}
