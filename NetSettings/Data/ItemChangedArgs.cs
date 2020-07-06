﻿namespace NetSettingsCore.Common
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
