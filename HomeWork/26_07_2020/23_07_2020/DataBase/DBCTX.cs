namespace _23_07_2020
{
    using _23_07_2020.DataBase;
    using System;
    using System.Data.Entity;
    using System.Drawing;
    using System.Linq;

    public class DBCTX : DbContext
    {
        static DBCTX()
        {
            //Database.SetInitializer(new DBInitializer());
        }
        public DBCTX() : base("name=GalleryDB")
        {
        }
        public virtual DbSet<_23_07_2020.DataBase.Image> Images { get; set; }
        public virtual DbSet<_23_07_2020.DataBase.User> Users { get; set; }
    }
}