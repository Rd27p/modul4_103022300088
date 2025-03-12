using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_103022300088
{
    internal class FanLaptop
    {
        public enum FanState
        {
            Quiet, Balanced, Performance, Turbo
        };
        public enum Trigger
        {
            Mode_Down, Mode_Up, Turbo_Shortcut
        };

        public class Transition
        {
            public FanState PrevState { get; }
            public FanState NextState { get; }
            public Trigger Trigger { get; }

            public Transition(FanState prevState, FanState nextState, Trigger trigger)
            {
                PrevState = prevState;
                NextState = nextState;
                Trigger = trigger;
            }
        }

        private Transition[] transitions =
        {
            new Transition(FanState.Quiet, FanState.Balanced, Trigger.Mode_Up),
            new Transition(FanState.Balanced, FanState.Quiet, Trigger.Mode_Down),
            new Transition(FanState.Balanced, FanState.Performance, Trigger.Mode_Up),
            new Transition(FanState.Performance, FanState.Balanced, Trigger.Mode_Down),
            new Transition(FanState.Performance, FanState.Turbo, Trigger.Mode_Up),
            new Transition(FanState.Turbo, FanState.Performance, Trigger.Mode_Down),
            new Transition(FanState.Quiet, FanState.Turbo, Trigger.Turbo_Shortcut),
            new Transition(FanState.Turbo, FanState.Quiet, Trigger.Turbo_Shortcut),
        };

        public FanState CurrentState { get; private set; } = FanState.Quiet;

        public FanState GetNextState(FanState prevState , Trigger trigger)
        {
            foreach (var transition in transitions)
            {
                if (transition.PrevState == prevState && transition.Trigger == trigger)
                {
                    return transition.NextState;
                }
            }
            return prevState;
        }

        public void ActivateState(Trigger trigger)
        {
            CurrentState = GetNextState(CurrentState, trigger);
        }
    }
}       
