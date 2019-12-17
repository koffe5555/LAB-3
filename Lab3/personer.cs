using System;

namespace Lab3
{
    public class Person
    {
        private string eyecolor;
        public string sex;
        public DateTime age = new DateTime();

        public hair har;

        public string GetEyeColor()
        {
            return eyecolor;
        }

        public void SetEyeColor(string eye)
        {
            eyecolor = eye;
        }

       public Person(string _eyecolor, string _sex, DateTime _age, hair _har)
        {

        eyecolor = _eyecolor;
        sex = _sex;
        age = _age;
        har = _har;
   
        }
        

    /* public void SetEyeColor()
     {
         eyecolor = Console.ReadLine();
     }

     public void PrintEyeColor()
     {
         Console.WriteLine("Ögonfärg: " + eyecolor);
     }*/

}

    public struct hair
    {
        public int hairlenght;
        public string haircolor;
    }
}