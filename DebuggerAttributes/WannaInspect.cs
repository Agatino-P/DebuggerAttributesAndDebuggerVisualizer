using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DebuggerAttributes
{
    [DebuggerTypeProxy(typeof(WannaInspectDebugDisplay))]
    
        
    public class WannaInspect
    {
        
        //[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
        public List<int> Numbers = new List<int>( Enumerable.Range(1, 10));
    }

    internal class WannaInspectDebugDisplay
    {
        private WannaInspect _wannaInspect { get; }
        public WannaInspectDebugDisplay(WannaInspect wannaInspect) => _wannaInspect = wannaInspect;
        
        public string numbers => string.Join("\\n", _wannaInspect.Numbers.Select(n => n.ToString()));

        public string NumbersDebuggerDisplay
        {
            get
            {
                XElement rootEle = new XElement("Numbers");
                foreach (int n in this._wannaInspect.Numbers)
                    rootEle.Add(new XElement("Numero", n));
                return rootEle.ToString();
            }
        }
    }
}
