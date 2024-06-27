using GraphQL;
using GraphQL.Types;
using ShoppingGraphQL.Interfaces;
using ShoppingGraphQL.Type;

namespace ShoppingGraphQL.Query
{
    public class CategoryQuery : ObjectGraphType
    {
        public CategoryQuery(ICategoryRepository categoryRepository)
        {
            Field<ListGraphType<CategoryType>>("Categories").Resolve(context =>
            {
                return categoryRepository.GetCategories();
            });
        }
    }
}
