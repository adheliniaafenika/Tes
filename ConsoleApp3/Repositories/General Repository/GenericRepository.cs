using ConsoleApp3.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace ConsoleApp3.Repositories.General_Repository
{
    public class GenericRepository<T> : IGeneric<T> where T : class
    {
        //private object nama;
        public void Connection(SqlConnection conn)
        {
            try
            {
                conn.Open(); //Buka koneksi
                Console.WriteLine("Succesfully Connect...");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }

        //public void Insert(T model, SqlConnection conn)
        //{
        //    using (SqlCommand command = new SqlCommand($"INSERT INTO {model}({model.nama}, model.sal, model.jurusan) VALUES ('{nama}', '{asal}', '{jurusan}')", conn))
        //    {
        //        command.ExecuteNonQuery(); //execute the query
        //        Console.WriteLine("query executed (insert data)");
        //    }
        //}

        public void GetAll(T model, SqlConnection conn)
        {
            string displayQuery = "SELECT * FROM {model}";
            SqlCommand displayCommand = new SqlCommand(displayQuery, conn);
            SqlDataReader dataReader = displayCommand.ExecuteReader();

            while (dataReader.Read())
            {
                Console.WriteLine(dataReader.GetValue(0).ToString()
                    + "     " + dataReader.GetValue(1).ToString()
                    + "     " + dataReader.GetValue(2).ToString()
                    + "     " + dataReader.GetValue(3).ToString());
            }
            dataReader.Close();
        }
    }

}

/////
