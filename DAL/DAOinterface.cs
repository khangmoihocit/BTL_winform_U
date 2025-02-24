using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    //interface
    public interface DAOinterface<T>
    {
        void add(T t);
        void update(T t);
        void deleteById(T t);
        T findById(string id);
    }
}
