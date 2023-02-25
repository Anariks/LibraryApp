namespace Contracts.Interfaces;
using System.Collections.Generic;
using Contracts.ApiDTO;
using Contracts.Database;

public interface ILibRepository
{
    Task<List<Book>> GetAllBooks(string orderParam);
    Task<List<Book>> GetRecommendedBooks(string filterParam);
    Task<Book> GetById(int id);
    Task DelById(int id);
    Task<Book> SaveOrUpdateBook(Book book);
    Task<Review> SaveReview(Review review);
    Task SaveRate(Rating rating);
}
