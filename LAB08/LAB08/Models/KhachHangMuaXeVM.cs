﻿using System.ComponentModel.DataAnnotations;

namespace LAB08.Models
{
	public class KhachHangMuaXeVM
	{
		[Key]
		public int MaKh { get; set; }
		public string HoTen { get; set; }
		public DateTime NgaySinh { get; set; }
		public string NhanHieu { get; set; }
		public string Model { get; set; }
	}
}
