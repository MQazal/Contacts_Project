using System;
using System.Data;
using ContactsProject_DataAccessLayer;

namespace ContactsProject_BusinessLogicLayer
{
    public class clsCountry
    {
        public int CountryID { set; get; }
        public string CountryName { set; get; }
        public string Code { set; get; }
        public string PhoneCode { set; get; }
        enum enMode { AddNew = 1, Update }
        enMode Mode;

        public clsCountry()
        {
            this.CountryID = default(int);
            this.CountryName = default(string);
            this.Code = default(string);
            this.PhoneCode = default(string);
            Mode = enMode.AddNew;
        }

        private clsCountry(int CountryID, string CountryName, string Code, string PhoneCode)
        {
            this.CountryID = CountryID;
            this.CountryName = CountryName;
            this.Code = Code;
            this.PhoneCode = PhoneCode;
            Mode = enMode.Update;
        }

        public static clsCountry FindCountry(int CountryID)
        {
            string CountryName = default(string), Code = default(string), PhoneCode = default(string);
            if (clsCountryData.FindCountryByID(CountryID, ref CountryName, ref Code, ref PhoneCode))
                return new clsCountry(CountryID, CountryName, Code, PhoneCode);
            else
                return null;
        }

        public static clsCountry FindCountry(string CountryName)
        {
            int CountryID = default(int);
            string Code = default(string), PhoneCode = default(string);
            if (clsCountryData.FindCountryByName(ref CountryID, CountryName, ref Code, ref PhoneCode))
                return new clsCountry(CountryID, CountryName, Code, PhoneCode);
            else
                return null;
        }

        private bool _AddNewCountry()
        {
            this.CountryID = clsCountryData.AddNewCountry(this.CountryName, this.Code, this.PhoneCode);
            return (this.CountryID != -1);
        }

        private bool _UpdateCountry()
        {
            return clsCountryData.UpdateCountry(this.CountryID, this.CountryName, this.Code, this.PhoneCode);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewCountry())
                    {
                        Mode = enMode.Update;
                        return true;
                    }

                    else
                        return false;

                case enMode.Update:
                    return _UpdateCountry();
            }
            return false;
        }

        public static bool DeleteCountry(int CountryID)
        {
            return clsCountryData.DeleteCountry(CountryID);
        }

        public static DataTable GetCountriesList()
        {
            return clsCountryData.GetCountriesList();
        }

        public static bool IsCountryExist(int CountryID)
        {
            return clsCountryData.IsCountryExist(CountryID);
        }

        public static bool IsCountryExist(string CountryName)
        {
            return clsCountryData.IsCountryExist(CountryName);
        }
    }
}