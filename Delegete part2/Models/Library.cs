using Delegete_part2.Exceptions;
using Delegete_part2.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Delegete_part2.Models
{
    internal class Library: IEntity
    {
        public int Id { get; }

        public int BookLimit { get; set; }

        private List<Book> _books ;

        public Library()
        {
            _books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            if (_books.Exists(m => m.Name == book.Name && !m.IsDeleted))
            {
                throw new AlreadyExistsException("Bu adda kitab var");

                if (_books.Count < BookLimit)
                {
                 _books.Add(book);   
                }
                throw new CapacityLimitException("Limit dolub");
            }
        }
        public Book GetBookById(int? id)
        {
            if (id == null)
            
                throw new ArgumentNullException("Id null ola  bilmez");

                return _books.Find(m => !m.IsDeleted && m.Id==id );
        }

        public List<Book> GetAllBooks()
        {
            List<Book> books = new List<Book>();
            books.AddRange(_books);
            return books;
        }
        public void DeleteBookById(int? id)
        {
            if (id == null)

                throw new ArgumentNullException("Id null ola  bilmez");
            Book book = _books.Find(m => m.Id==id && !m.IsDeleted);
            if (book != null)
                throw new NullReferenceException("Bele kitab yoxdu");
            book.IsDeleted = true;
        }
        public void EditBookName(int? id, string name)
        {
            if (id == null)

                throw new ArgumentNullException("Id null ola  bilmez");
            Book book = _books.Find(m => m.Id == id);
            if (book != null)
                throw new NotFoundException("Bele kitab yocdu");
            book.Name = name;

        }
        public List<Book> FilterByPageCount(double minPriceCount, double maxPriceCount)
        {
            return _books.FindAll(m => !m.IsDeleted && m.PageCount < maxPriceCount && m.PageCount > minPriceCount);
        }
    }
}
