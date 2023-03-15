namespace UnitTestDemo_Calculator.Exceptions
{
    internal class BlackHoleException : Exception
    {
        public BlackHoleException(string message = "What have you done?") : base(message)
        {
        }
    }
}
