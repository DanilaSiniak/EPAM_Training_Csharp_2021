using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    public class Students : Human
    {
        #region Properties
        public string University { get; set; }
        #endregion
        #region Methods
        public void DoStudy() { }
        public override string ToString()
        {
            return string.Format(
                "Класс Student: \n Полное имя: {0}, Рост: {1}, Вес: {2}, Университет : {3}",
                FullName,
                Height,
                Weight,
                University);

        }
        #endregion
    }
}
