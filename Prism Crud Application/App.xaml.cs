﻿using Prism_Crud_Application.Views;
using Prism.Ioc;
using Prism.Modularity;
using System.Windows;

namespace Prism_Crud_Application
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }
    }
}
