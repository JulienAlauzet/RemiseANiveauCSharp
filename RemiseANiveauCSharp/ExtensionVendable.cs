using System;
using System.Collections.Generic;
using System.Text;

namespace RemiseANiveauCSharp
{
    public static class ExtensionVendable
    {
        public static void AppliquerRemise(this IVendable item, int pourcentage)
        {
            if (pourcentage < 0 || pourcentage > 100)
                throw new ArgumentOutOfRangeException(nameof(pourcentage), "Le pourcentage doit être entre 0 et 100.");

            item.Prix -= item.Prix * pourcentage / 100m;
        }
    }
}
