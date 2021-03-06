// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace BoxGame {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using UnityEngine;
    using uFrame.Kernel;
    
    
    public class PerformGuessHandler {
        
        public GuessLabel Group;
        
        private BoxGame.GuessEvent _Event;
        
        private uFrame.ECS.EcsSystem _System;
        
        private int ActionNode28_min = default( System.Int32 );
        
        private int ActionNode28_max = default( System.Int32 );
        
        private int ActionNode28_Result = default( System.Int32 );
        
        public BoxGame.GuessEvent Event {
            get {
                return _Event;
            }
            set {
                _Event = value;
            }
        }
        
        public uFrame.ECS.EcsSystem System {
            get {
                return _System;
            }
            set {
                _System = value;
            }
        }
        
        public virtual void Execute() {
            ActionNode28_min = Event.min;
            ActionNode28_max = Event.max;
            // ActionNode
            // Visit uFrame.Actions.CreateRandoms.RandomInt
            ActionNode28_Result = uFrame.Actions.CreateRandoms.RandomInt(ActionNode28_min, ActionNode28_max);
            // SetVariableNode
            Group.guess = (System.Int32)ActionNode28_Result;
            // SetVariableNode
            Group.max = (System.Int32)Event.max;
            // SetVariableNode
            Group.min = (System.Int32)Event.min;
        }
    }
}
