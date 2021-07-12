using GraphQL;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GraphQLBasic.GraphQL
{
    public class RootQuery : ObjectGraphType
    {
        public RootQuery()
        {
            Field<ListGraphType<CustomerType>>("customers", resolve:
                context => GetCustomers());
            Field<CustomerType>("customer", arguments: new QueryArguments(
            new QueryArgument<IdGraphType> { Name = "id" }
            ), resolve: context =>
            {
                var id = context.GetArgument<int>("id");
                return GetCustomers().FirstOrDefault(x => x.Id == id);
            });
        }

        static List<Customer> GetCustomers()
        {
            var customers = new List<Customer>{
                new Customer 
                {
                    Id = 1,
                    Name = "Naimul",
                    Age = 34,
                    Address = "Dhanmondi"
                },
                new Customer
                {
                    Id = 2,
                    Name = "Imran",
                    Age = 36,
                    Address = "Gulshan"
                },
                new Customer
                 {
                   Id = 3,
                   Name = "Jamil",
                   Age = 31,
                   Address = "Uttara"
                 }
               };

            return customers;
        }
    }
}
