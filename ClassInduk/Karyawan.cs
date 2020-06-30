using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TugasLab9.KaryawanData
{
	public abstract class Karyawan
	{
		public string NIK { get; set; }
		public string Nama { get; set; }
        public string Jenis { get; set; }

        public abstract double Gaji();
	}
}
