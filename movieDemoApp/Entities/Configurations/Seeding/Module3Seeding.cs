﻿using Microsoft.EntityFrameworkCore;
using movieDemoApp.Entities;
using movieDemoApp.Enums;
using NetTopologySuite;
using NetTopologySuite.Geometries;

namespace EFCoreMovies.Entities.Seeding
{
    public static class Module3Seeding
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            var action = new Genre { Id = 1, Name = "Action" };
            var animation = new Genre { Id = 2, Name = "Animation" };
            var comedy = new Genre { Id = 3, Name = "Comedy" };
            var scienceFiction = new Genre { Id = 4, Name = "Science Fiction" };
            var drama = new Genre { Id = 5, Name = "Drama" };

            modelBuilder.Entity<Genre>().HasData(action, animation, comedy, scienceFiction, drama);

            var tomHolland = new Actor() { Id = 1, Name = "Tom Holland", DOB = new DateTime(1996, 6, 1), Biograpy = "Thomas Stanley Holland (born 1 June 1996) is an English actor. He is recipient of several accolades, including the 2017 BAFTA Rising Star Award. Holland began his acting career as a child actor on the West End stage in Billy Elliot the Musical at the Victoria Palace Theatre in 2008, playing a supporting part" };
            var samuelJackson = new Actor() { Id = 2, Name = "Samuel L. Jackson", DOB = new DateTime(1948, 12, 21), Biograpy = "Samuel Leroy Jackson (born December 21, 1948) is an American actor and producer. One of the most widely recognized actors of his generation, the films in which he has appeared have collectively grossed over $27 billion worldwide, making him the highest-grossing actor of all time (excluding cameo appearances and voice roles)." };
            var robertDowney = new Actor() { Id = 3, Name = "Robert Downey Jr.", DOB = new DateTime(1965, 4, 4), Biograpy = "Robert John Downey Jr. (born April 4, 1965) is an American actor and producer. His career has been characterized by critical and popular success in his youth, followed by a period of substance abuse and legal troubles, before a resurgence of commercial success later in his career." };
            var chrisEvans = new Actor() { Id = 4, Name = "Chris Evans", DOB = new DateTime(1981, 06, 13) };
            var laRoca = new Actor() { Id = 5, Name = "Dwayne Johnson", DOB = new DateTime(1972, 5, 2) };
            var auliCravalho = new Actor() { Id = 6, Name = "Auli'i Cravalho", DOB = new DateTime(2000, 11, 22) };
            var scarlettJohansson = new Actor() { Id = 7, Name = "Scarlett Johansson", DOB = new DateTime(1984, 11, 22) };
            var keanuReeves = new Actor() { Id = 8, Name = "Keanu Reeves", DOB = new DateTime(1964, 9, 2) };

            modelBuilder.Entity<Actor>().HasData(tomHolland, samuelJackson,
                            robertDowney, chrisEvans, laRoca, auliCravalho, scarlettJohansson, keanuReeves);

            var geometryFactory = NtsGeometryServices.Instance.CreateGeometryFactory(srid: 4326);

            var agora = new Cinema() { Id = 1, Name = "Agora Mall", location = geometryFactory.CreatePoint(new Coordinate(-69.9388777, 18.4839233)) };
            var sambil = new Cinema() { Id = 2, Name = "Sambil", location = geometryFactory.CreatePoint(new Coordinate(-69.911582, 18.482455)) };
            var megacentro = new Cinema() { Id = 3, Name = "Megacentro", location = geometryFactory.CreatePoint(new Coordinate(-69.856309, 18.506662)) };
            var acropolis = new Cinema() { Id = 4, Name = "Acropolis", location = geometryFactory.CreatePoint(new Coordinate(-69.939248, 18.469649)) };

            modelBuilder.Entity<Cinema>().HasData(agora, sambil, megacentro, acropolis);

            var agorraOffer = new CinemaOffer { Id = 1, CinemaId = agora.Id, Begin = new DateTime(2022, 2, 22), End = new DateTime(2022, 4, 22), DiscountPercentage = 10 };
            var acropolisOffer = new CinemaOffer { Id = 2, CinemaId = acropolis.Id, Begin = new DateTime(2022, 2, 15), End = new DateTime(2022, 2, 22), DiscountPercentage = 15 };
            modelBuilder.Entity<CinemaOffer>().HasData(acropolisOffer, agorraOffer);

            var cinemaHall2DAgora = new CinemaHall()
            {
                Id = 1,
                cinemaid = agora.Id,
                cost = 220,
                CinemaHallTypes = CinemaHallType.twoDimentions
            };
            var cinemaHall3DAgora = new CinemaHall()
            {
                Id = 2,
                cinemaid = agora.Id,
                cost = 320,
                CinemaHallTypes = CinemaHallType.threeDimentions
            };

            var cinemaHall2DSambil = new CinemaHall()
            {
                Id = 3,
                cinemaid = sambil.Id,
                cost = 200,
                CinemaHallTypes = CinemaHallType.twoDimentions
            };
            var cinemaHall3DSambil = new CinemaHall()
            {
                Id = 4,
                cinemaid = sambil.Id,
                cost = 290,
                CinemaHallTypes = CinemaHallType.threeDimentions
            };


            var cinemaHall2DMegacentro = new CinemaHall()
            {
                Id = 5,
                cinemaid = megacentro.Id,
                cost = 250,
                CinemaHallTypes = CinemaHallType.twoDimentions
            };
            var cinemaHall3DMegacentro = new CinemaHall()
            {
                Id = 6,
                cinemaid = megacentro.Id,
                cost = 330,
                CinemaHallTypes = CinemaHallType.threeDimentions
            };
            var cinemaHallCXCMegacentro = new CinemaHall()
            {
                Id = 7,
                cinemaid = megacentro.Id,
                cost = 450,
                CinemaHallTypes = CinemaHallType.CXC
            };

            var cinemaHall2DAcropolis = new CinemaHall()
            {
                Id = 8,
                cinemaid = acropolis.Id,
                cost = 250,
                CinemaHallTypes = CinemaHallType.twoDimentions
            };

            modelBuilder.Entity<CinemaHall>().HasData(cinemaHall2DMegacentro, cinemaHall3DMegacentro, cinemaHallCXCMegacentro, cinemaHall2DAcropolis, cinemaHall2DAgora, cinemaHall3DAgora, cinemaHall2DSambil, cinemaHall3DSambil);

            var avengers = new Movie()
            {
                Id = 1,
                Title = "Avengers",
                InCinemas = false,
                RelaseDate = new DateTime(2012, 4, 11),
                PosterUrl = "https://upload.wikimedia.org/wikipedia/en/8/8a/The_Avengers_%282012_film%29_poster.jpg",
            };

            var entityCinemaHallMovie = "CinemaHallMovie";
            var cinemaHallsId = "cinemaHallsId";
            var moviesId = "cinemasId";

            var entityGenreMovie = "GenreMovie";
            var genresId = "genresId";

            modelBuilder.Entity(entityGenreMovie).HasData(
                new Dictionary<string, object>
                {
                    [genresId] = action.Id,
                    [moviesId] = avengers.Id
                },
                 new Dictionary<string, object>
                 {
                     [genresId] = scienceFiction.Id,
                     [moviesId] = avengers.Id
                 }
                );

            var coco = new Movie()
            {
                Id = 2,
                Title = "Coco",
                InCinemas = false,
                RelaseDate = new DateTime(2017, 11, 22),
                PosterUrl = "https://upload.wikimedia.org/wikipedia/en/9/98/Coco_%282017_film%29_poster.jpg"
            };

            modelBuilder.Entity(entityGenreMovie).HasData(
               new Dictionary<string, object> { [genresId] = animation.Id, [moviesId] = coco.Id }
           );

            var noWayHome = new Movie()
            {
                Id = 3,
                Title = "Spider-Man: No way home",
                InCinemas = false,
                RelaseDate = new DateTime(2022, 12, 17),
                PosterUrl = "https://upload.wikimedia.org/wikipedia/en/0/00/Spider-Man_No_Way_Home_poster.jpg"
            };

            modelBuilder.Entity(entityGenreMovie).HasData(
               new Dictionary<string, object> { [genresId] = scienceFiction.Id, [moviesId] = noWayHome.Id },
               new Dictionary<string, object> { [genresId] = action.Id, [moviesId] = noWayHome.Id },
               new Dictionary<string, object> { [genresId] = comedy.Id, [moviesId] = noWayHome.Id }
           );

            var farFromHome = new Movie()
            {
                Id = 4,
                Title = "Spider-Man: Far From Home",
                InCinemas = false,
                RelaseDate = new DateTime(2019, 7, 2),
                PosterUrl = "https://upload.wikimedia.org/wikipedia/en/0/00/Spider-Man_No_Way_Home_poster.jpg"
            };

            modelBuilder.Entity(entityGenreMovie).HasData(
               new Dictionary<string, object> { [genresId] = scienceFiction.Id, [moviesId] = farFromHome.Id },
               new Dictionary<string, object> { [genresId] = action.Id, [moviesId] = farFromHome.Id },
               new Dictionary<string, object> { [genresId] = comedy.Id, [moviesId] = farFromHome.Id }
           );

            var theMatrixResurrections = new Movie()
            {
                Id = 5,
                Title = "The Matrix Resurrections",
                InCinemas = true,
                RelaseDate = new DateTime(2023, 1, 1),
                PosterUrl = "https://upload.wikimedia.org/wikipedia/en/5/50/The_Matrix_Resurrections.jpg",
            };

            modelBuilder.Entity(entityGenreMovie).HasData(
              new Dictionary<string, object> { [genresId] = scienceFiction.Id, [moviesId] = theMatrixResurrections.Id },
              new Dictionary<string, object> { [genresId] = action.Id, [moviesId] = theMatrixResurrections.Id },
              new Dictionary<string, object> { [genresId] = drama.Id, [moviesId] = theMatrixResurrections.Id }
          );

            modelBuilder.Entity(entityCinemaHallMovie).HasData(
             new Dictionary<string, object> { [cinemaHallsId] = cinemaHall2DSambil.Id, [moviesId] = theMatrixResurrections.Id },
             new Dictionary<string, object> { [cinemaHallsId] = cinemaHall3DSambil.Id, [moviesId] = theMatrixResurrections.Id },
             new Dictionary<string, object> { [cinemaHallsId] = cinemaHall2DAgora.Id, [moviesId] = theMatrixResurrections.Id },
             new Dictionary<string, object> { [cinemaHallsId] = cinemaHall3DAgora.Id, [moviesId] = theMatrixResurrections.Id },
             new Dictionary<string, object> { [cinemaHallsId] = cinemaHall2DMegacentro.Id, [moviesId] = theMatrixResurrections.Id },
             new Dictionary<string, object> { [cinemaHallsId] = cinemaHall3DMegacentro.Id, [moviesId] = theMatrixResurrections.Id },
             new Dictionary<string, object> { [cinemaHallsId] = cinemaHallCXCMegacentro.Id, [moviesId] = theMatrixResurrections.Id }
            );

            var keanuReevesMatrix = new MovieActor
            {
                actorid = keanuReeves.Id,
                movieid = theMatrixResurrections.Id,
                order = 1,
                character = "Neo"
            };

            var avengersChrisEvans = new MovieActor
            {
                actorid = chrisEvans.Id,
                movieid = avengers.Id,
                order = 1,
                character = "Capitán América"
            };

            var avengersRobertDowney = new MovieActor
            {
                actorid = robertDowney.Id,
                movieid = avengers.Id,
                order = 2,
                character = "Iron Man"
            };

            var avengersScarlettJohansson = new MovieActor
            {
                actorid = scarlettJohansson.Id,
                movieid = avengers.Id,
                order = 3,
                character = "Black Widow"
            };

            var tomHollandFFH = new MovieActor
            {
                actorid = tomHolland.Id,
                movieid = farFromHome.Id,
                order = 1,
                character = "Peter Parker"
            };

            var tomHollandNWH = new MovieActor
            {
                actorid = tomHolland.Id,
                movieid = noWayHome.Id,
                order = 1,
                character = "Peter Parker"
            };

            var samuelJacksonFFH = new MovieActor
            {
                actorid = samuelJackson.Id,
                movieid = farFromHome.Id,
                order = 2,
                character = "Samuel L. Jackson"
            };

            modelBuilder.Entity<Movie>().HasData(avengers, coco, noWayHome, farFromHome, theMatrixResurrections);

            modelBuilder.Entity<MovieActor>().HasData(samuelJacksonFFH, tomHollandFFH,
                tomHollandNWH, avengersRobertDowney, avengersScarlettJohansson,
                avengersChrisEvans, keanuReevesMatrix);
        }
    }
}