using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Local.Mvvm;

namespace TicTacToe.Local.Data
{
	public class PlayerItem : ObservableObject
	{
		private string _playerName;
		private bool _isTurn;

		public string PlayerName
		{
			get => _playerName;
			set { _playerName = value; OnPropertyChanged(); }
		}

		public bool IsTurn
		{
			get => _isTurn;
			set { _isTurn = value; OnPropertyChanged(); }
		}

		public PlayerItem(string name, bool isTurn)
		{
			PlayerName  = name;
			IsTurn = isTurn;
		}

		internal void SwitchTurn()
		{
			IsTurn = !IsTurn;
		}
	}
}
