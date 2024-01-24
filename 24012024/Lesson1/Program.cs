
using Lesson1;

Human hmn1 = new Human { Fullname = "Nermin" };
Student std1 = new Student { Fullname = "Hikmet", GroupNo = "PB302" };

hmn1.Display();
std1.Display();

// upcasting - Student->Human implicit conversion
Human hmn2 = std1;

hmn1.Display();
hmn2.Display();

// downcasting - Human -> Student - explicit conversion
//Student std2 = (Student)hmn2;
Student? std2 = hmn2 as Student;

var isStudent = hmn2 is Student;


Console.WriteLine(std2.GroupNo);












