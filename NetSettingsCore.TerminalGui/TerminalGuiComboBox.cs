using System;
using NetSettings.Common.Interfaces;
using NetSettings.TerminalGui.TerminalGuiControls;
using Terminal.Gui;

namespace NetSettingsCore.TerminalGui
{
    internal class TerminalGuiComboBox : TerminalGuiView, IComboBox
    {
        private readonly ComboBox _combobox;

        public TerminalGuiComboBox()
        {
            _combobox = new ComboBox();
            _view = _combobox;
        }

        public object SelectedItem { get => _combobox.SelectedItem; set => AddItem((string)value); }

        public event EventHandler SelectedIndexChanged;

        public void AddItem(string item)
        {
            _combobox.Add(new Label(item));
            //throw new NotImplementedException();
        }
    }
}