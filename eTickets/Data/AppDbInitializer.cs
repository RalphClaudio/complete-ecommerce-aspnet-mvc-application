using eTickets.Models;

namespace eTickets.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                context.Database.EnsureCreated();
                
                //Cinema
                if(!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            Name = "Cinema 1",
                            Logo = "https://images.pexels.com/photos/375885/pexels-photo-375885.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",
                            Description = "First Cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 2",
                            Logo = "https://images.pexels.com/photos/109669/pexels-photo-109669.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",
                            Description = "Second Cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 3",
                            Logo = "https://images.pexels.com/photos/1790556/pexels-photo-1790556.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",
                            Description = "Third Cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 4",
                            Logo = "https://images.pexels.com/photos/3945317/pexels-photo-3945317.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",
                            Description = "Fourth Cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 5",
                            Logo = "https://images.pexels.com/photos/3137890/pexels-photo-3137890.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",
                            Description = "Fifth Cinema"
                        }
                    });
                    context.SaveChanges();
                }

                //Actors
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            FullName = "Actor 1",
                            Bio = "First Actor",
                            ProfilePictureURL = "https://images.pexels.com/photos/6169316/pexels-photo-6169316.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1"
                        },
                        new Actor()
                        {
                            FullName = "Actor 2",
                            Bio = "Second Actor",
                            ProfilePictureURL = "https://images.pexels.com/photos/19431565/pexels-photo-19431565/free-photo-of-young-woman-in-a-dress-holding-a-bottle-of-champagne-and-standing-near-a-christmas-tree.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1"
                        },
                        new Actor()
                        {
                            FullName = "Actor 3",
                            Bio = "Third Actor",
                            ProfilePictureURL = "https://images.pexels.com/photos/1043471/pexels-photo-1043471.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1"
                        },
                        new Actor()
                        {
                            FullName = "Actor 4",
                            Bio = "Fourth Actor",
                            ProfilePictureURL = "https://images.pexels.com/photos/7266015/pexels-photo-7266015.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1"
                        },
                        new Actor()
                        {
                            FullName = "Actor 5",
                            Bio = "Fifth Actor",
                            ProfilePictureURL = "https://images.pexels.com/photos/7266014/pexels-photo-7266014.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1"
                        }
                    });
                    context.SaveChanges();
                }

                //Producers
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            FullName = "Producer 1",
                            Bio = "First Producer",
                            ProfilePictureURL = "https://images.pexels.com/photos/3379934/pexels-photo-3379934.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1"
                        },
                        new Producer()
                        {
                            FullName = "Producer 2",
                            Bio = "Second Producer",
                            ProfilePictureURL = "https://images.pexels.com/photos/1870438/pexels-photo-1870438.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1"
                        },
                        new Producer()
                        {
                            FullName = "Producer 3",
                            Bio = "Third Producer",
                            ProfilePictureURL = "https://images.pexels.com/photos/2773498/pexels-photo-2773498.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1"
                        },
                        new Producer()
                        {
                            FullName = "Producer 4",
                            Bio = "Fourth Producer",
                            ProfilePictureURL = "https://images.pexels.com/photos/2918590/pexels-photo-2918590.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1"
                        },
                        new Producer()
                        {
                            FullName = "Producer 5",
                            Bio = "Fifth Producer",
                            ProfilePictureURL = "https://images.pexels.com/photos/3928528/pexels-photo-3928528.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1"
                        }
                    });
                    context.SaveChanges();
                }

                //Movies
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            Name = "Movie 1",
                            Description = "Horror Movie",
                            Price = 300.00,
                            ImageURL = "https://images.pexels.com/photos/3379934/pexels-photo-3379934.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(7),
                            CinemaId = 4,
                            ProducerId = 4,
                            MovieCategory = Enum.MovieCategory.Horror
                        },
                        new Movie()
                        {
                            Name = "Movie 2",
                            Description = "Comedy Movie",
                            Price = 300.00,
                            ImageURL = "https://images.pexels.com/photos/3379934/pexels-photo-3379934.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(7),
                            CinemaId = 2,
                            ProducerId = 1,
                            MovieCategory = Enum.MovieCategory.Comedy
                        },
                        new Movie()
                        {
                            Name = "Movie 3",
                            Description = "Action Movie",
                            Price = 300.00,
                            ImageURL = "https://images.pexels.com/photos/3379934/pexels-photo-3379934.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(7),
                            CinemaId = 1,
                            ProducerId = 2,
                            MovieCategory = Enum.MovieCategory.Action
                        },
                        new Movie()
                        {
                            Name = "Movie 4",
                            Description = "Documentary Movie",
                            Price = 300.00,
                            ImageURL = "https://images.pexels.com/photos/3379934/pexels-photo-3379934.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(7),
                            CinemaId = 3,
                            ProducerId = 5,
                            MovieCategory = Enum.MovieCategory.Documentary
                        },
                        new Movie()
                        {
                            Name = "Movie 5",
                            Description = "Drama Movie",
                            Price = 300.00,
                            ImageURL = "https://images.pexels.com/photos/3379934/pexels-photo-3379934.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(7),
                            CinemaId = 5,
                            ProducerId = 3,
                            MovieCategory = Enum.MovieCategory.Drama
                        }
                    });
                    context.SaveChanges();
                }

                //Actors & Movies
                if (!context.Actors_Movies.Any())
                {
                    context.Actors_Movies.AddRange(new List<Actor_Movie>()
                    {
                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 1
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 4
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 2
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 3
                        }
                    });
                    context.SaveChanges();
                }

            }
        }
    }
}
