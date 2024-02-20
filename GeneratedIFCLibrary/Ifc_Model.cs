using System;
using System.Collections.Generic;
namespace IFC
{
	public class Ifc_Model
	{

               /// <summary>
        /// Version of this model
        /// </summary>
        protected Ifc_Version Version;

        /// <summary>
        /// IFC Items
        /// </summary>
		public Dictionary<string, Ifc_Entity> items;

        /// <summary>
        /// Constructure
        /// </summary>
        public Ifc_Model(string version)
        {
            switch (version.ToUpper())
            {
                case "IFC2X3": this.Version = Ifc_Version.Ifc2x3; break;
                case "IFC4": this.Version = Ifc_Version.Ifc4; break;
                case "IFC4X1": this.Version = Ifc_Version.Ifc4x1; break;
                case "IFC4X2": this.Version = Ifc_Version.Ifc4x2; break;
                case "IFC4X3": this.Version = Ifc_Version.Ifc4x3; break;
            }
            items = new Dictionary<string, Ifc_Entity>();
        }

        /// <summary>
        /// Initalize the model
        /// </summary>
        public virtual void Initialize()
        {
            items = new Dictionary<string, Ifc_Entity>();
        }

        /// <summary>
        /// Return IFC Item with specificed type
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public List<T> GetItems<T>() where T : Ifc_Entity
		{
			List<Ifc_Entity> itemList = items.Values.Where(x => x is T).ToList();
            List <T> results = new List<T>();
			foreach (var item in itemList)
			{
				results.Add((T)item);
			}
			return results;
        }

        void CheckAndAddItem(dynamic parameter)
        {
            if (parameter == null)
            {
                return;
            }
            if(parameter != null)
            {
                if (parameter is Ifc_Entity entity)
                {
                    if (entity.Model != this)
                    {
                        AddItem(entity);
                    }
                }
                else if (parameter.GetType().GetInterface("IEnumerable") != null)
                {
                    for (int i = 0; i < parameter.Count; i++)
                    {
                        CheckAndAddItem(parameter[i]);
                    }
                }
            }
        }

        public static string GenerateID()
        {
            return Guid.NewGuid().ToString().Replace("-", "").Substring(0, 22);
        }

        public virtual void Clear()
        {
            items.Clear();
        }

        public virtual void AddItem(Ifc_Entity ifcBase)
        {

            List<object?> parameters = ifcBase.GetParameters();

            foreach (var parameter in parameters)
            {
                if(parameter!= null)
                {
                    CheckAndAddItem(parameter);
                }
            }

            if (ifcBase.Model == this)
            {
                return;
            }

            string ifcid = "#" + (items.Count + 1);
            ifcBase.ifcid = ifcid;
            items.Add(ifcid, ifcBase);
            ifcBase.Model = this;

        }

        /// <summary>
        /// Export model to Ifc
        /// </summary>
        /// <returns></returns>
        public virtual void ExportIfc(string path)
        {
            var now = DateTime.UtcNow.ToString();
            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.WriteLine("ISO-10303-21;");
                writer.WriteLine("HEADER;");
                writer.WriteLine("FILE_DESCRIPTION(");
                writer.WriteLine("/* description */ ('ViewDefinition [PresentationView]', 'Comment [Cutouts,SDS/2 Detailed model]'),");
                writer.WriteLine("/* implementation_level */ '2;1');");
                writer.WriteLine("FILE_NAME(");
                writer.WriteLine("/* name */ '" + path + "',");
                writer.WriteLine("/* time_stamp */ '" + now + "',");
                writer.WriteLine("/* author */ ('Author Name'),");
                writer.WriteLine("/* organization */ ('Oganaization Name'),");
                writer.WriteLine("/* preprocessor_version */ 'Version Name',");
                writer.WriteLine("/* originating_system */ 'System Name',");
                writer.WriteLine("/* authorization */ 'None');");
                writer.WriteLine("FILE_SCHEMA (('" + GetVersionText().ToUpper() + "'));");
                writer.WriteLine("ENDSEC;");
                writer.WriteLine("DATA;");
                writer.WriteLine("");
                foreach (var item in items.Values.ToList())
                {
                    if (item != null)
                    {
                        string text = item.GetIfcFullText();
                        writer.WriteLine(text);
                    }
                }
                writer.WriteLine("");
                writer.WriteLine("ENDSEC;");
                writer.WriteLine("END-ISO-10303-21;");
            }
        }

        /// <summary>
        /// Get Version text of this version
        /// </summary>
        /// <returns></returns>
        public string GetVersionText()
        {
            switch (Version)
            {
                case Ifc_Version.UNDEFINED: return "";
                case Ifc_Version.Ifc2x3: return "Ifc2x3";
                case Ifc_Version.Ifc4: return "Ifc4";
                case Ifc_Version.Ifc4x1: return "Ifc4x1";
                case Ifc_Version.Ifc4x2: return "Ifc4x2";
                case Ifc_Version.Ifc4x3: return "Ifc4x3";
            }
            return "";
        }
 	}
	public enum Ifc_Version
	{
		UNDEFINED = 0,
		Ifc2x3 = 23,
		Ifc4 = 4,
		Ifc4x1 = 41,
		Ifc4x2 = 42,
		Ifc4x3 = 43,
	}
}
