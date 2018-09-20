using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ranorex;
using Xunit;
using Ranorex.Core;
using Microsoft.Extensions.Configuration;
using System.IO;
using System.Threading;

namespace trados
{
    public class TradosStudio
    {
        public Duration timeout;
        public const string licenseFormReference = "/form[@controlname='LicenseManagerForm']";
        public const string licenseFormOkBtnReference = "/form[@controlname='LicenseManagerForm']/container[@controlname='_contentPanel']//container[@controlname='panel1']/?/?/button[@controlname='_okCancelButton']";
        private readonly Settings settings;

        public const string welcomeBtn= "/form[@controlname='StudioWindowForm']/container[@controlname='_mainPanel']/?/?/container[@controlname='panel1']/?/?/container[@automationid='[Group] 0']";
        public const string dialogOpen = "/form[@title='Open Package']";
        public const string openPackageBtn = "/dom[@caption='SDL Trados Studio Start']//a[#'OpenPackage_titleLink']";
        public const string openBtn = "/ form[@title = 'Open Package'] / button[@text = '&Open']";
        public const string browseBtn = "/form[@automationid='Window_1']/container[@automationid='DockPanel_1']//container[@controlname='OpenPackagePreviewWizardPageControl']/?/?/container[@controlname='_projectFolderControl']/?/?/button[@controlname='_buttonProjectFolder']";
        public const string selectFolder = "/form[@title='Select Folder']/button[@text='Select Folder']";
        public const string appendCheckBox = "/form[@automationid='Window_1']/container[@automationid='DockPanel_1']//container[@controlname='OpenPackagePreviewWizardPageControl']/?/?/container[@controlname='_projectFolderControl']/?/?/checkbox[@controlname='_checkBoxProjectNameAppend']";
        public const string finishBtn = "/form[@automationid='Window_1']/?/?/button[@automationid='HelpButton']/?/?/button[@automationid='FinishButton']";

        public TradosStudio(Settings settings)
        {
            this.settings = settings;
        }

        public void Start()
        {
            timeout = settings.Timeout;

            Host.Local.RunApplication(settings.Path, "", Path.GetDirectoryName(settings.Path), false);

            Assert.True(Host.Local.TryFindSingle(licenseFormReference, timeout, out Element licenseForm));

            Assert.True(Host.Local.TryFindSingle(licenseFormOkBtnReference, timeout, out Element licenseFormOk));
             var licenseFormOkBtn = (Button)licenseFormOk;
              licenseFormOkBtn.Click();


            Assert.True(Host.Local.TryFindSingle(welcomeBtn, timeout, out Element welcome));

            Mouse.Click(welcomeBtn);
            Mouse.Click(openPackageBtn);

            Assert.True( Host.Local.TryFindSingle( dialogOpen, timeout, out Element openPathDialog));



            Ranorex.Keyboard.Press(@"D:\Vladuuuut\GITHUB\JuniorMind_projects\trados\trados\Assets\Project 1");

            Mouse.Click(openBtn);

        

            Mouse.Click(browseBtn);

            Ranorex.Keyboard.Press(@"C:\Users\geone\OneDrive\Documents\Katatonia");

            Mouse.Click(selectFolder);

            Assert.True(Host.Local.TryFindSingle(appendCheckBox, timeout, out Element appendCheck));

            CheckBox append = (CheckBox)appendCheck;

            if (append.Checked ==false)
            {
                Mouse.Click(appendCheckBox);
            }


            Mouse.Click(finishBtn);
            Thread.Sleep(2000);

            Mouse.Click(finishBtn);
        }
    }
}