using System;
using System.Collections.Generic;
using System.Text;

namespace OpenXML.Models
{
    public class Student
    {
        public static string HeaderRow = $"{nameof(Student.StudentId)},{nameof(Student.FirstName)},{nameof(Student.LastName)},{nameof(Student.DateOfBirth)},{nameof(Student.ImageData)}";
        public string StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        private string _DateOfBirth;
        public string DateOfBirth
        {
            get { return _DateOfBirth; }
            set
            {
                _DateOfBirth = value;

                //Convert DateOfBirth to DateTime
                DateTime dtOut;
                DateTime.TryParse(_DateOfBirth, out dtOut);
                DateOfBirthDT = dtOut;
            }
        }

        public DateTime DateOfBirthDT { get; internal set; }
        public string ImageData { get; set; }

        public string AbsoulteUrl { get; set; }

        public string Directory { get; set; }

        public string FullPathUrl
        {
            get
            {
                return AbsoulteUrl + "/" + Directory;
            }
        }

        public List<string> Exceptions { get; set; } = new List<string>();

        public void FromDirectory(string directory)
        {

            Directory = directory;

            if (String.IsNullOrEmpty(directory.Trim()))
            {
                return;
            }
            string[] data = directory.Trim().Split(" ", StringSplitOptions.None);

            StudentId = data[0];
            FirstName = data[1];
            LastName = data[2];
        }
    }
    }
