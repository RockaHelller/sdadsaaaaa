using Implicit_Explicit_Generics.Models;
using System;

namespace Implicit_Explicit_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Tast1
            //Celsius celsius = new Celsius(0);
            //Kelvin kelvin = celsius;
            //Console.WriteLine(kelvin.Degree);
            #endregion


            #region Implicit Explicit
            //Manat manat = new Manat(100);

            //Dollar dollar = manat;

            //Console.WriteLine(dollar.USD);

            //Bird bird = new Bird();

            //Animal animal = bird;

            //DateTime date = DateTime.Now;

            //Console.WriteLine(date.ToString("MMMM yy"));
            #endregion

            #region Generic List
            //StringList stringList = new StringList();
            ////Console.WriteLine(stringList.Add("123ase"));
            //stringList.Add("Murad");
            //stringList.Add("Musa");
            //stringList.Add("Resul");

            //stringList.GetAll();

            //IntList ages = new IntList();

            //ages.Add(18);
            //ages.Add(19);
            //ages.Add(15);

            //ages.GetAll();


            //LaptopList laptop = new LaptopList();

            //laptop.Add(new Laptop { Name = "ASUS" });
            //laptop.Add(new Laptop { Name = "MSI" });
            //laptop.Add(new Laptop { Name = "RAZER" });

            //laptop.GetAll();

            //DataList<int> ages = new DataList<int>();
            //ages.Add(18);
            //ages.Add(19);
            //ages.Add(15);
            //ages.Add(24);
            //ages.Add(28);
            //ages.GetAll();


            //DataList<string> names = new DataList<string>();
            //names.Add("Murad");
            //names.Add("Musa");
            //names.Add("Resul");
            //names.Add("Murad");
            //names.Add("Musa");
            //names.Add("Resul");
            //names.GetAll();


            //DataList<bool> married = new DataList<bool>();
            //married.Add(true);
            //married.Add(false);
            //married.Add(false);
            //married.Add(true);
            //married.Add(false);
            //married.Add(false);
            //married.GetAll();


            //Datas<string> name = new Datas<string>();

            //name.Add("CodeAcademy");

            //var resultName = name.GetAll();

            //foreach (var item in resultName)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion


            string a = "Salam";


            Repository<int> number = new Repository<int>();

            Repository<double> number = new Repository<double>();
            
            Repository<string> name1 = new Repository<string>();
            
            Repository<Student> student = new Repository<Student>();
            
            Repository<Worker> employee = new Repository<Worker>();





        }
    }


    public class Datas<T>
    {
        private T[] _datas;

        public Datas()
        {
            _datas = new T[0];
        }

        public void Add(T data)
        {
            Array.Resize(ref _datas, _datas.Length + 1);
            _datas[_datas.Length - 1] = data;
        }

        public T[] GetAll()
        {
            return _datas;
        }

    }


    public class DataList<T>
    {
        private T[] _datas;

        public DataList()
        {
            _datas = new T[0];
        }

        public void Add(T data)
        {
            Array.Resize(ref _datas, _datas.Length + 1);
            _datas[_datas.Length - 1] = data;
        }

        public void GetAll()
        {
            foreach (var item in _datas)
            {
                Console.WriteLine(item);
            }
        }
    }

    public class LaptopList
    {
        private Laptop[] _arr;

        public LaptopList()
        {
            _arr = new Laptop[0];
        }

        public void Add(Laptop laptop)
        {
            Array.Resize(ref _arr, _arr.Length + 1);
            _arr[_arr.Length - 1] = laptop;
        }

        public void GetAll()
        {
            for (int i = 0; i < _arr.Length; i++)
            {
                Console.WriteLine(_arr[i].Name);
            }
        }



    }

    public class StringList
    {
        private string[] _arr;

        public StringList()
        {
            _arr = new string[0];
        }
         
        public void Add(string str)
        {
            Array.Resize(ref _arr, _arr.Length + 1);
            _arr[_arr.Length - 1] = str;
        }

        public void GetAll()
        {
            for (int i = 0; i < _arr.Length; i++)
            {
                Console.WriteLine(_arr[i]);
            }
        }



    }

    public class IntList
    {
        private int[] _arr;

        public IntList()
        {
            _arr = new int[0];
        }

        public void Add(int str)
        {
            Array.Resize(ref _arr, _arr.Length + 1);
            _arr[_arr.Length - 1] = str;
        }

        public void GetAll()
        {
            for (int i = 0; i < _arr.Length; i++)
            {
                Console.WriteLine(_arr[i]);
            }
        }



    }


    //public class Dollar
    //{
    //    public double USD { get; set; }

    //    public Dollar(double usd)
    //    {
    //        USD = usd;
    //    }

    //}



    //public class Manat
    //{  
    //    public double AZN { get; set; }

    //    public Manat(double azn)
    //    {
    //        AZN = azn;
    //    }

    //    public static implicit operator Dollar(Manat manat)
    //    {
    //        return new Dollar(manat.AZN / 1.7);
    //        //return dollar;
    //    }

    //}



}
