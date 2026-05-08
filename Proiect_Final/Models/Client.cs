using System;
using System.Collections.Generic;
using System.Text;

namespace Proiect_Final.Models
{
    public class Client
    {
        public int IdClient { get; set; }
        public string NumePrenume { get; set; }
        public DateTime DataNasterii { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
    }
}
