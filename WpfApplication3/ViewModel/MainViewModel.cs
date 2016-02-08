using System.Windows;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace WpfApplication3.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        public UserNamesViewModel UsertNamesCollection { get; }
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel(UserNamesViewModel usertNamesCollection)
        {
            UsertNamesCollection = usertNamesCollection;
            ButtonClick = _buttonClick ?? (_buttonClick = new RelayCommand(ButtonClickCommand));
            ////if (IsInDesignMode)
            ////{
            ////    // Code runs in Blend --> create design time data.
            ////}
            ////else
            ////{
            ////    // Code runs "for real"
            ////}
        }

        private readonly RelayCommand _buttonClick;

        public RelayCommand ButtonClick { get; set; }

        private void ButtonClickCommand()
        {
            UsertNamesCollection.CreateCollection();
        }
    }
}