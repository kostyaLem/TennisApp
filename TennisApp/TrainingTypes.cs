using System.ComponentModel;

namespace TennisApp
{
    public enum TrainingTypes
    {
        [Description("Идеальная")]
        IdealParams = 1,

        [Description("Вес")]
        WeightAndExcursion,

        [Description("Сила")]
        DynamometryAndForse
    }
}
