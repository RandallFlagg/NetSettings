using NetSettings.Common.Interfaces;
using NetSettings.Data;
using NetSettings.View;
using NetSettingsCore.TerminalGui;
using NetSettingsTest.Controls;
using Newtonsoft.Json;
using NStack;
using System.Collections.Generic;
using System.IO;
using Terminal.Gui;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace NetSettingsTest.Forms
{
    internal class TerminalGuiMainWindow : Window
    {
        private TerminalGuiMainWindow _top;
        private const string UserPath = @".\settings";
        private DataView fView;
        private DataProvider fData;
        private DataViewParams fDataViewParams;
        private TerminalGuiSettingsForm fSettingsForm;
        private IControlContainer _userControl11;
        private IControlContainer _controlContainer1;
        private Dictionary<string, object> fUserSettings;

        public TerminalGuiMainWindow()
        {
            fView = new DataView();
            const string settingsFilePath = @"Resources\GuiTemplate.json";
            fData = new DataProvider(ItemTree.FromFile(settingsFilePath));
            _userControl11 = new ControlContainer();
            //Create manually view[1]
            fDataViewParams = new DataViewParams
            {
                guiProvider = new TerminalGuiGuiProvider(),
                dataProvider = fData,
                container = _userControl11,
                descriptionContainer = _controlContainer1
            };

            //Create view[2] with predefined 'SettingsForm' from the same data provider
            //fSettingsForm = new SettingsForm((DataProvider)fData, new DataViewParams(), new DataView());
            fSettingsForm = new TerminalGuiSettingsForm(fData);
            X = 0;
            Y = 1; // Leave one row for the toplevel menu

            // By using Dim.Fill(), it will automatically resize without manual intervention
            Width = Dim.Fill();
            Height = Dim.Fill();
            this._top = this;
            this.Initialized += TerminalGuiMainWindow_Initialized;
            //init();
        }

        private void TerminalGuiMainWindow_Initialized(object sender, System.EventArgs e)
        {
            fData.ItemChanged += fData_ItemChanged;
            LoadSettings();
            fData.DataBinding = fUserSettings;

            fView.Create(fDataViewParams);//TODO: Compare the init process of this form with the SettingsForm

            fSettingsForm.OnSave += fSettingsForm_OnSave;
            //fSettingsForm.Show();//TODO: Do we need this?
        }

        //TODO: Delete this event
        private void fData_ItemChanged(ItemChangedArgs changedArgs)
        {
            if (changedArgs.ChangedMode == ItemChangedMode.UserConfirmed)
            {
                var k = 0;
            }
        }

        private void fSettingsForm_OnSave()
        {
            Save();
        }

        private void Save()
        {
            string text = JsonConvert.SerializeObject(fUserSettings, new JsonSerializerSettings()
            {
                Formatting = Formatting.Indented
            });

            File.WriteAllText(UserPath, text);
        }

        private void LoadSettings()
        {
            if (!File.Exists(UserPath))
            {
                fUserSettings = fData.GenerateDefaultOptionsSet();
                Save();
            }
            else
            {
                string text = File.ReadAllText(UserPath);
                fUserSettings = JsonConvert.DeserializeObject<Dictionary<string, object>>(text);
            }
        }

        //TODO: Delete this method. Here just to checkthat telegram.UI is working
        private void init()
        {
            // Creates a menubar, the item "New" has a help menu.
            var menu = new MenuBar(new MenuBarItem[] {
            new MenuBarItem ("_File", new MenuItem [] {
                new MenuItem ("_New", "Creates new file", null),
                new MenuItem ("_Close", "",null),
                new MenuItem ("_Quit", "", () => { if (Quit ()) _top.Running = false; })
            }),
            new MenuBarItem ("_Edit", new MenuItem [] {
                new MenuItem ("_Copy", "", null),
                new MenuItem ("C_ut", "", null),
                new MenuItem ("_Paste", "", null)
            })
            });
            _top.Add(menu);

            static bool Quit()
            {
                var n = MessageBox.Query(50, 7, "Quit Demo", "Are you sure you want to quit this demo?", "Yes", "No");
                return n == 0;
            }

            var login = new Label("Login: ") { X = 3, Y = 2 };
            var password = new Label("Password: ")
            {
                X = Pos.Left(login),
                Y = Pos.Top(login) + 1
            };
            var loginText = new TextField("")
            {
                X = Pos.Right(password),
                Y = Pos.Top(login),
                Width = 40
            };
            var passText = new TextField("")
            {
                Secret = true,
                X = Pos.Left(loginText),
                Y = Pos.Top(password),
                Width = Dim.Width(loginText)
            };

            // Add some controls, 
            this.Add(
                // The ones with my favorite layout system, Computed
                login, password, loginText, passText,

        // The ones laid out like an australopithecus, with Absolute positions:
        new CheckBox(3, 6, "Remember me"),
        new RadioGroup(3, 8, new ustring[] { "_Personal", "_Company" }, 0),
        new Button(3, 14, "Ok"),
        new Button(10, 14, "Cancel"),
        new Label(3, 18, "Press F9 or ESC plus 9 to activate the menubar")
    );
        }
    }
}