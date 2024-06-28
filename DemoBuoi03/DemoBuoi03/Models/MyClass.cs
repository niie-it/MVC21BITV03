namespace DemoBuoi03.Models
{
	public class MyClass
	{
		public static int FuncA()
		{
			Thread.Sleep(2000);
			return 0;
		}
		public static string FuncB()
		{
			Thread.Sleep(5000);
			return "21BITV03";
		}
		public static void FuncC()
		{
			Thread.Sleep(3000);
		}

		public async static Task<int> FuncAAsync()
		{
			await Task.Delay(2000);
			return 0;
		}
		public static async Task<string> FuncBAsync()
		{
			await Task.Delay(5000);
			return "21BITV03";
		}
		public static async Task FuncCAsync()
		{
			await Task.Delay(3000);
		}
	}
}
