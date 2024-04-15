
using Microsoft.VisualBasic;

///sample Lambda expression
int[] arr={1,2,3,4,5};

int result=arr.Multiply();
System.Console.WriteLine(result);

int max=arr.Max();
int min=arr.Min();
int sum=arr.Sum();
double avg=arr.Average();

System.Console.WriteLine(max);
System.Console.WriteLine(min);
System.Console.WriteLine(sum);
System.Console.WriteLine(avg);

//sample Lambda expression class and object Car

List<Car> cars=new List<Car>
{
    new Car{Name="Civic",Model="2014",Brand="Honda",Price=2500000},
    new Car{Name="Corolla",Model="2019",Brand="Toyota",Price=2000000},
    new Car{Name="Vitz",Model="2016",Brand="Toyota",Price=1500000},
    new Car{Name="City",Model="2015",Brand="Honda",Price=1800000},
    new Car{Name="Mehran",Model="2019",Brand="Suzuki",Price=1000000},
};

var car=cars.Where(c=>c.Price>1500000).ToList();

var car1=cars.Where(x=>x.Price>1500000 && x.Price<2000000).ToList();

foreach(var item in car1)
{
    System.Console.WriteLine(item.Name);
}


var car3=cars.Where(x=>x.Price>1500000 && x.Price<2500000 && x.Brand=="Toyota").ToList();

foreach(var item in car3)
{
    System.Console.WriteLine(item.Name);
}

var car4=cars.Where(x=>x.Brand=="Toyota").Average(x=>x.Price);

System.Console.WriteLine(car4);
var car5=cars.Where(x=>x.Brand!="Honda").ToList();

var car6=cars.Sum(x=>x.Price);

var car7=cars.Average(x=>x.Price);

var car8=cars.Where(x=>x.Model=="2014" || x.Model=="2015").ToList();

var car9=cars.Min(x=>x.Price);