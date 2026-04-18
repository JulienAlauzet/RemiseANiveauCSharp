namespace RemiseANiveauCSharp
{
    public class TestsVehicules
    {
        [Fact]
        public void AppliquerRemise_DoitReduireLePrix()
        {
            Vehicule voiture = new Vehicule("TestCar", 100m);

            voiture.AppliquerRemise(10);

            Assert.Equal(90m, voiture.Prix);
        }

        [Fact]
        public void AppliquerRemise_PrixInitialZero_ResteZero()
        {
           
            var v = new Vehicule("Gratuit", 0m);
            
            v.AppliquerRemise(10);
            
            Assert.Equal(0m, v.Prix);
        }

        [Fact]
        public void AppliquerRemise_DeCentPourcent_DoitRendreLePrixNul()
        {
            
            var v = new Vehicule("Gratuite", 100m);
            
            v.AppliquerRemise(100);
            
            Assert.Equal(0m, v.Prix);
        }

    }
}