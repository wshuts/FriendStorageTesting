using System;
using System.Windows.Input;

namespace FriendStorage.UITests.Extensions
{
  public static class CommandExtensions
  {
    public static bool IsCanExecuteChangedFired(
      this ICommand command,
      Action action)
    {
      var fired = false;
      command.CanExecuteChanged += (s, e) => fired = true;

      action();

      return fired;
    }
  }
}
