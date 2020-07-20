namespace _23_07_2020
{
    using _23_07_2020.DataBase;
    using System;
    using System.Data.Entity;
    using System.Drawing;
    using System.Linq;

    public class DBGalleryContext : DbContext
    {
        public DBGalleryContext() : base("name=GalleryDB")
        {
            Database.SetInitializer(new GalleryDBInitializer());
        }
        public virtual DbSet<_23_07_2020.DataBase.Image> Images { get; set; }
    }
}