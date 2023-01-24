using Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace ConsoleApp
{
	public class BooksService
	{
		BooksRepository _repository = new BooksRepository();
		public BooksService(BooksRepository repository)
		{
			_repository = repository;
		}
		public void AddBook()
		{
			Console.WriteLine("Podaj tytul: "); string tytul = Console.ReadLine();
			Console.WriteLine("Podaj autora: "); string autor = Console.ReadLine();
			Console.WriteLine("Podaj ISBN: "); string isbn = Console.ReadLine();
			Console.WriteLine("Podaj rok wydania: "); int rokwydania = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Podaj liczbe dostepnych egezemplarzy: "); int dostepnosc = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Podaj cene: "); decimal cena = Convert.ToDecimal(Console.ReadLine());
			_repository.Instert(new Book(tytul, autor, rokwydania, isbn, dostepnosc, cena));
		}
		public void RemoveBook()
		{
			Console.WriteLine("Podaj tytul: "); string tytul = Console.ReadLine();
			_repository.RemoveByTitle(tytul);
		}
		public void ListBook()
		{
			foreach (var ksiazka in _repository.GetAll())
			{
				Console.WriteLine($"{ ksiazka.Title}, { ksiazka.Author}, { ksiazka.ISBN}, { ksiazka.PublicationYear}, { ksiazka.ProductsAvailable}, { ksiazka.Price}");
			}
		}
		public void ChangeState()
		{
			Console.WriteLine("Podaj tytul: "); string tytul = Console.ReadLine();
			Console.WriteLine("Podaj zmiane stanu: "); int zmiana = Convert.ToInt32(Console.ReadLine());
			_repository.ChangeState(tytul, zmiana);
		}
	}
}
