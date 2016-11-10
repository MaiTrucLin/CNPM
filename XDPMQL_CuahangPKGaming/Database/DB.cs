using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XDPMQL_CuahangPKGaming.Database
{
    public class DB
    {
        //Tạo kết nỗi Cơ sở dư liệu
        private static SqlConnection _connection;
        private static  void OpenConnection()
        {
            try
            {
                var scon1 = "Data Source=TRUNGDUNG/TRUNGDUNG;Initial Catalog=XDPMQLPKGaming;Integrated Security=True";
                if (_connection == null)
                    _connection = new SqlConnection();
                if (_connection.State != ConnectionState.Open)
                    _connection.Open();
            }
            catch(Exception)
            {
                MessageBox.Show("Kết nối thất bại");
            }
        }
        //Ngắt kết nối
        private static void CloseConnection()
        {
            if (_connection == null) return;
            if (_connection.State != ConnectionState.Open)
                _connection.Close();
        }
        // Hàm chứa tên thủ tục và danh sách tham số
        private static SqlCommand BuildCommand(string procedureName,SqlParameter[] sqlParameters)
        {
            var cmd = new SqlCommand
            {
                CommandText = procedureName,
                Connection = _connection,
                CommandType = CommandType.StoredProcedure
            };
            foreach (var sqlParameter in sqlParameters)
            {
                cmd.Parameters.Add(sqlParameter);
            }
            return cmd;
        }

        private static SqlCommand BuildIntCommand(string procedureName, SqlParameter[] parameters)
        {
            var cmd = new BuildCommand(procedureName, parameters);
            cmd.Parameters = new SqlParameter("ReturnValue",
                SqlDbType.Int, 4, 
                ParameterDirection.ReturnValue, 
                false, 
                0, 0, 
                string.Empty, 
                DataRowVersion.Default, 
                null);
            return cmd;
        }
    }
}
