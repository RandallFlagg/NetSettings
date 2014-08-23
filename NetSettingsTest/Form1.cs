﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NetSettingsTest;

namespace NetSettings
{
    public partial class Form1 : Form
    {
        const string SettingsFilePath = @"Resources\GuiTemplate.json";
        MenuSettings settings;
        CreationParams fCreationParameters;
        Timer fFilterTimer;
        Filter fSettingsFilter;
        DataEntity fData;

        SettingsForm fSettingsForm;
        public Form1()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            settings = new MenuSettings();
            fData = new DataEntity(ItemTree.FromFile(SettingsFilePath));
            fCreationParameters = new CreationParams();
            fCreationParameters.container = userControl11;
            fCreationParameters.descriptionContainer = controlContainer1;
            fCreationParameters.root = fData;
            

            fSettingsForm = new SettingsForm(fData);
            fSettingsForm.OnSave += fSettingsForm_OnSave;
            fSettingsForm.Show();
            
            settings.Create(fCreationParameters);

            fFilterTimer = new Timer();
            fFilterTimer.Tick += fFilterTimer_Tick;
            fFilterTimer.Interval = 300;
        }

        void fSettingsForm_OnSave()
        {
            int k = 0;
        }

        void fFilterTimer_Tick(object sender, EventArgs e)
        {
            fFilterTimer.Enabled = false;
            settings.SetFilter(fSettingsFilter);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //fCreationParameters.root.fRootTemplate.ToFile(SettingsFilePath);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            fSettingsFilter = new Filter()
            {
                IncludeName = (sender as TextBox).Text
            };
            fFilterTimer.Enabled = false;
            fFilterTimer.Enabled = true;
         
        }
    }
}
