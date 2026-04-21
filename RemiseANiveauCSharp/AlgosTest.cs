using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks.Dataflow;

namespace RemiseANiveauCSharp

{
    public static class AlgosTest
    {

        public static int SommeDesMultiples_3_5_7 (int n)
        {
            int somme = 0;

            for (int i = 3; i <= n; i++)
            {
                if (i %3 == 0 || i % 5 == 0 || i % 7 == 0)
                {
                    somme += i;
                }
            }

            return somme;
        }

        public static List<string> DecoupeMessage(string messageRecu)
        {
            List<string> messages = new List<string>();

            string motEnCours = "";
            char? separateurAttendu = null;

            foreach (char c in messageRecu)
            {

                if (c == separateurAttendu)
                {
                    messages.Add(motEnCours.Trim());
                    motEnCours = "";
                    separateurAttendu = null;
                    continue;
                }

                if (separateurAttendu is null)
                {
                    if (c == '\'' || c == '"')
                    {
                        separateurAttendu = c;
                    }
                    else
                    {
                        if (c != ',' && c != ' ')
                        {
                            separateurAttendu = ',';
                            motEnCours += c;
                        }
                    }
                }
                else
                {
                    motEnCours += c;
                }

            }

            if (!(motEnCours is null) && motEnCours != "" && motEnCours != " ") messages.Add(motEnCours.Trim());

            return messages;
        }

    }
}
