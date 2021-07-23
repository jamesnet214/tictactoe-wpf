using System.Windows;
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

			MouseMove += GameView_MouseMove;
		}

		private void GameView_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.LeftButton == System.Windows.Input.MouseButtonState.Pressed)
			{
				this.DragMove();
			}
		}
	}
}
