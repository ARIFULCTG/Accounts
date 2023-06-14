using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClientVie
{
    public class LedgerJournal
    {
        public int LedgerID { get; set; }
        public string ladgerName { get; set; }
        public string SlName { get; set; }
        public string jnalID { get; set; }
        public string Sl { get; set; }
        public Nullable<decimal> Debit { get; set; }
        public Nullable<decimal> Credit { get; set; }
    }
}