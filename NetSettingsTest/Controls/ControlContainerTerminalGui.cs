using System;
using NetSettings.Common.Interfaces;
using Terminal.Gui;

namespace NetSettingsTest.Controls
{
    public class ControlContainer : ScrollView, IControlContainer
    {
        //    public void AddControl(IControl control)
        //    {
        //        this.Controls.Add(control.Instance as Control);
        //    }

        //    public ControlContainer()
        //    {
        //        base.DoubleBuffered = true;
        //        //https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.controlstyles?view=netcore-3.1
        //        //this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
        //        base.AutoScroll = true;
        //    }

        //    public void ScrollY(int delta)
        //    {
        //        int scrollPosition = this.VerticalScroll.Value - delta;
        //        scrollPosition = Math.Min(Math.Max(scrollPosition, this.VerticalScroll.Minimum), this.VerticalScroll.Maximum);
        //        this.VerticalScroll.Value = scrollPosition;
        //    }

        //    public void Reset()
        //    {
        //        Controls.Clear();
        //        ResetPosition();
        //    }

        //    public void ResetPosition()
        //    {
        //        this.HorizontalScroll.Value = this.VerticalScroll.Value = 0;

        //    }

        //    public void StartUpdate()
        //    {
        //        this.SuspendLayout();
        //        ControlHelper.SuspendDrawing(this);
        //    }
        //    public void EndUpdate()
        //    {
        //        this.ResumeLayout();
        //        ControlHelper.ResumeDrawing(this);
        //    }
        //}
        public void AddControl(IControl control)
        {
            Console.WriteLine("In AddControl Method");
            this.Add(control.Instance as View);
            //throw new NotImplementedException();
        }

        public void EndUpdate()
        {
            //TODO: IMPLEMENT REQUIRED
            //throw new NotImplementedException();
        }

        public void Reset()
        {
            Console.WriteLine("In Reset Method");
            //throw new NotImplementedException();
        }

        public void ResetPosition()
        {
            //TODO: IMPLEMENT ME
            //throw new NotImplementedException();
        }

        public void StartUpdate()
        {
            Console.WriteLine("In StartUpdate Method");
            //throw new NotImplementedException();
        }
    }
}
