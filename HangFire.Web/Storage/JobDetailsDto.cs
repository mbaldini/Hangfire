﻿using System.Collections.Generic;
using HangFire.Common;

namespace HangFire.Web
{
    internal class JobDetailsDto
    {
        public JobMethod Method { get; set; }
        public string[] Arguments { get; set; }
        public IDictionary<string, string> OldFormatArguments { get; set; }
        public string State { get; set; }
        public IDictionary<string, string> Properties { get; set; }
        public IList<Dictionary<string, string>> History { get; set; }
    }
}
