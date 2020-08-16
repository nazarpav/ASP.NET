using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _23_07_2020.DataBase
{
    public class Image
    {
        public int Id { get; set; }
        public string Path { get; set; }
        public string Name { get; set; }
    }

}