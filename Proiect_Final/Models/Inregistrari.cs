using System;
using System.Collections.Generic;
using System.Text;

namespace Proiect_Final.Models
{
    public class Inregistrari
    {
        public int Id { get; set; }
        public int IdClient { get; set; }
        public int IdAbonament { get; set; }
        public DateTime DataStart { get; set; }
        public DateTime DataFinish { get; set; }
    }
}
