// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using StudentMngmtSystem;

StudentBL sBLobj=new StudentBL();

sBLobj.AcceptStudentDetails();
//sBLobj.CalcTotal();
//sBLobj.CalcAvg();

int t1;//Total
float p1;//Percentage

sBLobj.CalcResult(out t1,out p1);

System.Console.WriteLine($"Total {t1}");
System.Console.WriteLine( $"Percentage :{p1}");
