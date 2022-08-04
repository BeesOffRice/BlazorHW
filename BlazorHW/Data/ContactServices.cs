namespace BlazorHW.Data
{
    public class ContactServices
    {
        private readonly ContactContext _db;

        public ContactServices(ContactContext db)
        {
            _db = db;
        }

        //get a list of all the contacts in the db
        public List<ContactInfo> GetContacts()
        {
            var conlist = _db.Contacts.ToList();
            return conlist;
        }

        //adds a new contact to the db
        public string AddContact(ContactInfo objContact)
        {
            _db.Contacts.Add(objContact);
            _db.SaveChanges();

            return "New Contact added";

        }

        //returns an employee with the guid g
        public ContactInfo GetEmployeeByGuid(Guid g)
        {
            ContactInfo objContact = _db.Contacts.FirstOrDefault(s => s.Id == g);
            return objContact;
        }

        //updates an existing contact

        public string UpdateContact(ContactInfo objContact)
        {
            _db.Contacts.Update(objContact);
            _db.SaveChanges();
            return "Contact has been updated";
        }

        //deletes a contact

        public string DeleteContact(ContactInfo objContact)
        {
            _db.Contacts.Remove(objContact);
            _db.SaveChanges();
            return "Contact deleted";
        }


    }
}
