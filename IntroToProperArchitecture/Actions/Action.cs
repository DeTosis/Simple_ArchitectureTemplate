using IntroToProperArchitecture.Actions;
using IntroToProperArchitecture.ActionSuppliment;

namespace IntroToProperArchitecture {
    internal class Action : BaseAction {
        public Action() {
            SubscribeToListener();
            NotifyOnActionEnded();
        }

        protected override void SubscribeToListener() { 
            ActionListener.Subscribe(this); 
        }

        protected override void NotifyOnActionEnded() {
            ActionEndedEventArgs eArgs = new ActionEndedEventArgs("Arguments of an ended action");
            OnActionEnded(eArgs);
        }
    }
}
