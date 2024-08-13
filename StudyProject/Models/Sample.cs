using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudyProject.Models
{
    public class Sample
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        //adding new colomn 17/07/24

        public string Address { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Country { get; set; }
    }
}