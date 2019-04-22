namespace Magazine
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class DataContext : DbContext
    {
        // Контекст настроен для использования строки подключения "DataContext" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "Magazine.DataContext" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "DataContext" 
        // в файле конфигурации приложения.
        public DataContext()
            : base("name=DataContext")
        {
        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<PublisingHouse> PublisingHouses { get; set; }
        // Добавьте DbSet для каждого типа сущности, который требуется включить в модель. Дополнительные сведения 
        // о настройке и использовании модели Code First см. в статье http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}