using System;

namespace RemiseANiveauCSharp
{
    public class Vehicule : IVendable
    {

        public string Nom { get; set; }
        public decimal Prix { get; set; }

        public Vehicule(string unNom, decimal unPrix)
        {
            Nom = unNom;
            Prix = unPrix;
        }
    }
}
