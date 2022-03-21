using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using TicTacToe.Local.Mvvm;

namespace TicTacToe.UI.Views
{
	public class MainWindow : Window
	{
		static MainWindow()
		{
			DefaultStyleKeyProperty.OverrideMetadata(typeof(MainWindow), new FrameworkPropertyMetadata(typeof(MainWindow)));
		}

		public MainWindow()
		{
			DataContext = new MainViewModel();
			WindowStyle = WindowStyle.None;
			AllowsTransparency = true;
		}

		public override void OnApplyTemplate()
		{
			if (GetTemplateChild("PART_Border") is Border border)
			{
				border.MouseMove += Border_MouseMove;
			}
		}

		private void Border_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.LeftButton == MouseButtonState.Pressed && sender.Equals(e.OriginalSource))
			{
				this.DragMove();
			}
		}
	}
}
