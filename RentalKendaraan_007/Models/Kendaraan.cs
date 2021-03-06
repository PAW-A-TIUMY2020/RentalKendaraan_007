﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan_007.Models
{
    public partial class Kendaraan
    {
        public Kendaraan()
        {
            Peminjaman = new HashSet<Peminjaman>();
        }
        [Required(ErrorMessage = "ID Kendaraan tidak boleh kosong")]
        public int IdKendaraan { get; set; }

        [Required(ErrorMessage = "Nama Kendaraan tidak boleh kosong")]
        public string NamaKendaraan { get; set; }

        [Required(ErrorMessage = "No Polisi tidak boleh kosong")]
        public string NoPolisi { get; set; }

        [MinLength(16, ErrorMessage = "No STNK minimal 16 angka")]
        [MaxLength(16, ErrorMessage = "No STNK maksimal 16 angka")]
        public string NoStnk { get; set; }


        public int? IdJenisKendaraan { get; set; }


        public string Ketersediaan { get; set; }

        public JenisKendaraan IdJenisKendaraanNavigation { get; set; }
        public ICollection<Peminjaman> Peminjaman { get; set; }
    }
}
