﻿using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using NetSettingsCore.Common;
using BorderStyle = NetSettingsCore.Common.BorderStyle;
using DockStyle = NetSettingsCore.Common.DockStyle;

namespace NetSettingsCore.WinForms.WinFormControls
{
    public class WinFormTextBox : TextBox, ITextBox
    {
        private WinFormFont _winFormFont;
        public new IList Controls => base.Controls;
        public new IFont Font
        {
            get
            {
                if (_winFormFont == null)
                {
                    _winFormFont = new WinFormFont(base.Font);
                }

                return _winFormFont;

            }
            set
            {
                base.Font = new Font(value.FontFamily, value.Size, (FontStyle)value.Appearance);
                _winFormFont = new WinFormFont(base.Font);
            }
        }

        public event EventHandler MouseClick;
        public event EventHandler SelectedIndexChanged;
        public event EventHandler MouseDoubleClick;
        public event EventHandler KeyDown;
        public ITextBox Instance { get=>this; }
        public DockStyle Dock { get; set; }
        public BorderStyle BorderStyle { get; set; }
    }
}