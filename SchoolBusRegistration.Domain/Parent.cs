namespace SchoolBusRegistration.Domain
{
    public class Parent:BaseEntity
    {
        public string Name { get; set; }
        public string IdentityNumber { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Child> Children { get; set; }
    }
}