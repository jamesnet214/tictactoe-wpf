using System.Windows;
using System.Windows.Controls;

namespace TicTacToe.UI.Units
{
	public class GameBoardItem : ListBoxItem
	{
		static GameBoardItem()
		{
			DefaultStyleKeyProperty.OverrideMetadata(typeof(GameBoardItem), new FrameworkPropertyMetadata(typeof(GameBoardItem)));
		}
	}
}
