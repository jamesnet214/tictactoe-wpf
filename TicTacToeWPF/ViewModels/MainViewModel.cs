using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;
using TicTacToeWPF.Models;
using TicTacToeWPF.Mvvm;

namespace TicTacToeWPF.ViewModels
{
    public class MainViewModel : ObservableObject
    {
        private bool _playerTurn;
        private bool _isActivated;
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
        }

        private void Restart(object obj)
        {
            Source.ForEach(x => x.IsChecked = false);
            IsActivated = false;
        }

        private void Click(TicTacToeItem obj)
        {
            obj.PlayerType = _playerTurn ? "O" : "X";
            _playerTurn = !_playerTurn;
        }
    }
}
