﻿
using System.Reflection;
using AttributeClassLib;

namespace Assignment_Q_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Users\\rushi\\OneDrive\\Desktop\\D_Data\\PG-DAC\\Github Data\\PrepatoryAssignments\\C#.net\\Assignment_04_\\PocoLibrary\\bin\\Debug\\net8.0\\PocoLibrary.dll";
            string queryFile = "C:\\Users\\rushi\\OneDrive\\Desktop\\Project\\Queries2.sql";

            Assembly assembly = Assembly.LoadFrom(path);

            Type[] type = assembly.GetTypes();

            foreach (Type t in type)
            {
                if (!t.Name.Contains("Attributes"))
                {
                    Console.WriteLine(t.Name);
                    string query = "";

                    Attribute[] attributesonTypes = t.GetCustomAttributes().ToArray();

                    foreach (Attribute attribute in attributesonTypes)
                    {
                        if (attribute is DataTable)
                        {
                            DataTable table = (DataTable)attribute;

                            query = query + "create table " + table.Table + "(";

                            break;


                        }
                    }

                    PropertyInfo[] propertyInfo = t.GetProperties();
                    foreach (PropertyInfo property in propertyInfo)
                    {
                        Attribute[] propertyAttributes = property.GetCustomAttributes().ToArray();


                        foreach (Attribute attribute in propertyAttributes)
                        {
                            if (attribute is DataColumn)
                            {
                                DataColumn column = (DataColumn)attribute;
                                query = query + column.Columnname + " " + column.ColumnType + ",";
                                break;
                            }

                        }

                    }

                    query = query.TrimEnd(',');
                    query = query + ") ;";

                    FileStream fileStream = null;

                    if (File.Exists(queryFile))
                    {
                        fileStream = new FileStream(queryFile, FileMode.Append, FileAccess.Write);
                    }
                    else
                    {
                        fileStream = new FileStream(queryFile, FileMode.OpenOrCreate, FileAccess.Write);

                    }

                    StreamWriter stream = new StreamWriter(fileStream);
                    stream.Write(query);
                    stream.Close();
                    fileStream.Close();

                    stream = null;
                    fileStream = null;

                    Console.WriteLine("Done Query Writing !");
                }
            }
        }

    }
}
