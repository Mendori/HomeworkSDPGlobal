﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad4.Models
{
    public class Book : BindableBase, IDataErrorInfo
    {
        private int _inventoryNumber;
        private string _author;
        private string _title;
        private string _yearPublisher;
        private decimal _price;
        public int InventoryNumber
        {
            get { return _inventoryNumber; }
            set
            {
                _inventoryNumber = value;
                OnPropertyChanged();
            }
        }
        public string Author
        {
            get { return _author; }
            set
            {
                _author = value;
                OnPropertyChanged();
            }
        }
        public string Title
        {
            get { return _title; }
            set
            {
                _title = value;
                OnPropertyChanged();
            }
        }
        public string YearPublisher
        {
            get { return _yearPublisher; }
            set
            {
                _yearPublisher = value;
                OnPropertyChanged();
            }
        }
        public decimal Price
        {
            get { return _price; }
            set
            {
                _price = value;
                OnPropertyChanged();
            }
        }
        public Book(Book book) : this()
        {
            InventoryNumber = book.InventoryNumber;
            Author = book.Author;
            Title = book.Title;
            YearPublisher = book.YearPublisher;
            Price = book.Price;
        }
        public Book()
        {
            _bookValidator = new BookValidator();
        }



        private readonly BookValidator _bookValidator;
        public bool IsValid
        {
            get { return _bookValidator.Validate(this).IsValid; }

        }
////////////////////////////////////
public string Error
        {
            get
            {
                if (_bookValidator != null)
                {
                    var results = _bookValidator.Validate(this);
                    if (results != null && results.Errors.Any())
                    {
                        var errors =
                        String.Join(Environment.NewLine, results.Errors.Select(x => x.ErrorMessage).ToArray());
                        return errors;
                    }
                }
                return String.Empty;
            }
        }
        ////////////////////////////////////
        public string this[string columnName]
        {
            get
            {
                var firstOrDefault = _bookValidator.Validate(this)
                .Errors.FirstOrDefault(lol => lol.PropertyName == columnName);
                if (firstOrDefault != null)
                    return _bookValidator != null ? firstOrDefault.ErrorMessage : String.Empty;
                return String.Empty;
            }
        }






    }

    
}