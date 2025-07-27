
// CST-150 Activity 7
// Author: Your Name
// Date: July 2025
// Citation: Adapted from Starting Out With Visual C#, 6/e

namespace BusinessLayer
{
    /// <summary>
    /// Represents a pet with a name, type, and age.
    /// </summary>
    public class Pet
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Age { get; set; }

        public Pet(string name, string type, int age)
        {
            Name = name;
            Type = type;
            Age = age;
        }
    }
}