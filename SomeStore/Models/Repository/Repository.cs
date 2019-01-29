using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SomeStore.Models.Repository
{
    /// <summary>
    /// Класс, хранилище
    /// </summary>
    public class Repository
    {
        private EFDbContext context = new EFDbContext();

        /// <summary>
        /// Возвращает результат чтения свойства с таким же именем в класса EFDbContext
        /// </summary>
        public IEnumerable<Game> Games { get { return context.Games; } }
    }
}