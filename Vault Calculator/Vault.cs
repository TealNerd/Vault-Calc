using System;
using System.Text;

namespace Vault_Calculator
{
    class Vault
    {
        private bool _checkDouble;
        private int _x;
        private int _y;
        private int _layer = 0;

        public bool checkDouble { set { _checkDouble = value; } }
        public int x { set { _x = value; } }
        public int y { set { _y = value; } }
        public int layer { set { _layer = value; } }

        public int Cost()
        {
            if (_layer < 1)
                return 0;
            else if (_layer == 1)
                return 1;
            return (int)(((2 * _layer * _layer * _layer) + _layer) / 3.0) + Convert.ToInt32(_x!=_y) * Diff(_layer) + Convert.ToInt32(_checkDouble)*(2 * ((_layer-1) * (_layer-1) + (_layer-1)) + 1);
        }

        public int Diff(int l)
        {
            if (l < _y)
                return 0;
            return 2 * (l - _y) * (l - _y) + 2 * (l - _y) + 1 + Diff(l - _x);
        }
    }
}
