using System;
using System.Windows.Input;
using TicTacToe.Local.Data;
using TicTacToe.Local.Mvvm;

namespace TicTacToe.Local.VIewModel
{
	public class GameViewModel : ObservableObject
	{
		private bool playerTurn;

		public SquareItem[] Squares { get; set; }

		public GameViewModel()
		{
			SetGameBoard();
		}

		private void Choice(SquareItem obj)
		{
			obj.SquareValue = playerTurn ? "O" : "X";
			playerTurn = !playerTurn;
		}

		private void SetGameBoard()
		{
			Squares = new[]
			{
				new SquareItem(Choice),
				new SquareItem(Choice),
				new SquareItem(Choice),
				new SquareItem(Choice),
				new SquareItem(Choice),
				new SquareItem(Choice),
				new SquareItem(Choice),
				new SquareItem(Choice),
				new SquareItem(Choice),
			};
		}
	}
}
