using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTicTacToe
{
    public class Player
    {
        private bool _player1 = true;

        public bool Player1
        {
            get { return _player1; }
            set
            {
                _player1 = value;
                if (_player1)
                    Player2 = false;
            }
        }

        private bool _player2;

        public bool Player2
        {
            get { return _player2; }
            set
            {
                _player2 = value;
                if (_player2)
                    Player2 = false;
            }
        }
    }
}
