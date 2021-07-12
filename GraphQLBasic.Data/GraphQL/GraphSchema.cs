using GraphQL;
using GraphQL.Types;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;


namespace GraphQLBasic.Data.GraphQL
{
    public class GraphSchema : Schema
    {
        public GraphSchema(IServiceProvider provider) : base(provider)
        {
            Query = provider.GetRequiredService<RootQuery>();
            //Query = resolver.Resolve<RootQuery>();
        }
    }
}
