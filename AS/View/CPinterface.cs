using System.Collections.Generic;

namespace AS.View
{
    interface CPinterface
    {
        string Source { get; }
        void Load(string source);
       // HashSet<ConfigerationPanel> GetIdNames();
    }
}
