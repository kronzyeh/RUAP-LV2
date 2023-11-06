using Begin2.Models;
using Begin2.Services;
using System.Web.Http;


namespace Begin2.Controllers
{
    public class ContactController : ApiController
    {
        private ContactRepository contactRepository;
        
        public ContactController()
        {
            this.contactRepository = new ContactRepository();
        }
        // GET: Contact
        public Contact[] Get()
        {
            return contactRepository.GetAllContacts();
        }
    }
}