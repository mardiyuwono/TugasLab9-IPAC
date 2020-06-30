using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TugasLab9.KaryawanData
{
	public class Sales : Karyawan
	{
		public double JumlahPenjualan {get;set;}
		public double Komisi {get;set;}
        
		public override double Gaji()
		{
			double Gaji = 0;
			Gaji = JumlahPenjualan * Komisi;
			return Gaji;
		}
	}
}
