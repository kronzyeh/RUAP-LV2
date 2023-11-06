using Begin2.Models;
using Begin2.Services;
using System.Net.Http;
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

        public HttpResponseMessage Post(Contact contact)
        {
            this.contactRepository.SaveContact(contact);

            var response = Request.CreateResponse<Contact>(System.Net.HttpStatusCode.Created, contact);

            return response;
        }
    }
}