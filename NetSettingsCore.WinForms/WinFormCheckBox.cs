using System;
using System.Collections;
using System.Windows.Forms;
using NetSettingsCore.Common;

namespace NetSettings.Forms
{
    public class WinFormCheckBox : CheckBox, ICheckBox
    {
        public WinFormCheckBox()
        {
            base.MouseClick += WinFormCheckBox_MouseClick;
        }
        public new IList Controls => base.Controls;
        public IFont Font { get; set; }
        public event EventHandler MouseClick;

        private void WinFormCheckBox_MouseClick(object sender, MouseEventArgs e)
        {
            MouseClick(sender, e as EventArgs);
        }

        //public event EventHandler MouseClick { get; set; }// { return CheckBox.MouseClick; };
        public event EventHandler SelectedIndexChanged;
        public event EventHandler MouseDoubleClick;
        public event EventHandler KeyDown;
    }
}