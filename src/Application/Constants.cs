using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevelUp.Logic
{
    public class Constants
    {
        public const string AwardType_Points = "Puntos";
        public const string AwardType_Money = "Dinero";
        public const int AwardName_MaxLength = 200;
        public const int AwardDescription_MaxLength = 700;
        public const int RuleName_MaxLength = 100;
        public const int RuleDescription_MaxLength = 500;
        public const string JASON_MIMEType = "application/json";

        public enum Rule_AwardColumns
        {
            Name,
            View,
            Delete
        };

        public enum Rule_AchievementColumns
        {
            Name,
            Amount,
            Delete
        };
    }
}
