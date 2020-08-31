using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bartender_App.Models
{
    public class Queue
    {
        private List<QueueLine> lineCollection = new List<QueueLine>();
        public virtual void AddItem(Cocktail cocktail)
        {
            QueueLine line = lineCollection
            .Where(p => p.Cocktail.CocktailID == cocktail.CocktailID)
            .FirstOrDefault();
            lineCollection.Add(new QueueLine
            {
                Cocktail = cocktail
            });
            
        }
        public virtual void RemoveLine(Cocktail cocktail) => lineCollection.RemoveAt(0);
        public virtual void Clear() => lineCollection.Clear();
        public virtual IEnumerable<QueueLine> Lines => lineCollection;
    }
    public class QueueLine
    {
        public int QueueLineID { get; set; }
        public Cocktail Cocktail { get; set; }
    }
}