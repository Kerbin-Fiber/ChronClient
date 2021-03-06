﻿using ChronClient.GUI.UserControls.ModuleControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ChronClient.GUI
{
    /// <summary>
    /// Interaktionslogik für ChronClient.xaml
    /// </summary>
    public partial class MainWindow_DashboardPage_SettingsPage : Page
    {
        public MainWindow_DashboardPage_SettingsPage()
        {
            InitializeComponent();

            ListSettings.Children.Add(new C_Control_ModuleToggle(ref Module.Airjump._ToggleState, new Action(() => { Module.Airjump.Refresh(); }), "AirJump"));
        }

        
    }
}
