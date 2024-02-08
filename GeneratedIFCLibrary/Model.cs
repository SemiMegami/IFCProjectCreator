using System;
using System.Collections.Generic;
namespace IFC
{
	public class Model
	{

        /// <summary>
        /// IFC Items
        /// </summary>
		public List<Entity> Items;
        
        /// <summary>
        /// Constructure
        /// </summary>
        public Model()
        {
            Items = new List<Entity>();
        }

        /// <summary>
        /// Return IFC Item with specificed type
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public List<T> GetItems<T>() where T : Entity
		{
			List<Entity> items = Items.Where(x => x is T).ToList();
            List < T > results = new List<T>();
			foreach (var item in items)
			{
				results.Add((T)item);
			}
			return results;
        }
 	}
}
