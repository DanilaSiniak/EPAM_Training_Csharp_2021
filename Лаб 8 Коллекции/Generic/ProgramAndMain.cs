using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Generic
{
    class ProgramAndMain
    {
        static void Main(string[] args)
        {
            try
            {
                var st1 = new Students
                {
                    Weight = 70,
                    Height = 178,
                    FirstName = "Стас",
                    LastName = "Коташевич",
                    University = "BSTU"
                };
                var st2 = new Students
                {
                    Weight = 54,
                    Height = 172,
                    FirstName = "Александр",
                    LastName = "Маевский",
                    University = "BSTU"
                };
                var st3 = new Students
                {
                    Weight = 54,
                    Height = 181,
                    FirstName = "Влад",
                    LastName = "Ковальчук",
                    University = "BSU"
                };
                var st4 = new Students
                {
                    Weight = 78,
                    Height = 181,
                    FirstName = "Иван",
                    LastName = "Иваненко",
                    University = "BSU"
                };
                var st5 = new Students
                {
                    Weight = 81,
                    Height = 154,
                    FirstName = "Максим",
                    LastName = "Боровский",
                    University = "BSTU"
                };
                var wr1 = new Workers
                {
                    Weight = 67,
                    Height = 190,
                    FirstName = "Павел",
                    LastName = "Галанин",
                    Salary = 578.4
                };
                var wr2 = new Workers
                {
                    Weight = 67,
                    Height = 190,
                    FirstName = "Дмитрий",
                    LastName = "Грибовский  ",
                    Salary = 976.5
                };
                var wr3 = new Workers
                {
                    Weight = 55,
                    Height = 172,
                    FirstName = "Денис",
                    LastName = "Тупик",
                    Salary = 493
                };
                var container1 = new HumanContainer<Human> { st1, st2, wr1, wr2,st3,st4,st5,wr3 };

                foreach (var human in container1)
                {
                    Console.WriteLine(human.ToString());
                }

           
                var list = new List<HumanContainer<Human>>();
                list.Add(container1);

                //where          +++
                Console.WriteLine("\nLinq To objects: Where");
                var whereRes = container1.Where(h => h.FullName.StartsWith("Д"));
                foreach (var human in whereRes)
                    Console.WriteLine(human.ToString());
                //select         +++
                Console.WriteLine("\nLinq To objects: Select");
                var selectRes = container1.Select((h, i) => new { Index = i + 1, h.FullName });
                foreach (var el in selectRes)
                    Console.WriteLine(el);


                //One of the first in container1           +++++++
                Console.WriteLine("\nLinq To objects: First");
                var firstRes = container1.First(h => h.FullName.Length > 12);
                Console.WriteLine(firstRes);

         
                //Min height   +++++++++ 
                Console.WriteLine("\nLinq To objects: Min Height");
                var minRes = container1.Min(h => h.Height);
                Console.WriteLine(minRes);

                //найти максимальную коллекцию, содержащую указанный элемент
                Console.WriteLine("\nLinq To objects: Max Height");
                var maxRes = container1.Max(h => h.Height);
                Console.WriteLine(maxRes);
                ///найти количество коллекций, содержащих указанный элемент, 
                Console.WriteLine("\nLinq To objects: Same elements");
                var Same = container1.Count(h => h.Height==190);
                Console.WriteLine(Same);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }

    public class HumanContainer<T> : IEnumerable<T> where T : Human
    {
        #region Fields
        private readonly List<T> _container;
        #endregion
        #region Constructors
        public HumanContainer()
        {
            _container = new List<T>();
        }
        #endregion
        #region Properties
        public int Count
        {
            get { return _container.Count; }
        }
        #endregion
        #region Indexers
        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= Count)
                    throw new IndexOutOfRangeException();
                return _container[index];
            }
            set
            {
                if (index < 0 || index >= Count)
                    throw new IndexOutOfRangeException();
                _container[index] = value;
            }
        }
        #endregion
        #region Methods
        public T GetByName(string name)
        {
            return _container.FirstOrDefault(h => string.Compare(h.FirstName, name, StringComparison.InvariantCultureIgnoreCase) == 0);

        }
        public void Add(T human)
        {
            _container.Add(human);
        }
        public T Remove(T human)
        {
            var element = _container.FirstOrDefault(h => h == human);
            if (element != null)
            {
                _container.Remove(element);
                return element;
            }
            throw new NullReferenceException();
        }
        public void Sort()
        {
            _container.Sort();
        }
    
        public IEnumerator<T> GetEnumerator()
        {
            return _container.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }
    #endregion

}
