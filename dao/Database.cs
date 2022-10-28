using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using b4product;
using ConsoleApp3.Entity;

namespace ConsoleApp3.dao
{
    public sealed class Database
    {
        const string PRODUCT = "product";
        const string CATEGORY = "category";
        const string ACCESSORY = "accessory";
        private static Database data = null;
        private List<Product> productTable = new List<Product>();
        private List<Category> categoryTable = new List<Category>();
        private List<Accessotion> accessionsTable = new List<Accessotion>();
        public static Database Instants
        {
            get
            {
                if (data == null)
                {
                    data = new Database();
                }
                return data;
            }
        } 
        public int insertTable(string name,BaseIdAndName row)
        {
            if(name == PRODUCT)
            {
                var product = row as Product;
                productTable.Add(product);
                return 1;
            }
            if (name == CATEGORY)
            {
                var category = row as Category;
                categoryTable.Add(category);
                return 1;
            }
            if(name == ACCESSORY)
            {
                var accessory=row as Accessotion;
                accessionsTable.Add(accessory);
                return 1;
            }
            return 0;
        }
        public object selectTable(string name)
        {
            if (name == "product")
            {
                return productTable;
            }
            if (name == "category")
            {
                return categoryTable;
            }
            if (name == "accessory")
            {
                return accessionsTable;
            }
            return null;
        }
        public int updateTable(string name,BaseIdAndName row)
        {
            if (name == PRODUCT)
            {
                for(int i = 0; i < productTable.Count; i++)
                {
                    if (row.Id == productTable[i].Id)
                    {
                        productTable[i] = (Product)row;
                        return 1;
                    }
                }
            }
            if (name == CATEGORY)
            {
                for(int i=0; i < categoryTable.Count; i++)
                {
                    if (row.Id == categoryTable[i].Id)
                    {
                        categoryTable[i] = (Category)row;
                        return 1;
                    }
                }
            }
            if(name== ACCESSORY)
            {
                for(int i=0; i < accessionsTable.Count; i++)
                {
                    if (row.Id == accessionsTable[i].Id)
                    {
                        accessionsTable[i] = (Accessotion)row;
                        return 1;
                    }
                }
            }
            return 0;
        }
        public bool deleteTable(string name,BaseIdAndName row)
        {
            if (name == PRODUCT)
            {
                for(int i=0; i < productTable.Count; i++)
                {
                    if (row.Id == productTable[i].Id)
                    {
                        productTable.Remove(productTable[i]);
                        return true;
                    }
                }
            }
            if (name == CATEGORY)
            {
                for(int i=0;i<categoryTable.Count; i++)
                {
                    if(row.Id == categoryTable[i].Id)
                    {
                        categoryTable.Remove(categoryTable[i]);
                        return true;
                    }
                }
            }
            if (name == ACCESSORY)
            {
                for(int i=0;i<accessionsTable.Count; i++)
                {
                    if (row.Id == accessionsTable[i].Id)
                    {
                        accessionsTable.Remove(accessionsTable[i]);
                        return true;
                    }
                }
            }
            return false;
        }
        public void trucateTable(string name)
        {
            if (name == PRODUCT)
            {
                productTable.Clear();
            }
            if (name == CATEGORY)
            {
                categoryTable.Clear();
            }

        }
        public object updateTableById(int id, BaseIdAndName row)
        {
            var Type = row.GetType().Name;
            if (Type == "Product")
            {
                for (int i = 0; i < productTable.Count; i++)
                {
                    if (id == productTable[i].Id)
                    {
                        productTable[i] = (Product)row;
                        return productTable;
                    }
                }
            }
            if (Type == "Category")
            {
                for (int i = 0; i < categoryTable.Count; i++)
                {
                    if (id == categoryTable[i].Id)
                    {
                        categoryTable[i] = (Category)row;
                        return categoryTable;
                    }
                }
            }
            if (Type == "Accesory")
            {
                for (int i = 0; i < accessionsTable.Count; i++)
                {
                    if (id == accessionsTable[i].Id)
                    {
                        accessionsTable[i] = (Accessotion)row;
                        return accessionsTable;
                    }
                }
            }
            return null;
        }
    }
    
   
}
