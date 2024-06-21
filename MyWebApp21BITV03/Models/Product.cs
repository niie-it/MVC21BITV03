using System.ComponentModel.DataAnnotations;

namespace MyWebApp21BITV03.Models
{
    public class Product
    {
        [Display(Name = "Mã")]
        public int ID { get; set; }

		[Display(Name = "Tên sản phẩm")]
		public string Name { get; set; }

		[Display(Name = "Giá")]
		public double Price { get; set; }
    }
}
