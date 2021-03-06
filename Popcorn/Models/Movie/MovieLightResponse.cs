﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp.Deserializers;

namespace Popcorn.Models.Movie
{
    public class MovieLightResponse
    {
        [DeserializeAs(Name = "totalMovies")]
        public int TotalMovies { get; set; }

        [DeserializeAs(Name = "movies")]
        public List<MovieLightJson> Movies { get; set; }
    }
}
