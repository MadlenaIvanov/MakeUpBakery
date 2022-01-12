namespace MakeUpBakery.Data.Models
{
    using MakeUpBakery.Data.Common.Models;

    public class Setting : BaseDeletableModel<int>
    {
        public string Name { get; set; }

        public string Value { get; set; }
    }
}
