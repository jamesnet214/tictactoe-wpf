using System;
using System.Windows.Input;
using TicTacToe.Local.Mvvm;

namespace TicTacToe.Local.Data
{
	public class SquareItem : ObservableObject
	{
		public ICommand ChoiceCommand { get; set; }

		private string _squareValue;
		public string SquareValue
		{
			get => _squareValue;
			set { _squareValue = value; OnPropertyChanged(); }
		}

		public SquareItem(Action<SquareItem> choice)
		{ 
			ChoiceCommand = new RelayCommand<SquareItem>(choice);

		}
	}
}
