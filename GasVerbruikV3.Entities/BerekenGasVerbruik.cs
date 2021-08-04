using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;

namespace GasVerbruikV3.Entities
{
    public class BerekenGasVerbruik
    {
        private WoningType _woningType;

        private int _bouwJaar;

        private IDictionary<WoningType, int> _woningDictionary;

        public BerekenGasVerbruik(WoningType woningType, int bouwJaar)
        {
            _woningType = woningType;
            _bouwJaar = bouwJaar;
            var nvCollection = ConfigurationManager.GetSection("WoningTypeConfiguration") as NameValueCollection;
            _woningDictionary = nvCollection.ToEnumDictionary<WoningType>(); 
        }

        public int GeefJaarVerbruik()
        {
            var gasverbruikPeriode = new BerekenGasVerbruikPeriode(_bouwJaar);
            return gasverbruikPeriode.GeefGasVerbruikPeriode(_woningDictionary[this._woningType]);
        }
    }
}


