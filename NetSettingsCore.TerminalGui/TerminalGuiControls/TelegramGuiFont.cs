using NetSettings.Common.Classes;
using NetSettings.Common.Interfaces;

namespace NetSettingsCore.TerminalGui
{
    internal class TelegramGuiFont : IFont
    {
        public float Size { get; set; }

        public MeasureUnit Unit => throw new System.NotImplementedException();

        public string FamilyName { get; set; }
        public FontAppearance Appearance { get; set; }

        public object Native => throw new System.NotImplementedException();
    }
}