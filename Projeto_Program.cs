Album linkinParkAlbum =  new Album();
linkinParkAlbum.Name = "From Zero";

Song song1 = new Song();
song1.Name = "From Zero (Intro)";
song1.Artist = "Linkin Park";
song1.Duration = 22;
song1.Available = true;

Song song2 = new Song();
song2.Name = "The Emptiness Machine";
song2.Artist = "Linkin Park";
song2.Duration = 190;
song2.Available = true;

Song song3 = new Song();
song3.Name = "Cut the Bridge";
song3.Artist = "Linkin Park";
song3.Duration = 228;
song3.Available = true;

Song song4 = new Song();
song4.Name = "Heavy is the Crown";
song4.Artist = "Linkin Park";
song4.Duration = 167;
song4.Available = true;

Song song5 = new Song();
song5.Name = "Over Each Other";
song5.Artist = "Linkin Park";
song5.Duration = 170;
song5.Available = true;

Song song6 = new Song();
song6.Name = "Casualty";
song6.Artist = "Linkin Park";
song6.Duration = 140;
song6.Available = true;

Song song7 = new Song();
song7.Name = "Overflow";
song7.Artist = "Linkin Park";
song7.Duration = 211;
song7.Available = true;

Song song8 = new Song();
song8.Name = "Two Faced";
song8.Artist = "Linkin Park";
song8.Duration = 183;
song8.Available = true;

Song song9 = new Song();
song9.Name = "Stained";
song9.Artist = "Linkin Park";
song9.Duration = 185;
song9.Available = true;

Song song10 = new Song();
song10.Name = "IGYEIH";
song10.Artist = "Linkin Park";
song10.Duration = 209;
song10.Available = true;

Song song11 = new Song();
song11.Name = "Good Things Go";
song11.Artist = "Linkin Park";
song11.Duration = 209;
song11.Available = true;

linkinParkAlbum.AddSong(song1);
linkinParkAlbum.AddSong(song2);
linkinParkAlbum.AddSong(song3);
linkinParkAlbum.AddSong(song4);
linkinParkAlbum.AddSong(song5);
linkinParkAlbum.AddSong(song6);
linkinParkAlbum.AddSong(song7);
linkinParkAlbum.AddSong(song8);
linkinParkAlbum.AddSong(song9);
linkinParkAlbum.AddSong(song10);
linkinParkAlbum.AddSong(song11);

linkinParkAlbum.DisplayAlbumSongs();
