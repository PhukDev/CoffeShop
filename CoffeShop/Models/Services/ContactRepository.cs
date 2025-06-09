using CoffeShop.Data;

namespace CoffeShop.Models.Services
{
    public class ContactRepository
    {
        private readonly CoffeeshopDbContext _context;

        public ContactRepository(CoffeeshopDbContext context)
        {
            _context = context;
        }

        public void AddContact(Contact contact)
        {
            contact.SubmittedAt = DateTime.Now;
            _context.Contacts.Add(contact);
            _context.SaveChanges();
        }
    }
}
