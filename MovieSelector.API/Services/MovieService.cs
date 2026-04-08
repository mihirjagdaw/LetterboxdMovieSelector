using MovieSelector.Shared.Models;

namespace MovieSelector.API.Services
{
    public class MovieService
    {
        private List<Movie> _movies = new List<Movie>();

        public void LoadFromStream (Stream fileStream)
        {
            using var reader = new StreamReader(fileStream);

            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                if (string.IsNullOrWhiteSpace(line))
                {
                    continue;
                }
                
                var values = line.Split(',');

                if (values.Length != 3)
                {
                    _movies.Add(new Movie
                    {
                        Name = values[1],
                        ReleaseYear = values[2]
                    });
                }

            }    
        }

        public Movie? getRandomMovie()
        {
            if(_movies.Count == 0)
            {
                return null;
            }
            int randomIndex = new Random().Next(_movies.Count);
            return _movies[randomIndex];
        }
    }
}
