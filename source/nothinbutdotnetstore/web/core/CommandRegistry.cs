using System.Collections.Generic;
using System.Linq;

namespace nothinbutdotnetstore.web.core
{
    public class CommandRegistry : IFindCommands
    {
        readonly IEnumerable<IProcessOneRequest> all_the_commands;

        public CommandRegistry(IEnumerable<IProcessOneRequest> all_the_commands)
        {
            this.all_the_commands = all_the_commands;
        }

        public IProcessOneRequest get_the_command_that_can_process(IContainRequestInformation request)
        {
            return all_the_commands.First(x => x.can_process(request));
        }
    }
}