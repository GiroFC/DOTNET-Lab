namespace LibraryAPI.Models
{
    public class UserModel
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public ICollection<LoanModel> Loans { get; private set; } = new List<LoanModel>();

        public UserModel(string name, string email)
        {
            Id = Guid.NewGuid();
            Name = name;
            Email = email;
        }

        public void UpdateName(string newName)
        {
            if (!string.IsNullOrEmpty(newName))
                Name = newName;
        }

        public void UpdateEmail(string newEmail)
        {
            if (!string.IsNullOrEmpty(newEmail))
                Email = newEmail;
        }
    }
}
