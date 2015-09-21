namespace BoxGame {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using uFrame.ECS;
    
    
    public partial class SetUILabel {
        
        public override void Execute() {
        	label.text = value;
        }
    }
}
