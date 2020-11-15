using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.SQLite;
using System.Globalization;
using Youtube_dl_ffmpeg_tool.Models;


namespace Youtube_dl_ffmpeg_tool.Helper
{
    public class DataHelper
    {
        private static string strConnect = "Data Source=StreamTool.db;Version=3;";
        private static DataHelper db;

        private DataHelper() 
        {

        }
        public static void InitDataHelper()
        {
            if (db == null)
            {
                db = new DataHelper();
            }
        }

        private DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();

            using (SQLiteConnection connection = new SQLiteConnection(strConnect))
            {
                connection.Open();

                SQLiteCommand command = new SQLiteCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains("@"))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection);

                adapter.Fill(data);

                connection.Close();
            }

            return data;
        }
        private int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;

            using (SQLiteConnection connection = new SQLiteConnection(strConnect))
            {
                connection.Open();

                SQLiteCommand command = new SQLiteCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains("@"))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteNonQuery();

                connection.Close();
            }

            return data;
        }

        private object ExecuteScalar(string query, object[] parameter = null)
        {
            object data = 0;

            using (SQLiteConnection connection = new SQLiteConnection(strConnect))
            {
                connection.Open();

                SQLiteCommand command = new SQLiteCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains("@"))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteScalar();

                connection.Close();
            }

            return data;
        }

        public static BindingList<Playlist> LoadPlayList()
        {
            var query = "SELECT * FROM Playlist";
            BindingList<Playlist> playlists = new BindingList<Playlist>();
            DataTable data = db.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Playlist playlist = new Playlist()
                {
                     PlaylistId = int.Parse(item["PlaylistId"].ToString()),
                     PlaylistName = item["PlaylistName"].ToString()
                };
                playlists.Add(playlist);
            }

            return playlists;
        }

        public static void AddPlaylist(Playlist playlist)
        {
            var query = $"INSERT INTO Playlist(PlaylistName) VALUES('{playlist.PlaylistName}')";
            db.ExecuteNonQuery(query);
        }

        public static void DeletePlaylist(int playlistId)
        {
            var query = $"DELETE FROM Playlist WHERE PlaylistId={playlistId}";
            db.ExecuteNonQuery(query);
        }

        public static List<MediaType> GetMediaTypes()
        {
            var query = $"SELECT * FROM MediaType";
            List<MediaType> mediaTypes = new List<MediaType>();
            DataTable data = db.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                MediaType mediaType = new MediaType()
                {
                    MediaTypeId = int.Parse(item["MediaTypeId"].ToString()),
                    MediaTypeName = item["MediaTypeName"].ToString()
                };
                mediaTypes.Add(mediaType);
            }
            return mediaTypes;
        }

        public static BindingList<Media> GetMedias(int playlistId)
        {
            var query = $"SELECT * FROM Media WHERE PlaylistId={playlistId}";
            BindingList<Media> medias = new BindingList<Media>();
            DataTable data = db.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Media media = new Media()
                {
                    MediaTypeId = int.Parse(item["MediaTypeId"].ToString()),
                    PlaylistId = int.Parse(item["PlaylistId"].ToString()),
                    MediaId = int.Parse(item["MediaId"].ToString()),
                    MediaLink = item["MediaLink"].ToString(),
                    MediaName = item["MediaName"].ToString(),
                    RepeatTime = int.Parse(item["RepeatTime"].ToString())
                };
                medias.Add(media);
            }
            return medias;
        }

        public static void AddMedia(Media media)
        {
            var query = $"INSERT INTO " +
                $"Media(MediaName,MediaLink,MediaTypeId,RepeatTime,PlaylistId) " +
                $"VALUES(\"{media.MediaName}\",\"{media.MediaLink}\",{media.MediaTypeId},{media.RepeatTime},{media.PlaylistId})";
            db.ExecuteNonQuery(query);
        }

        public static void DeleteMedia(int mediaId)
        {
            var query = $"DELETE FROM Media WHERE MediaId={mediaId}";
            db.ExecuteNonQuery(query);
        }
    }
}
