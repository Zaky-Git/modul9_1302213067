using Microsoft.AspNetCore.Mvc;

namespace modul9_1302213067.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MovieController : ControllerBase
    {
        public static List<Movie> MovieList = new List<Movie>
        {
            new Movie ("The Shawshank Redemption","Frank Darabont", "Over the course of several years," +
                "two convicts form a friendship, seeking consolation and, eventually," +
                "redemption through basic compassion.", new List<string>
                {
                    "Tim Robbins", "Morgan Freeman" ,"Bob Gunton", "William Sadler"
                } ),
            new Movie ("The Godfather"," Francis Ford Coppola", "The aging patriarch of an organized " +
                            "crime dynasty in postwar New York City transfers control of his clandestine " +
                            "empire to his reluctant youngest son.", new List<string>
                {
                    "Marlon Brando", "Al Pacino" ,"James Caan" ,"Diane Keaton"
                } ),
            new Movie ("Interstellar","Christopher Nolan", "A team of explorers travel through a " +
                         "wormhole in space in an attempt to ensure humanity's survival", new List<string>
                {
                    "Matthew McConaughey", "Anne Hathaway" ,"Jessica Chastain" ,"Mackenzie Foy"
                } ),
        };

        [HttpGet]

        public IEnumerable<Movie> Get()
        {
            return MovieList;
        }

        [HttpGet("{id}")]

        public Movie Get(int id)
        {
            return MovieList[id];
        }

        [HttpPost]

        public void Post(Movie movie)
        {
            MovieList.Add(movie);
        }

        [HttpDelete("{id}")]

        public void Delete(int id)
        {
            MovieList.RemoveAt(id);
        }
    }
}
