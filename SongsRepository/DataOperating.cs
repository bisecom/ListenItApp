using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SQLite;
using System.Data;


namespace SongsRepository
{
     public static class DataOperating
    {
        public static List<SongData> SongsList { get; set; }
        static DataOperating() { }

        public static string GetDbConnection()
        {
            var settings = System.Configuration.ConfigurationManager.ConnectionStrings["MySong"].ConnectionString;
            return settings;
        }

        public static int AddSong(SongData obj)
        {
            using (SQLiteConnection connection = new SQLiteConnection(GetDbConnection()))
            {
                connection.Open();
                SQLiteCommand cmd = new SQLiteCommand(connection);
                cmd.CommandText = $"INSERT INTO SongsList(Genres, Album, Song, ArtistName, SongYear, AlbumSlide) VALUES ('{obj.GenresSong}', '{obj.Album}', '{obj.SongName}', '{obj.ArtistName}', {obj.YearOfSong}, @img)";
                cmd.Prepare();

                cmd.Parameters.Add("@img", DbType.Binary, obj.AlbumImage.Length);
                cmd.Parameters["@img"].Value = obj.AlbumImage;
                cmd.ExecuteNonQuery();

                cmd.CommandText = $"SELECT Id FROM SongsList WHERE Genres = '{obj.GenresSong}' AND Song = '{obj.SongName}';";
                cmd.Prepare();
                int index = Convert.ToInt32(cmd.ExecuteScalar());
                return index;

            }
        }

        public static List<SongData> GetDataFromDB()
        {
            SongsList = null;
            using (SQLiteConnection connection = new SQLiteConnection(GetDbConnection()))
            {
                const string query = @"SELECT s.Id, s.Genres, s.Album, s.Song, s.ArtistName, s.SongYear, s.AlbumSlide FROM SongsList s";
                connection.Open();
                var cmd = connection.CreateCommand();
                cmd.CommandText = query;
                cmd.Connection = connection;

                var reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    SongsList = new List<SongData>();
                    foreach (DbDataRecord row in reader)
                    {
                        SongsList.Add(new SongData()
                        {
                            IdSong = Convert.ToInt32(row["Id"]),
                            GenresSong = row["Genres"].ToString(),
                            Album = row["Album"].ToString(),
                            SongName = row["Song"].ToString(),
                            ArtistName = row["ArtistName"].ToString(),
                            YearOfSong = Convert.ToInt32(row["SongYear"]),
                            AlbumImage = (byte[])row["AlbumSlide"]
                        });
                    }
                }
                reader.Close();
            }

            return SongsList;
        }

    
        public static void EditDataOfDB(SongData obj)
        {
            string query = $"UPDATE SongsList SET Genres = '{obj.GenresSong}', Album = '{obj.Album}', Song = '{obj.SongName}', ArtistName = '{obj.ArtistName}', SongYear = {obj.YearOfSong}, AlbumSlide = @img WHERE Id = {obj.IdSong}";
            using (SQLiteConnection connection = new SQLiteConnection(GetDbConnection()))
            {
                connection.Open();
                var cmd = connection.CreateCommand();
                cmd.CommandText = query;
                cmd.Connection = connection;
                cmd.Parameters.Add("@img", DbType.Binary, obj.AlbumImage.Length);
                cmd.Parameters["@img"].Value = obj.AlbumImage;
                cmd.ExecuteNonQuery();
             }

        }

        public static void DeleteLineFromDB(int index)
        {
            string query = $"DELETE FROM SongsList WHERE Id = {index}";
            using (SQLiteConnection connection = new SQLiteConnection(GetDbConnection()))
            {
                connection.Open();
                var cmd = connection.CreateCommand();
                cmd.CommandText = query;
                cmd.Connection = connection;
                cmd.ExecuteNonQuery();
            }

        }

    }
    }