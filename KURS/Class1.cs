using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlServerCe;
using System.ServiceModel;

namespace KURS
{
    [ServiceContract]
    public interface IServer
    { 
        [OperationContract]
        string DoQuery(string query,bool ret);
    }


    public class ServBD : IServer
    {
        public string DoQuery(string query, bool ret)
        {
            if (!ret)
            {
               try
            {
                using (SqlCeConnection conn = new SqlCeConnection(@"Data Source=C:\Users\Андрей свали с компа\Desktop\myDB.sdf"))
                {
                    conn.Open();
                    using (SqlCeCommand c = new SqlCeCommand(query))
                    {
                        c.Connection = conn;
                        c.ExecuteNonQuery();
                    }
                }
return "Execution completed sucsessful";
            }
            catch (Exception exp)
            {
return "Excecution error: "+exp.Message;
            }


            } else

                try
                { 
                    string s = "";
                    using (SqlCeConnection conn = new SqlCeConnection(@"Data Source=C:\Users\Андрей свали с компа\Desktop\myDB.sdf"))
                    {
                        conn.Open();
                        using (SqlCeCommand c = new SqlCeCommand(query))
                        {
                            c.Connection = conn;
                            SqlCeDataReader sql=c.ExecuteReader();
                           
                            while (sql.Read())
                            {
                                for (int i = 0; i < sql.FieldCount; i++)
                                    s += sql.GetValue(i).ToString() + " ";
                                s += Environment.NewLine;
                            }
                            sql.Close();
                        }
                    }
                    return s;
                }
                catch (Exception exp)
                {
                    return "Excecution error: " + exp.Message;
                }
        }
    }


}

   

