﻿#pragma checksum "C:\Users\Bharath\Documents\Visual Studio 2012\Projects\Expense Manager\Expense Manager\AddExpense.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "FC78C65F5C55A011BD395EA5C1A71D85"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18051
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace Expense_Manager {
    
    
    public partial class AddExpense : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.TextBox expense_box;
        
        internal System.Windows.Controls.TextBox tag_box;
        
        internal System.Windows.Controls.Button add_expense_button;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/Expense%20Manager;component/AddExpense.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.expense_box = ((System.Windows.Controls.TextBox)(this.FindName("expense_box")));
            this.tag_box = ((System.Windows.Controls.TextBox)(this.FindName("tag_box")));
            this.add_expense_button = ((System.Windows.Controls.Button)(this.FindName("add_expense_button")));
        }
    }
}

