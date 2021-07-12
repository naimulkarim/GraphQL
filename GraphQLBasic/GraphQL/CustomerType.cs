using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace GraphQLBasic.GraphQL
{
    public class CustomerType : ObjectGraphType<Customer>
    {
        public CustomerType()
        {
            Field(x => x.Id);
            Field(x => x.Name);
            Field(x => x.Age);
            Field(x => x.Address, nullable: true);
        }
    }
}
