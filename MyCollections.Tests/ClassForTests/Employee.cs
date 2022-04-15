namespace MyCollections.Tests.ClassForTests
{
    public class Employee
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public override bool Equals(object obj)
        {
            bool result = false;

            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            if (obj is Employee other)
            {
                other = (Employee)obj;
                result = true;

                if (Name != other.Name)
                {
                    result = false;
                }

                if (Age != other.Age)
                {
                    result = false;
                }
            }

            return result;
        }
    }
}
