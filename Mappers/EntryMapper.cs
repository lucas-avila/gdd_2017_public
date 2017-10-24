using PagoAgilFrba.Model;
using PagoAgilFrba.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoAgilFrba.Mappers
{
    class EntryMapper : StoreResultMapper<Entry>
    {
        public Entry getMapped(Dictionary<string, object> row)
        {
            Entry entry = new Entry();
            entry.description = (String)row["ent_description"];
            entry.id = (int)row["ent_id"];
            return entry;
        }
    }
}
