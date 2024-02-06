using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFCProjectCreator
{
    public class IFCDeriveAttribute : IFCAttribute
    {
        public string DeriveText { get; set; }

        public IFCDeriveAttribute() : base()
        {
            DeriveText = "";
        }

        public override List<string> GetCSharpText()
        {
            throw new NotImplementedException();
        }
    }
}
