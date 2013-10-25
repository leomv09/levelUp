using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LevelUp.Logic
{
    class Functions
    {
        public static bool DataGridViewHasDuplicatedValues(DataGridView dataGrid, int columnIndex)
        {
            string value;
            int valueCount;

            for (int i = 0; i < dataGrid.Rows.Count - 1; i++)
            {
                value = dataGrid.Rows[i].Cells[columnIndex].Value.ToString();

                if (value != null)
                {
                    valueCount = dataGrid.Rows.Cast<DataGridViewRow>().Count(
                        row =>
                        row.Cells[columnIndex].Value != null &&
                        row.Cells[columnIndex].Value.ToString() == value
                    );

                    if (valueCount > 1)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public static bool IsNullRow(DataGridViewRow row)
        {
            int ValidCells = row.Cells.Cast<DataGridViewCell>().Count(C => C.Value != null);
            return ValidCells == 0;

        }

        public static bool IsNumeric(string value)
        {
            int number;
            return Int32.TryParse(value, out number);
        }

        public static bool IsMoney(string value)
        {
            double number;
            return double.TryParse(value, out number) && number >= 0;
        }

    }
}
