﻿using System;
using System.Collections.Generic;
using System.Text;
using Avalonia.Collections;
using Avalonia.LogicalTree;
using NetSettingsCore.Common;

namespace NetSettingsCore.Avalonia.AvaloniaControls
{
    class LogicalControls : List<IControl>
    {
        public LogicalControls(IAvaloniaList<ILogical> logicalChildren)
        {
        }
    }
}
