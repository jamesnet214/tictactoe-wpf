using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace TicTacToe.UI.Views
{
	public class GameView : Window
	{
		static GameView()
		{
			DefaultStyleKeyProperty.OverrideMetadata(typeof(GameView), new FrameworkPropertyMetadata(typeof(GameView)));
		}

		public GameView()
		{
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
			if (e.LeftButton == System.Windows.Input.MouseButtonState.Pressed
				&& sender.Equals(e.OriginalSource))
			{
				this.DragMove();
			}
		}
	}
}
