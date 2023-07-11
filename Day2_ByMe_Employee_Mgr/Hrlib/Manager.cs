namespace Hrlib;

public class Manager:Employee{

    private string teamName;
    private int teamSize;
    private double incentive;


    public Manager(){

    }

    public Manager(string teamName,int teamSize,double incentive,
    int empId,string name,string email,
    DateTime joinDate,Department dept,double baseSal):base( empId,name,email,joinDate,dept,baseSal){
        this.teamName=teamName;
        this.teamSize=teamSize;
        this.incentive=incentive;
    }

    public double Incentive{
        get{return this.incentive;}
        set{this.incentive=value;}
    }

     public  void ComputeSal(){
        double TotalSal = base.BaseSal + this.incentive;
        Console.WriteLine("Manager Sal : "+ TotalSal);
    }

    public override string ToString(){
        return base.ToString()+" "+this.teamName+" "+this.teamSize+" "+incentive;
    }

}