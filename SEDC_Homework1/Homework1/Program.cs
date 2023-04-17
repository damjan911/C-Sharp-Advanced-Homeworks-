#region

using Homework1.Entities;

Teacher teacher1 = new Teacher() { Id = 1,Name = "Martin", UserName = "martinpano", Password = "netigokazhuvam", Subject = "CSharp Advanced"};
Teacher teacher2 = new Teacher() { Id = 2, Name = "Ivo", UserName = "ivoo", Password = "netigokazhuvam123", Subject = "Node JS" };

List<int>grades1 = new List<int>() { 8,7,6};

Student student1 = new Student() { Id = 1,Name = "Antonio", UserName = "antonio123", Password = "test123", Grades = grades1 };
Student student2 = new Student() { Id = 2, Name = "Stefan", UserName = "stefan123", Password = "test1234", Grades = new List<int> { 9,8,7} };

teacher1.PrintUser();
teacher2.PrintUser();

student1.PrintUser();
student2.PrintUser();
#endregion
