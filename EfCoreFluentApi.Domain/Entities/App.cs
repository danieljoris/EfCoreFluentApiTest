using System;

namespace EfCoreFluentApi.Domain.Entities
{
    public class App
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public AppSettings Settings { get; private set; }

        public App(Guid id, string name, AppSettings settings)
        {
            Id = id;
            Name = name;
            Settings = settings;
        }

        public App(Guid id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
