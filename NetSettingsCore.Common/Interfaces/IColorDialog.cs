﻿namespace NetSettingsCore.Common.Interfaces
{
    public interface IColorDialog : IControl
    {
        object Color { get; set; }
        bool FullOpen { get; set; }
        DialogResult ShowDialog();
    }
}