using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreTuto.Models
{
   public class Tag
    {
        public int ID { get; set; }
        public string TagName { get; set; }
        public int TagType { get; set; }

        public List<Attributes> Attributes = new List<Attributes>();
    }
}
