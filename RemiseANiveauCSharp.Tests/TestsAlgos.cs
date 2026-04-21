using System;
using System.Collections.Generic;
using System.Text;

namespace RemiseANiveauCSharp
{

    public class TestsAlgos
    {

        [Fact]
        public void Somme0_Retourne0()
        {
            Assert.Equal(0, AlgosTest.SommeDesMultiples_3_5_7(0));
        }

        [Fact]
        public void Somme2_Retourne0()
        {
            Assert.Equal(0, AlgosTest.SommeDesMultiples_3_5_7(2));
        }

        [Fact]
        public void Somme3_Retourne3()
        {
            Assert.Equal(3, AlgosTest.SommeDesMultiples_3_5_7(3));
        }

        [Fact]
        public void Somme5_Retourne8()
        {
            Assert.Equal(8, AlgosTest.SommeDesMultiples_3_5_7(5));
        }

        [Fact]
        public void Somme15_Retourne81()
        {
            Assert.Equal(81, AlgosTest.SommeDesMultiples_3_5_7(15));
        }

        [Fact]
        public void Decoupe_CasSimple_RetourneTroisElements()
        {
            // Arrange
            string input = "Simple, Message, Test";

            // Act
            var resultat = AlgosTest.DecoupeMessage(input);

            // Assert
            Assert.Equal(3, resultat.Count);
            Assert.Equal("Simple", resultat[0]);
            Assert.Equal("Message", resultat[1]);
            Assert.Equal("Test", resultat[2]);
        }

        [Fact]
        public void Decoupe_AvecGuillemets_IgnoreVirgulesInternes()
        {
            // Arrange
            string input = "'Message, avec, virgules', Simple";

            // Act
            var resultat = AlgosTest.DecoupeMessage(input);

            // Assert
            Assert.Equal(2, resultat.Count);
            Assert.Equal("Message, avec, virgules", resultat[0]);
            Assert.Equal("Simple", resultat[1]);
        }

        [Fact]
        public void Decoupe_EspacesEtMelange_NettoieEtSepare()
        {
            // Arrange
            string input = "  Espace  , \"Double, Quote\" , 'Simple' ";

            // Act
            var resultat = AlgosTest.DecoupeMessage(input);

            // Assert
            Assert.Equal(3, resultat.Count);
            Assert.Equal("Espace", resultat[0]);
            Assert.Equal("Double, Quote", resultat[1]);
            Assert.Equal("Simple", resultat[2]);
        }

    }

}
