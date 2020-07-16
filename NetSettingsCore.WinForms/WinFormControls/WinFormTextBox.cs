using System;
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
        public DockStyle Dock 
        {
            get { return GUIBindings.FromWinFormDockStyle(base.Dock);}
            set { base.Dock = GUIBindings.ToWinFormDockStyle(value); }
        }
        public BorderStyle BorderStyle { get; set; }
    }

    class GUIBindings
    {
        public static DockStyle FromWinFormDockStyle(System.Windows.Forms.DockStyle dockStyle)
        {
            switch (dockStyle)
            {
                case System.Windows.Forms.DockStyle.None:
                    return DockStyle.None;
                    break;
                case System.Windows.Forms.DockStyle.Top:
                    break;
                case System.Windows.Forms.DockStyle.Bottom:
                    break;
                case System.Windows.Forms.DockStyle.Left:
                    break;
                case System.Windows.Forms.DockStyle.Right:
                    break;
                case System.Windows.Forms.DockStyle.Fill:
                    return DockStyle.Fill;
                    break;
            }

            return DockStyle.None;
        }

        public static System.Windows.Forms.DockStyle ToWinFormDockStyle(DockStyle dockStyle)
        {
            switch (dockStyle)
            {
                case DockStyle.None:
                    return System.Windows.Forms.DockStyle.None;
                case DockStyle.Fill:
                    return System.Windows.Forms.DockStyle.Fill;
                    
            }
            return System.Windows.Forms.DockStyle.None;


        }

    }
}