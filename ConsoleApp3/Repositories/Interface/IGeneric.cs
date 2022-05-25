using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace ConsoleApp3.Repositories.Interface
{
    public interface IGeneric<T> where T : class
    {
        public void Connection(SqlConnection conn);

        //public void Insert(T model, SqlConnection con);

        //public void UpdateNama(T model, SqlConnection conn);

        //public void UpdateAsal(T model, SqlConnection conn);

        //public void UpdateJurusan(T model, SqlConnection conn);

        //public void Delete(T model, SqlConnection conn);

        //public void GetById(T model, SqlConnection conn);

        public void GetAll(T model, SqlConnection conn);
    }
}
