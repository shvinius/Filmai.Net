using MySql.Data.MySqlClient;

namespace Kino_festivalis.Models
{
    public class FilmContext
    {
        public string  JungtiesNuorodaTekstas { get; set; }

        public FilmContext(string jungtiesNuorodaTekstas)
        {
            JungtiesNuorodaTekstas = jungtiesNuorodaTekstas;
        }

        //  Funkcijos
        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(JungtiesNuorodaTekstas);
        }
        public List<Film> GautiVisusFilmus()
        {
            List<Film> list = new List<Film>();

            using (MySqlConnection jungtis = GetConnection())
            {
                jungtis.Open();
                MySqlCommand sqlUzklausa = new MySqlCommand("SELECT * FROM filmai", jungtis);
                MySqlDataReader skaneris = sqlUzklausa.ExecuteReader();
                using (skaneris)
                {
                    while (skaneris.Read())
                    {
                        list.Add(new Film()
                        {
                            FilmId = skaneris.GetInt32("film_id"),
                            Title = skaneris.GetString("title"),
                            Description = skaneris.GetString("description"),
                            ReleaseYear = skaneris.GetInt32("release_year"),
                            Length = skaneris.GetInt32("length"),
                            Rating = skaneris.GetString("rating")
                        });
                    }
                }
            }
            return list;
        }
    }
}
