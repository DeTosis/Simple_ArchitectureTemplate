namespace IntroToProperArchitecture.ActionSuppliment {
    internal class ActionEndedEventArgs {
        public dynamic ActionData { get; private set; }
        public ActionEndedEventArgs(dynamic ActionData) {
            this.ActionData = ActionData;
        }
    }
}
