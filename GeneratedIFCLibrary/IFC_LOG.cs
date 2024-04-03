using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#pragma warning disable VSSpell001 // Spell Check
#nullable enable
namespace IFC
          
{
    public class IFC_LOG
    {
        IFC_LOGTYPE LogType;
        public IFC_I_ENTITY? Source;
        public string Information;

        public IFC_LOG(IFC_LOGTYPE logType, IFC_I_ENTITY source, string Information) 
        { 
            this.LogType = logType;
            this.Source = source;
            this.Information = Information;
        }
        public IFC_LOG(IFC_LOGTYPE logType, string Information)
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

    public enum IFC_LOGTYPE
    {
        ERROR,
        WARNING, 
        INFO
    }
}

