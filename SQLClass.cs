using System.Data;
using System.Data.SqlClient;

namespace KBJU
{
    class SQLClass
    {
        public DataTable AppTable = new DataTable();
        public SqlCommand SELcmd = new SqlCommand();
        public SqlCommand UPDcmd = new SqlCommand();
        public SqlCommand INSTcmd = new SqlCommand();
        public SqlConnection MyConnection;

        public DataTable SelConnect(SqlCommand com)
        {/*Метод получения ответа SQL*/
            string ConnectionString = Properties.Settings.Default.MyConnect;
            MyConnection = new SqlConnection(ConnectionString);
            com.CommandType = CommandType.Text;
            com.Connection = MyConnection;
            com.CommandTimeout = 0;
            SqlDataAdapter Adapter = new SqlDataAdapter(com);
            DataTable AppDataTable = new DataTable();
            Adapter.Fill(AppDataTable);
            MyConnection.Close();
            return AppDataTable;
        }

        public void FixChanges(DataTable dt)
        {/*Метод сохранения изменений в БД*/
            string ConnectionString = Properties.Settings.Default.MyConnect;
            MyConnection = new SqlConnection(ConnectionString);
            SqlDataAdapter Adapter = new SqlDataAdapter();
            //AppTable.GetChanges(DataRowState.Modified);
            UPDcmd.Connection = MyConnection;
            UPDcmd.CommandTimeout = 0;
            Adapter.UpdateCommand = UPDcmd;
            Adapter.Update(dt);
            
        }

        public void InsertCh(DataTable dt)
        {/*Метод добавления записей в БД*/
            string ConnectionString = Properties.Settings.Default.MyConnect;
            MyConnection = new SqlConnection(ConnectionString);
            SqlDataAdapter Adapter = new SqlDataAdapter();
            Adapter.InsertCommand = INSTcmd;
            INSTcmd.CommandTimeout = 0;
            Adapter.Update(dt);
        }
    }
}
