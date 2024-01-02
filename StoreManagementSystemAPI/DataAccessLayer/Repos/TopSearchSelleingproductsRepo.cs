using DataAccessLayer.Interfaces;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repos
{
    internal class TopSearchSelleingproductsRepo : Repo, IRepo<TopSearchSelleingproduct, string, TopSearchSelleingproduct>
    {
        public TopSearchSelleingproduct Create(TopSearchSelleingproduct obj)
        {
            var match = db.TopSearchSelleings.Count(c => c.TopProductName == obj.TopProductName);
            if (match > 0)
            {
                var upd = (from s in db.TopSearchSelleings
                           where s.TopProductName == obj.TopProductName
                           select s).SingleOrDefault();
                obj.Count = upd.Count + 1;
                obj.Id = upd.Id;
                obj.TopProductName = upd.TopProductName;
                db.Entry(upd).CurrentValues.SetValues(obj);
                db.SaveChanges();

            }
            else if (match == 0)
            {
                db.TopSearchSelleings.Add(obj);
                db.SaveChanges();

            }
            return obj;
        }

        public bool Delete(string id)
        {
            var ex = Read(id);
            db.TopSearchSelleings.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<TopSearchSelleingproduct> Read()
        {
            return db.TopSearchSelleings.ToList();
        }

        public TopSearchSelleingproduct Read(string id)
        {
            return db.TopSearchSelleings.Find(id);
        }

        public TopSearchSelleingproduct Update(TopSearchSelleingproduct Obj)
        {
            var exdata = db.Products.Find(Obj.Id);
            db.Entry(exdata).CurrentValues.SetValues(Obj);
            if (db.SaveChanges() > 0) return Obj;
            return null;

        }
    }
}
