using Microsoft.EntityFrameworkCore;

namespace EFCoreLab.Models
{
	public class MyDbContext : DbContext
	{
		public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }

		#region Tables

		public DbSet<Loai>Loais { get; set; }
		public DbSet<HangHoa> HangHoas { get; set;}
		public DbSet<KhachHang> KhachHangs { get; set; }

		#endregion

	}
}
