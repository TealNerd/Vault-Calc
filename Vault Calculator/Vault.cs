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

        public int X_layer()
        {
            return (_x > _y) ? (_layer / _y) + _layer: _layer;
        }

        public int Y_layer()
        {
            return (_x < _y) ? (_layer / _x) + _layer + ((_checkDouble) ? 1 : 0) : _layer;
        }

        public float X_time(int speed)
        {
            float obi = 9.375f;

            switch (speed)
            {
                case 1:
                    obi /= 1.3f;
                    break;
                case 2:
                    obi /= 1.69f;
                    break;
                case 3:
                    obi /= 2.20f;
                    break;
                case 4:
                    obi /= 2.86f;
                    break;
                case 5:
                    obi /= 3.71f;
                    break;
            }

            return 1800 * obi * X_layer() / 60;
        }

        public float Y_time(int speed)
        {
            float obi = 9.375f;

            switch (speed)
            {
                case 1:
                    obi /= 1.3f;
                    break;
                case 2:
                    obi /= 1.69f;
                    break;
                case 3:
                    obi /= 2.20f;
                    break;
                case 4:
                    obi /= 2.86f;
                    break;
                case 5:
                    obi /= 3.71f;
                    break;
            }

            return 1800 * obi * Y_layer() / 60;
        }
    }
}
