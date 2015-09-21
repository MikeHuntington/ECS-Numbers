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
    using BoxGame;
    using UnityEngine;
    using uFrame.ECS;
    using UniRx;
    using UnityEngine.UI;
    
    
    [uFrame.Attributes.uFrameIdentifier("1808b178-2183-4a06-908d-2a68a3450772")]
    public partial class GuessLabel : uFrame.ECS.EcsComponent {
        
        private Subject<UnityEngine.UI.Text> _labelObservable;
        
        private Subject<Int32> _minObservable;
        
        private Subject<Int32> _guessObservable;
        
        private Subject<Int32> _maxObservable;
        
        [UnityEngine.SerializeField()]
        private UnityEngine.UI.Text _label;
        
        [UnityEngine.SerializeField()]
        private Int32 _min;
        
        [UnityEngine.SerializeField()]
        private Int32 _guess;
        
        [UnityEngine.SerializeField()]
        private Int32 _max;
        
        public int ComponentID {
            get {
                return 1;
            }
        }
        
        public IObservable<UnityEngine.UI.Text> labelObservable {
            get {
                if (_labelObservable == null) {
                    _labelObservable = new Subject<UnityEngine.UI.Text>();
                }
                return _labelObservable;
            }
        }
        
        public IObservable<Int32> minObservable {
            get {
                if (_minObservable == null) {
                    _minObservable = new Subject<Int32>();
                }
                return _minObservable;
            }
        }
        
        public IObservable<Int32> guessObservable {
            get {
                if (_guessObservable == null) {
                    _guessObservable = new Subject<Int32>();
                }
                return _guessObservable;
            }
        }
        
        public IObservable<Int32> maxObservable {
            get {
                if (_maxObservable == null) {
                    _maxObservable = new Subject<Int32>();
                }
                return _maxObservable;
            }
        }
        
        public UnityEngine.UI.Text label {
            get {
                return _label;
            }
            set {
                _label = value;
                if (_labelObservable != null) {
                    _labelObservable.OnNext(value);
                }
            }
        }
        
        public Int32 min {
            get {
                return _min;
            }
            set {
                _min = value;
                if (_minObservable != null) {
                    _minObservable.OnNext(value);
                }
            }
        }
        
        public Int32 guess {
            get {
                return _guess;
            }
            set {
                _guess = value;
                if (_guessObservable != null) {
                    _guessObservable.OnNext(value);
                }
            }
        }
        
        public Int32 max {
            get {
                return _max;
            }
            set {
                _max = value;
                if (_maxObservable != null) {
                    _maxObservable.OnNext(value);
                }
            }
        }
    }
}
