﻿using System.Globalization;

namespace MusicStore.Models
{
    public class Album
    {
        public int AlbumId { get; set; }
        public int GenreId { get; set; }
        public int ArtistId { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string AlbumArtUrl { get; set; }

        public Artist Artists { get; set; }
        public Genre Genres { get; set; }
    }
}
