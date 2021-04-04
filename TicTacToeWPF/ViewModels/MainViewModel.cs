using System.Collections.Generic;
using System.Windows.Input;
using TicTacToeWPF.Models;
using TicTacToeWPF.Mvvm;

namespace TicTacToeWPF.ViewModels
{
    public class MainViewModel : ObservableObject
    {
        private bool _playerTurn;
        private List<TicTacToeItem> _source;

        public ICommand ClickCommand { get; set; }

        public List<TicTacToeItem> Source
        {
            get { return _source; }
            set { _source = value; }
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

            ClickCommand = new RelayCommand<TicTacToeItem>(Click);
        }

        private void Click(TicTacToeItem obj)
        {
            obj.PlayerType = _playerTurn ? "X" : "O";
            _playerTurn = !_playerTurn;
        }
    }
}
