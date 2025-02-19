Song musica1 = new Song();
musica1.Name = "Getsêmani";
musica1.Artist = "Leonardo Gonçalves";
musica1.Duration = 269;
musica1.Available = true;

Song musica2 = new Song();
musica2.Name = "SPOT!";
musica2.Artist = "ZICO, JENNIE";
musica2.Duration = 167;
musica2.Available = false;

Console.WriteLine(musica1.ShortDescription);
musica1.DisplayTechnicalSheet();
musica2.DisplayTechnicalSheet();

