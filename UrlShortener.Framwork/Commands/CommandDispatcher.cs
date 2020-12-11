using System;
using System.Collections.Generic;
using System.Text;

namespace UrlShortener.Framework.Commands
{
    public class CommandDispatcher
    {
        private readonly IServiceProvider _provider;

        public CommandDispatcher(IServiceProvider provider)
        {
            _provider = provider;
        }

        public CommandResult Dispatch(ICommand command)
        {
            Type type = typeof(ICommandHandler<>);
            Type[] typeArgs = { command.GetType() };
            Type handlerType = type.MakeGenericType(typeArgs);
            dynamic handler = _provider.GetService(handlerType);
            CommandResult result = handler.Handle((dynamic)command);
            return result;
        }
    }
}
