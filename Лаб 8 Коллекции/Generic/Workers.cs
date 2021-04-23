using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    public class Workers : Human
    {
        #region Properties
        public double Salary { get; set; }
        #endregion
        #region Methods
        public void DoWord() { }
        public override string ToString()
        {
            return string.Format("Класс Worker: \n Полное имя: {0}, Рост: {1}, Вес: {2}, Зарплата: {3}",
                FullName,
                Height,
                Weight,
                Salary);
        }
    }
}
#endregion