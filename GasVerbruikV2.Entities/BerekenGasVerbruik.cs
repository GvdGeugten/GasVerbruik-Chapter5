using System;

namespace GasVerbruikV2.Entities
{
    public class BerekenGasVerbruik
    {
        private WoningType _woningType;

        private int _bouwJaar;

        public BerekenGasVerbruik(WoningType woningType, int bouwJaar)
        {
            _woningType = woningType;
            _bouwJaar = bouwJaar;
        }

        public int GeefJaarVerbruik()
        {
            switch (_woningType)
            {
                case WoningType.Portiekwoning:
                    return GeefGasVerbruikPeriode(Constants.StandaardVerbruikPortiekWoning);

                case WoningType.Flat:
                    return GeefGasVerbruikPeriode(Constants.StandaardVerbruikFlat);

                case WoningType.Galerijwoning:
                    return GeefGasVerbruikPeriode(Constants.StandaardVerbruikGalerijWoning);

                case WoningType.Maisonnette:
                    return GeefGasVerbruikPeriode(Constants.StandaardVerbruikMaisonnette);

                case WoningType.Rijtjeswoning:
                    return GeefGasVerbruikPeriode(Constants.StandaardVerbruikRijtjesWoning);

                case WoningType.TweeOnderEenKap:
                    return GeefGasVerbruikPeriode(Constants.StandaardVerbruikTweeOnderEenKap);

                case WoningType.VrijstaandKlein:
                    return GeefGasVerbruikPeriode(Constants.StandaardVerbruikVrijstaandKlein);

                case WoningType.VrijstaandGroot:
                    return GeefGasVerbruikPeriode(Constants.StandaardVerbruikVrijstaandGroot);

                default:
                    throw new ApplicationException($"Geen verbruik gegevens gevonden bij woningtype {_woningType} voor jaar {_bouwJaar}");
            }
        }

        private int GeefGasVerbruikPeriode(int standaardWaarde)
        {
            if (_bouwJaar < 1966)
            {
                return GeefGecorrigeerdVerbruik(standaardWaarde, Constants.VerbruikVermenigvuldigingBouwjaarTot1966);
            }
            if (_bouwJaar < 1976)
            {
                return GeefGecorrigeerdVerbruik(standaardWaarde, Constants.VerbruikVermenigvuldigingBouwjaarTot1976);
            }
            if (_bouwJaar < 1989)
            {
                return GeefGecorrigeerdVerbruik(standaardWaarde, Constants.VerbruikVermenigvuldigingBouwjaarTot1989);
            }
            if (_bouwJaar < 2001)
            {
                return GeefGecorrigeerdVerbruik(standaardWaarde, Constants.VerbruikVermenigvuldigingBouwjaarTot2001);
            }
            return standaardWaarde;
        }

        private static int GeefGecorrigeerdVerbruik(int standaardWaarde, float verhoging)
        {
            return (int)((float)standaardWaarde * verhoging);
        }
    }
}


