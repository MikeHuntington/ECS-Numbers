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
    using UniRx;
    using uFrame.ECS;
    
    
    public partial class GuessEvent : object {
        
        [UnityEngine.SerializeField()]
        private Int32 _min;
        
        [UnityEngine.SerializeField()]
        private Int32 _max;
        
        public Int32 min {
            get {
                return _min;
            }
            set {
                _min = value;
            }
        }
        
        public Int32 max {
            get {
                return _max;
            }
            set {
                _max = value;
            }
        }
    }
}
