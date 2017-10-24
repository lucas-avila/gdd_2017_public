using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace PagoAgilFrba.Utils{

    class Parameter {
        public object value { get; set; }
        public string key { get; set; }

        public Parameter(String key, Object value) {
            this.key = key;
            this.value = value;
        }
    }

    class DefaultMapper : StoreResultMapper<Dictionary<String, Object>> {
        public Dictionary<String, Object> getMapped(Dictionary<string, object> row) {
            return row;
        }
    }

    class StoreManager{

        private static StoreManager instance;
        private static String connectionString;
        private static String schema = ConfigurationManager.AppSettings["schema"];

        private StoreManager(String stringProperty) {
            connectionString = stringProperty;
        }

        public static StoreManager getInstance() {
            if (instance == null) {
                instance = new StoreManager(ConfigurationManager.AppSettings["connection.string"]);
            }
            return instance;
        }

        private SqlConnection getConnection() {
            return new SqlConnection(connectionString);
        }

        public List<Dictionary<String,Object>> executeReadStore(String name,List<Parameter> parameters = null){
            return executeReadStore<Dictionary<String,Object>>(name,new DefaultMapper(),parameters);
        }

        public List<T> executeReadStore<T>(String name,StoreResultMapper<T> mapper,List<Parameter> parameters = null) {
            using (SqlConnection connection = getConnection()){
                if (parameters == null){
                    parameters = new List<Parameter>(); 
                }
                connection.Open();
                SqlCommand command = createSqlCommand(name, connection, parameters);
                SqlDataReader dr = command.ExecuteReader();
                List<T> result = new List<T>();

                using (dr){
                    List<String> columnNames = Enumerable.Range(0, dr.FieldCount).Select(dr.GetName).ToList();

                    while (dr.Read()){
                        Dictionary<String, Object> row = new Dictionary<String, Object>();
                        foreach(var columnName in columnNames){
                            row.Add(columnName, dr[columnName]);
                        }
                        result.Add(mapper.getMapped(row));
                    }
                }
                return result;
            }

        }

        public T executeReadSingleResult<T>(String name, StoreResultMapper<T> mapper, List<Parameter> parameters = null) {
            List<T> list = executeReadStore<T>(name, mapper, parameters);
            if (list.Count == 1) { 
                return list[0];
            }
            return default(T);
        }

        public void executeNonQuery(String name , List<Parameter> parameters = null){
            if (parameters == null){
                    parameters = new List<Parameter>(); 
            }
            using(SqlConnection connection = getConnection()){
                connection.Open();
                SqlCommand command = createSqlCommand(name, connection, parameters);
                command.ExecuteNonQuery();
            }

        }

        public int getStoreProcedureResult(String name, List<Parameter> parameters = null)
        {
            if (parameters == null)
            {
                parameters = new List<Parameter>();
            }
            using (SqlConnection connection = getConnection())
            {
                connection.Open();
                SqlCommand command = createSqlCommand(name, connection, parameters);
                command.Parameters.Add(new SqlParameter("@answer", 1)).Direction = ParameterDirection.Output;
                command.ExecuteNonQuery();
                return (int)command.Parameters["@answer"].Value;
            }
        }

        private SqlCommand createSqlCommand(String name, SqlConnection connection, List<Parameter> parameters){
            SqlCommand command = new SqlCommand(schema + "." + name, connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            foreach (var parameter in parameters){
                command.Parameters.Add(new SqlParameter(parameter.key, parameter.value));
            }
            return command;
        }

    }
}
