using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using System.Reflection;
using System.ComponentModel;

namespace GUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

           Assembly asm = typeof(DevExpress.UserSkins.mySkin).Assembly;
           DevExpress.Skins.SkinManager.Default.RegisterAssembly(asm);
           SkinManager.EnableFormSkins();

           UserLookAndFeel.Default.SkinName = "mySkin";

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            SkinManager.EnableFormSkins();

            DAL.DataProvider.InitalizeConnection();

            DevExpress.XtraGrid.Localization.GridLocalizer.Active = new VietnameseGridLocalizer();
            DevExpress.XtraEditors.Controls.Localizer.Active = new VietnameseEditorsLocalizer();

            Application.Run(new MainForm());
        }

       
    }
}
