using System.Collections.Generic;

namespace MovieLibrary
{
    public class FilmLibrary : IFilmLibrary
    {
        private List<IFilm> _film = new List<IFilm>();

        public void AddFilm(IFilm film)
        {
            _film.Add(film);
        }

        public void RemoveFilm(string title)
        {
            IFilm filmToRemove = _film.Find(f => f.Title == title);

            if (filmToRemove != null)
            {
                _film.Remove(filmToRemove);
            }
        }

        public List<IFilm> GetFilms()
        {
            return _film;
        }

        public List<IFilm> SearchFilms(string query)
        {
            return _film.FindAll(
                a => a.Title.Contains(query) || a.Director.Contains(query)
            );
        }

        public int GetTotalFilmCount()
        {
            return _film.Count;
        }
    }
}
