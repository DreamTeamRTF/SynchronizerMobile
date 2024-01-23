using SynchronizerMobile.Resources.Models;
using SynchronizerMobile.Resources.Styles;

namespace SynchronizerMobile;

public partial class SyncPlaylistPage : ContentPage
{
	private List<PlaylistWithServiceType> _playlists;
    public List<PlaylistWithServiceType> Playlists {
		get => _playlists;
		set
		{
			_playlists = value;
			//Todo:сделать пересборку страницы
		}
	}

    public SyncPlaylistPage(List<PlaylistWithServiceType> playlists)
	{
        InitializeComponent();
        Playlists = playlists;
		collectionView.ItemsSource = playlists;
	}
}