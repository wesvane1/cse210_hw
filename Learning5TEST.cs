using System;

class Program
{
    static void Main(string[] args)
    {
        HEmployee emp1 = new HEmployee();
        emp1.SetName("Wes");
        emp1.SetIdNumber("123qwe");
        emp1.SetPayRate(17);
        emp1.SetHours(45);

        SEmployee emp2 = new SEmployee();
        emp2.SetName("Savanna");
        emp2.SetIdNumber("456rty");
        emp2.SetSalary(35000);

        DisplayEmpInfo(emp1);
        DisplayEmpInfo(emp2);

        List<Employee> employees = new List<Employee>();
        employees.Add(emp1);
        employees.Add(emp2);

        // This will get the pay of all employees no matter if they are salary or hourly.
        foreach (Employee emp in employees)
        {
          emp.GetPay();
        }
    }

    public static void DisplayEmpInfo(Employee employee)
    {
        string pay = employee.GetPay();
        Console.WriteLine($"{employee.GetName()} will be payed {pay}");
    }
}
abstract class Employee
{
  protected string _name;
  protected string _idNumber;

  public Employee()
  {

  }
  public string GetName()
  {
    return _name;
  }
  public void SetName(string name)
  {
    _name = name;
  }
  public string GetIdNumber()
  {
    return _idNumber;
  }
  public void SetIdNumber(string idNumber)
  {
    _idNumber = idNumber;
  }

  // public virtual string GetPay()
  // {
  //   return "test";
  // }

  // Abstract means that all methods need to override this, there is no choice.
  public abstract string GetPay();
}
class SEmployee : Employee
{
  private float _salary = 0;

  public float GetSalary()
  {
    return _salary;
  }
  public void SetSalary(float salary)
  {
    _salary = salary;
  }

  public override string GetPay()
  {
    return $"{_salary/12} monthly";
  }
}

class HEmployee : Employee
{
  private float _payRate = 0;
  private int _hours = 0;

  public float GetPayRate()
  {
    return _payRate;
  }
  public void SetPayRate(float payRate)
  {
    _payRate = payRate;
  }
  public int GetHours()
  {
    return _hours;
  }
  public void SetHours(int hours)
  {
    _hours = hours;
  }

  public override string GetPay()
  {
    return $"{(_hours * _payRate)*4} monthly";
  }
}