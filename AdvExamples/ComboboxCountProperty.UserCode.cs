﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// Your custom recording code should go in this file.
// The designer will only add methods to this file, so your custom code won't be overwritten.
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
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace AdvExamples
{
    public partial class ComboboxCountProperty
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void CycleComboBox()
        {
            //ListItem windowsVistaBlack = "/list/listitem[@text='Windows Vista Black']";
            ComboBox myDropDown = "/form[@controlname='OptionsForm']/?/?/tabpage[@controlname='m_tabGui']/combobox[@controlname='m_cmbBannerStyle']";
            
            myDropDown.Click(); //Show list items
            
            IList<Ranorex.ListItem> myList = myDropDown.Items; //Collect all list items
            Ranorex.Report.Info("Total Items = " + myList.Count);
            
            foreach (Ranorex.ListItem myItem in myList) {
            	myItem.Select();
            	Delay.Duration(300);
            }
            
        }

    }
}