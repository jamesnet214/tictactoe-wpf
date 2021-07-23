using System;
using System.Windows;
using TicTacToe.Local.VIewModel;
using TicTacToe.UI.Views;

namespace TicTacToe
{
	public class App : Application
	{
		protected override void OnStartup(StartupEventArgs e)
		{
			base.OnStartup(e);

			GameView window = new();
			window.DataContext = new GameViewModel();
			window.ShowDialog();
			Environment.Exit(0);
		}
	}
}
