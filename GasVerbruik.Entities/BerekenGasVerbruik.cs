using System;

namespace GasVerbruik.Entities
{
    public class BerekenGasVerbruik
    {
        private int _woningType;

        private int _bouwJaar;
        
        public BerekenGasVerbruik(int woningType, int bouwJaar)
        {
            _woningType = woningType;
            _bouwJaar = bouwJaar;
        }

        public int GeefJaarVerbruik()
        {
            switch (_woningType)
            {
                case 1:
                    return GeefGasVerbruikPeriode(720);

                case 2:
                    return GeefGasVerbruikPeriode(730);

                case 3:
                    return GeefGasVerbruikPeriode(770);

                case 4:
                    return GeefGasVerbruikPeriode(800);

                case 5:
                    return GeefGasVerbruikPeriode(1150);

                case 6:
                    return GeefGasVerbruikPeriode(1300);

                case 7:
                    return GeefGasVerbruikPeriode(1350);

                case 8:
                    return GeefGasVerbruikPeriode(1400);

                default:
                    throw  new ApplicationException($"Geen verbruik gegevens gevonden bij woningtype {_woningType} voor jaar {_bouwJaar}");
            }
        }

        private int GeefGasVerbruikPeriode(int value)
        {
            if (_bouwJaar < 1966)
            {
                return (int)((float)value * 2.1F);
            }
            if (_bouwJaar < 1976)
            {
                return (int)((float)value * 1.7F);
            }
            if (_bouwJaar < 1989)
            {
                return (int)((float)value * 1.4F);
            }
            if (_bouwJaar < 2001)
            {
                return (int)((float)value * 1.05F);
            }
            return value;
        }
    }
}

