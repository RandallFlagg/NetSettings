using System;
using NetSettings.Common.Classes;
using NetSettings.Common.Interfaces;
using NetSettings.TerminalGui.TerminalGuiControls;

namespace NetSettingsCore.TerminalGui
{
    public class TerminalGuiGuiProvider : IGuiProvider
    {
        public IGuiElement CreateGuiElement(string guiElementName)
        {
            switch (guiElementName)
            {
                case "textbox":
                    var value = new TerminalGuiView();
                    return value;
                default:
                    throw new NotImplementedException("gui element creation is yet to be implemented.");
            }
        }

        public IGuiElement CreateGuiElement(GuiElementType guiElementName)
        {
            return CreateGuiElement(guiElementName, null);
        }

        public IGuiElement CreateGuiElement(GuiElementType guiElementName, params object[] list)
        {
            IGuiElement control;
            switch (guiElementName)
            {
                case GuiElementType.Image:
                case GuiElementType.Number:
                case GuiElementType.Text:
                    throw new NotImplementedException("gui element creation is yet to be implemented.");
                    //control = new WinFormTextBox();
                    break;
                case GuiElementType.IFont:
                    //if (list.Length == 2)
                    //{
                    //    control = new WinFormFont((string)list[0], (float)list[1]);
                    //}
                    //else if (list.Length == 3)
                    //{
                    //    control = new WinFormFont((string)list[0], (float)list[1], (FontAppearance)list[2]);
                    //}
                    //else
                    //{
                    //    throw new NotImplementedException();
                    //}
                    control = new TelegramGuiFont();
                    break;
                case GuiElementType.GuiElement:
                    control = new TerminalGuiView();
                    //control = new WinFormControl();
                    break;
                case GuiElementType.Label:
                    control = new TerminalGuiLabel();
                    //control = new WinFormLabel();
                    break;
                case GuiElementType.Menu: //Label
                    //throw new NotImplementedException("gui element creation is yet to be implemented.");
                    control = new TerminalGuiView();
                    //control = new WinFormLabel();
                    break;
                case GuiElementType.Bool:
                    //throw new NotImplementedException("gui element creation is yet to be implemented.");
                    control = new TerminalGuiView();
                    //control = new WinFormCheckBox();
                    break;
                case GuiElementType.Button:
                    //throw new NotImplementedException("gui element creation is yet to be implemented.");
                    control = new TerminalGuiView();
                    //control = new WinFormButton();
                    break;
                case GuiElementType.Color:
                    //throw new NotImplementedException("gui element creation is yet to be implemented.");
                    control = new TerminalGuiView();
                    //control = new WinFormColorControl();
                    break;
                case GuiElementType.Combo:
                    //throw new NotImplementedException("gui element creation is yet to be implemented.");
                    control = new TerminalGuiView();
                    //control = new WinFormComboBox();
                    break;
                case GuiElementType.ColorDialog:
                    //throw new NotImplementedException("gui element creation is yet to be implemented.");
                    control = new TerminalGuiView();
                    //control = new WinFormColorDialog();
                    break;
                default:
                    throw new NotImplementedException($"gui element {guiElementName} is not known. How did we get here?");
            }

            return control;
        }

        public IGuiElement CreateGuiElement(object guiElementName)
        {
            return CreateGuiElement(guiElementName, null);
        }

        public IGuiElement CreateGuiElement(object guiElementName, params object[] list)
        {
            return CreateGuiElement((GuiElementType) guiElementName);
        }

        public void ShowPreviewForm(ShowFormParams parameters)
        {
            throw new NotImplementedException();
        }
    }
}