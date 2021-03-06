﻿using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace WinFwk.UIModules
{
    public static class UIModuleHelper
    {
        public static DockContent BuildDockContent(Control control, bool allowclose = true)
        {
            DockContent content = new DockContent();
            control.Dock = DockStyle.Fill;
            content.Text = control.Name;
            content.Controls.Add(control);
            content.Tag = control;
            content.CloseButton = allowclose;
            content.CloseButtonVisible = allowclose;

            return content;
        }
    }
}