using PagoAgilFrba.Model;
using PagoAgilFrba.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoAgilFrba.Mappers
{
    class ClientComboMapper : StoreResultMapper<ClientCombo>
    {
        public ClientCombo getMapped(Dictionary<string, object> row)
        {
            ClientCombo cc = new ClientCombo();
            cc.name = (String)row["cli_name"];
            cc.id = (int)row["cli_id"];
            return cc;
        }
    }
}