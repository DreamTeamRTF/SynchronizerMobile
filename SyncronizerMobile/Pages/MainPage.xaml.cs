using SynchronizerMobile.Resources.Models;

namespace SynchronizerMobile
{
    public partial class MainPage : ContentPage
    {
        private readonly WebSynchronizerService _service;

        public MainPage()
        {
            InitializeComponent();
            _service = new WebSynchronizerService();
        }

        private async void OnGetSyncBtnClicked(object sender, EventArgs e)
        {
            var playlists = await _service.GetPlaylistsAsync(UsernameEntry.Text);
            //var playlists = new List<PlaylistWithServiceType>();
            if(playlists.Count > 0)
                await Navigation.PushAsync(new SyncPlaylistPage(playlists));
        }
    }

}
