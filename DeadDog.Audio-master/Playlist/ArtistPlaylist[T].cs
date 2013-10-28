﻿using System;
using System.Collections.Generic;
using DeadDog.Audio.Libraries;
using DeadDog.Audio.Libraries.Collections;

namespace DeadDog.Audio
{
    public class ArtistPlaylist : PlaylistCollection<Track>
    {
        private readonly Artist artist;
        private readonly Dictionary<Album, AlbumPlaylist> playlists;

        public ArtistPlaylist(Artist artist)
        {
            this.artist = artist;
            playlists = new Dictionary<Album, AlbumPlaylist>();

            foreach (Album album in artist.Albums)
            {
                var albumplaylist = new AlbumPlaylist(album);
                playlists.Add(album, albumplaylist);
                addPlaylist(albumplaylist);
            }

            this.artist.Albums.AlbumAdded += Albums_AlbumAdded;
            this.artist.Albums.AlbumRemoved += Albums_AlbumRemoved;
        }

        private void Albums_AlbumRemoved(AlbumCollection collection, AlbumEventArgs e)
        {
            if (playlists.ContainsKey(e.Album))
            {
                removePlaylist(playlists[e.Album]);
                playlists.Remove(e.Album);
            }
            else throw new InvalidOperationException("Playlist was not in the ArtistPlaylist and could not be removed");
        }

        private void Albums_AlbumAdded(AlbumCollection collection, AlbumEventArgs e)
        {
            var albumplaylist = new AlbumPlaylist(e.Album);
            playlists.Add(e.Album, albumplaylist);
            addPlaylist(albumplaylist);
        }
    }
}