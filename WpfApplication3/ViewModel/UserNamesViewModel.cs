using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication3.ViewModel
{
    public class UserNamesViewModel : ViewModelBase
    {
        private ObservableCollection<UserNames> _names;

        public ObservableCollection<UserNames> Names
        {
            get { return _names; }
            set
            {
                if (_names == value)
                    return;
                _names = value;
                OnPropertyChanged();
            }
        }

        private bool _isOpen;

        public bool IsOpen
        {
            get { return _isOpen; }
            set
            {
                _isOpen = value;
                OnPropertyChanged();
            }
        }

        public UserNamesViewModel()
        {
        }

        public void CreateCollection()
        {
            Names = new ObservableCollection<UserNames>();
            Names.Add(new UserNames
            {
                FirstName = "Seba",
                LastName = "De Gambe"
            });

            Names.Add(new UserNames
            {
                FirstName = "Ania",
                LastName = "Działowska"
            });
            Names.Add(new UserNames
            {
                FirstName = "Seba",
                LastName = "De Gambe"
            });

            Names.Add(new UserNames
            {
                FirstName = "Ania",
                LastName = "Działowska"
            });
            Names.Add(new UserNames
            {
                FirstName = "Seba",
                LastName = "De Gambe"
            });

            Names.Add(new UserNames
            {
                FirstName = "Ania",
                LastName = "Działowska"
            });
            IsOpen = true;
        }
    }
}
