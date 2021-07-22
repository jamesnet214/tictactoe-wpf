using System;
using System.Collections.Generic;
using System.Windows.Input;
using TicTacToeWPF.Models;
using TicTacToeWPF.Mvvm;

namespace TicTacToeWPF.ViewModels
{
    public class MainViewModel : ObservableObject
    {
        private bool _playerTurn;
        private bool _isActivated;
        private TicTacToeItem _winner;
        private List<TicTacToeItem> _source;

        public ICommand StartCommand { get; set; }
        public ICommand RestartCommand { get; set; }
        public ICommand ClickCommand { get; set; }

        public List<TicTacToeItem> Source
        {
            get { return _source; }
            set { _source = value; }
        }

        public bool IsActivated
        {
            get { return _isActivated; }
            set { _isActivated = value; OnPropertyChanged(); }
        }

        public TicTacToeItem Winner
        {
            get { return _winner; }
            set { _winner = value; OnPropertyChanged(); }
        }

        public MainViewModel()
        {
            Source = new List<TicTacToeItem>
            {
                new TicTacToeItem(),
                new TicTacToeItem(),
                new TicTacToeItem(),
                new TicTacToeItem(),
                new TicTacToeItem(),
                new TicTacToeItem(),
                new TicTacToeItem(),
                new TicTacToeItem(),
                new TicTacToeItem()
            };

            StartCommand = new RelayCommand<object>(Start);
            RestartCommand = new RelayCommand<object>(Restart);
            ClickCommand = new RelayCommand<TicTacToeItem>(Click);
        }

        private void Start(object obj)
        {
            IsActivated = true;
            Winner = null;
        }

        private void Restart(object obj)
        {
            Source.ForEach(x => { x.IsChecked = false; x.PlayerType = null; });
            IsActivated = true;
            Winner = null;
        }

        private void Click(TicTacToeItem obj)
        {
            obj.PlayerType = _playerTurn ? "O" : "X";
            _playerTurn = !_playerTurn;

            Winner = CalculateWinner(Source);

            if (Winner != null)
			{
                IsActivated = false;
            }
        }

        private TicTacToeItem CalculateWinner(List<TicTacToeItem> items)
		{
            List<int[]> arrayList = new List<int[]>()
            {
                new int[] { 0, 1, 2 },
                new int[] { 3, 4, 5 },
                new int[] { 6, 7, 8 },
                new int[] { 0, 3, 6 },
                new int[] { 1, 4, 7 },
                new int[] { 2, 5, 8 },
                new int[] { 0, 4, 8 },
                new int[] { 2, 4, 6 }
            };

			for (int i = 0; i < arrayList.Count; i++)
			{
                var tempArray = arrayList[i];

                var firstType = items[tempArray[0]].PlayerType;
                var secondType = items[tempArray[1]].PlayerType;
                var thirdType = items[tempArray[2]].PlayerType;

                if (firstType == secondType && firstType == thirdType && firstType != null)
				{
                    return items[tempArray[0]];
				}
			}

            return null;
        }
    }
}
