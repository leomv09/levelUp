using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LevelUpApplication
{
    class Functions
    {
        public static bool DataGridViewHasDuplicatedValues(DataGridView Grid)
        {
            DataGridViewRowCollection Rows = Grid.Rows;
            string Value;
            int ValueCount;
            int Name = 0;

            for (int i = 0; i < Rows.Count - 1; i++)
            {
                Value = Rows[i].Cells[0].Value.ToString();

                ValueCount = Grid.Rows.Cast<DataGridViewRow>().Count(R =>
                    R.Cells[Name].Value != null &&
                    R.Cells[Name].Value.ToString() == Value);

                if (ValueCount > 1)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool IsNullRow(DataGridViewRow Row)
        {
            int ValidCells = Row.Cells.Cast<DataGridViewCell>().Count(C => C.Value != null);
            return ValidCells == 0;

        }

        public static bool IsNumeric(string value)
        {
            int number;
            return Int32.TryParse(value, out number);
        }

        public static bool IsMoney(string value)
        {
            float number;
            return float.TryParse(value, out number) && number >= 0;
        }

    }
}
