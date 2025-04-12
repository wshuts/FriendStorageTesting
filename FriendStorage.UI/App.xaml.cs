﻿using FriendStorage.UI.Startup;
using FriendStorage.UI.View;
using System.Windows;
using Autofac;

namespace FriendStorage.UI
{
  public partial class App
  {
    protected override void OnStartup(StartupEventArgs e)
    {
      base.OnStartup(e);
      var bootStrapper = new BootStrapper();
      var container = bootStrapper.BootStrap();

      var mainWindow = container.Resolve<MainWindow>();
      mainWindow.Show();
    }
  }
}
