using Ranorex;
using Xunit;
using Ranorex.Core;
using Microsoft.Extensions.Configuration;
using System.IO;


namespace trados
{
    public class UnitTest1 
    {
        private readonly Settings settings = new Settings();
        public readonly Duration timeout; 
       // public const string licenseFormReference = "/form[@controlname='LicenseManagerForm']";
       // public const string licenseFormOkBtnReference = "/form[@controlname='LicenseManagerForm']/container[@controlname='_contentPanel']//container[@controlname='panel1']/?/?/button[@controlname='_okCancelButton']";
        public const string tradosMainHomePanel_LowerRibbonReference = "/form[@controlname='StudioWindowForm']/?/?/container[@automationid='Ribbon']/container[@automationid='Lower Ribbon']";
        public const string projectSettingsBtnReference = "/form[@controlname='StudioWindowForm']//container[@automationid='Lower Ribbon']/container[@automationid='Group : configurationRibbonGroup']/button[@automationid='[Group : configurationRibbonGroup Tools] Tool : IgCommandBarAction:ProjectSettingsAction - Index : 0 ']";
        public const string settingsFormDialogReference = "/form[@controlname='SettingsDialogForm']";
        public const string settingsNode4 = "/form[@controlname='SettingsDialogForm']/container[@controlname='_contentPanel']/container[@controlname='_settingsUIControl']//container[@controlname='panel1']/?/?/element[@automationid='[Node] 4']";
        public const string node4_AllLanguagePairs = "/form[@controlname='SettingsDialogForm']/container[@controlname='_contentPanel']//container[@controlname='panel1']/?/?/tree[@accessiblerole='Outline']/treeitem[@accessiblename='All Language Pairs']";
        public const string allLanguagePairs_batchProcessing = "/form[@controlname='SettingsDialogForm']/container[@controlname='_contentPanel']//container[@controlname='panel1']/?/?/tree[@accessiblerole='Outline']/treeitem[@accessiblename='Batch Processing']";
        public const string batchProcessing_analizeFiles = "/form[@controlname='SettingsDialogForm']/container[@controlname='_contentPanel']//container[@controlname='panel1']/?/?/tree[@accessiblerole='Outline']/treeitem[@accessiblename='Analyze Files']";
        public const string crossFilesRepetitionsCheckBox = "/form[@controlname='SettingsDialogForm']/container[@controlname='_contentPanel']/container[@controlname='_settingsUIControl']//container[@controlname='panel2']//container[@controlname='_generalGroupBox']/?/?/checkbox[@controlname='_reportCrossFileRepetitionsCheckBox']";
        public const string projectsButton = "/form[@controlname='StudioWindowForm']/container[@controlname='_mainPanel']/?/?/container[@controlname='panel1']/?/?/container[@automationid='[Group] 1']";
        public const string viewProjectFilesBtnReference = "/form[@controlname='StudioWindowForm']//container[@automationid='Lower Ribbon']/container[@automationid='Group : TasksRibbonGroup']/button[@automationid='[Group : TasksRibbonGroup Tools] Tool : IgCommandBarAction:OpenProjectFromListAction - Index : 3 ']";
        public const string closeBtn = "/form[@controlname='StudioWindowForm']/?/?/container[@automationid='Ribbon']/button[@automationid='Close']";
        public const string okPropBtn = "/form[@controlname='SettingsDialogForm']/container[@controlname='_tableLayoutPanel']/?/?/button[@controlname='okButton']";
         public UnitTest1()
         {   
            // Given

            timeout = settings.Timeout;
            
            var startProgram = new TradosStudio(settings);
            startProgram.Start();       
         }


       


        [Fact]
        public void EnterSettings_CrossFilesRepettionOptionChecked()
        {
            //When
             
            var tradosMainHomePanel_LowerRibbon = Host.Local.FindSingle(tradosMainHomePanel_LowerRibbonReference, timeout);
            tradosMainHomePanel_LowerRibbon.EnsureVisible();

            Assert.True(tradosMainHomePanel_LowerRibbon.TryFindSingle(projectSettingsBtnReference, timeout, out Element projectSettings));                 
            var projectSettingsBtn = (Button)projectSettings;
            projectSettingsBtn.Click();

            Assert.True(Host.Local.TryFindSingle(settingsFormDialogReference, timeout, out Element settingsForm));

            Mouse.Click(settingsNode4);
            Mouse.Click(node4_AllLanguagePairs);
            Mouse.Click(allLanguagePairs_batchProcessing);
            Mouse.Click(batchProcessing_analizeFiles);

            // Then
            CheckBox crossFilesRepetitions = settingsForm.FindSingle(crossFilesRepetitionsCheckBox);

            Assert.True(crossFilesRepetitions.Checked);

            Mouse.Click(okPropBtn);

            Mouse.Click(closeBtn);
        }


        
    }
}
