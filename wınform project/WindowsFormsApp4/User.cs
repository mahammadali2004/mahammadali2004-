using System;

namespace WindowsFormsApp4
{
    internal class User
    {
        internal string password;
        internal string checkpasword;

        public object Email { get; internal set; }
        public string Fullname { get; internal set; }
        public Func<string> Password { get; internal set; }
        public string Checkpasword { get; internal set; }
    }
}