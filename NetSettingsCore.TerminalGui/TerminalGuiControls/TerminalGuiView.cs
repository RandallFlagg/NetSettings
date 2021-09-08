using NetSettings.Common.Classes;
using NetSettings.Common.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using Terminal.Gui;
using static System.Reflection.Metadata.BlobBuilder;

namespace NetSettings.TerminalGui.TerminalGuiControls
{
    public class TerminalGuiView : IControl
    {
        protected View _view;
        //private WinFormFont _font;
        private readonly IList<IControl> _visualControls;

        public TerminalGuiView()
        {
            _view = new View();
            _visualControls = new List<IControl>();
        }

        public bool Visible { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Text { get => _view.Text.ToString(); set => _view.Text = value; }

        public IList VisualControl => (IList)this._visualControls;

        public IList<IControl> LogicalControls { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Width { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Height { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DockStyle Dock { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Common.Classes.Color BackColor
        {
            get => throw new NotImplementedException();
            //    _view.ColorScheme["Base"];
            set => throw new NotImplementedException();
            //_view.ColorScheme = value;
        }
        public Common.Classes.Color ForeColor
        {
            set => throw new NotImplementedException();//_view.ColorScheme = value;
        }
        public Common.Classes.Point Location { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IFont Font { get; set; }

        public virtual object Instance => _view;

        public event EventHandler DoubleClick;
        public event EventHandler MouseClick;
        public event EventHandler TextChanged;
        public event EventHandler Leave;
        public event EventHandler MouseDoubleClick;
        public event EventHandler KeyDown;
        public event EventHandler Click;
        public event EventHandler MouseEnter;
        public event EventHandler MouseLeave;

        public IControl AddVisualControl(IControl control)
        {
            Console.WriteLine("In TerminalGuiView.AddVisualControl");
            _visualControls.Add(control);
            _view.Add((View)control.Instance);
            return control;
            throw new NotImplementedException();
        }

        //public virtual Color BackColor
        //{
        //    get
        //    {
        //        var color = _view.BackColor;
        //        return Color.FromArgb(color.A, color.R, color.G, color.B);
        //    }
        //    set => _view.BackColor = DrawingColor.FromArgb(value.A, value.R, value.G, value.B);
        //}

        //public DockStyle Dock
        //{
        //    get => Enum.Parse<DockStyle>(_view.Dock.ToString());
        //    set => _view.Dock = Enum.Parse<WinFormDockStyle>(value.ToString());
        //}

        //public Point Location
        //{
        //    get => new Point(_view.Location.X, _view.Location.Y);
        //    set => _view.Location = new DrawingPoint(value.X, value.Y);
        //}

        //public IFont Font
        //{
        //    get => _font;
        //    set
        //    {
        //        _view.Font = (Font) value.Native;
        //        _font = new WinFormFont(_view.Font);
        //    }
        //}

        //public bool Visible { get => _view.Visible; set => _view.Visible = value; }
        //public string Text { get => _view.Text; set => _view.Text = value; }
        //public int Width { get => _view.Width; set => _view.Width = value; }
        //public int Height { get => _view.Height; set => _view.Height = value; }

        //public virtual object Instance => _view;
        //private readonly IList<IControl> _visualControls = new List<IControl>();

        //public IList VisualControl => (IList)_visualControls;

        //public IList<IControl> LogicalControls { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        //public Color ForeColor { set => _view.ForeColor = DrawingColor.FromArgb(value.A, value.R, value.G, value.B); }

        //public IControl AddVisualControl(IControl control)
        //{
        //    _visualControls.Add(control);
        //    _view.Controls.Add((Control)control.Instance);
        //    return control;
        //}

        ////public static T Cast<T>(object o)
        ////{
        ////    return (T)o;
        ////}

        //public event EventHandler MouseClick
        //{
        //    add => _view.MouseClick += new MouseEventHandler(value);
        //    remove => _view.MouseClick -= new MouseEventHandler(value);
        //}

        //public event EventHandler MouseDoubleClick
        //{
        //    add => _view.MouseDoubleClick += new MouseEventHandler(value);
        //    remove => _view.MouseDoubleClick -= new MouseEventHandler(value);
        //}
        //public event EventHandler KeyDown
        //{
        //    add => _view.KeyDown -= new KeyEventHandler(value);
        //    remove => _view.KeyDown -= new KeyEventHandler(value);
        //}
        //public event EventHandler DoubleClick
        //{
        //    add => _view.DoubleClick += value;
        //    remove => _view.DoubleClick -= value;
        //}
        //public event EventHandler TextChanged
        //{
        //    add => _view.TextChanged += value;
        //    remove => _view.TextChanged -= value;
        //}
        //public event EventHandler Leave
        //{
        //    add => _view.Leave += value;
        //    remove => _view.Leave -= value;
        //}
        //public event EventHandler Click
        //{
        //    add => _view.Click += value;
        //    remove => _view.Click -= value;
        //}
        //public event EventHandler MouseEnter
        //{
        //    add => _view.MouseEnter += value;
        //    remove => _view.MouseEnter -= value;
        //}

        //public event EventHandler MouseLeave
        //{
        //    add => _view.MouseLeave += value;
        //    remove => _view.MouseLeave -= value;
        //}
    }
}