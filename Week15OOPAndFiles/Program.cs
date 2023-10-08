List<Movie> myMovies = new List<Movie>();


string[] data = GetDataFromMyFile(); //string[] data = GetDataFromMyFile(); selle saab kustutada kui kasutada alumist kommentaari osa
//ReadDataFromArray(data); //ReadDataFromArray(GetDataFromMyFile());

foreach (string line in data)
{
    string[] tempArray = line.Split(new char[] {';'}, StringSplitOptions.RemoveEmptyEntries);
    //Console.WriteLine("Temp array");
    //ReadDataFromArray(tempArray);
    Movie newMovie = new Movie(tempArray[0], tempArray[2]);
    myMovies.Add(newMovie);
}

foreach(Movie movie in myMovies)
{
    Console.WriteLine($"One of my favorite movie {movie.Titel} was realeased {movie.Year}.");
}

static string[] GetDataFromMyFile()
{
    string filePath = @"C:\Massiivid\movies.txt";
    //string[] dataFromFile = File.ReadAllLines(filePath);

    return File.ReadAllLines(filePath);
}

static void ReadDataFromArray(string[] someArray)
{
    foreach (string line in someArray)
    {
        Console.WriteLine(line);
    }
}

class Movie
{
    string titel;
    string year;

    public string Titel
    {
        get { return titel; }
    }

    public string Year
    {
        get { return year; }
    }

    public Movie(string _titel, string _year)
    {
        titel = _titel;
        year = _year;
    }   
}