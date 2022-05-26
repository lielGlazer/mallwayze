using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DBConection
    {
        wayzeShoopEntities wm = new wayzeShoopEntities();
        public DBConection() { }
        public List<T> GetDbSet<T>() where T : class
        {
            //using (wayzeShoopEntities wm  = new wayzeShoopEntities())
            {
                
                return wm.GetDbSet<T>().ToList();
            }
        }
        public enum ExecuteActions
        {
            Insert,
            Update,
            Delete
        }
        public void Execute<T>(T entity, ExecuteActions exAction) where T : class
        {
          //  using (wayzeShoopEntities wm = new wayzeShoopEntities())
            {
                var model = wm.Set<T>();
                switch (exAction)
                {
                    case ExecuteActions.Insert:
                        model.Add(entity);
                        break;
                    case ExecuteActions.Update:
                        model.Attach(entity);
                        wm.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                        break;
                    case ExecuteActions.Delete:
                        model.Attach(entity);
                        wm.Entry(entity).State = System.Data.Entity.EntityState.Deleted;
                        break;
                    default:
                        break;
                }
                wm.SaveChanges();
                


            }
        }
    }
}

