using PickleStudio.Core.Interfaces;
using System.Collections.Generic;

namespace PickleStudio.Core.Commands
{
    public static class CommandExtensions
    {
        private static Dictionary<Command, ICommand> _commands = new Dictionary<Command, ICommand>();

        public static void Register(this Command type, ICommand command)
        {
            if (_commands.ContainsKey(type)) 
            {
                _commands[type] = command;
            }
            else
            {
                _commands.Add(type, command);
            }
        }

        public static void Execute(this Command type, params string[] args)
        {
            if (_commands.ContainsKey(type)) _commands[type].Execute(args);
        }

        public static void SetEnabled(this Command type, bool enabled)
        {
            if (_commands.ContainsKey(type)) _commands[type].Enabled = enabled;
        }

        public static T Get<T>(this Command type)
            where T : class, ICommand
        {
            return (_commands.ContainsKey(type)) ? _commands[type] as T : (T)null;
        }
    }
}
