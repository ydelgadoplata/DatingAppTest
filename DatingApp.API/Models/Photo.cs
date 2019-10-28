using System;

namespace DatingApp.API.Models
{
    public class Photo
    {
        public int Id { get; set; }

        public string Url { get; set; }

        public string Description { get; set; }

        public DateTime DateAdded { get; set; }

        public bool IsMain { get; set; }

        public User User { get; set; } // se deben definir estas 2 propiedades para permitir el borrado en cascada, es decir, si se borra al usuario se borran las fotos.

        public int UserId { get; set; }
    }
}