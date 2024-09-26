namespace Tests
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person1 p1 = new Person1("Gosho");
            Person1 p2 = new Person1("Misho");
            Person1 p3 = new Person1("Gosho");
            Person1 p4 = new Person1("Tisho");

            HashSet<Person1> p = new HashSet<Person1>();

            p.Add(p1);
            p.Add(p2);
            p.Add(p3);
            p.Add(p4);

            Console.WriteLine(p.Count);



            //Beer beer = new Beer("shumensko");
            //beer.Update("pirinsko");
            //Console.WriteLine(beer);



            //Parent p = new Child();
            //p.Print();



            //var child = new Child();



            //string str1 = "Academy";
            //string str2 = str1;

            //str1 = "Alpha";

            //Console.WriteLine($"{str1} {str2}");

            //ToUpper(str1, str2);

            //Console.WriteLine($"{str1} {str2}");



            //Person person = new Person() { Name = "Ivan", Age = 10 };

            //Update(person);

            //Console.WriteLine($"{person.Name} {person.Age}");

            Console.ReadLine();
        }

        public static void Update(Person p)
        {
            p.Name = "Ivan Ivanov";
            p.Age = 20;

            p = new Person();
            p.Name = "Ivan Ivanov Ivanov";
            p.Age = 30;
        }

        public static void ToUpper(string str1, string str2)
        {
            str1 = str1.ToUpper();
            str2 = str2.ToUpper();
        }
    }

    class Node
    {
        int value;
        Node left, right;

        public Node(int value, Node left, Node right)
        {
            this.value = value;
            this.left = left;
            this.right = right;
        }

        public IEnumerable<int> Foo()
        {
            var list = new List<int>();

            if (this.left == null && this.right == null)
            {
                list.Add(this.value);
            }

            if (this.left != null)
            {
                list.AddRange(this.left.Foo());
            }

            if (this.right != null)
            {
                list.AddRange(this.right.Foo());
            }

            return list;
        }

        public static void Method(Node root)
        {
            if (root.left == null && root.right == null)
            {
                Console.WriteLine(root.value);
            }

            if (root.left != null)
            {
                Method(root.left);
            }

            if (root.right != null)
            {
                Method(root.right);
            }
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    class Parent
    {
        //public Parent()
        //{
        //    Console.WriteLine("Parent");
        //}

        public virtual void Print()
        {
            Console.WriteLine("I am parent!");
        }
    }

    class Child : Parent
    {
        //public Child()
        //{
        //    Console.WriteLine("Child");
        //}

        public override void Print()
        {
            Console.WriteLine("I am child!");
        }
    }

    public class Beer
    {
        private /*readonly*/ string name;

        public Beer(string name)
        {
            this.name = name;
        }

        public void Update(string newName)
        {
            this.name = newName;
        }

        public override string ToString()
        {
            return this.name;
        }
    }

    class Person1
    {
        private string name;

        public Person1(string name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return this.name;
        }

        public override bool Equals(object? obj)
        {
            Person1 other = (Person1)obj;

            return this.name == other.name;
        }
    }
}
