
namespace MyClasses
{
    public interface IEmployee
    {
        string GetHealthInsuranceAmount();

        int EmpID { get; set; }
        string EmpName { get; set; }
        string Location { get; set; }
    }
}
