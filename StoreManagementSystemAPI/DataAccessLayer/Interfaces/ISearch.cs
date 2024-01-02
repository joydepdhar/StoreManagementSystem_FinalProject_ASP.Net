using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interfaces
{
    public interface ISearch<T>
    {
        List<T> Search(Dictionary<string, dynamic> Search);
    }
}
