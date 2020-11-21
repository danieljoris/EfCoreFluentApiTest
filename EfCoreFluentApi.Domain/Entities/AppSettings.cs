using EfCoreFluentApi.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace EfCoreFluentApi.Domain.Entities
{
    public class AppSettings
    {
        public Guid Id { get; private set; }
        private List<Setting> _settings;
        public IReadOnlyCollection<Setting> Settings => _settings.AsReadOnly();

        protected AppSettings()
        {
            Id = Guid.NewGuid();
            _settings = new List<Setting>();
        }

        /*
        public AppSettings(App app)
        {
            Id = Guid.NewGuid();
            _settings = new List<Setting>();
            App = app;
        }*/

    }
}
