﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
    public class BooksRepository
    {
        readonly List<Book> _database = new List<Book>();
		public BooksRepository()
		{
           _database.Add(new Book("Stary człowiek i morze", "Ernest Hemingway", 1986, "AAAA", 10, 19.99m));
           _database.Add(new Book("Komu bije dzwon", "Ernest Hemingway", 1997, "BBBB", 0, 119.99m));
           _database.Add(new Book("Alicja w krainie czarów", "C.K. Lewis", 1998, "CCCC", 53, 39.99m));
           _database.Add(new Book("Opowieści z Narnii", "C.K. Lewis", 1999, "DDDD", 33, 49.99m));
           _database.Add(new Book("Harry Potter", "J.K. Rowling", 2000, "EEEE", 23, 69.99m));
           _database.Add(new Book("Paragraf 22", "Joseph Heller", 2001, "FFFF", 5, 45.99m));
           _database.Add(new Book("Lalka", "Bolesław Prus", 2002, "GGGG", 7, 76.99m));
           _database.Add(new Book("To", "Stephen King", 2003, "HHHH", 2, 12.99m));
           _database.Add(new Book("Idiota", "Fiodor Dostojewski", 1950, "IIII", 89, 25.99m));
           _database.Add(new Book("Mistrz i Małgorzata", "Michaił Bułhakow", 1965, "JJJJ", 41, 36.99m));
		}
        public void Instert(Book book)
        {
            _database.Add(book);
        }
        public List<Book> GetAll()
        {
            return _database;
        }
        public void RemoveByTitle(string title)
        {
           _database.Remove(_database.First(x => x.Title == title));
        }
        public void ChangeState(string title, int stateChange)
        {
            _database.First(x => x.Title == title).ProductsAvailable += stateChange;
        }

    }
    public class OrdersRepository
    {
        private List<Order> database = new List<Order>();
        public void Insert(Order order)
        {
            database.Add(order);
        }
        public List<Order> GetAll()
        {
            return database;
        }
    }

    public class Persistence
    {
    }
}
