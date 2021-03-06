using uFrame.Attributes;
using UnityEngine.EventSystems;

namespace uFrame.ECS
{
    [UFrameEventDispatcher("On Submit"), uFrameCategory("uGUI")]
    public class SubmitDispatcher : EcsDispatcher, ISubmitHandler
    {
        public BaseEventData EventData { get; set; }

        public void OnSubmit(BaseEventData eventData)
        {
            Publish(this);
        }
    }
}