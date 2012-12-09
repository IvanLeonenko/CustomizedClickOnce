using System;
using System.Windows;
using CustomizedClickOnce.Common;
using System.Diagnostics;

namespace CustomizedClickOnce
{
    public partial class App
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            try
            {
                var clickOnceHelper = new ClickOnceHelper(Globals.PublisherName, Globals.ProductName);
                clickOnceHelper.UpdateUninstallParameters();
                clickOnceHelper.AddShortcutToStartup();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            base.OnStartup(e);
        }
    }
}
