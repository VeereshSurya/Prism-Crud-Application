using Prism.Commands;
using Prism.Mvvm;
using Prism_Crud_Application.Models;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Input;

namespace Prism_Crud_Application.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {

        #region Properties and Declarations

        private string _title = "Prism Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private string _bookName;
        public string BookName
        {
            get { return _bookName; }
            set { SetProperty(ref _bookName, value); }
        }

        private string _author;
        public string Author
        {
            get { return _author; }
            set { SetProperty(ref _author, value); }
        }

        private int _price;
        public int Price
        {
            get { return _price; }
            set { SetProperty(ref _price, value); }
        }

        private string _publications;
        public string Publications
        {
            get { return _publications; }
            set { SetProperty(ref _publications, value); }
        }

        private Visibility _isVisibleUpdateAndCancle { get; set; }
        public Visibility IsVisibleUpdateAndCancle
        {
            get { return _isVisibleUpdateAndCancle; }
            set
            {
                _isVisibleUpdateAndCancle = value;
            }
        }

        private ObservableCollection<Book> _allBooks;
        public ObservableCollection<Book> AllBooks
        {
            get { return _allBooks; }
            set
            {
                _allBooks = value;
            }
        }

        #endregion

        #region Commands

        public ICommand AddBookCommand { get; private set; }
        public ICommand RemoveBookCommand { get; private set; }
        public ICommand UpdateBookCommand { get; private set; }
        public ICommand CancleBookCommand { get; private set; }
        public ICommand PreviousPageCommand { get; private set; }
        public ICommand NextPageCommand { get; private set; }

        #endregion

        public MainWindowViewModel()
        {
            AllBooks = new ObservableCollection<Book>();
            AddBookCommand = new DelegateCommand(AddBookCommandHandler, CanExecuteAddBookCommandHandler);
            RemoveBookCommand = new DelegateCommand(RemoveBookCommandHandler, CanExecuteRemoveBookCommandHandler);
        }

        #region Public Methods

        private void AddBookCommandHandler()
        {
            var newbook = new Book
            {
                Name = BookName,
                Price = Price,
                Author = Author,
                Publications = Publications
            };

            AllBooks.Add(newbook);
        }

        private bool CanExecuteAddBookCommandHandler()
        {
            return true;
        }

        public void RemoveBookCommandHandler()
        {
            var bookToDelete = AllBooks.FirstOrDefault(e => e.Id.Equals(5) && e.Name.Equals("Veeresh") && e.Author.Equals("Surya") && Publications.Equals("Surya"));
            if(bookToDelete != null)
            {
                AllBooks.Remove(bookToDelete);
            }
        }

        public bool CanExecuteRemoveBookCommandHandler()
        {
            return true;
        }

        #endregion




    }
}
