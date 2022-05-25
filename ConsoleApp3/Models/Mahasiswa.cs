using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ConsoleApp3.Models
{
    public class Mahasiswa
    { 
        // ? disebelah tipe data -> data boleh kosong (utk semua tipe data kecuali string)
        // string yg boleh kosong -> penulisannya biasa
        // string yg wajib diisi -> ditambahkan [Required] diatasnya
        // [Key] -> berarti data tsb adalah primary key

        [Key]
        public int NIM { get; set; }

        public string Nama { get; set; }

        public string Asal { get; set; }

        public string Jurusan { get; set; }
    }
}





