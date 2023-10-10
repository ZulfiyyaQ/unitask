namespace TASK8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Person person = new Person("Zulfiyya",19);
            //person.Introduce();

            Circle circle = new Circle("red", 4);
            circle.CalculateArea();

            Rectangle rectangle = new Rectangle("blue", 6, 10);
            rectangle.CalculateArea();

        }
    }

    class Shape
    {
        private string _color;

        public string Color
        {
            get { return _color; }
            init { _color = value; }
        }
        protected int _area;
        public void PrintColor()
        {
            Console.WriteLine(Color);
        }
        public void PrintArea()
        {
            Console.WriteLine(_area);
        }
        public void PrintInfo()
        {
            Console.WriteLine(_color, _area);
        }
        public Shape(string color)
        {
            Color = color;
        }

    }
    class Circle : Shape
    {
        private int _radius;

        public int Radius
        {
            get { return _radius; }
            set { _radius = value; }
        }
        public void CalculateArea()
        {
            _area = Radius * Radius * 3;
            Console.WriteLine(_area);
        }
        public Circle(string color,int radius): base(color)
        {
            Radius= radius;
            
        }
        
    }

    class Rectangle : Shape
    {
        private int _length;
        private int _width;


        public int Width
        {
            get { return _width; }
            set { _width = value; }
        }

        public int Length
        {
            get { return _length; }
            set { _length = value; }
        }
        public Rectangle(string color, int length, int width) : base(color)
        {
            Length = length;
            Width= width;
            
        }
        public void CalculateArea()
        {
            _area = Length * Width;
            Console.WriteLine(_area);
        }
        public int WidthMetod()
        {
            return _width;
        }
    
    }






    class Person
    {
        private string _name;
        private int _age;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;

        }
        public void Introduce()
        {
            Console.WriteLine($"Salam, menim adım {_name}-dir.{_age} yashım var");
        }
    }
}