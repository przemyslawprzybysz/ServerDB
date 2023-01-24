using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Persistence;

namespace ConsoleApp
{

	class Program
	{
		public static void DisplayMenu()
		{
			Console.Clear();
			Console.WriteLine("Wspierane komendy:\n*dodaj*\n*usun*\n*wypisz*\n*zmien*\n*dodaj zamowienie*\n*lista zamowien*\n*wyjdz*");
		}
		static void Main(string[] args)
		{
			
			Book book = new Book("Przykładowy tytuł", "Adam Kowalski", 2022, "0000000000", 5, 10.99M);
			BooksRepository repository = new BooksRepository();
			string text = Console.ReadLine();
			if (text.Split(' ')[0] == "admin" && text.Split(' ')[1] == "password")
			{
				Console.WriteLine("Access Granted");
				Console.ReadKey();
			}
			else
			{
				Console.WriteLine("Access Denied");
				Console.ReadKey();
			}
			Console.WriteLine("Wspierane komendy: ");
			BooksService service = new BooksService(repository);
			string tmp;
			OrdersRepository ordersRepository = new OrdersRepository();
			OrderService orderService = new OrderService(ordersRepository);
			do
			{
				DisplayMenu();
				tmp = Console.ReadLine();
				switch (tmp)
				{
					case "dodaj": service.AddBook(); Console.WriteLine("Press Any Key"); Console.ReadKey(); break;
					case "usun": service.RemoveBook(); Console.WriteLine("Press Any Key"); Console.ReadKey(); break;
					case "wypisz": service.ListBook(); Console.WriteLine("Press Any Key"); Console.ReadKey(); break;
					case "zmien": service.ChangeState(); Console.WriteLine("Press Any Key"); Console.ReadKey(); break;
					case "dodaj zamowienie": orderService.PlaceOrder(); break;
					case "lista zamowien": orderService.ListAll(); Console.WriteLine("Press Any Key"); Console.ReadKey(); break;
					case "wyjdz": Console.WriteLine("zamykanie programu..."); Console.WriteLine("Press Any Key"); Console.ReadKey(); break;
					default: Console.WriteLine("podana komenda nie jest wspierana"); Console.WriteLine("Press Any Key"); Console.ReadKey(); break;
				}
			} while (tmp != "wyjdz");
		}
	}
}
