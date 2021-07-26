using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;
using TicTacToe.Local.Data;
using TicTacToe.Local.Mvvm;

namespace TicTacToe.Local.VIewModel
{
    public class GameViewModel : ObservableObject
    {
        #region Variables

        private int _playCount;
        private PlayerItem _player1;
        private PlayerItem _player2;
        private SquareItem[] _squares;
        #endregion

        #region PlayCount

        public int PlayCount
        {
            get => _playCount;
            set { _playCount = value; OnPropertyChanged(); }
        }
        #endregion

        #region Squares

        public SquareItem[] Squares
        {
            get => _squares;
            set { _squares = value; OnPropertyChanged(); }
        }
        #endregion

        #region Player1

        public PlayerItem Player1
        {
            get => _player1;
            set { _player1 = value; OnPropertyChanged(); }
        }
        #endregion

        #region Player2	

        public PlayerItem Player2
        {
            get => _player2;
            set { _player2 = value; OnPropertyChanged(); }
        }
        #endregion

        #region Constructor

        public GameViewModel()
        {
            SetPlayers();
            SetSquares();
        }
        #endregion

        #region Choice

        private void Choice(SquareItem square)
        {
            square.Player = (PlayCount++ % 2) switch
            {
                0 => Player.Player1,
                1 => Player.Player2,
                _ => Player.None
            };

            // Switch player turn.
            Player1.SwitchTurn();
            Player2.SwitchTurn();

            if (CalculateWinner() is SquareItem winner)
            {
                // Win
                Finish(winner.Player);
            }
            else if (PlayCount == 9)
            {
                // Draw
                Finish(Player.None);
            }
        }

        private void Finish(Player player)
        {
            if (player == Player.None)
            {
                Player1.Result.Add("D");
                Player2.Result.Add("D");
            }
            else
            {
                Player1.Result.Add(player == Player.Player1 ? "W" : "L");
                Player2.Result.Add(player == Player.Player2 ? "W" : "L");
            }
            SetSquares();
        }
        #endregion

        #region SetPlayers

        private void SetPlayers()
        {
            Player1 = new("James");
            Player2 = new("ELena");
        }
        #endregion


        #region SetSquares

        private void SetSquares()
        {
            ICommand choiceCommand = new RelayCommand<SquareItem>(Choice, (o) => o?.Player == Player.None);
            List<SquareItem> data = new();

            for (int i = 0; i < 10; i++)
            {
                data.Add(new SquareItem(choiceCommand));
            }
            Squares = data.ToArray();
            PlayCount = 0;
            Player1.IsTurn = true;
            Player2.IsTurn = false;
        }
        #endregion

        #region CalculateWinner

        private SquareItem CalculateWinner()
        {
            var items = Squares;

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

                var firstType = items[tempArray[0]].Player;
                var secondType = items[tempArray[1]].Player;
                var thirdType = items[tempArray[2]].Player;

                if (firstType == secondType && firstType == thirdType && firstType != Player.None)
                {
                    return items[tempArray[0]];
                }
            }

            return null;
        }
        #endregion
    }
}
