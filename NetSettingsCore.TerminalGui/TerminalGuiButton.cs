using NetSettings.Common.Classes;
using NetSettings.Common.Interfaces;
using NetSettings.TerminalGui.TerminalGuiControls;
using Terminal.Gui;

namespace NetSettingsCore.TerminalGui
{
    internal class TerminalGuiButton : TerminalGuiView, IButton
    {
        private readonly Button _button;

        public TerminalGuiButton()
        {
            _button = new Button();
            _view = _button;
        }

        public FlatStyle FlatStyle
        {
            //get =>  throw new NotImplementedException(); set => throw new NotImplementedException();
            get; set;
        }
    }
}