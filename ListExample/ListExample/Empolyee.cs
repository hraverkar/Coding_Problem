using System.Collections.Generic;

namespace ListExample
{
  class Empolyee
  {
    private string EmpolyeeName_;
    public string Employeename
    {
      get {return EmpolyeeName_; }
      set { EmpolyeeName_ = value; }
    }

    private int EmployeeID_;
    public int EmployeeID
    {
      get {return EmployeeID_; }
      set {EmployeeID_ = value; }
    }

    private double Salary_;
    public double Salary
    {
      get { return Salary_; }
      set { Salary_ = value; }
    }

    public Empolyee(int v1, string v2, double v3)
    {
      EmployeeID_ = v1 ;
      EmpolyeeName_ =v2 ;
      Salary_ =v3 ;
    }

  }
}
