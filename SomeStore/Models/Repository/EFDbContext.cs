using System.Data.Entity;


namespace SomeStore.Models.Repository
{
    /// <summary>
    /// Класс, который ассоциирует модель данных Game с созданной базой Content
    /// </summary>
    public class EFDbContext : DbContext
    {
        /// <summary>
        /// Свойство для работы с каждой из таблиц БД
        /// </summary>
        public DbSet<Game> Games { get; set; }
    }
}