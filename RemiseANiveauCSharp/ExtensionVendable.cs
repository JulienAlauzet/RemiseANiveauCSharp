using System;
using System.Collections.Generic;
using System.Text;

namespace RemiseANiveauCSharp
{
    public static class ExtensionVendable
    {
        // Le 'this' devant le premier paramètre est la clé de la méthode d'extension
        public static void AppliquerRemise(this IVendable item, int pourcentage)
        {
            item.Prix -= item.Prix * pourcentage / 100m; // Note le 'm' pour decimal
        }
    }
}
