using System;
using System.Collections.Generic;
using System.Text;

namespace EfCoreFluentApi.Domain.ValueObjects
{
    public class Setting
    {
        public string Key { get; private set; }
        public string Value { get; private set; }
        public Type Type { get; private set; }
        protected Setting() { }

        public Setting(string key, string value, Type type)
        {
            Key = key;
            Value = value;
            Type = type;
        }

        public override string ToString()
        {
            return $"{Key}:{Value} - Type {Type.ToString()}";
        }
    }
}
