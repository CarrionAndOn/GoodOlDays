using MelonLoader;
using BoneLib;

namespace GoodOlDays
{
    internal partial class Main : MelonMod
    {
        public override void OnEarlyInitializeMelon()
        {
            base.OnEarlyInitializeMelon();
        }

        public override void OnInitializeMelon()
        {
            base.OnInitializeMelon();
            Hooking.OnLevelInitialized += WeAreSoBack;
        }
        public void WeAreSoBack(LevelInfo levelInfo)
        {
            WarningText.ClutterYourScreen();
        }
        public override void OnLateInitializeMelon()
        {
            base.OnLateInitializeMelon();
        }

        public override void OnUpdate()
        {
            base.OnUpdate();
        }

        public override void OnFixedUpdate()
        {
            base.OnFixedUpdate();
        }

        public override void OnLateUpdate()
        {
            base.OnLateUpdate();
        }
    }
}
