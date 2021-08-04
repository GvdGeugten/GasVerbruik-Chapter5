
namespace GasVerbruikV3.Entities
{
    public class BerekenGasVerbruikPeriode
    {
        private int BouwJaar { get; set; }

        public BerekenGasVerbruikPeriode(int bouwJaar)
        {
            BouwJaar = bouwJaar;
        }

        public int GeefGasVerbruikPeriode(int standaardWaarde)
        {
            if (BouwJaar < 1966)
            {
                return GeefGecorrigeerdVerbruik(standaardWaarde, Constants.VerbruikVermenigvuldigingBouwjaarTot1966);
            }
            if (BouwJaar < 1976)
            {
                return GeefGecorrigeerdVerbruik(standaardWaarde, Constants.VerbruikVermenigvuldigingBouwjaarTot1976);
            }
            if (BouwJaar < 1989)
            {
                return GeefGecorrigeerdVerbruik(standaardWaarde, Constants.VerbruikVermenigvuldigingBouwjaarTot1989);
            }
            if (BouwJaar < 2001)
            {
                return GeefGecorrigeerdVerbruik(standaardWaarde, Constants.VerbruikVermenigvuldigingBouwjaarTot2001);
            }
            return standaardWaarde;
        }

        public static int GeefGecorrigeerdVerbruik(int standaardWaarde, float verhoging)
        {
            return (int)((float)standaardWaarde * verhoging);
        }

        private class Constants
        {
            public const float VerbruikVermenigvuldigingBouwjaarTot1966 = 2.1F;
            public const float VerbruikVermenigvuldigingBouwjaarTot1976 = 1.7F;
            public const float VerbruikVermenigvuldigingBouwjaarTot1989 = 1.4F;
            public const float VerbruikVermenigvuldigingBouwjaarTot2001 = 1.05F;
        }
    }
}
