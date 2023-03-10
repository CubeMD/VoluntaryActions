using UnityEngine;

namespace Tools.Cameras
{
    /// <summary>
    /// Static camera that follows the selected agent with local or world offset
    /// </summary>
    public class StaticOffsetAgentFollowCamera : BaseAgentFollowCamera
    {
        public enum OffsetType
        {
            World,
            Local
        }

        [SerializeField]
        private OffsetType offsetType;
        [SerializeField]
        private Vector3 cameraOffset;

        [SerializeField]
        private bool overrideXAxis;
        [SerializeField]
        private bool overrideYAxis;
        [SerializeField]
        private bool overrideZAxis;
        [SerializeField]
        private Vector3 overrideAxis = Vector3.zero;

        protected override void UpdatePosition()
        {
            Vector3 newPosition = offsetType == OffsetType.Local ? 
                AgentPosition + GetReferenceOrientation(Vector3.up) * cameraOffset :
                AgentPosition + cameraOffset;

            if (overrideXAxis)
            {
                newPosition.x = overrideAxis.x;
            }
            
            if (overrideYAxis)
            {
                newPosition.y = overrideAxis.y;
            }
            
            if (overrideZAxis)
            {
                newPosition.z = overrideAxis.z;
            }

            transform.position = newPosition;
        }
    }
}