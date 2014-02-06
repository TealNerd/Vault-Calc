using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vault_Calc
{
    class Vault
    {
        public int vaultVal(int layer, double x, double y)
        {
            double n = (int)((x / y) * layer);
            double g = (int)(layer / 5.0);

            double oneoneV = ((2.0 / 3.0) * Math.Pow(n, 3.0)) + (2.0 * Math.Pow(n, 2.0)) + ((7.0 / 3.0) * n);
            double correction = g * (5.0 + (6.0 * n) + (2.0 * Math.Pow(n, 2.0)));
            correction = correction + ((Math.Pow(x, 2.0) / 3.0) * g * (g + 1.0) * (2.0 * g + 1.0));
            correction = correction - (Math.Pow(g, 2.0) + g) * (2.0 * x * n + 3 * x);

            int total = (int)(oneoneV + correction);
            return total;
        }
    }
}
