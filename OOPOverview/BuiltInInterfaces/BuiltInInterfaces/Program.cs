using BuiltInInterfaces;

Student student1= new Student() { Id=1,Name= "Hakan", Age=26, Score=74};
Student student2= new Student() { Id=1,Name= "Sümeyye", Age=30, Score=65};
Student student3= new Student() { Id=1,Name= "Zeynep", Age=29, Score=89};

ClassRoom room= new ClassRoom();
room.Add(student1);
room.Add(student2);
room.Add(student3);

var sorted =room.GetSortedStudents();
foreach(var student in room)
{
    Console.WriteLine($"{student.Name} {student.Age} {student.Score}");
}