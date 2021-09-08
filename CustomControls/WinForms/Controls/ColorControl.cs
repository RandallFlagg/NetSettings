﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace CustomControls.WinForms.Controls
{
    public class ColorControl : TextBox
    {
        public ColorControl()
        {
            base.Font = new Font("Arial", 9, FontStyle.Bold);
            this.BorderStyle = BorderStyle.Fixed3D;
        }

        private void RefreshName()
        {
            if (!Updating && !DisableAutoColorName)
            {
                Updating = true;
                Text = "#" + base.BackColor.ToArgb().ToString("X").Substring(2, 6);
                Updating = false;
            }
        }

        public bool DisableAutoColorName { get; set; }

        public bool Updating { get; set; }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Rectangle t = ClientRectangle;
            t.Width -= 1;
            t.Height -= 1;
            e.Graphics.DrawRectangle(Pens.Black, t);
        }

        protected override void OnLeave(EventArgs e)
        {
            DisableAutoColorName = false;
            RefreshName();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                if (DisableAutoColorName)
                {
                    DisableAutoColorName = false;
                    //RefreshControlValue((colorControl.Tag as VisualItem));
                }
            }
            else
            {
                DisableAutoColorName = true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        public override Color BackColor
        {
            set
            {
                base.BackColor = value;
                if (!Updating)
                {
                    base.BackColor = Color.FromArgb(value.A, value.R, value.G, value.B);

                    var brightness = Math.Sqrt(.241 * base.BackColor.R * base.BackColor.R + .691 * base.BackColor.G * base.BackColor.G + .068 * base.BackColor.B * base.BackColor.B);
                    ForeColor = brightness < 130 ? ForeColor = Color.White : ForeColor = Color.Black;

                    RefreshName();
                }
            }
        }
    }
}
