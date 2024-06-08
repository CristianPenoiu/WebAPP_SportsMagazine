using WebApplication1.Models;

namespace WebApplication1.Services.Interfaces
{
    public interface IContactInfo
    {
        List<ContactInfo> GetAllContacts();
        void CreateContact(ContactInfo contactInfo);
    }
}
