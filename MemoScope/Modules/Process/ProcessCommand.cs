﻿using System.Windows.Forms;
using WinFwk.UICommands;
using WinFwk.UITools.ToolBar;

namespace MemoScope.Modules.Process
{
    public class ProcessCommand : AbstractVoidUICommand
    {
        public ProcessCommand() : base("Process", "Display process", UIToolBarSettings.File.Name, Properties.Resources.ddr_memory, Keys.Control|Keys.F2)
        {
        }

        public override void Run()
        {
            ProcessModule mod = GetModule<ProcessModule>();
            mod.Init();
            DockModule(mod);
        }
    }
}