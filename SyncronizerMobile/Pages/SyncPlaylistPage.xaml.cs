using SyncronizerMobile.Resources.Models;
using SyncronizerMobile.Resources.Styles;

namespace SyncronizerMobile;

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