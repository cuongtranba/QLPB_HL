using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Model.Helper;
using _4.Helper.UserControls;

namespace _4.Helper
{
    public static class DataGridViewExtentions
    {
        public static DataGridView HiddentColumns<T>(this DataGridView dataGridView)
        {
            var hiddenColumns = typeof(T).GetProperties().Where(prop => Attribute.IsDefined(prop, typeof(HiddenColumn))).ToList();
            for (int i = 0; i < dataGridView.ColumnCount; i++)
            {
                foreach (var hiddenColumn in hiddenColumns)
                {
                    dataGridView.Columns[hiddenColumn.Name].Visible = false;
                }
            }
            return dataGridView;
        }
        public static GridView HiddentColumns<T>(this GridView dataGridView)
        {
            var hiddenColumns = typeof(T).GetProperties().Where(prop => Attribute.IsDefined(prop, typeof(HiddenColumn))).ToList();
            for (int i = 0; i < dataGridView.ColumnCount; i++)
            {
                foreach (var hiddenColumn in hiddenColumns)
                {
                    dataGridView.Columns[hiddenColumn.Name].Visible = false;
                }
            }
            return dataGridView;
        }
        public static DataGridView FormatDateTime<T>(this DataGridView dataGridView)
        {
            var dateColumns = typeof(T).GetProperties().Where(prop => Attribute.IsDefined(prop, typeof(DateTimeFormat))).ToList();
            foreach (var dateColumn in dateColumns)
            {
                IList<System.Reflection.CustomAttributeData>
                    datas = dateColumn.GetCustomAttributesData();
                foreach (var item in datas)
                {
                    if (item.AttributeType.Name == typeof(DateTimeFormat).Name)
                    {
                        dataGridView.Columns[dateColumn.Name].DefaultCellStyle.Format = item.ConstructorArguments[0].Value.ToString();
                    }
                }
            }
            return dataGridView;
        }
        public static GridView FormatDateTime<T>(this GridView dataGridView)
        {
            var dateColumns = typeof(T).GetProperties().Where(prop => Attribute.IsDefined(prop, typeof(DateTimeFormat))).ToList();
            foreach (var dateColumn in dateColumns)
            {
                IList<System.Reflection.CustomAttributeData>
                    datas = dateColumn.GetCustomAttributesData();
                foreach (var item in datas)
                {
                    if (item.AttributeType.Name == typeof(DateTimeFormat).Name)
                    {
                        dataGridView.Columns[dateColumn.Name].DefaultCellStyle.Format = item.ConstructorArguments[0].Value.ToString();
                    }
                }
            }
            return dataGridView;
        }
        public static GridView FormatNumber<T>(this GridView dataGridView)
        {
            var dateColumns = typeof(T).GetProperties().Where(prop => Attribute.IsDefined(prop, typeof(NumberFormat))).ToList();
            foreach (var dateColumn in dateColumns)
            {
                IList<System.Reflection.CustomAttributeData>
                    datas = dateColumn.GetCustomAttributesData();
                foreach (var item in datas)
                {
                    if (item.AttributeType.Name == typeof(NumberFormat).Name)
                    {
                        dataGridView.Columns[dateColumn.Name].DefaultCellStyle.Format = item.ConstructorArguments[0].Value.ToString();
                    }
                }
            }
            return dataGridView;
        }
        public static GridView ColumnContentAlign<T>(this GridView dataGridView)
        {
            var dateColumns = typeof(T).GetProperties().Where(prop => Attribute.IsDefined(prop, typeof(AlignCell))).ToList();
            foreach (var dateColumn in dateColumns)
            {
                IList<System.Reflection.CustomAttributeData>
                    datas = dateColumn.GetCustomAttributesData();
                foreach (var item in datas)
                {
                    if (item.AttributeType.Name == typeof(AlignCell).Name)
                    {
                        dataGridView.Columns[dateColumn.Name].DefaultCellStyle.Alignment = (DataGridViewContentAlignment)item.ConstructorArguments[0].Value;
                    }
                }
            }
            return dataGridView;
        }

        public static SortableBindingList<T> ToSortableBindingList<T>(this List<T> list) where T : class
        {
            var sortableBindingList = new SortableBindingList<T>();
            foreach (var item in list.AsParallel())
            {
                sortableBindingList.Add(item);
            }
            return sortableBindingList;
        }
    }
}
