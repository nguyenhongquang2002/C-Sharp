using System;
using System.Collections.Generic;

namespace T2009M.session3
{
    public class Student : Human
    {
        private string name;
        private int age;
        private DateTime birthday;
        private string nickName;
        private string cannang;

        // public string[] gallery = new string[3];
        public List<string> phoneNumbers = new List<string>();

        public Student()
        {

        }

        public string this[int index] // indexer la bien doi tuong duoc su dung nhu 1 array
        {
            get => phoneNumbers[index];
            set => phoneNumbers[index] = value;
        }

        public override string Weight
        {
            get => cannang;
            set => cannang = value;
        }

        public Student(string name, int age)
        {
            Name = name;
            Age = age;
            phoneNumbers.Add("a");
            phoneNumbers.Add("b");
            phoneNumbers.Add("c");
        }

        public string Name // properties
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public int Age
        {
            get => age;
            set => age = value;
        }

        public DateTime Birthday // read only
        {
            get => birthday;
        }

        public string NickName // write only
        {
            set => nickName = value;
        }
    }
}