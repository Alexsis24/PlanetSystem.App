namespace PlanetSystem.Services
{
    internal static class PlanetsService
    {
        private static List<Planet> planets = new()
        {
            new()
            {
                Name = "  Mercury",
                Subtitle = "   The smallest planet",
                HeroImage = "mercury.png",
                Description = "Mercury is the smallest planet in the Solar System and the closest to the Sun. Its orbit around the Sun takes 87.97 Earth days, the shortest of all the Sun's planets.",
                AccentColorStart = Color.FromArgb("#353535"),
                AccentColorEnd = Color.FromArgb("#8d9098"),
                Images = new()
                {
                    "https://cdn.theatlantic.com/thumbor/D15rQggf6357X1-u6VpTD2N1yQE=/0x27:1041x613/976x549/media/img/mt/2017/04/MercuryImage/original.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/73_carousel_mercury_2.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/75_mercury_carousel_1.jpg",
                }
            },
            new()
            {
                Name = "  Venus",
                Subtitle = "   The pressure cooker",
                HeroImage = "venus.png",
                Description = "It’s one of the four inner, terrestrial (or rocky) planets, and it’s often called Earth’s twin because it’s similar in size and density. These are not identical twins, however – there are radical differences between the two worlds.",
                AccentColorStart = Color.FromArgb("#a6393b"),
                AccentColorEnd = Color.FromArgb("#d17f21"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/143_Venus-800x600.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/147_Hubble_Venus_Clouds-800x600.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/146_venus_carousel_3.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/144_PIA00485_Venus_Caldera-800.jpg"
                }
            },
            new()
            {
                Name = "  Earth",
                Subtitle = "   The cradle of life",
                HeroImage = "earth.png",
                Description = "Earth—our home planet—is the only place we know of so far that’s inhabited by living things. It's also the only planet in our solar system with liquid water on the surface.",
                AccentColorStart = Color.FromArgb("#0e3d68"),
                AccentColorEnd = Color.FromArgb("#2e97c7"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/68_epicearthmoonstill_800.png",
                    "https://solarsystem.nasa.gov/system/feature_items/images/69_earth_carousel_3.jpg",
                    "https://images.newscientist.com/wp-content/uploads/2019/09/09162708/iss048-e-2035_lrg.jpg?width=778"
                }
            },
            new()
            {
                Name = "  Mars",
                Subtitle = "   The iron planet",
                HeroImage = "mars.png",
                Description = "Mars is a dusty, cold, desert world with a very thin atmosphere. There is strong evidence Mars was – billions of years ago – wetter and warmer, with a thicker atmosphere.",
                AccentColorStart = Color.FromArgb("#a230356"),
                AccentColorEnd = Color.FromArgb("#eb3333"),
                Images = new()
                {
                    "https://researchfdi.com/wp-content/uploads/2021/10/8944_1-PIA24546-1280.jpeg",
                    "https://www.worldatlas.com/r/w1300-q80/upload/bb/c3/32/shutterstock-1041249343.jpg",
                    "https://www.openaccessgovernment.org/wp-content/uploads/2021/04/dreamstime_xxl_121672573-scaled.jpg"
                }
            },
            new()
            {
                Name = "  Jupiter",
                Subtitle = "   The gas giant",
                HeroImage = "jupiter.png",
                Description = "Jupiter is more than twice as massive than the other planets of our solar system combined. The giant planet's Great Red Spot is a centuries-old storm bigger than Earth.",
                AccentColorStart = Color.FromArgb("#9d4a40"),
                AccentColorEnd = Color.FromArgb("#cd8026"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/11_Full_Jupiter-800.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/10_Jupiter_Io_Juno-800.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/13_PIA24237_Jupiter_Cyclones-800.jpg"
                }
            },
            new()
            {
                Name = "  Saturn",
                Subtitle = "   The ring planet",
                HeroImage = "saturn.png",
                Description = "Adorned with a dazzling, complex system of icy rings, Saturn is unique in our solar system. The other giant planets have rings, but none are as spectacular as Saturn's.",
                AccentColorStart = Color.FromArgb("#996237"),
                AccentColorEnd = Color.FromArgb("#c6502f"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/151_saturn_carousel_1.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/152_saturn_carousel_2.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/155_saturn_carousel_5.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/153_saturn_carousel_3.jpg"
                }
            },
            new()
            {
                Name = "  Uranus",
                Subtitle = "   The ice giant",
                HeroImage = "uranus.png",
                Description = "Uranus—seventh planet from the Sun—rotates at a nearly 90-degree angle from the plane of its orbit. This unique tilt makes Uranus appear to spin on its side.",
                AccentColorStart = Color.FromArgb("#9d4a40"),
                AccentColorEnd = Color.FromArgb("#996237"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/88_carousel_uranus.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/89_uranus_carousel_1.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/88_carousel_uranus.jpg"
                }
            },
            new()
            {
                Name = "  Neptune",
                Subtitle = "   The god of sea",
                HeroImage = "neptune.png",
                Description = "Dark, cold, and whipped by supersonic winds is the ice giant Neptune. Neptune is the only planet in our solar system not visible to the naked eye.",
                AccentColorStart = Color.FromArgb("#0c293d"),
                AccentColorEnd = Color.FromArgb("#26abe0"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/82_carousel_neptune_1.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/86_carousel_neptune_5.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/84_neptune_carousel_2.jpg"
                }
            },

            /*Dwarf planets*/
            new()
            {
                Name = "  Pluto",
                Subtitle = "   The ex planet",
                HeroImage = "pluto.png",
                Description = "Pluto is a complex world of ice mountains and frozen plains. Once considered the ninth planet, Pluto is the best known of a new class of worlds called dwarf planets.",
                AccentColorStart = Color.FromArgb("#9d4a40"),
                AccentColorEnd = Color.FromArgb("#996237"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/rails/active_storage/blobs/eyJfcmFpbHMiOnsibWVzc2FnZSI6IkJBaHBBc29EIiwiZXhwIjpudWxsLCJwdXIiOiJibG9iX2lkIn19--1ef352a5c476ac5421a627a2e228e5acf1fc6ed3/PIA19857.jpg",
                    "https://solarsystem.nasa.gov/rails/active_storage/blobs/eyJfcmFpbHMiOnsibWVzc2FnZSI6IkJBaHBBckFEIiwiZXhwIjpudWxsLCJwdXIiOiJibG9iX2lkIn19--1120618ad30f3328931c4d666bd1087ae9998d7b/PIA20213_1200w.jpg",
                    "https://solarsystem.nasa.gov/rails/active_storage/blobs/eyJfcmFpbHMiOnsibWVzc2FnZSI6IkJBaHBBczhFIiwiZXhwIjpudWxsLCJwdXIiOiJibG9iX2lkIn19--26a2b6f6e25196e5f47858d8f1865fb9b520c049/nh-apluto-mountains-plains-9-17-15_0.jpg"
                }
            },
            new()
            {
                Name = "  Ceres",
                Subtitle = "   The hidden ice",
                HeroImage = "ceres.png",
                Description = "Ceres makes up almost a third of the asteroid belt's total mass, but it is still far smaller than Earth's Moon. Ceres is heavily cratered with large amounts of ice underground.",
                AccentColorStart = Color.FromArgb("#787d9c"),
                AccentColorEnd = Color.FromArgb("#565a70"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/rails/active_storage/blobs/eyJfcmFpbHMiOnsibWVzc2FnZSI6IkJBaHBBaTRGIiwiZXhwIjpudWxsLCJwdXIiOiJibG9iX2lkIn19--2f9d6d3f4ecc4a346044d5ac4c33fc48b76cef67/PIA20182.jpg",
                    "https://solarsystem.nasa.gov/rails/active_storage/blobs/eyJfcmFpbHMiOnsibWVzc2FnZSI6IkJBaHBBbzREIiwiZXhwIjpudWxsLCJwdXIiOiJibG9iX2lkIn19--ccf156d2995dee0d7b2563aecdfbb0022b3d11bd/PIA20358.jpg",
                    "https://solarsystem.nasa.gov/rails/active_storage/blobs/eyJfcmFpbHMiOnsibWVzc2FnZSI6IkJBaHBBb3dEIiwiZXhwIjpudWxsLCJwdXIiOiJibG9iX2lkIn19--89dc924ceb1b7c67cf6049cf202734ff747a470e/PIA21079.jpg"
                }
            },
            new()
            {
                Name = "  Eris",
                Subtitle = "   The biggie small",
                HeroImage = "eris.png",
                Description = "Eris is one of the largest known dwarf planets in our solar system. It's about the same size as Pluto but is three times farther from the Sun.",
                AccentColorStart = Color.FromArgb("#898c8c"),
                AccentColorEnd = Color.FromArgb("#768691"),
                Images = new()
                {
                    "https://cdn.mos.cms.futurecdn.net/ufTfK2rbpQXZBjt2ZPsm57-1200-80.jpg.webp",
                    "https://www.solarsystemscope.com/spacepedia/images/handbook/renders/eris.png"
                }
            },
            new()
            {
                Name = " Makemake",
                Subtitle = "   The reddish ice",
                HeroImage = "makemake.png",
                Description = "Makemake is located in the Kuiper Belt, a donut-shaped region of icy bodies beyond the orbit of Neptune.",
                AccentColorStart = Color.FromArgb("#c6502f"),
                AccentColorEnd = Color.FromArgb("#996237"),
                Images = new()
                {
                    "https://cdn.mos.cms.futurecdn.net/8QBGiy9BhmttKdGeAAZpn8-1200-80.jpg.webp",
                    "https://www.solarsystemscope.com/spacepedia/images/handbook/renders/makemake.png"
                }
            },
            new()
            {
                Name = "  Haumea",
                Subtitle = "   The space egg",
                HeroImage = "haumea.png",
                Description = "Haumea is roughly the same size as Pluto. It is one of the fastest rotating large objects in our solar system. The fast spin distorts Haumea's shape, making this dwarf planet look like a football.",
                AccentColorStart = Color.FromArgb("#d1d7e6"),
                AccentColorEnd = Color.FromArgb("#828599"),
                Images = new()
                {
                    "https://www.solarsystemscope.com/spacepedia/images/handbook/renders/haumea.png",
                    "https://solarsystem.nasa.gov/rails/active_storage/blobs/eyJfcmFpbHMiOnsibWVzc2FnZSI6IkJBaHBBcEJ5IiwiZXhwIjpudWxsLCJwdXIiOiJibG9iX2lkIn19--cbc291b6d9659fbccebd845aae501d9f81f89e3c/haumea_480x320.jpg"
                }
            },
        };

        public static List<Planet> GetFeaturedPlanets()
        {
            var random = new Random();
            var randomizedPlanets = planets.OrderBy(item => random.Next());

            return randomizedPlanets.Take(2).ToList();
        }

        public static List<Planet> GetAllPlanets()
            => planets;
    }
}
