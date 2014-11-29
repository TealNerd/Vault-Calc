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
            return (_layer > 1)?(int)(((2 * _layer * _layer * _layer) + _layer) / 3.0) + ((_x!=_y)? Diff(_layer):0) + ((_checkDouble)? (2 * ((_layer-1) * (_layer-1) + (_layer-1)) + 1):0):1;
        }

        public int Diff(int l)
        {
            return (l >= _y)?2 * (l - _y) * (l - _y) + 2 * (l - _y) + 1 + Diff(l - _x):0;
        }
    }
}
