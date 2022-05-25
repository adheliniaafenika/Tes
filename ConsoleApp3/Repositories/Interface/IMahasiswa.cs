using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace ConsoleApp3.Repositories.Interface
{
    public interface IMahasiswa
    {
        public void Connection(SqlConnection conn);

        public void Insert(string nama, string asal, string jurusan, SqlConnection conn);

        public void UpdateNama(int nim, string nama, SqlConnection conn);

        public void UpdateAsal(int nim, string asal, SqlConnection conn);

        public void UpdateJurusan(int nim, string jurusan, SqlConnection conn);

        public void Delete(int nim, SqlConnection conn);

        public void GetById(int nim, SqlConnection conn);

        public void GetAll(SqlConnection conn);

    }
}

