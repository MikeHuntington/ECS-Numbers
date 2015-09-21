namespace BoxGame {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using uFrame.ECS;
    
    
    public partial class PushBox {
        
        public override void Execute() {
        	rigidBody.AddForce(direction * 2f);
        }
    }
}
