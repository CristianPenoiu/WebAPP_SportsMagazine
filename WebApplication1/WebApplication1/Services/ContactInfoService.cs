using System.Threading.Tasks;
using WebApplication1.Models;
using WebApplication1.Repositories.Interfaces;

namespace WebApplication1.Services.Interfaces
{
    public class ContactInfoService : IContactInfo
    {
        private IRepositoryWrapper _repositoryWrapper;

        public ContactInfoService(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }

        public void CreateContact(ContactInfo contact)
        {
            _repositoryWrapper.ContactInfoRepository.Create(contact);
            _repositoryWrapper.ContactInfoRepository.Save();
        }

        public List<ContactInfo> GetAllContacts()
        {
            var allContacts = _repositoryWrapper.ContactInfoRepository.FindAll().ToList();
            return allContacts;
        }

    }
}
