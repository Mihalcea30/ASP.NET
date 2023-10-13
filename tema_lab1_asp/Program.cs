using tema_lab1_asp;
List<Materie> Materii = new List<Materie>();
var Mat1 = new Materie("Baze de Date", 7);
var Mat2 = new Materie("OOP", 5);
var Mat3 = new Materie("Algebra", 6);
var Mat4 = new Materie("Algoritmi fundamentali", 5);
var Mat5 = new Materie("Tehnici Web", 3);
Materii.Add(Mat1);
Materii.Add(Mat2);
Materii.Add(Mat3);
Materii.Add(Mat4);
Materii.Add(Mat5);
List<string> nume = new List<string> {"Mihalcea", "Popescu", "Becali", "Praz", "Copos", "Ionescu", "Agigea"};
List<string> prenume = new List<string> { "Alexandru", "Alin", "George", "Bogdan", "Corneliu", "Mihai", "Ecluza" };
List<double> medii = new List<double> {8.18, 9.00, 8.50, 6.45, 7.20, 6.90, 10};
List<Student> studenti = new List<Student>();
for (int i = 0; i < 7; i++)
{
    List<Materie> materii = new List<Materie>();
    foreach (Materie m in Materii)
        if (m.nr_credite > i)
            materii.Add(m);
    Student s = new Student(nume[i], prenume[i], medii[i], materii);
    studenti.Add(s);
}
foreach (Student student in studenti)
    student.AfisMaterii();
