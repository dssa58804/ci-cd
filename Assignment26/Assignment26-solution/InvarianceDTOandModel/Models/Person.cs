namespace ValidateTheNameModelBinding.Models
{
    public class Person
    {
        private readonly FirstName firstName;
        private readonly LastName lastName;

        public Person(FirstName firstName, LastName lastName)
        {
            this.firstName = firstName ?? throw new ArgumentNullException(nameof(firstName));
            this.lastName = lastName ?? throw new ArgumentNullException(nameof(lastName));
        }

        public string GetFirstName() => firstName.GetFirstName();
        public string GetLastName() => lastName.GetLastName();
    }
}
