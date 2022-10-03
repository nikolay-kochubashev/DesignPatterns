﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reporter
{
    public class EmployeeReport
    {
        public string Header { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public string Footer { get; set; }

        public override string? ToString() => new StringBuilder()
            .Append(Header)
            .Append(Title)
            .Append(Body)
            .Append(Footer)
            .ToString();
        
    }
}
