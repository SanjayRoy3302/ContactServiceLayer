using ContactServiceLayer.Models;

namespace ContactServiceLayer
{
    public interface IContactDetailsService
    {
        List<ContactDetails> GetAllContactsList();
        BaseResponseModel AddContact(ContactDetails contactDetails);
        BaseResponseModel UpdateContact(ContactDetails contactDetails);
        BaseResponseModel DeleteContact(int contactDetailId);
    }
}
