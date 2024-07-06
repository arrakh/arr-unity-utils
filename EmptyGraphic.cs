using UnityEngine.UI;

namespace Arr.Utils
{
    public class EmptyGraphic : Graphic
    {
        public EmptyGraphic()
        {
            useLegacyMeshGeneration = false;
        }
        
        public override void SetMaterialDirty() { }
        public override void SetVerticesDirty() { }
    }
}