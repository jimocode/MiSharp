﻿using System;

namespace DeadDog.Audio.Libraries
{
    /// <summary>
    ///     Provides data for the <see cref="DeadDog.Audio.Libraries.Album.AlbumCollection.AlbumAdded" /> and the
    ///     <see
    ///         cref="DeadDog.Audio.Libraries.Album.AlbumCollection.AlbumRemoved" />
    ///     events.
    /// </summary>
    public class AlbumEventArgs : EventArgs
    {
        private readonly Album album;

        /// <summary>
        ///     Initializes a new instance of the <see cref="AlbumEventArgs" /> class.
        /// </summary>
        /// <param name="album">The album.</param>
        public AlbumEventArgs(Album album)
        {
            this.album = album;
        }

        /// <summary>
        ///     Gets the album associated with the event.
        /// </summary>
        /// <value>
        ///     The album.
        /// </value>
        public Album Album
        {
            get { return album; }
        }
    }
}