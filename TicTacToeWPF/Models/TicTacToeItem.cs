using TicTacToeWPF.Mvvm;

namespace TicTacToeWPF.Models
{
	public class TicTacToeItem : ObservableObject
	{
		private bool _isChecked;
		private string _playerType;
		public string PlayerType
		{
			get { return _playerType; }
			set { _playerType = value; OnPropertyChanged(); }
		}

		public bool IsChecked
		{
			get { return _isChecked; }
			set { _isChecked = value; OnPropertyChanged(); }
		}
	}
}
