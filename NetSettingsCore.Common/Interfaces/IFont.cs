using NetSettings.Common.Classes;

namespace NetSettings.Common.Interfaces
{
    public interface IFont : INativeGuiElement
    {
        float Size { get; set; }
        //FontAppearance Appearance { get; }
        //string FontFamily { get;  }
        MeasureUnit Unit { get; }
        string FamilyName { get; set; }
        FontAppearance Appearance { get; set; }
    }

    public interface INativeGuiElement : IGuiElement
    {
        object Native { get; }
    }
}