using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongsRepository
{
    public class SongData
    {
        public int IdSong { get; set; }
        public string GenresSong { get; set; }
        public string Album { get; set; }
        public string SongName { get; set; }
        public string  ArtistName { get; set; }
        public int YearOfSong { get; set; }
        public byte[] AlbumImage { get; set; }

        public SongData() { }
        public override string ToString()
        {
            return $"Id {IdSong} Genres {GenresSong} Album {Album} SongName {SongName} ArtistName {ArtistName} Year {YearOfSong} AlbumImage {AlbumImage}";
        }

    }
}
