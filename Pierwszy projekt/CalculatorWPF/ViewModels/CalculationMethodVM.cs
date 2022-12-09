using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using UtilitiesWpf;

namespace CalculatorWPF.ViewModels
{
    class CalculationMethodVM : ObserverVM, ICalculatorOnpVM
    {

        public CalculationMethodVM()
        {
            ChoseVM = new CalculatorOnpVM();
            ListOfViewModel = new List<ICalculatorOnpVM>();
            ListOfViewModel.Add(ChoseVM);
            ListOfViewModel.Add(new CalculatorVM());
        }

        private ICalculatorOnpVM _choseVM;
        public ICalculatorOnpVM ChoseVM
        {
            get { return _choseVM; }
            set 
            { 
                _choseVM = value;
                ClearCommand.Execute(null);
                OnPropertyChanged(nameof(ChoseVM));
            }
        }

        private List<ICalculatorOnpVM> _listOfViewModel;
        public List<ICalculatorOnpVM> ListOfViewModel
        {
            get { return _listOfViewModel; }
            set 
            { 
                _listOfViewModel = value;
                OnPropertyChanged(nameof(ListOfViewModel));
            }
        }

        public ICommand ArithmeticOperationsCommand
        {
            get
            {
                return ChoseVM.ArithmeticOperationsCommand;
            }
        }

        public ICommand BackCommand
        {
            get
            {
                return ChoseVM.BackCommand;
            }
        }

        public ICommand ClearCommand
        {
            get
            {
                return ChoseVM.ClearCommand;
            }
        }

        public ICommand CloseParenthesisOperationsCommand
        {
            get
            {
                return ChoseVM.CloseParenthesisOperationsCommand;
            }
        }

        public ICommand EqualCommand
        {
            get
            {
                return ChoseVM.EqualCommand;
            }
        }

        public ICommand FunctionCommand
        {
            get
            {
                return ChoseVM.FunctionCommand;
            }
        }

        public bool IsParenthesisAvailable
        {
            get
            {
                return ChoseVM.IsParenthesisAvailable;
            }
            set
            {
                ChoseVM.IsParenthesisAvailable = value;
            }
        }

        public ICommand KeyDownCommand
        {
            get
            {
                return ChoseVM.KeyDownCommand;
            }
        }

        public ICommand NumberCommand
        {
            get
            {
                return ChoseVM.NumberCommand;
            }
        }

        public ICommand OpenParenthesisOperationsCommand
        {
            get
            {
                return ChoseVM.OpenParenthesisOperationsCommand;
            }
        }

        public string ShowValue
        {
            get
            {
                return ChoseVM.ShowValue;
            }
            set
            {
                ChoseVM.ShowValue = value;
                OnPropertyChanged(nameof(ShowValue));
            }
        }

        public string NameOfViewModel { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
