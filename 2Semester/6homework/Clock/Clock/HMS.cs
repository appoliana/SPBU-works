using System;

namespace Clock
{
    class HMS
    {
        public HMS (DateTime dateTime)
        {
            if (dateTime.Hour < 10)
            {
                Hour = $"0{dateTime.Hour}";
            }
            else
            {
                Hour = dateTime.Hour.ToString();
            }

            if (dateTime.Minute < 10)
            {
                Minute = $"0{dateTime.Minute}";
            }
            else
            {
                Minute = dateTime.Minute.ToString();
            }

            if (dateTime.Second < 10)
            {
                Secound = $"0{dateTime.Second}";
            }
            else
            {
                Secound = dateTime.Second.ToString();
            }
        }
        public string Hour { get; }
        public string Minute { get; }
        public string Secound { get; }
    }
}
