using System;
using System.Windows.Input;
using TicTacToe.Local.Data;
using TicTacToe.Local.Mvvm;

namespace TicTacToe.Local.VIewModel
{
	public class GameViewModel : ObservableObject
	{
		private int _playCount;

		public SquareItem[] Squares { get; set; }

		public int PlayCount
		{
			get => _playCount;
			set { _playCount = value; OnPropertyChanged(); }
		}

		public GameViewModel()
		{
			SetGameBoard();
		}

		private void Choice(SquareItem item)
		{
			item.Player = (PlayCount++ % 2) switch
			{
				0 => Player.Player1,
				1 => Player.Player2,
				_ => Player.None
			};
		}

		private bool CanChoice(SquareItem obj)
		{
			return obj?.Player == Player.None;
		}

		private void SetGameBoard()
		{
			var choiceCommand = new RelayCommand<SquareItem>(Choice, CanChoice);

			var data = new[]
			{
				new SquareItem(choiceCommand),
				new SquareItem(choiceCommand),
				new SquareItem(choiceCommand),
				new SquareItem(choiceCommand),
				new SquareItem(choiceCommand),
				new SquareItem(choiceCommand),
				new SquareItem(choiceCommand),
				new SquareItem(choiceCommand),
				new SquareItem(choiceCommand),
			};
			Squares = data;
		}
	}
}
