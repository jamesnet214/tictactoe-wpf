using System.Windows;
using System.Windows.Controls;

namespace TicTacToe.UI.Units
{
	public class PlayerCard : Control
	{
		static PlayerCard()
		{
			DefaultStyleKeyProperty.OverrideMetadata(typeof(PlayerCard), new FrameworkPropertyMetadata(typeof(PlayerCard)));
		}
	}
}
