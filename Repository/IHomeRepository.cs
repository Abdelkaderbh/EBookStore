﻿using EBookStore.Models;

namespace EBookStore.Repository
{
    
        public interface IHomeRepository
        {
            Task<IEnumerable<Book>> GetBooks(string sTerm = "", int genreId = 0);
            Task<IEnumerable<Genre>> Genres();
        }
    
}