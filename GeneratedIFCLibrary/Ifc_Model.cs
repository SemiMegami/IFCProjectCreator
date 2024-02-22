using System;
using System.Collections.Generic;
#pragma warning disable VSSpell001 // Spell Check
namespace IFC
{
	public class IFC_Model
	{

        /// <summary>
        /// Version of this model
        /// </summary>
        protected IFC_Version Version;

        /// <summary>
        /// IFC Items
        /// </summary>
		public Dictionary<string, IFC> items;

        /// <summary>
        /// Constructor
        /// </summary>
        public IFC_Model(string version)
        {
            switch (version.ToUpper())
            {
                case "IFC2X3": this.Version = IFC_Version.IFC2x3; break;
                case "IFC4": this.Version = IFC_Version.IFC4; break;
                case "IFC4X1": this.Version = IFC_Version.IFC4x1; break;
                case "IFC4X2": this.Version = IFC_Version.IFC4x2; break;
                case "IFC4X3": this.Version = IFC_Version.IFC4x3; break;
            }
            items = new Dictionary<string, IFC>();
        }

        /// <summary>
        /// Initialize the model
        /// </summary>
        public virtual void Initialize()
        {
            items = new Dictionary<string, IFC>();
        }

        /// <summary>
        /// Return IFC Item with specified type
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public List<T> GetItems<T>() where T : IFC
		{
			List<IFC> itemList = items.Values.Where(x => x is T).ToList();
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
                if (parameter is IFC_Entity entity)
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

        public virtual void AddItem(IFC_Entity IFCBase)
        {

            List<object?> parameters = IFCBase.GetParameters();

            foreach (var parameter in parameters)
            {
                if(parameter!= null)
                {
                    CheckAndAddItem(parameter);
                }
            }

            if (IFCBase.Model == this)
            {
                return;
            }

            string IFC_ID = "#" + (items.Count + 1);
            IFCBase.IFC_ID = IFC_ID;
            items.Add(IFC_ID, IFCBase);
            IFCBase.Model = this;

        }

        /// <summary>
        /// Export model to IFC
        /// </summary>
        /// <returns></returns>
        public virtual void ExportIFC(string path)
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
                        string text = item.GetIFCFullText();
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
                case IFC_Version.UNDEFINED: return "";
                case IFC_Version.IFC2x3: return "IFC2x3";
                case IFC_Version.IFC4: return "IFC4";
                case IFC_Version.IFC4x1: return "IFC4x1";
                case IFC_Version.IFC4x2: return "IFC4x2";
                case IFC_Version.IFC4x3: return "IFC4x3";
            }
            return "";
        }
 	}
	public enum IFC_Version
	{
		UNDEFINED = 0,
		IFC2x3 = 23,
		IFC4 = 4,
		IFC4x1 = 41,
		IFC4x2 = 42,
		IFC4x3 = 43,
	}
}
