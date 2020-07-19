namespace _23_07_2020
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Images : DbContext
    {
        public Images()
            : base("name=Images")
        {
        }
        public virtual DbSet<Image> Images_ { get; set; }
    }

    public class Image
    {
        public int Id { get; set; }
        public string Path { get; set; }
        public string Name { get; set; }
    }
}