using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "Hospital_b" в коде и файле конфигурации.
    public class Hospital_b : IHospital_b
    {
        public string DoWork()
        {
            return "Den, you are amazing, man!!";
        }
    }
}
