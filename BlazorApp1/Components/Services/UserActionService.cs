namespace BlazorApp1.Services
{
    public class UserActionService
    {
        private readonly List<string> _actions = new List<string>();

        // Registra uma ação
        public void LogAction(string action)
        {
            _actions.Add($"{DateTime.Now}: {action}");
        }

        // Retorna a lista de ações registradas
        public List<string> GetActions()
        {
            return _actions;
        }
    }
}
