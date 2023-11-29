using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SB_Admin.Helpers
{
    public static class SqlHelper
    {
        const string _connectionString = @"Server=DESKTOP-AMJ6R3D\SQLEXPRESS;Database=Cinema;Trusted_Connection=True;";

        public async static Task<DataTable> GetDatas(string query)
        {
            using SqlConnection connection = new SqlConnection(_connectionString);
            await connection.OpenAsync();
            DataTable dataTable = new DataTable();
            using SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            adapter.Fill(dataTable);
            await connection.CloseAsync();
            return dataTable;
        }

        public async static Task<int> Exec(string query)
        {
            using SqlConnection connection = new SqlConnection(_connectionString);
            await connection.OpenAsync();
            using SqlCommand command = new SqlCommand(query, connection);
            int result = command.ExecuteNonQuery();
            await connection.CloseAsync();
            return result;
        }
    }
}