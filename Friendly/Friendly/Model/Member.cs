using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Friendly.Model
{
    class Member
    {
        private string firstName;
        private string lastName;
        private string gender;
        private string birthdate;
        private string industry;
        private string email;
        private string workplace;
        private string profession;
        private string hometown;
        private string education;
        private string password;

        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                lastName = value;
            }
        }

        public string Gender
        {
            get
            {
                return gender;
            }

            set
            {
                gender = value;
            }
        }

        public string Birthdate
        {
            get
            {
                return birthdate;
            }

            set
            {
                birthdate = value;
            }
        }

        public string Industry
        {
            get
            {
                return industry;
            }

            set
            {
                industry = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string Workplace
        {
            get
            {
                return workplace;
            }

            set
            {
                workplace = value;
            }
        }

        public string Profession
        {
            get
            {
                return profession;
            }

            set
            {
                profession = value;
            }
        }

        public string Hometown
        {
            get
            {
                return hometown;
            }

            set
            {
                hometown = value;
            }
        }

        public string Education
        {
            get
            {
                return education;
            }

            set
            {
                education = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public Member() { }
        public Member(string firstName, string  lastName, string birthdate, string email, string password)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Birthdate = birthdate;
            this.Email = email;
            this.Password = password;
                
        }
        public Member(string firstName, string lastName, string gender, string birthdate, string industry, string email, string workplace, string profession, string hometown, string education)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Gender = gender;
            this.Birthdate = birthdate;
            this.Industry = industry;
            this.Email = email;
            this.Workplace = workplace;
            this.Profession = profession;
            this.Hometown = hometown;
            this.Education = education;
        }
        
    }
}