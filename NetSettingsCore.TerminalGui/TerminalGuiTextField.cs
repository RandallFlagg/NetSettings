using System;
using NetSettings.Common.Classes;
using NetSettings.Common.Interfaces;
using NetSettings.TerminalGui.TerminalGuiControls;
using Terminal.Gui;

namespace NetSettingsCore.TerminalGui
{
    internal class TerminalGuiTextField : TerminalGuiView, ITextBox
    {
        private readonly TextField _textField;

        public TerminalGuiTextField()
        {
            _textField = new TextField();
            _view = _textField;
        }

        public bool Multiline { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool ReadOnly { get => _textField.ReadOnly; set => _textField.ReadOnly = value; }
        public BorderStyle BorderStyle { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}