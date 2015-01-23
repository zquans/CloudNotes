﻿using CloudNotes.DesktopClient.Extensibility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CloudNotes.DesktopClient.Extensions
{
    [Extension("{93275853-1649-4726-8200-3F3643779499}", "MyCustomTool", typeof(CustomSettingProvider))]
    public class CustomToolExtension : ToolExtension
    {
        public CustomToolExtension()
            : base("My Custom Tool")
        { }

        protected override void DoExecute(IShell shell)
        {
            //await shell.AddNoteAsync(new Extensibility.Data.Note
            //{
            //    Title = "8899",
            //    Content = "hello"
            //});
            //MessageBox.Show(shell.Text);
            var setting = this.SettingProvider.GetExtensionSetting<CustomSetting>();
            if (setting!=null)
            {
                MessageBox.Show(setting.Greeting);
            }
        }

        public override string DisplayName
        {
            get { return this.ToolName; }
        }

        public override string Manufacture
        {
            get { return "daxnet"; }
        }

        public override string Description
        {
            get { return "A simple custom extension."; }
        }
    }
}