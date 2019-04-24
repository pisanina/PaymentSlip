using System;

namespace PaymentSlip
{
    public static class RandomNameforEmployee
    {
        private enum name
        {
            Betty, Carol, Donna, Harry, Jack, Jacob, Olivier
        }

        private enum surname
        {
            Brown, Davis, Johnson, Miller, Wilson
        }

        static public string GenerateFirstName()
        {
            Random random = new Random();
            name firstName = (name)random.Next(0, 7);
            return firstName.ToString();
        }

        static public string GenerateLastName()
        {
            Random random = new Random();
            surname lastName = (surname)random.Next(0, 5);
            return lastName.ToString();
        }
    }
}