namespace IntroToProperArchitecture.ActionSuppliment {
    internal interface IAction {
        public event EventHandler<ActionEndedEventArgs> ActionEnded;
        protected virtual void OnActionEnded(ActionEndedEventArgs e) { }
    }
}
