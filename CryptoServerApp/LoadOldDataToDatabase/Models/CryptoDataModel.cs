using System;
using System.Collections.Generic;

namespace LoadOldDataToDatabase.Models
{
    public partial class CryptoDataModel
    {
        public int Id { get; set; }
        public DateTime TimeNow { get; set; }
        public double? BtcvalueEur { get; set; }
        public double? BtcvalueUsd { get; set; }
        public double? EthvalueEur { get; set; }
        public double? EthvalueUsd { get; set; }
        public double? XrpvalueEur { get; set; }
        public double? XrpvalueUsd { get; set; }
        public double? AdavalueEur { get; set; }
        public double? AdavalueUsd { get; set; }
        public double? DogevalueEur { get; set; }
        public double? DogevalueUsd { get; set; }
        public double? LtcvalueEur { get; set; }
        public double? LtcvalueUsd { get; set; }
        public double? SolvalueEur { get; set; }
        public double? SolvalueUsd { get; set; }
        public double? TrxvalueEur { get; set; }
        public double? TrxvalueUsd { get; set; }
        public double? DotvalueEur { get; set; }
        public double? DotvalueUsd { get; set; }
        public double? MaticvalueEur { get; set; }
        public double? MaticvalueUsd { get; set; }
    }
}
