using System;
using System.Collections.Generic;
using System.Text;

namespace TellerDesktop
{
    public class ValidationMessage
    {
        public bool BoolianEquivalent { get; set; }
        public string Text { get; set; }

        public ValidationMessage(string text)
        {
            Text = text;
        }
        public ValidationMessage(string text, bool boolianEquivalent)
        {
            Text = text;
            BoolianEquivalent = boolianEquivalent;
        }
    }
}
