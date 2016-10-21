using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

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
