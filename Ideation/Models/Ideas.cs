using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ideation.Models
{
    public class Ideas
    {
        public int Id { get; set; }

        public string Idea { get; set; }

        public Meeting Meeting { get; set; }

        public User Owner { get; set; }

    }
}