using NetSettings.Common.Interfaces;
using NetSettings.Data;
using NetSettings.View;
using NetSettingsCore.TerminalGui;
using NetSettingsTest.Controls;
using NStack;
using System.Xml.Linq;
using NetSettingsTest.Forms;
using Terminal.Gui;

namespace NetSettingsTest
{
    class TerminalGuiProgram
    {
        static void Main()
        {
            Application.Run<TerminalGuiMainWindow>();
        }
    }
}