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
    using uFrame.ECS;
    using UniRx;
    
    
    [uFrame.Attributes.uFrameIdentifier("d4b7d9d1-d0ad-48f2-88f9-d5455e81fab0")]
    public partial class Box : uFrame.ECS.EcsComponent {
        
        private Subject<String> _nameObservable;
        
        [UnityEngine.SerializeField()]
        private String _name;
        
        public int ComponentID {
            get {
                return 4;
            }
        }
        
        public IObservable<String> nameObservable {
            get {
                if (_nameObservable == null) {
                    _nameObservable = new Subject<String>();
                }
                return _nameObservable;
            }
        }
        
        public String name {
            get {
                return _name;
            }
            set {
                _name = value;
                if (_nameObservable != null) {
                    _nameObservable.OnNext(value);
                }
            }
        }
    }
}
