﻿namespace VidlyApp.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public Genre Genre { get; set; }
        public byte GenreId { get; set; }
        public DateTime ReleaseDate { get; set; }
        public DateTime DateAdded { get; set; }
        public byte NumberInStock { get; set; }
    }
}
