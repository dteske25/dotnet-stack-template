using System;
using System.Collections.Generic;
using System.Text;

namespace DotnetStack.Core.Types
{
    public class Quote : BaseDataObject
    {
        public string Text { get; set; } = "";
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";

    }
}
