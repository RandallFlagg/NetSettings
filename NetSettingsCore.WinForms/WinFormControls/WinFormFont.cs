using NetSettings.Common.Classes;
using NetSettings.Common.Interfaces;
using System;
using System.Drawing;

namespace NetSettings.WinForms.WinFormControls
{
    internal class WinFormFont : IFont
    {
        private Font _font;
        private float _size;

        public string FontFamily => _font.FontFamily.ToString();
        public MeasureUnit Unit => Enum.Parse<MeasureUnit>(_font.Unit.ToString());
        public object Native => _font;

        public float Size { get => _font.Size; set => _size = value; }
        public string FamilyName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public FontAppearance Appearance { get => Enum.Parse<FontAppearance>(_font.Style.ToString()); set => throw new NotImplementedException(); }

        public WinFormFont():this("Tahoma", 14, FontAppearance.Regular) { 

        }
        public WinFormFont(string familyName, float emSize) :
            this(familyName, emSize, FontAppearance.Regular)
        {
        }

        public WinFormFont(string familyName, float emSize, FontAppearance style)
        {
            var fontStyle = Enum.Parse<FontStyle>(style.ToString(), true);
            _font = new Font(familyName, emSize, fontStyle);
        }

        internal WinFormFont(Font font)
        {
            _font = font ?? throw new NullReferenceException();
        }
    }
}