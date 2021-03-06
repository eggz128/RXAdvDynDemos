///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace AdvExamples
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The ComboboxCountProperty recording.
    /// </summary>
    [TestModule("5e8cc741-3074-4150-8c83-ba0c0b0da61d", ModuleType.Recording, 1)]
    public partial class ComboboxCountProperty : ITestModule
    {
        /// <summary>
        /// Holds an instance of the AdvExamplesRepository repository.
        /// </summary>
        public static AdvExamplesRepository repo = AdvExamplesRepository.Instance;

        static ComboboxCountProperty instance = new ComboboxCountProperty();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ComboboxCountProperty()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ComboboxCountProperty Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MainForm.Tools' at 22;9.", repo.MainForm.ToolsInfo, new RecordItemIndex(0));
            repo.MainForm.Tools.Click("22;9");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'KeePass.Options' at 58;14.", repo.KeePass.OptionsInfo, new RecordItemIndex(1));
            repo.KeePass.Options.Click("58;14");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OptionsForm.Interface' at 48;8.", repo.OptionsForm.InterfaceInfo, new RecordItemIndex(2));
            repo.OptionsForm.Interface.Click("48;8");
            Delay.Milliseconds(200);
            
            CycleComboBox();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
