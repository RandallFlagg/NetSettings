﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetSettings.Data
{
    public enum ItemChangedMode { None, OnTheFly, UserConfirmed, Synthesized }
    public class ItemChangedArgs
    {
        public string type { get; set; }
        public string Key { get; set; }
        public object Val { get; set; }
        public ItemChangedMode ChangedMode { get; set; }

        public object sender;

    }
}
