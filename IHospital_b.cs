using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени интерфейса "IHospital_b" в коде и файле конфигурации.
    [ServiceContract]
    public interface IHospital_b
    {
        [OperationContract]
        string DoWork();
    }
}
