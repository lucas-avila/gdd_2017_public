using PagoAgilFrba.Model;
using PagoAgilFrba.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoAgilFrba.Mappers
{
    class ClientMapper : StoreResultMapper<Client>{

        public Client getMapped(Dictionary<string, object> row)
        {
            Client client = new Client();
            client.id = (int)row["cli_id"];
            client.dni = (decimal)row["cli_dni"];
            client.name = (String)row["cli_name"];
            client.lastName = (String)row["cli_last_name"];
            client.email = (String)row["cli_email"];
            client.address = (String)row["cli_address"];
            client.birthday = (DateTime)row["cli_date_birth"];
            client.postCode = (String)row["cli_postal_code"];
            client.active = (Boolean)row["cli_active"];

            return client;
        }
    }
}
