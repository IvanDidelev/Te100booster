namespace WinFormsApplication.Exceptions
{
    public class AuthException : Exception
    {
        public AuthException() : base("Непрвильный логин или пароль")
        {
        }
    }
}
