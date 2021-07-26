using System.Windows;
using System.Windows.Controls;

namespace TicTacToe.UI.Units
{
    public class GameBoard : ListBox
    {
        static GameBoard()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(GameBoard), new FrameworkPropertyMetadata(typeof(GameBoard)));
        }

        protected override DependencyObject GetContainerForItemOverride()
        {
            return new GameBoardItem();
        }
    }
}
