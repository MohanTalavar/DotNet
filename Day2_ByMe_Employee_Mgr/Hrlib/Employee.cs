namespace Hrlib;
using System;
public  class  Employee{

    private int empId;
    private string name;
    private string email;
    private DateTime joinDate;

    private Department dept;
    private double baseSal;

    public Employee(){}

    public Employee(int empId,string name,string email,DateTime joinDate,Department dept,double baseSal){

        this.empId = empId;
        this.name = name;
        this.email = email;
        this.joinDate = joinDate;
        this.dept = dept;
        this.baseSal=baseSal;

    }





    public override string ToString(){

        return this.empId+" "+
        this.name+" "+
        this.email+" "+
        this.joinDate+" "+
        this.dept+" "+
        this.baseSal;
    }

    public int Empid{

        get{ return this.empId;  }
        set{ this.empId = value;}
    }

    public string Name{

        get{ return this.name;  }
        set{ this.name = value;}
    }

    public string Email{

        get{ return this.email;  }
        set{ this.email = value;}
    }

    public DateTime JoinDate{

        get{ return this.joinDate;  }
        set{ this.joinDate = value;}
    }

    public Department Dept{

        get{ return this.dept;  }
        set{ this.dept = value;}
    }


    public double BaseSal{

        get{ return this.baseSal;  }
        set{ this.baseSal = value;}
    }










}