using SpeedyAir.Abstractions;

namespace SpeedyAir.Presentation
{
    public class InventoryManagementMenu : IMenu
    {
        private IEnumerable<string> _menuItems;
        public SortedDictionary<string, ICommand> CommandDictionary { get; set; }

        public InventoryManagementMenu(IEnumerable<ICommand> commands)
        {
            CommandDictionary = new SortedDictionary<string, ICommand>();
            
            foreach (var cmd in commands)
                CommandDictionary.Add(cmd.CommandKey, cmd);
            
        }
            
        public void Prompt(IScreen screen)
        {
            var menuItems = BuildMenuItems();
            screen.PrintLine("\nAvailable Inventory Commands \n");
            foreach (var item in menuItems)
                screen.PrintLine(item);

            screen.PrintLine("\n\n");

            var entered = screen.ReadCommand();

            if(!string.IsNullOrEmpty(entered) && CommandDictionary.TryGetValue(entered , out ICommand enteredCommond))
            {
                var result = enteredCommond.Execute();
                screen.PrintLine("Command Executed Successfully. Here is the result => ");
                screen.PrintLine(result);
            }
            else            
                screen.PrintLine("Command is not defined. Please Try Again.");

            Prompt(screen);
        }

        private IEnumerable<string> BuildMenuItems()
        {
            _menuItems ??= CommandDictionary.Values.Select(cmd => $"\t{cmd.CommandKey}- {cmd.CommandLine}");

            return _menuItems;
        }
    }
}
