using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TugasLab9.KaryawanData
{
	public class KaryawanHarian : Karyawan
	{
		public double UpahPerJam {get;set;}
		public double JumlahJamKerja {get;set;}
  
		public override double Gaji()
		{
			double Gaji = 0;
			Gaji = UpahPerJam * JumlahJamKerja;
			return Gaji;
		}
	}
}
