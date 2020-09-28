﻿namespace NetSettings.Common.Classes
{
    public enum GuiElementType
    {
        //{"text", typeof(ITextBox)},
        //{"bool", typeof(ICheckBox)
        //},
        //{"menu", typeof(ILabel)},
        //{"combo", typeof(IComboBoxDoubleClick)},
        //{"image", typeof(ITextBox)},
        //{"number", typeof(ITextBox)},
        //{"color", typeof(IColorControl)}
        Text,
        Number,
        Image,
        //ITextBox,
        Bool,
        //ICheckBox,
        Menu,
        //ILabel,
        Combo,
        //ComboBoxDoubleClick,
        Color,
        //ColorControl,
        IFont,
        GuiElement,
        Label,
        //ILabel,
        Button,
        ColorDialog,
        SaveFileDialog,
        OpenFileDialog
    }
}