using DPINT_Wk1_Strategies.ViewModel;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DPINT_Wk1_Strategies
{
    public class ValueConverterViewModel : ViewModelBase
    {
        private NumberConverterFactory _numberConverterFactory;
        private INumberConverter _toConverter;
        private INumberConverter _fromConverter;

        private string _fromText;
        public string FromText
        {
            get { return _fromText; }
            set
            {
                _fromText = value;
                RaisePropertyChanged("FromText");
                this.ConvertNumbers();
            }
        }

        private string _toText;
        public string ToText
        {
            get { return _toText; }
            set
            {
                _toText = value;
                RaisePropertyChanged("ToText");
            }
        }

        private string _fromConverterName;
        public string FromConverterName
        {
            get { return _fromConverterName; }
            set
            {
                _fromConverterName = value;
                RaisePropertyChanged("FromConverterName");
                _fromConverter = _numberConverterFactory.GetConverter(value);
                this.ConvertNumbers();
            }
        }

        private string _toConverterName;
        public string ToConverterName
        {
            get { return _toConverterName; }
            set
            {
                _toConverterName = value;
                RaisePropertyChanged("ToConverterName");
                _toConverter = _numberConverterFactory.GetConverter(value);
                this.ConvertNumbers();
            }
        }

        public ObservableCollection<string> ConverterNames { get; set; }
        public ICommand ConvertCommand { get; set; }

        public ValueConverterViewModel()
        {
            _numberConverterFactory = new NumberConverterFactory();
            ConverterNames = new ObservableCollection<string>(_numberConverterFactory.ConverterNames);

            _fromConverter = _numberConverterFactory.GetConverter(ConverterNames.First());
            _toConverter = _numberConverterFactory.GetConverter(ConverterNames.First());

            FromConverterName = ConverterNames.First();
            ToConverterName = ConverterNames.First();

            //FromText = "0";
            //ToText = "0";
            //FromConverterName = "Numerical";
            //ToConverterName = "Numerical";

            ConvertCommand = new RelayCommand(ConvertNumbers);
        }

        private void ConvertNumbers()
        {
            int number = _fromConverter.ToNumerical(FromText);
            ToText = _toConverter.ToLocalString(number);
        }
    }
}
