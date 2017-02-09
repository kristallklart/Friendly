namespace Friendly.Model
{
    namespace Model
    {
        class Location
        {
            private string city;
            private string country;

            public string City
            {
                get
                {
                    return city;
                }

                set
                {
                    city = value;
                }
            }

            public string Country
            {
                get
                {
                    return country;
                }

                set
                {
                    country = value;
                }
            }
        }
    }
}
