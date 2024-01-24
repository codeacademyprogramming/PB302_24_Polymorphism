

using Lesson2;

Human hmn1 = new Human();

var prStd = new ProgrammingStudent();

Object obj = prStd;
Human hmn = prStd;
Student std = prStd;


ProgrammingStudent prStd1 = (ProgrammingStudent)obj;

int num = 5;
string str = "salam";
Human hmn2 = new Human { Name = "Hikmet" };
Student std2 = new Student { Name = "Nermin", GroupNo = "P111" };

Console.WriteLine(num);
Console.WriteLine(str);
Console.WriteLine(hmn2.ToString());

//upcasting
object stdObj = std2;

Console.WriteLine(stdObj.ToString());
Console.WriteLine(std2);
//downcasting
Student std3 = (Student)stdObj;

int num1 = 10;
char letter = 'A';

//boxing
object numObj = num1;
//unboxing
num1 = (int)numObj;


Console.WriteLine(numObj);


Human hmn4 = new Human { Name = "Hikmet",Surname="Abbasov" };
Human hmn5 = new Human { Name = "Hikmet",Surname="Babayev" };
Human hmn6 = hmn5;

int num11 = 44;
int num12 = 55;




Console.WriteLine(hmn4.GetHashCode());
Console.WriteLine(hmn5.GetHashCode());
Console.WriteLine(hmn6.GetHashCode());

Console.WriteLine(hmn4 == hmn5);
Console.WriteLine(hmn4.Equals(hmn5));




