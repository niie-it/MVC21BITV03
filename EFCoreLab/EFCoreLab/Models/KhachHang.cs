using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreLab.Models
{
	[Table("KhachHang")]
	public class KhachHang
	{
		[StringLength(5, MinimumLength = 5)]
		[Key]
		public string MaKh { get; set; }
		public string HoTen { get; set; }

		[MaxLength(11)]
		public string SoDt { get; set; }
		public string Email { get; set; }
	}
}
