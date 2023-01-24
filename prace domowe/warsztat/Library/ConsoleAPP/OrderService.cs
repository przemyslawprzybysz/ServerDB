using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistence;
using Domain;

namespace ConsoleApp
{
	class OrderService
	{
		private OrdersRepository _orderRepository;
		public OrderService(OrdersRepository ordersRepository)
		{
			_orderRepository = ordersRepository;
		}
		public void PlaceOrder()
		{
			Order order = new Order();
			int idksiazki;
			int ilosc;
			string tmp;
			do
			{
				Console.Clear();
				Console.WriteLine("add - dodaj pozycje do zamowienia\nend - zamknij zamowienie");
				tmp = Console.ReadLine();
				switch (tmp)
				{

					case "add":
						Console.WriteLine("Podaj ID ksiazki: "); idksiazki = Convert.ToInt32(Console.ReadLine());
						Console.WriteLine("Podaj ilosc: "); ilosc = Convert.ToInt32(Console.ReadLine());
						BookOrdered bookOrdered = new BookOrdered();
						bookOrdered.BookId = idksiazki;
						bookOrdered.NumerOrdered = ilosc;
						order.BooksOrderedList.Add(bookOrdered);
						Console.WriteLine("Dodano zamowienie\nPress Any Key"); Console.ReadLine();
						break;
					case "end": _orderRepository.Insert(order); Console.WriteLine("wysyłanie zamowien...\nPress Any Key"); Console.ReadLine(); break;
					default: Console.WriteLine("Podana komenda nie jest wspierana\nPress Any Key"); Console.ReadLine(); break;
				}
			} while (tmp != "end");
		}
		public void ListAll()
		{
			foreach (var item in _orderRepository.GetAll())
			{
				Console.WriteLine(item.ToString());
			}
		}



	}
}
