namespace ManagementProduct.Models
{
    public class Customer
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Cpf { get; private set; }
        public string Phone { get; private set; }
        public string Address { get; private set; }
        public string Notes { get; private set; }

        public Customer(string name, string email, string cpf, string phone, string address, string notes)
        {
            Name = name;
            Email = email;
            Cpf = cpf;
            Phone = phone;
            Address = address;
            Notes = notes;
        }

        public void UpdateCustomer(string name, string email, string cpf, string phone, string address, string notes)
        {
            Name = name;
            Email = email;
            Cpf = cpf;
            Phone = phone;
            Address = address;
            Notes = notes;
        }
    }
}
