          using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#pragma warning disable VSSpell001 // Spell Check
namespace CSiBKK.IFC
{
    public class IFC_Log
    {
        IFC_LogType LogType;
        public IFC_Entity? Source;
        public string Information;

        public IFC_Log(IFC_LogType logType, IFC_Entity source, string Information) 
        { 
            this.LogType = logType;
            this.Source = source;
            this.Information = Information;
        }
        public IFC_Log(IFC_LogType logType, string Information)
        {
            this.LogType = logType;
            this.Information = Information;
        }

        public override string ToString()
        {
            if(Source != null)
            {
                return LogType.ToString()+  ": " + Source.IFC_ID + "-" + Source.GetType().Name.ToUpper() + ": " + Information;
            }
            else
            {
                return LogType.ToString() + ": " + Information;
            }
        }
    }

    public enum IFC_LogType
    {
        ERROR,
        WARNING, 
        INFO
    }
}

