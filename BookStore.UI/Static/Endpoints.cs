using System;
namespace BookStore.UI.Static
{
    public static class Endpoints
    {
        public static string BaseUrl = "https://localhost:5001/";

        public static string AuthorsEndpoint = $"{BaseUrl}api/authors/";

        public static string BooksEndpoint = $"{BaseUrl}api/books/";

        public static string RegisterEndPoint = $"{BaseUrl}api/users/register/";

        public static string LoginEndPoint = $"{BaseUrl}api/users/login/";



    }
}
