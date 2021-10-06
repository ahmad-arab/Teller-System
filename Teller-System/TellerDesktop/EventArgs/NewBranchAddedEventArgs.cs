using System;
using System.Collections.Generic;
using System.Text;

namespace TellerDesktop
{
    public class NewBranchAddedEventArgs
    {
        public Branch Branch { get; set; }

        public NewBranchAddedEventArgs(Branch b)
        {
            Branch = b;
        }
    }
}
