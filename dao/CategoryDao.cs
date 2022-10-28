using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp3.Entity;

namespace ConsoleApp3.dao
{
    internal class CategoryDao
    {
        List<BaseIdAndName> listTable = new List<BaseIdAndName>();
        public int insert(BaseIdAndName row)
        {
            try
            {
                listTable.Add(row);
                return 1;
            }
            catch
            {
            return 0;
            }
        }
        public int update(BaseIdAndName row,string name)
        {
            for(int i = 0; i < listTable.Count; i++)
            {
                if (row.Id == listTable[i].Id)
                {
                    listTable[i] = row;
                    return 1;
                }
            }
            return 0;
        }
        public bool delete(BaseIdAndName row,string name)
        {
            for (int i = 0; i < listTable.Count; i++)
            {
                if (row.Id == listTable[i].Id)
                {
                    listTable.Remove(listTable[i]);
                    return true;
                }
            }
            return false;
        }
        public object findAll(string name)
        {
            return listTable;
        }
        public object findById(BaseIdAndName row)
        {
            for (int i = 0; i < listTable.Count; i++)
            {
                if (row.Id == listTable[i].Id)
                {
                    return listTable[i];
                }
            }
            return null;
        }
    }
}
