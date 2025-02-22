using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using RedHeadToolz.Audio;

namespace RedHeadToolz.Utils
{
    public class InitController : MonoBehaviour
    {
        [SerializeField] private string nextScene;
        [SerializeField] private List<BaseModule> modules;

        // Start is called before the first frame update
        void Start()
        {
            Screen.sleepTimeout = SleepTimeout.NeverSleep;
            Screen.orientation = ScreenOrientation.LandscapeLeft;
            // Screen.SetResolution(1920, 1080, false);
        }

        // Update is called once per frame
        void Update()
        {
            bool allInitialized = true;
            foreach(BaseModule module in modules)
            {
                if(module.InitState == InitializationState.NotInitialized)
                {
                    module.Init();
                    break;
                }
                else if(module.InitState == InitializationState.Initializing)
                {
                    allInitialized = false;
                    break;
                }
                else if(module.InitState == InitializationState.Initialized)
                {
                    module.Update(Time.deltaTime);
                }
            }

            // should add some way to represent percentage of modules loaded

            if(allInitialized)
            {
                SceneManager.LoadScene(nextScene);
            }
        }
    }
}