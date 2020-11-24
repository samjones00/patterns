using System;
using System.Collections.Generic;
using System.Linq;

namespace Patterns.Builder.FuncBuilder
{
    public class FuncBuilder
    {
        private readonly IList<Func<FuncOrder,FuncOrder>> _actions = new List<Func<FuncOrder, FuncOrder>>();
        
        public FuncBuilder AddStoreName(string name) => AddAction(x => x.StoreName = name);
        public FuncBuilder AddCustomerName(string customerName) => AddAction(x => x.CustomerName = customerName);

        public FuncBuilder AddAction(Action<FuncOrder> action)
        {
            _actions.Add(x =>
            {
                action(x);
                return x;
            });

            return this;
        }

        public FuncOrder Build() => _actions.Aggregate(new FuncOrder(), (model, action) => action(model));
    }
}
