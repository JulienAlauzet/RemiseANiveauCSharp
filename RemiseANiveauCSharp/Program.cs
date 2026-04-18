using System;
using System.Linq;
using System.Threading.Tasks;

namespace RemiseANiveauCSharp
{ 
    public class Program
    {
        public static async Task Main()
        {

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Hello World\n");

            #region Garage

            //List<Vehicule> vehicules = [new("V1", 15000m), new("V2", 21000m), new("V3", 18000m), new("V4", 24000m), new("V5", 14000m)];

            List<Vehicule> vehicules = await ChargerVehiculesAsync();

            // Solution 1 :
            // vehicules.ForEach(v => Console.WriteLine($"{v.Nom} coûte {v.Prix}€"));

            //Solution 2 :
            /*vehicules
                .Select(v => (v.Nom, v.Prix))
                .ToList()
    .           ForEach(t => Console.WriteLine($"{t.Nom} coûte {t.Prix}€"));*/

            // Solution 3 :
            foreach (var v in vehicules)
            {
                Console.WriteLine($"{v.Nom} coûte {v.Prix}€");
            }

            // Trouver tous les véhicules dont le prix est supérieur à 20 000 €.
            var vehiculesChers = vehicules.Where(v => v.Prix > 20000).ToList();
            Console.WriteLine("\nVéhicules dont le prix est supérieur à 20 :\n");
            //vehiculesChers.ForEach(v => Console.WriteLine($"{v.Nom} coûte {v.Prix}€"));
            foreach (var v in vehiculesChers)
            {
                Console.WriteLine($"{v.Nom} coûte {v.Prix}€");
            }

            // Calculer la moyenne de prix de tous les véhicules du garage.
            Console.WriteLine($"\nMoyenne des prix sur les véhicules : {vehicules.Average(v => v.Prix)}€");
            #endregion

            #region Interface et Extension

            Vehicule voiture2 = vehicules[1];

            try
            {
                voiture2.AppliquerRemise(10);
            } catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Erreur lors de l'application de la remise : {ex.Message}");
            }

            Console.WriteLine($"{voiture2.Nom} coûte {voiture2.Prix}€");

            #endregion

        }

        static async Task<List<Vehicule>> ChargerVehiculesAsync()
        {
            await Task.Delay(2000);
            List<Vehicule> vehicules = [new("V1", 15000m), new("V2", 21000m), new("V3", 18000m), new("V4", 24000m), new("V5", 14000m)];
            return vehicules;
        }

    }
}