using System;

namespace ExceptionsApp
{
    public class GradeException : ArgumentOutOfRangeException
    {
        public GradeException(string message) : base(message) { }
    }
}