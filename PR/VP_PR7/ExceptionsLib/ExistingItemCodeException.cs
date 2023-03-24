using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsLib
{
    [Serializable]
    public class ExistingItemCodeException : ApplicationException
    {
        public Item Item { get; set; }

        public ExistingItemCodeException() { }
        public ExistingItemCodeException(string message) : base(message) { }
        public ExistingItemCodeException(string message, Exception ex) : base(message) { }
        // Конструктор для обработки сериализации типа
        protected ExistingItemCodeException(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext contex)
            : base(info, contex) { }
        public ExistingItemCodeException(Item item)
        {
            this.Data.Add("Время возникновения: ", DateTime.Now);
            this.Data.Add("Причина: ", "Такой артикул уже используется");
            Item = item;
            Data.Add("Элемент", item.ToString());
        }
    }
}
