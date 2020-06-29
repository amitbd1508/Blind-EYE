using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Net.Mail;
using System.Threading;
using System.Net;

using System.Globalization;
using System.Linq.Expressions;
using System.Reflection;
namespace BlindEye_Lib.Utilities
{
    public class ListItemObject
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public string pid { get; set; }

    }

    public static class DDLHelper
    {
        public static List<ListItemObject> PopulateList<T>(List<T> items, string nameProperty, string valueProperty)
        {
            List<ListItemObject> list = new List<ListItemObject>();
            items.ForEach(i =>
            {
                ListItemObject obj = new ListItemObject();
                var props = typeof(T).GetProperties();
                foreach (PropertyInfo propInfo in props)
                {
                    fillListObject<T>(nameProperty, valueProperty, i, obj, propInfo);
                }
                list.Add(obj);


            });
            return list;
        }

        private static void fillListObject<T>(string nameProperty, string valueProperty, T i, ListItemObject obj, PropertyInfo propInfo)
        {
            if (propInfo.Name == nameProperty)
            {
                obj.Name = propInfo.GetValue(i, null).ToString();
            }
            if (propInfo.Name == valueProperty)
            {
                obj.Value = propInfo.GetValue(i, null).ToString();
            }
        }

        public static List<ListItemObject> PopulateList<T>(List<T> items, string nameProperty, string valueProperty, string parentProperty)
        {
            List<ListItemObject> list = new List<ListItemObject>();
            items.ForEach(i =>
            {
                ListItemObject obj = new ListItemObject();
                var props = typeof(T).GetProperties();
                foreach (PropertyInfo propInfo in props)
                {
                    fillListObject<T>(nameProperty, valueProperty, i, obj, propInfo);

                    if (propInfo.Name == parentProperty)
                    {
                        obj.pid = propInfo.GetValue(i, null).ToString();
                    }
                }
                list.Add(obj);


            });
            return list;
        }
    }
}
