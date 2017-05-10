using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api.Models
{
    public class Account
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Path { get; set; }
    }
}