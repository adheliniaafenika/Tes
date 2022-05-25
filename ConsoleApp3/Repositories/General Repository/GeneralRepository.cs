using ConsoleApp3.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace ConsoleApp3.Repositories.General_Repository
{
    public class GeneralRepository : IMahasiswa
    {
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

        public void Insert(string nama, string asal, string jurusan, SqlConnection conn)
        {
            using (SqlCommand command = new SqlCommand($"INSERT INTO Mahasiswa(Nama, Asal, Jurusan) VALUES ('{nama}', '{asal}', '{jurusan}')", conn))
            {
                command.ExecuteNonQuery(); //execute the query
                Console.WriteLine("query executed (insert data)");
            }
        }

        public void UpdateNama(int nim, string nama, SqlConnection conn)
        {
            using (SqlCommand command = new SqlCommand($"UPDATE Mahasiswa SET Nama = '{nama}' WHERE NIM = {nim}", conn))
            {
                command.ExecuteNonQuery(); //execute the query
                Console.WriteLine("query executed (update data nama)");
            }
        }

        public void UpdateAsal(int nim, string asal, SqlConnection conn)
        {
            using (SqlCommand command = new SqlCommand($"UPDATE Mahasiswa SET Asal = '{asal}' WHERE NIM = {nim}", conn))
            {
                command.ExecuteNonQuery(); //execute the query
                Console.WriteLine("query executed (update data asal)");
            }
        }

        public void UpdateJurusan(int nim, string jurusan, SqlConnection conn)
        {
            using (SqlCommand command = new SqlCommand($"UPDATE Mahasiswa SET Jurusan = '{jurusan}' WHERE NIM = {nim}", conn))
            {
                command.ExecuteNonQuery(); //execute the query
                Console.WriteLine("query executed (update data jurusan)");
            }
        }

        public void Delete(int nim, SqlConnection conn)
        {
            using (SqlCommand command = new SqlCommand($"DELETE FROM Mahasiswa WHERE NIM = {nim}", conn))
            {
                command.ExecuteNonQuery(); //execute the query
                Console.WriteLine("query executed (delete data)");
            }
        }

        public void GetById(int nim, SqlConnection conn)
        {
            string displayQuery = $"SELECT * FROM Mahasiswa WHERE NIM = {nim}";
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

        public void GetAll(SqlConnection conn)
        {
            string displayQuery = "SELECT * FROM Mahasiswa";
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