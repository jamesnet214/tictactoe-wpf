using System.Windows;
using System.Windows.Controls;

namespace TicTacToe.UI.Units
{
	public class ScoreBoxItem : ListBoxItem
	{
		static ScoreBoxItem()
		{
			DefaultStyleKeyProperty.OverrideMetadata(typeof(ScoreBoxItem), new FrameworkPropertyMetadata(typeof(ScoreBoxItem)));
		}
	}
}
