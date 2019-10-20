using SongsRepository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListenIt
{
    public partial class MainForm : Form
    {
         public MainForm()
        {
            InitializeComponent();
            PopulateDGV();
            bindingSourceSongs.DataSource = DataOperating.GetDataFromDB();
            dataGridView1.DataSource = bindingSourceSongs;

        }

       
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var addForm = new AddEditForm();

            if (addForm.ShowDialog() == DialogResult.OK && addForm.mysong != null && addForm.DataIsOk)
            {
                DataOperating.AddSong(addForm.mysong); 
            }
            bindingSourceSongs.DataSource = DataOperating.GetDataFromDB();

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            var selectedRow = dataGridView1.SelectedRows[0];
            SongData editSong = new SongData();
            editSong.IdSong = Convert.ToInt32(selectedRow.Cells[0].Value);
            editSong.GenresSong = Convert.ToString(selectedRow.Cells[1].Value);
            editSong.Album = Convert.ToString(selectedRow.Cells[2].Value);
            editSong.SongName = Convert.ToString(selectedRow.Cells[3].Value);
            editSong.ArtistName = Convert.ToString(selectedRow.Cells[4].Value);
            editSong.YearOfSong = Convert.ToInt32(selectedRow.Cells[5].Value);
            foreach(SongData song in DataOperating.SongsList)
            {
                if (song.IdSong == editSong.IdSong)
                    editSong.AlbumImage = song.AlbumImage;
            }

            AddEditForm myedit = new AddEditForm(editSong);
            myedit.Text = "Editing selected song";
            if (myedit.ShowDialog() == DialogResult.OK && myedit.DataIsOk)
            {
                DataOperating.EditDataOfDB(myedit.mysong);
            }
            bindingSourceSongs.DataSource = DataOperating.GetDataFromDB();

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var selectedRow = dataGridView1.SelectedRows[0];
            DialogResult dialogResult = MessageBox.Show($"Are you sure to delete song: {selectedRow.Cells[3].Value.ToString()}", "Song deleting", MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.OK)
            {
                DataOperating.DeleteLineFromDB(Convert.ToInt32(selectedRow.Cells[0].Value));
                bindingSourceSongs.DataSource = DataOperating.GetDataFromDB();
            }
            else if (dialogResult == DialogResult.Cancel)
            {
                return;
            }
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.Focused)
            {
                pictureBoxMain.SizeMode = PictureBoxSizeMode.CenterImage;
                pictureBoxMain.BorderStyle = BorderStyle.FixedSingle;
                var selectedRow = dataGridView1.SelectedRows[0];
                foreach (SongData song in DataOperating.SongsList)
                {
                    if (song.IdSong == Convert.ToInt32(selectedRow.Cells[0].Value))
                    {
                        using (MemoryStream ms = new MemoryStream(song.AlbumImage))
                        {
                            pictureBoxMain.Image = Image.FromStream(ms);
                        }
                    }
                }
            }


        }

        private void PopulateDGV()
        {
            dataGridView1.AutoGenerateColumns = false;
            DataGridViewTextBoxColumn track = new DataGridViewTextBoxColumn();
            track.HeaderText = "Song No";
            track.DataPropertyName = "IdSong";
            dataGridView1.Columns.Add(track);

            DataGridViewTextBoxColumn genres = new DataGridViewTextBoxColumn();
            genres.HeaderText = "Genres";
            genres.DataPropertyName = "GenresSong";
            dataGridView1.Columns.Add(genres);

            DataGridViewTextBoxColumn album = new DataGridViewTextBoxColumn();
            album.HeaderText = "Album";
            album.DataPropertyName = "Album";
            dataGridView1.Columns.Add(album);

            DataGridViewTextBoxColumn song = new DataGridViewTextBoxColumn();
            song.HeaderText = "Song Name";
            song.DataPropertyName = "SongName";
            dataGridView1.Columns.Add(song);

            DataGridViewTextBoxColumn artist = new DataGridViewTextBoxColumn();
            artist.HeaderText = "Artist Name";
            artist.DataPropertyName = "ArtistName";
            dataGridView1.Columns.Add(artist);

            DataGridViewTextBoxColumn year = new DataGridViewTextBoxColumn();
            year.HeaderText = "Year Of The Song";
            year.DataPropertyName = "YearOfSong";
            dataGridView1.Columns.Add(year);

            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[3].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming Soon!");
        }
    }
}
