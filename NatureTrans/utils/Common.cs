using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NatureTrans.utils
{
    internal static class Common
    {
        public static int LevenshteinDistance(string source, string target)
        {
            if (string.IsNullOrEmpty(source) || string.IsNullOrEmpty(target))
            {
                return Math.Max(source?.Length ?? 0, target?.Length ?? 0);
            }

            int[,] distances = new int[source.Length + 1, target.Length + 1];

            for (int i = 0; i <= source.Length; i++)
            {
                distances[i, 0] = i;
            }

            for (int i = 0; i <= target.Length; i++)
            {
                distances[0, i] = i;
            }

            for (int i = 1; i <= source.Length; i++)
            {
                for (int j = 1; j <= target.Length; j++)
                {
                    int cost = source[i - 1] == target[j - 1] ? 0 : 1;
                    distances[i, j] = Math.Min(Math.Min(distances[i - 1, j] + 1, distances[i, j - 1] + 1), distances[i - 1, j - 1] + cost);
                }
            }

            return distances[source.Length, target.Length];
        }

        public static DataTable GetDataTableFromEntity<T>(T entity, string[] excludedColumns = null)
        {
            
            DataTable dataTable = new DataTable(typeof(T).Name);
            excludedColumns ??= Array.Empty<string>();

            foreach (var property in typeof(T).GetProperties().Where(p => !excludedColumns.Contains(p.Name)))
            {
                if (property.CanRead)

                {
                    
                    Type underlyingType = Nullable.GetUnderlyingType(property.PropertyType);
                    DataColumn column = new DataColumn(property.Name, underlyingType ?? property.PropertyType);
                    dataTable.Columns.Add(column);
                }
            }

            var row = dataTable.NewRow();
            foreach (var property in typeof(T).GetProperties())
            {
                if (property.CanRead)
                {
                    string columnName = property.Name;
                    object value = property?.GetValue(entity);

                    if (value != null && dataTable.Columns.Contains(columnName)) // Check if column exists
                    {
                        row[columnName] = value ?? DBNull.Value;
                    }

                }
            }

            dataTable.Rows.Add(row);
            return dataTable;
        }

        public static T ConvertRowToEntity<T>(DataGridViewRow row) where T : new()
        {
            T entity = new T();
            foreach (var property in typeof(T).GetProperties())
            {
                // Check if the column exists in the DataGridView by the property name
                if (row.DataGridView.Columns.Contains(property.Name))
                {
                    // Get the value from the row's cell
                    object cellValue = row.Cells[property.Name].Value;

                    // Check if the value is not null before assigning
                    if (cellValue != DBNull.Value && cellValue != null)
                    {
                        // Convert and set the value to the property
                        property.SetValue(entity, Convert.ChangeType(cellValue, property.PropertyType));
                    }
                }
            }
            return entity;
        }
    }
}
