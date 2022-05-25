using System;
using System.Data.SqlClient;
using ConsoleApp3.Repositories.Data;
using ConsoleApp3.Repositories.Interface;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args) //komentar
        {
            string connectionString;
            connectionString = "Data Source=DESKTOP-9REJOVV;User ID=sa;Password=adhelinia123.tes";
            SqlConnection conn;
            conn = new SqlConnection(connectionString);

            MahasiswaRepository mahasiswaRepository = new MahasiswaRepository();

            mahasiswaRepository.Connection(conn);
            //mahasiswaRepository.Insert("Nia", "Bekasi", "Informatika", conn);
            //mahasiswaRepository.Insert("Tina", "Makassar", "Ekonomi", conn);
            //mahasiswaRepository.UpdateNama(1, "Tina", conn);
            //mahasiswaRepository.UpdateAsal(1, "Makassar", conn);
            //mahasiswaRepository.UpdateJurusan(1, "Ekonomi", conn);
            //mahasiswaRepository.Delete(1, conn);
            //mahasiswaRepository.GetById(3, conn);
            //mahasiswaRepository.GetAll(conn);
        }
    }
}
