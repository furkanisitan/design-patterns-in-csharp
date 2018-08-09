using DependencyInjection.Abstract;
using System;
using System.Collections.Generic;
using System.Data;

namespace DependencyInjection
{
    class Context
    {
        private static Dictionary<string, IDisplayer> _dependencies;

        static Context()
        {
            _dependencies = new Dictionary<string, IDisplayer>();
        }

        public static void DependencyRegister(string name, IDisplayer dependency)
        {
            _dependencies.Add(name, dependency);
        }

        public static IDisplayer ResolveDependency(string name)
        {
            if (_dependencies.ContainsKey(name))
                return _dependencies[name];
            throw new Exception("Dependency object not found!");
        }

        public static Sample CreateSample()
        {
            var dataSet = new DataSet();
            dataSet.ReadXml(@"..\..\Dependency.xml");
            var displayer = ResolveDependency(dataSet.Tables["sample"].Rows[0]["displayer"].ToString());
            return new Sample(displayer)
            {
                Msg = dataSet.Tables["sample"].Rows[0]["msg"].ToString()
            };
        }
    }
}
