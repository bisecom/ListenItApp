namespace ListenIt
{
    partial class AddEditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditForm));
            this.buttonOk = new System.Windows.Forms.Button();
            this.labelGenres = new System.Windows.Forms.Label();
            this.textBoxGenres = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelAlbum = new System.Windows.Forms.Label();
            this.textBoxAlbum = new System.Windows.Forms.TextBox();
            this.labelSong = new System.Windows.Forms.Label();
            this.textBoxSong = new System.Windows.Forms.TextBox();
            this.labelArtistName = new System.Windows.Forms.Label();
            this.textBoxArtName = new System.Windows.Forms.TextBox();
            this.labelSongYear = new System.Windows.Forms.Label();
            this.textBoxSongYear = new System.Windows.Forms.TextBox();
            this.labelAlbumSlide = new System.Windows.Forms.Label();
            this.buttonUpload = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBoxEdit = new System.Windows.Forms.PictureBox();
            this.labelSlide = new System.Windows.Forms.Label();
            this.pictureBoxAddHead = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAddHead)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOk
            // 
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOk.Location = new System.Drawing.Point(231, 461);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(83, 32);
            this.buttonOk.TabIndex = 0;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // labelGenres
            // 
            this.labelGenres.AutoSize = true;
            this.labelGenres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGenres.Location = new System.Drawing.Point(26, 114);
            this.labelGenres.Name = "labelGenres";
            this.labelGenres.Size = new System.Drawing.Size(68, 20);
            this.labelGenres.TabIndex = 1;
            this.labelGenres.Text = "Genres";
            // 
            // textBoxGenres
            // 
            this.textBoxGenres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxGenres.Location = new System.Drawing.Point(29, 142);
            this.textBoxGenres.Name = "textBoxGenres";
            this.textBoxGenres.Size = new System.Drawing.Size(180, 21);
            this.textBoxGenres.TabIndex = 2;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancel.Location = new System.Drawing.Point(368, 461);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(83, 32);
            this.buttonCancel.TabIndex = 0;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelAlbum
            // 
            this.labelAlbum.AutoSize = true;
            this.labelAlbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAlbum.Location = new System.Drawing.Point(26, 174);
            this.labelAlbum.Name = "labelAlbum";
            this.labelAlbum.Size = new System.Drawing.Size(59, 20);
            this.labelAlbum.TabIndex = 1;
            this.labelAlbum.Text = "Album";
            // 
            // textBoxAlbum
            // 
            this.textBoxAlbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAlbum.Location = new System.Drawing.Point(29, 202);
            this.textBoxAlbum.Name = "textBoxAlbum";
            this.textBoxAlbum.Size = new System.Drawing.Size(180, 21);
            this.textBoxAlbum.TabIndex = 2;
            // 
            // labelSong
            // 
            this.labelSong.AutoSize = true;
            this.labelSong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSong.Location = new System.Drawing.Point(26, 238);
            this.labelSong.Name = "labelSong";
            this.labelSong.Size = new System.Drawing.Size(51, 20);
            this.labelSong.TabIndex = 1;
            this.labelSong.Text = "Song";
            // 
            // textBoxSong
            // 
            this.textBoxSong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSong.Location = new System.Drawing.Point(29, 266);
            this.textBoxSong.Name = "textBoxSong";
            this.textBoxSong.Size = new System.Drawing.Size(178, 21);
            this.textBoxSong.TabIndex = 2;
            // 
            // labelArtistName
            // 
            this.labelArtistName.AutoSize = true;
            this.labelArtistName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelArtistName.Location = new System.Drawing.Point(26, 304);
            this.labelArtistName.Name = "labelArtistName";
            this.labelArtistName.Size = new System.Drawing.Size(103, 20);
            this.labelArtistName.TabIndex = 1;
            this.labelArtistName.Text = "Artist Name";
            // 
            // textBoxArtName
            // 
            this.textBoxArtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxArtName.Location = new System.Drawing.Point(29, 332);
            this.textBoxArtName.Name = "textBoxArtName";
            this.textBoxArtName.Size = new System.Drawing.Size(180, 21);
            this.textBoxArtName.TabIndex = 2;
            // 
            // labelSongYear
            // 
            this.labelSongYear.AutoSize = true;
            this.labelSongYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSongYear.Location = new System.Drawing.Point(26, 361);
            this.labelSongYear.Name = "labelSongYear";
            this.labelSongYear.Size = new System.Drawing.Size(94, 20);
            this.labelSongYear.TabIndex = 1;
            this.labelSongYear.Text = "Song Year";
            // 
            // textBoxSongYear
            // 
            this.textBoxSongYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSongYear.Location = new System.Drawing.Point(29, 389);
            this.textBoxSongYear.Name = "textBoxSongYear";
            this.textBoxSongYear.Size = new System.Drawing.Size(180, 21);
            this.textBoxSongYear.TabIndex = 2;
            // 
            // labelAlbumSlide
            // 
            this.labelAlbumSlide.AutoSize = true;
            this.labelAlbumSlide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAlbumSlide.Location = new System.Drawing.Point(26, 427);
            this.labelAlbumSlide.Name = "labelAlbumSlide";
            this.labelAlbumSlide.Size = new System.Drawing.Size(181, 20);
            this.labelAlbumSlide.TabIndex = 1;
            this.labelAlbumSlide.Text = "Upload Album Slide...";
            // 
            // buttonUpload
            // 
            this.buttonUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUpload.Location = new System.Drawing.Point(29, 461);
            this.buttonUpload.Name = "buttonUpload";
            this.buttonUpload.Size = new System.Drawing.Size(83, 32);
            this.buttonUpload.TabIndex = 0;
            this.buttonUpload.Text = "Upload...";
            this.buttonUpload.UseVisualStyleBackColor = true;
            this.buttonUpload.Click += new System.EventHandler(this.buttonUpload_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBoxEdit
            // 
            this.pictureBoxEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxEdit.Location = new System.Drawing.Point(260, 202);
            this.pictureBoxEdit.Name = "pictureBoxEdit";
            this.pictureBoxEdit.Size = new System.Drawing.Size(200, 240);
            this.pictureBoxEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxEdit.TabIndex = 3;
            this.pictureBoxEdit.TabStop = false;
            // 
            // labelSlide
            // 
            this.labelSlide.AutoSize = true;
            this.labelSlide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSlide.Location = new System.Drawing.Point(306, 174);
            this.labelSlide.Name = "labelSlide";
            this.labelSlide.Size = new System.Drawing.Size(96, 20);
            this.labelSlide.TabIndex = 1;
            this.labelSlide.Text = "Song Slide";
            // 
            // pictureBoxAddHead
            // 
            this.pictureBoxAddHead.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAddHead.Image")));
            this.pictureBoxAddHead.Location = new System.Drawing.Point(29, 12);
            this.pictureBoxAddHead.Name = "pictureBoxAddHead";
            this.pictureBoxAddHead.Size = new System.Drawing.Size(422, 99);
            this.pictureBoxAddHead.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAddHead.TabIndex = 4;
            this.pictureBoxAddHead.TabStop = false;
            // 
            // AddEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 505);
            this.Controls.Add(this.pictureBoxAddHead);
            this.Controls.Add(this.pictureBoxEdit);
            this.Controls.Add(this.textBoxSongYear);
            this.Controls.Add(this.labelAlbumSlide);
            this.Controls.Add(this.labelSongYear);
            this.Controls.Add(this.textBoxArtName);
            this.Controls.Add(this.labelArtistName);
            this.Controls.Add(this.textBoxSong);
            this.Controls.Add(this.labelSong);
            this.Controls.Add(this.textBoxAlbum);
            this.Controls.Add(this.labelSlide);
            this.Controls.Add(this.labelAlbum);
            this.Controls.Add(this.textBoxGenres);
            this.Controls.Add(this.labelGenres);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonUpload);
            this.Controls.Add(this.buttonOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddEditForm";
            this.Text = "Add Song";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAddHead)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Label labelGenres;
        private System.Windows.Forms.TextBox textBoxGenres;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelAlbum;
        private System.Windows.Forms.TextBox textBoxAlbum;
        private System.Windows.Forms.Label labelSong;
        private System.Windows.Forms.TextBox textBoxSong;
        private System.Windows.Forms.Label labelArtistName;
        private System.Windows.Forms.TextBox textBoxArtName;
        private System.Windows.Forms.Label labelSongYear;
        private System.Windows.Forms.TextBox textBoxSongYear;
        private System.Windows.Forms.Label labelAlbumSlide;
        private System.Windows.Forms.Button buttonUpload;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBoxEdit;
        private System.Windows.Forms.Label labelSlide;
        private System.Windows.Forms.PictureBox pictureBoxAddHead;
    }
}