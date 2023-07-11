using Hrlib;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

DateTime newDate = new DateTime(2023,03,03);

//string teamName,int teamSize,double incentive,
   // int empId,string name,string email,
   // DateTime joinDate,Department dept,double baseSal

Manager man = new Manager("Pirates",55,15000,
    101,"Mohan Talvar","mt@gmail.com",
    newDate,Department.HR,25000);

man.ComputeSal();
    Console.WriteLine(man);