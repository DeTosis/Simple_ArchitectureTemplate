using IntroToProperArchitecture.ActionSuppliment;

namespace IntroToProperArchitecture.Actions {
    internal static class ActionListener{
        static IAction? current_action;
        public static void Subscribe(IAction action) {
            if (action == null) { throw new NotImplementedException(); } 
            if (current_action != null) { throw new InvalidOperationException(); } // Subscribed Action should end before we can use new one 
            current_action = action;
            current_action.ActionEnded += OnActionEnded;
        }

        private static void OnActionEnded(object? sender, ActionEndedEventArgs e) {
            Console.WriteLine(e.ActionData); // Work with data
            DisposeEndedAction();
        }

        private static void DisposeEndedAction() { 
            if (current_action == null) return;
            current_action.ActionEnded -= OnActionEnded;
            current_action = null;
        }
    }
}
