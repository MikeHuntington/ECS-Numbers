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
    using BoxGame;
    
    
    public class GuessLabelguessPropertyChanged {
        
        public GuessLabel Group;
        
        private GuessLabel _Event;
        
        private uFrame.ECS.EcsSystem _System;
        
        private string FormatStringAction21_Result = default( System.String );
        
        private UnityEngine.UI.Text ActionNode20_label = default( UnityEngine.UI.Text );
        
        private string ActionNode20_value = default( System.String );
        
        private BoxGame.SetUILabel ActionNode20 = new BoxGame.SetUILabel();
        
        public GuessLabel Event {
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
            // FormatStringAction
            FormatStringAction21_Result = string.Format(@"{0}", Group.guess);
            ActionNode20_label = Group.label;
            ActionNode20_value = FormatStringAction21_Result;
            // ActionNode
            // Visit BoxGame.SetUILabel
            ActionNode20.label = ActionNode20_label;
            ActionNode20.value = ActionNode20_value;
            ActionNode20.System = System;
            ActionNode20.Execute();
        }
    }
}