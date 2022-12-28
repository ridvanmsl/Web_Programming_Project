namespace WebAssignment.Models
{
    public static class PopularMoviesRepo
    {
        private static List<movies> _popmov = new List<movies>();

        static PopularMoviesRepo()
        {
            _popmov = new List<movies>()
            {
                new movies(){name="Doctor Strange",duration=126,lilmovimg="https://m.media-amazon.com/images/M/MV5BNWM0ZGJlMzMtZmYwMi00NzI3LTgzMzMtNjMzNjliNDRmZmFlXkEyXkFqcGdeQXVyMTM1MTE1NDMx._V1_FMjpg_UX1000_.jpg",category="Action", id=1},
                new movies(){name="The Northman",duration=137,lilmovimg="https://m.media-amazon.com/images/M/MV5BMzVlMmY2NTctODgwOC00NDMzLWEzMWYtM2RiYmIyNTNhMTI0XkEyXkFqcGdeQXVyNTAzNzgwNTg@._V1_.jpg",category="Adventure",id=2},
                new movies(){name="Lord Of The Rings",duration=178,lilmovimg="https://m.media-amazon.com/images/M/MV5BZGMxZTdjZmYtMmE2Ni00ZTdkLWI5NTgtNjlmMjBiNzU2MmI5XkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_.jpg",category="Adventure",id=3},
                new movies(){name="The Godfather",duration=175,lilmovimg="https://m.media-amazon.com/images/M/MV5BM2MyNjYxNmUtYTAwNi00MTYxLWJmNWYtYzZlODY3ZTk3OTFlXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_.jpg",category="Crime",id=4},
                new movies(){name="Pulp Fiction",duration=154,lilmovimg="https://m.media-amazon.com/images/I/71mlgE7nUdL._AC_UF1000,1000_QL80_.jpg",category="Comedy", id=5},
                new movies(){name="The Batman",duration=176,lilmovimg="https://m.media-amazon.com/images/M/MV5BMDdmMTBiNTYtMDIzNi00NGVlLWIzMDYtZTk3MTQ3NGQxZGEwXkEyXkFqcGdeQXVyMzMwOTU5MDk@._V1_FMjpg_UX1000_.jpg",category="Action",id=6},
                new movies(){name="Dune",duration=155,lilmovimg="https://imageio.forbes.com/specials-images/imageserve/61116cea2313e8bae55a536a/-Dune-/0x0.jpg?format=jpg&width=960",category="Adventure", id=7},
                new movies(){name="Interstellar",duration=169,lilmovimg="https://www.arthipo.com/image/cache/catalog/poster/movie/1-758/pfilm716-interstellar_a074ce1f-movie-film-posteri-1000x1000.jpg",category="Science Fiction",id=8},
                new movies(){name="Fight Club",duration=139,lilmovimg="https://img.fruugo.com/product/0/08/14290080_max.jpg",category="Thriller",id=9},
                new movies(){name="The Shawshank Redemption",duration=144,lilmovimg="https://m.media-amazon.com/images/M/MV5BMDFkYTc0MGEtZmNhMC00ZDIzLWFmNTEtODM1ZmRlYWMwMWFmXkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_FMjpg_UX1000_.jpg",category="Thriller",id=10},
            };
        }
        public static List<movies> Popmov
        {
            get
            {
                return _popmov;
            }
        }
    }
}
