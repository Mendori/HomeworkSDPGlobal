using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using zad4.Commands;
using zad4.DataAccess.Interface;
using zad4.Models;

namespace zad4.ViewModels
{
    class MainViewModel
    {

       
        public ICommand SaveFile { get; private set; }


        public ObservableCollection<Book> Books
        {
            get;
            set;
        }
        public Book NewBook
        {
            get;
            set;
        }
        public ICommand AddBook
        {
            get;
            private set;
        }
        private void AddNewBook()
        {
            if (NewBook.IsValid)
            {
                Books.Add(new Book(NewBook));
            }
        }
        private readonly ISourceOperationStrategy _sourceOperations;
        private readonly IDialogService _dialogService;
        
        public ICommand OpenFile
        {
            get;
            private set;
        }
        
        public MainViewModel(IDialogService dialogService, ISourceOperationStrategy sourceOperations)
        {
            _dialogService = dialogService;
            _sourceOperations = sourceOperations;
            Books = new ObservableCollection<Book>();
            NewBook = new Book();
            AddBook = new RelayCommand(param => AddNewBook(), null);
            OpenFile = new RelayCommand(param => LoadDataFromFile(), null);
            //added by M.
            SaveFile = new RelayCommand(param => SaveDataToFile(), null);
        }

        private void SaveDataToFile()
        {
            var fileName = _dialogService.SaveFileDialog();

            if (fileName != null)
            {
                _sourceOperations.GetWriter(fileName).WriteBooks(fileName, Books.ToList() );    
                    
            };
            
        }
        

        private void LoadDataFromFile()
        {
            var fileName = _dialogService.OpenFileDialog();
            if (fileName != null)
            {
                List<Book> bookList = _sourceOperations.GetReader(fileName).ReadBooks(fileName);
                Books.Clear();
                foreach (Book book in bookList)
                {
                    Books.Add(book);
                }
            }
        }


    }
}
