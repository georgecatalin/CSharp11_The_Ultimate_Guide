namespace ValueTuplesLib
{
    /// <summary>
    /// ValueTuples are firstly introduced in C# 7
    /// </summary>
    public class Employee
    {
        public (int Age, string Name, string Role) GetEmployeeDetails()
        {
            return (46, "George Calin", "Project Manager");
        }
    }
}
