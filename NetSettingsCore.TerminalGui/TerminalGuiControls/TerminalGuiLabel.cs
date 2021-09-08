using NetSettings.Common.Classes;
using NetSettings.Common.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using Terminal.Gui;

namespace NetSettings.TerminalGui.TerminalGuiControls
{
    internal class TerminalGuiLabel : TerminalGuiView, ILabel
    {
        private readonly Label _label;

        public TerminalGuiLabel() {
            _label = new Label();
            _view = _label;
        }
        //public IList VisualControl => throw new NotImplementedException();

        //public IList<IControl> LogicalControls { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        //public DockStyle Dock { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        //public NetSettings.Common.Classes.Color BackColor { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        //public NetSettings.Common.Classes.Color ForeColor { set => throw new NotImplementedException(); }
        //public NetSettings.Common.Classes.Point Location { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }


        //string IControl.Text { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        //int IControl.Width { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        //int IControl.Height { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        //public event EventHandler DoubleClick;
        //public event EventHandler TextChanged;
        //public event EventHandler MouseDoubleClick;
        //public event EventHandler Click;

        //event EventHandler IControl.MouseClick
        //{
        //    add
        //    {
        //        throw new NotImplementedException();
        //    }

        //    remove
        //    {
        //        throw new NotImplementedException();
        //    }
        //}

        //event EventHandler IControl.Leave
        //{
        //    add
        //    {
        //        throw new NotImplementedException();
        //    }

        //    remove
        //    {
        //        throw new NotImplementedException();
        //    }
        //}

        //event EventHandler IControl.KeyDown
        //{
        //    add
        //    {
        //        throw new NotImplementedException();
        //    }

        //    remove
        //    {
        //        throw new NotImplementedException();
        //    }
        //}

        //event EventHandler IControl.MouseEnter
        //{
        //    add
        //    {
        //        throw new NotImplementedException();
        //    }

        //    remove
        //    {
        //        throw new NotImplementedException();
        //    }
        //}

        //event EventHandler IControl.MouseLeave
        //{
        //    add
        //    {
        //        throw new NotImplementedException();
        //    }

        //    remove
        //    {
        //        throw new NotImplementedException();
        //    }
        //}

        //public IControl AddVisualControl(IControl control)
        //{
        //    throw new NotImplementedException();
        //}
    }
}