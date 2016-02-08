using System.Windows;
using GalaSoft.MvvmLight.Command;

namespace WpfApplication3.ViewModel
{
    public class UserNames
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public RelayCommand<string> ItemClick
        {
            get { return new RelayCommand<string>(ItemClickCommand); }
        }

        private void ItemClickCommand(string obj)
        {
            MessageBox.Show(obj);
        }

   }
}