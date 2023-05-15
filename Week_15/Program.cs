
List<Movie> myMovies = new List<Movie>();

string[] data = GetDataFromFile();
//ReadDataFromArray(data);

foreach (string line in data)
{
    string[] tempArray = line.Split(new char[] { ';' } StringSplitOption.RemoveEmptyEntries);
    Movie newMovie = new Movie (tempArray)[0], tempArray[2]);
}

static string[] GetDataFromMyFile()
{
    string filePath = @"/Users/michael/Desktop/RKE129/VisualStudio/Data/movies.txt";
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
    string title; //fields
    string year;

    public string Title
    {
        get { return title; }
    }

    public string Year
    {
        get { return year; }
    }

    public Movie(string _title, string _year)
    {
        title = _title;
        year = _year;
    }
}