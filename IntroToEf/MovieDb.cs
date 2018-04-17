using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace IntroToEf
{
    class MovieDb : DbContext
    {
        /* TODO: Get the connection string string in App.config working
         * - It doesn't like my provider, how do we get a valid provider?
         */
        public MovieDb()
            : base(@"Server=localhost\SQLEXPRESS;Database=MoviesDbEf;Trusted_Connection=True;")
        //: base("MoviesDbEf")
        {
        }

        public DbSet<Movie> Movies { get; set; }
    }
}
