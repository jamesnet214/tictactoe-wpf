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

		public PlayerItem(string name)
		{
			PlayerName  = name;
		}

		public string PlayerName
		{
			get => _playerName;
			set { _playerName = value; OnPropertyChanged(); }
		}
	}
}
