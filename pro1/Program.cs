int[]  number={1,2,3,4,5,6};

for(int i=0;i<number.Length;i++)
{
    Console.WriteLine(number[i]);
}

System.Console.WriteLine("-----------------");
foreach(int i in number)
{
    Console.WriteLine(i);
}

List<Student> x = new List<Student>();
//instance of student class
Student st = new Student();
st.Name="Raj";
st.Age=20;
st.Address="Kathmandu";
st.Email="test@gmail.com";
st.Phone="1234567890";
x.Add(st);

Student st1 = new Student();
st1.Name="Raj1";
st1.Age=21;
st1.Address="Kathmandu1";
st1.Email="test2@gmail.com";
st1.Phone="1234567891";
x.Add(st1);

foreach(Student s in x)
{
    Console.WriteLine(s.Name);
    Console.WriteLine(s.Age);
    Console.WriteLine(s.Address);
    Console.WriteLine(s.Email);
    Console.WriteLine(s.Phone);
    Console.WriteLine("-----------------");
}

//instance of laptop

List<Laptop> y = new List<Laptop>();


Laptop l = new Laptop();
l.Brand="Dell";
l.Model="Inspiron";
l.Price=50000;
l.Name="Dell Inspiron";
y.Add(l);

Laptop l1 = new Laptop();
l1.Brand="HP";
l1.Model="Pavilion";
l1.Price=60000;
l1.Name="HP Pavilion";
y.Add(l1);

Laptop l2 = new Laptop();
l2.Brand="Lenovo";
l2.Model="Thinkpad";
l2.Price=70000;
l2.Name="Lenovo Thinkpad";
y.Add(l2);


foreach(Laptop s in y)
{
    Console.WriteLine(s.Name);
    Console.WriteLine(s.Brand);
    Console.WriteLine(s.Model);
    Console.WriteLine(s.Price);
    Console.WriteLine("-----------------");
}

//
List<Mobile> ListMobiles = new List<Mobile>();

// for (int i = 0; i < 3; i++)
// {
//     Mobile m = new Mobile();
//     System.Console.WriteLine("Enter the name of mobile");
//     m.Name = Console.ReadLine();

//     System.Console.WriteLine("Enter the model of mobile");
//     m.Model = Console.ReadLine();

//     System.Console.WriteLine("Enter the brand of mobile");
//     m.Brand = Console.ReadLine();

//     System.Console.WriteLine("Enter the price of mobile");
//     m.Price = Convert.ToInt32(Console.ReadLine());

//     ListMobiles.Add(m);
// }

string choice = "yes";

do
{
    Mobile m = new Mobile();
    System.Console.WriteLine("Enter the name of mobile");
    m.Name = Console.ReadLine();

    System.Console.WriteLine("Enter the model of mobile");
    m.Model = Console.ReadLine();

    System.Console.WriteLine("Enter the brand of mobile");
    m.Brand = Console.ReadLine();

    System.Console.WriteLine("Enter the price of mobile");
    m.Price = Convert.ToInt32(Console.ReadLine());

    ListMobiles.Add(m);

    System.Console.WriteLine("-----------------");

    System.Console.WriteLine("Do you want to add more mobiles? yes/no");
    choice = Console.ReadLine();
    
} while (choice == "yes");

foreach(Mobile s in ListMobiles)
{
    Console.WriteLine(s.Name);
    Console.WriteLine(s.Brand);
    Console.WriteLine(s.Model);
    Console.WriteLine(s.Price);
    Console.WriteLine("-----------------");
}



