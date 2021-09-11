﻿using System;
using NetSettings.Common.Classes;
using NetSettings.Common.Interfaces;
using Font = SharpDX.DirectWrite.Font;

namespace NetSettings.Avalonia.AvaloniaControls
{
    internal class AvaloniaFont : IFont
    {
        public Font Instance { get; internal set; }

        public AvaloniaFont(string familyName, float emSize) :
            this(familyName, emSize, FontAppearance.Regular)
        {
        }

        public AvaloniaFont(string familyName, float emSize, FontAppearance style)
        {
            throw new NotImplementedException();
            //Instance = new AvaloniaFont(familyName, emSize, (FontStyle)style);
        }

        internal AvaloniaFont(Font font)
        {
            Instance = font;
        }

        public float Size { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }//Instance.Size);
        public FontAppearance Appearance { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Name { get; set; }
        public string FamilyName
        {
            get => throw new NotImplementedException();//Instance.Name);
            set => throw new NotImplementedException();
        }
        //string IFont.FontFamily { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public object Native { get; set; }

        public object Unit => throw new NotImplementedException();

        MeasureUnit IFont.Unit => throw new NotImplementedException();
    }
}