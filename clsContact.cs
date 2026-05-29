using System;
using System.Data;
using ContactsProject_DataAccessLayer;

namespace ContactsProject_BusinessLogicLayer
{
    public class clsContact
    {
        public int ContactID { set; get; }
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string Email { set; get; }
        public string Phone { set; get; }
        public string Address { set; get; }
        public DateTime DateOfBirth { set; get; }
        public int CountryID { set; get; }
        public string ImagePath { set; get; }
        enum enMode { AddNew = 1, Update };
        enMode Mode;

        public clsContact()
        {
            this.ContactID = default(int);
            this.FirstName = default(string);
            this.LastName = default(string);
            this.Email = default(string);
            this.Phone = default(string);
            this.Address = default(string);
            this.DateOfBirth = DateTime.Today;
            this.CountryID = default(int);
            this.ImagePath = default(string);
            Mode = enMode.AddNew;
        }

        private clsContact(int ContactID, string FirstName, string LastName, string Email, string Phone, string Address,
            DateTime DateOfBirth, int CountryID, string ImagePath)
        {
            this.ContactID = ContactID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;
            this.Phone = Phone;
            this.Address = Address;
            this.DateOfBirth = DateOfBirth;
            this.CountryID = CountryID;
            this.ImagePath = ImagePath;
            Mode = enMode.Update;
        }

        public static clsContact Find(int ContactID)
        {
            string FirstName = "", LastName = "", Email = "", Phone = "", Address = "", ImagePath = "";
            int CountryID = default(int);
            DateTime DateOfBirth = default(DateTime);

            if (clsContactData.Find(ContactID, ref FirstName, ref LastName, ref Email, ref Phone, ref Address, ref DateOfBirth,
                ref CountryID, ref ImagePath))
                return new clsContact(ContactID, FirstName, LastName, Email, Phone, Address, DateOfBirth,
                    CountryID, ImagePath);
            else
                return null;
        }

        private bool _AddNewContact()
        {
            this.ContactID = clsContactData.AddNewContact(this.FirstName, this.LastName, this.Email, this.Phone, this.Address,
                this.DateOfBirth, this.CountryID, this.ImagePath);
            return (this.ContactID != -1);
        }

        private bool _UpdateContact()
        {
            return clsContactData.UpdateContact(this.ContactID, this.FirstName, this.LastName, this.Email, this.Phone,
                this.Address, this.DateOfBirth, this.CountryID, this.ImagePath);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewContact())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case enMode.Update:
                    return _UpdateContact();
            }

            return false;
        }

        public static bool DeleteContact(int ContactID)
        {
            return clsContactData.DeleteContact(ContactID);
        }

        public static DataTable GetContactsList()
        {
            return clsContactData.GetContactList();
        }

        public static bool IsContactExist(int ContactID)
        {
            return clsContactData.IsContactExist(ContactID);
        }
    }
}