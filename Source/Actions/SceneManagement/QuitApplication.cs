using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/Actions/Scene Management/Quit Application")]
    public sealed class QuitApplication : VoidAction
    {
        public override void Do()
        {
            Application.Quit();
        }
    }
}
