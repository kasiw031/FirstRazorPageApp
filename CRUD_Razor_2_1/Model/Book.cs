using System;
using System.ComponentModel.DataAnnotations;

namespace CRUD_Razor_2_1.Model
{
    public class Book
    {
        public Book()
        {
        }

        [Key]
        public int Id
        {
            get;
            set;
        }

        [Required]
        public string Name
        {
            get;
            set;
        }

        public string ISBN
        {
            get;
            set;
        }

        public string Author
        {
            get;
            set;
        }
    }
}
