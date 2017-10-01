using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace PagoAgilFrba.Utils{

    class Parameter {
        public object value { get; set; }
        public string key { get; set; }

        public Parameter(String key, Object value) {
            this.key = key;
            this.value = value;
        }
    }

    class StoreManager{

        private static StoreManager instance;
        private static SqlConnection connection;
        private static String schema = ConfigurationManager.AppSettings["schema"];

        private StoreManager(String connectionString) {
            connection = new SqlConnection(connectionString);
        }

        public static StoreManager getInstance() {
            if (instance == null) {
                instance = new StoreManager(ConfigurationManager.AppSettings["connection.string"]);
            }
            return instance;
        }

        public List<Dictionary<String,Object>> executeReadStore(String name,List<Parameter> parameters = null) {
            using (connection) {
                if (parameters == null){
                    parameters = new List<Parameter>(); 
                }
                connection.Open();
                SqlCommand command = new SqlCommand(schema+"." + name, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                foreach (var parameter in parameters){
                    command.Parameters.Add(new SqlParameter(parameter.key, parameter.value));
                }
                SqlDataReader dr = command.ExecuteReader();
                List<Dictionary<String,Object>> result = new List<Dictionary<String,Object>>();

                using (dr){
                    List<String> columnNames = Enumerable.Range(0, dr.FieldCount).Select(dr.GetName).ToList();

                    while (dr.Read()){
                        Dictionary<String, Object> row = new Dictionary<String, Object>();
                        foreach(var columnName in columnNames){
                            row.Add(columnName, dr[columnName]);
                        }
                        result.Add(row);
                    }
                }
                return result;
            }

        }

    }
}
