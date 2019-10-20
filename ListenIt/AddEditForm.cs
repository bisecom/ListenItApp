using SongsRepository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListenIt
{
    public partial class AddEditForm : Form
    {
        private string filename;
        public SongData mysong { get; set; }
        public bool DataIsOk { get; set; }
        private byte[] imageByteArr;
        private int songId;

        public AddEditForm()
        {
            InitializeComponent();
            songId = 0;
        }

        public AddEditForm(SongData obj)
        {
            InitializeComponent();
            PopulateEditing(obj);
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
           mysong = null;
            DataIsOk = true;
                if (textBoxGenres.Text == "" || textBoxAlbum.Text == "" || textBoxSong.Text == "" ||
                    textBoxArtName.Text == "" || textBoxSongYear.Text == "" /*|| filename == null*/)
                {
                    MessageBox.Show("Please, enter data correctly!");
                    DataIsOk = false;
                }
                else
                {
                    mysong = new SongData();
                    mysong.GenresSong = textBoxGenres.Text;
                    mysong.Album = textBoxAlbum.Text;
                    mysong.SongName = textBoxSong.Text;
                    mysong.ArtistName = textBoxArtName.Text;
                    try
                    {
                        mysong.YearOfSong = Convert.ToInt32(textBoxSongYear.Text);
                    }
                    catch (FormatException ex)
                    {
                        MessageBox.Show("Please, enter data using correct format!");
                        DataIsOk = false;
                    }

                    if (filename != null && songId == 0)
                        mysong.AlbumImage = CreateBArrayFromImage(filename);

                    if (filename == null && songId == 0)
                        mysong.AlbumImage = CreateBArrayFromImage("Example.png");

                    if (songId != 0 && filename != null)
                    {
                        mysong.IdSong = songId;
                        mysong.AlbumImage = CreateBArrayFromImage(filename);
                    }
                    if (songId != 0 && filename == null)
                    {
                        mysong.IdSong = songId;
                        mysong.AlbumImage = imageByteArr;
                    }
                }  
            
        }

        private void buttonUpload_Click(object sender, EventArgs e)
        {
            filename = null;
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.FileName = "fileName.jpg";
            openFileDialog1.Title = "Select Image File";
            openFileDialog1.Filter = "Image Files  (*.jpg ; *.jpeg ; *.png ; *.gif ; *.tiff ; *.nef) | *.jpg; *.jpeg; *.png; *.gif; *.tiff; *.nef";
            DialogResult image = openFileDialog1.ShowDialog();
            if (image == DialogResult.OK)
            {
                string filePath1 = null;
                filePath1 = openFileDialog1.FileName;
                if (filePath1 != null)
                filename = filePath1;
                using (MemoryStream ms = new MemoryStream(CreateBArrayFromImage(filename)))
                {
                    pictureBoxEdit.Image = Image.FromStream(ms);
                }
            }
        }

        private byte[] CreateBArrayFromImage(string fileName)
        {
            Image img = Image.FromFile(fileName);
            int maxWidth = 180, maxHeight = 180;
            
            double ratioX = (double)maxWidth /
            img.Width;
            double ratioY = (double)maxHeight /
            img.Height;
            double ratio = Math.Min(ratioX, ratioY);
            int newWidth = (int)(img.Width * ratio);
            int newHeight = (int)(img.Height * ratio);
            Image mi = new Bitmap(newWidth, newHeight);
            //рисунок в памяти
            Graphics g = Graphics.FromImage(mi);
            g.DrawImage(img, 0, 0, newWidth, newHeight);
            MemoryStream ms = new MemoryStream();
            //поток для ввода|вывода байт из памяти
            mi.Save(ms, ImageFormat.Jpeg);
            ms.Flush();//выносим в поток все данные из буфера
            ms.Seek(0, SeekOrigin.Begin);
            BinaryReader br = new BinaryReader(ms);
            byte[] buf = br.ReadBytes((int)ms.Length);
            return buf;
        }

        private void PopulateEditing(SongData mysong)
        {
            imageByteArr = null;
            textBoxGenres.Text = mysong.GenresSong;
            textBoxAlbum.Text = mysong.Album;
            textBoxSong.Text = mysong.SongName;
            textBoxArtName.Text = mysong.ArtistName;
            textBoxSongYear.Text = mysong.YearOfSong.ToString();
            imageByteArr = mysong.AlbumImage;
            songId = mysong.IdSong;
            using (MemoryStream ms = new MemoryStream(mysong.AlbumImage))
            {
                pictureBoxEdit.Image = Image.FromStream(ms);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
