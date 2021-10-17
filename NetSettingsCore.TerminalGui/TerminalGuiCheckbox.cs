using NetSettings.Common.Interfaces;
using NetSettings.TerminalGui.TerminalGuiControls;
using Terminal.Gui;

namespace NetSettingsCore.TerminalGui
{
    internal class TerminalGuiCheckbox : TerminalGuiView, ICheckBox
    {
        private readonly CheckBox _checkBox;

        public TerminalGuiCheckbox()
        {
            _checkBox = new CheckBox();
            _view = _checkBox;
        }

        public bool Checked { get => _checkBox.Checked; set => _checkBox.Checked = value; }
    }
}