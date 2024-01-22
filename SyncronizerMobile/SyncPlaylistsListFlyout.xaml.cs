using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SyncronizerMobile
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SyncPlaylistsListFlyout : ContentPage
    {
        public ListView ListView;

        public SyncPlaylistsListFlyout()
        {
            InitializeComponent();

            BindingContext = new SyncPlaylistsListFlyoutViewModel();
            ListView = MenuItemsListView;
        }

        private class SyncPlaylistsListFlyoutViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<SyncPlaylistsListFlyoutMenuItem> MenuItems { get; set; }

            public SyncPlaylistsListFlyoutViewModel()
            {
                MenuItems = new ObservableCollection<SyncPlaylistsListFlyoutMenuItem>(new[]
                {
                    new SyncPlaylistsListFlyoutMenuItem { Id = 0, Title = "Page 1" },
                    new SyncPlaylistsListFlyoutMenuItem { Id = 1, Title = "Page 2" },
                    new SyncPlaylistsListFlyoutMenuItem { Id = 2, Title = "Page 3" },
                    new SyncPlaylistsListFlyoutMenuItem { Id = 3, Title = "Page 4" },
                    new SyncPlaylistsListFlyoutMenuItem { Id = 4, Title = "Page 5" },
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}