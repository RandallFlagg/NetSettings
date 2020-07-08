﻿using System;
using System.Windows.Forms;

namespace NetSettingsCore.WinForms.WinFormControls
{
    //TODO: Can this be deleted? See WinFormLabel
    //TODO: Can this be changed to internal?
    public class ComboBoxDoubleClick : WinFormComboBox 
    {
        DateTime prevClick = DateTime.MinValue;

        protected override void OnMouseClick(MouseEventArgs e)
        {
            if (DateTime.Now.AddMilliseconds(-500) < prevClick)
            {
                prevClick = DateTime.MinValue;
                OnMouseDoubleClick(e);
            }
            else
                prevClick = DateTime.Now;

            base.OnMouseClick(e);
        }
    }
}
