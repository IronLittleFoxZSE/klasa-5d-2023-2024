using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using UtilitiesWpf;

namespace CalculatorWPF.ViewModels
{
    class CalculatorVM : ObserverVM
    {
        private long previewValue = 0;
        private long currentValue = 0;
        private string previewOperator = "+";

        private bool operatorCommandFlag = false;
        private bool operatorEqualFlag = false;

        private string _showValue;

        public string ShowValue
        {
            get 
            { 
                return _showValue; 
            }
            set 
            {
                _showValue = value;
                OnPropertyChanged(nameof(ShowValue));
            }
        }

        private ICommand _numberCommand;

        public ICommand NumberCommand
        {
            get 
            {
                if (_numberCommand == null)
                    _numberCommand = new RelayCommand<object>(
                        (object o)=>
                        {
                            int value = int.Parse(o.ToString());

                            if (operatorCommandFlag)
                            {
                                currentValue = 0;
                                operatorCommandFlag = false;
                            }
                            if (operatorEqualFlag)
                            {
                                previewValue = 0;
                                previewOperator = "+";
                                operatorEqualFlag = false;
                            }

                            currentValue = currentValue * 10 + value;

                            ShowValue = currentValue.ToString();
                        });
                return _numberCommand; 
            }
        }

        private ICommand _arithmeticOperationsCommand;

        public ICommand ArithmeticOperationsCommand
        {
            get
            {
                if (_arithmeticOperationsCommand == null)
                    _arithmeticOperationsCommand = new RelayCommand<object>(
                        (object o)=>
                        {
                            string selectOperator = o.ToString();

                            if (operatorEqualFlag)
                            {
                                currentValue = 0;
                                previewOperator = "+";
                                operatorEqualFlag = false;
                            }

                            currentValue = CalculatePreviewOperation();

                            ShowValue = currentValue.ToString();

                            previewValue = currentValue;
                            previewOperator = selectOperator;

                            operatorCommandFlag = true;
                        });
                return _arithmeticOperationsCommand;
            }
        }

        private ICommand _equalCommand;

        public ICommand EqualCommand
        {
            get 
            {
                if (_equalCommand == null)
                    _equalCommand = new RelayCommand<object>(
                        (object o)=>
                        {
                            previewValue = CalculatePreviewOperation();
                            ShowValue = previewValue.ToString();

                            operatorCommandFlag = true;
                            operatorEqualFlag = true;
                        });
                return _equalCommand; 
            }
        }

        private ICommand _clearCommand;

        public ICommand ClearCommand
        {
            get 
            {
                if (_clearCommand == null)
                    _clearCommand = new RelayCommand<object>(
                        (object o)=>
                        {
                            currentValue = 0;
                            ShowValue = currentValue.ToString();
                            operatorCommandFlag = false;
                            previewValue = 0;
                            previewOperator = "+";
                        });
                return _clearCommand;
            }
        }

        public CalculatorVM()
        {
            ShowValue = currentValue.ToString();
        }

        private long CalculatePreviewOperation()
        {
            if (previewOperator == "+")
                return previewValue + currentValue;
            else if (previewOperator == "-")
                return previewValue - currentValue;
            else if (previewOperator == "*")
                return previewValue * currentValue;
            else if (previewOperator == "/")
                return previewValue / currentValue;
            else if (previewOperator == "%")
                return previewValue % currentValue;

            return 0;
        }
    }
}
