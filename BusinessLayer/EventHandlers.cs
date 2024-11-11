using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group1_PRG282_Project.BusinessLayer
{
    internal class EventHandlers
    {
        public void OnlyNumbers(object sender, KeyPressEventArgs e)
        {
            //Ipout validation only allowing for digits; no letters
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; //Dissalow the key press
            }
        }

        //Event handler to allow only letters
        public void OnlyLetters(object sender, KeyPressEventArgs e)
        {
            //Input validation only allowing letters; no digits
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;  //Disallow the key press
            }
        }
    }

    public class Student //Object for students 
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Course { get; set; }

        public Student() { }

        public Student(int studentId, string name, int age, string course)
        {
            ID = studentId;
            Name = name;
            Age = age;
            Course = course;
        }

        public override string ToString()
        {
            return $"{ID}, {Name}, {Age}, {Course}";
        }
    }
}
