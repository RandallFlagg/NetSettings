﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NetSettings.Data
{
    public class Filter
    {
        public string IncludeName;

        internal bool IsEmpty()
        {
            return String.IsNullOrWhiteSpace(IncludeName);
        }
    }
}
