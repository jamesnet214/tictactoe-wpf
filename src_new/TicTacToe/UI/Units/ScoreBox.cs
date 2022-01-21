using System.Windows;
using System.Windows.Controls;

namespace TicTacToe.UI.Units
{
	public class ScoreBox : ListBox
	{
		static ScoreBox()
		{
			DefaultStyleKeyProperty.OverrideMetadata(typeof(ScoreBox), new FrameworkPropertyMetadata(typeof(ScoreBox)));
		}

		protected override DependencyObject GetContainerForItemOverride()
		{
			return new ScoreBoxItem();
		}
	}
}
