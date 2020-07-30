using System;
using System.Net.Http;
using Blazored.LocalStorage;
using BookStore.UI.Contracts;
using BookStore.UI.Models;

namespace BookStore.UI.Services
{
    public class AuthorRepository : BaseRepository<Author>, IAuthorRepository
    {
        private readonly IHttpClientFactory _client;
        private readonly ILocalStorageService _localStorage;

        public AuthorRepository(IHttpClientFactory client,
            ILocalStorageService localStorage) : base(client, localStorage)
        {
            _client = client;
            _localStorage = localStorage;
        }
    }
}
