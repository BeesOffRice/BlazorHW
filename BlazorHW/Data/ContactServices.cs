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
        public ContactInfo GetContactByGuid(Guid g)
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

        //sorts a list of type contactinfo alphabetically by last name
        public void SortLastName(List<ContactInfo> list)
        {
            int a = 0;
            ContactInfo placeholder;
            char lastchar = 'k';

            for(int i = 0; i < list.Count; i++)
            {
                a = 0;
                while(a < list.Count)
                {
                    char[] ch;
                    ch = list[i].LastName.ToCharArray();

                    if (a == 0)
                    {
                        lastchar= ch[0];
                        a++;
                    } 
                    else
                    {
                        if (Convert.ToInt32(ch[0]) < Convert.ToInt32(lastchar))
                        {
                            placeholder=list[i-1];
                            list[i-1] = list[i];
                            list[i] = placeholder;
                        }
                        else
                        {
                            lastchar = ch[0];
                        }
                        a++;
                    }
                }
            }
        }

        //sorts a contacts by first name
        public void SortFirstName(List<ContactInfo> list)
        {
            int a = 0;
            ContactInfo placeholder;
            char lastchar = 'k';

            for (int i = 0; i < list.Count; i++)
            {
                a = 0;
                while (a < list.Count)
                {
                    char[] ch;
                    ch = list[i].FirstName.ToCharArray();

                    if (a == 0)
                    {
                        lastchar = ch[0];
                        a++;
                    }
                    else
                    {
                        if (Convert.ToInt32(ch[0]) < Convert.ToInt32(lastchar))
                        {
                            placeholder = list[i - 1];
                            list[i - 1] = list[i];
                            list[i] = placeholder;
                        }
                        else
                        {
                            lastchar = ch[0];
                        }
                        a++;
                    }
                }
            }
        }

        }
}
