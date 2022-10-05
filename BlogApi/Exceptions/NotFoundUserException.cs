using System;

namespace BlogApi.Exceptions
{
    public class NotFoundUserException : Exception
    {
        public NotFoundUserException():base("kullanıcı adı veya şifre hatalı")
        {
        }

        public NotFoundUserException(string message) : base(message)
        {
        }

        public NotFoundUserException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
