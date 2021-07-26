using System;

namespace TicTacToe
{
    public static class Starter
    {
        [STAThread]
        public static void Main(string[] args)
        {
            new App().Run();
        }
    }
}
