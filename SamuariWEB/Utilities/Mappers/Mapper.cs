using SamuraiWEB.Utilities.Mappers.Interfaces;

namespace SamuraiWEB.Utilities.Mappers
{
    internal static class Mapper
    {
        public static IModelToViewModelMapper ModelToViewModelMapping { get; }
        public static IViewModelToModelMapper ViewModelToModelMapping { get; }

        static Mapper()
        {
            ModelToViewModelMapping = new ModelToViewModelMapper();
            ViewModelToModelMapping = new ViewModelToModelMapper();
        }

    }
}
