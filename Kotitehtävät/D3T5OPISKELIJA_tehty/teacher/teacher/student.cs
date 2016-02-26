using System;


namespace teacher
{
    class Student 
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StudentID { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }

       
        public Student(string firstName, string lastName, string studentID, string address, string phonenumber)
        {
            FirstName = firstName;
            LastName = lastName;
            StudentID = studentID;
            Address = address;
            PhoneNumber = phonenumber;
        }

    
        public override string ToString()
        {
            return "\n   Etunimi:   "+FirstName + "\n   Sukunimi:  " + LastName + "\n   ID:        " 
                + StudentID + "\n   Osoite:    " + Address + "\n   Puh.Num:   " + PhoneNumber;
        }
      
      
        
        public void StudentMethod()
        {
            Console.WriteLine("This method belongs to Student!");
        }

      
    }
}
