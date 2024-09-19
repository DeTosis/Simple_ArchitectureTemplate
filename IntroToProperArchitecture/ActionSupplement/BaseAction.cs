namespace IntroToProperArchitecture.ActionSuppliment {
    internal abstract class BaseAction : IAction {
        public event EventHandler<ActionEndedEventArgs>? ActionEnded;
        protected void OnActionEnded(ActionEndedEventArgs eArgs) {
            EventHandler<ActionEndedEventArgs>? handler = ActionEnded;
            handler?.Invoke(this, eArgs);
        }

        protected abstract void SubscribeToListener();
        protected abstract void NotifyOnActionEnded();
    }
}
