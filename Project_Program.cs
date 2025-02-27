//CREATING BANDS

//Band - Linkin Park
Band linkinPark = new Band("Linkin Park");

//CREATING ALBUMS

//Linkin Park Album - From Zero
Album linkinParkAlbum =  new Album("From Zero");

//CREATING SONGS

Song song1 = new Song(linkinPark, "From Zero (Intro)")
{
    Duration = 22,
    Available = true,
};

Song song2 = new Song(linkinPark, "The Emptiness Machine")
{
    Duration = 190, 
    Available = true,
};

Song song3 = new Song(linkinPark, "Cut the Bridge")
{
    Duration = 228, 
    Available = true,
};

Song song4 = new Song(linkinPark, "Heavy is the Crown")
{
    Duration = 167, 
    Available = true,
};


Song song5 = new Song(linkinPark, "Over Each Other")
{
    Duration = 170, 
    Available = true,
};

Song song6 = new Song(linkinPark, "Casualty")
{
    Duration = 140, 
    Available = true,
};

Song song7 = new Song(linkinPark, "Overflow")
{
    Duration = 211, 
    Available = true,
};

Song song8 = new Song(linkinPark, "Two Faced")
{
    Duration = 183, 
    Available = true,
};

Song song9 = new Song(linkinPark, "Stained")
{
    Duration = 185,
    Available = true,
};

Song song10 = new Song(linkinPark, "IGYEIH")
{
    Duration = 209, 
    Available = true,
};

Song song11 = new Song(linkinPark, "Good Things Go")
{
    Duration = 209, 
    Available = true,
};

//ADDING SONGS TO ALBUMS
//From Zero:
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

//ADDING ALBUMS ON BANDS
//Linkin Park:
linkinPark.AddAlbum(linkinParkAlbum);

//DISPLAYING ALBUM SONGS
linkinParkAlbum.DisplayAlbumSongs();

//DISPLAYING BAND DISCOGRAPHY
linkinPark.DisplayDiscography();
