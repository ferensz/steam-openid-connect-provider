using System;

namespace SteamOpenIdConnectProvider.NameParser
{
    public class Name : IComparable<Name>
    {
        public string Salutation { get; set; }

        public string FirstName { get; set; }

        public string MiddleInitials { get; set; }

        public string LastName { get; set; }

        public string Suffix { get; set; }

        public int CompareTo(Name other)
        {
            // Compare last names.
            var diff = String.Compare(LastName.ToLower(), other.LastName.ToLower(), StringComparison.Ordinal);
            if (diff != 0) return diff;

            // Compare first names.
            diff = String.Compare(FirstName.ToLower(), other.FirstName.ToLower(), StringComparison.Ordinal);
            if (diff != 0) return diff;

            // Compare Middle initials
            diff = String.Compare(MiddleInitials.ToLower(), other.MiddleInitials.ToLower(), StringComparison.Ordinal);
            if (diff != 0) return diff;

            return 0;
        }
    }
}