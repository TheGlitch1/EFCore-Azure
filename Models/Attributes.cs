using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreTuto.Models
{
    public class Attributes
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Type { get; set; }

        public Tag Tag { get; set; }
    }
}
