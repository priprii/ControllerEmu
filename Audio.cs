using System.IO;
using System.Windows.Forms;
using SharpDX.MediaFoundation;

namespace ControllerEmu {
    public class Audio {
        private static bool MediaManagerStarted { get; set; }

        public static void StartMediaManager() {
            if(!MediaManagerStarted) {
                MediaManagerStarted = true;
                MediaManager.Startup(true);
            }
        }

        public static void StopMediaManager() {
            if(MediaManagerStarted) {
                MediaManagerStarted = false;
                MediaManager.Shutdown();
            }
        }

        public static void Play(string audioFile, double vol) {
            if(!File.Exists(Application.StartupPath + @"\" + audioFile)) { return; }
            StartMediaManager();

            using(MediaEngineClassFactory MediaEngineFactory = new MediaEngineClassFactory()) {
                using(MediaEngine AudioMediaEngine = new MediaEngine(MediaEngineFactory, null, MediaEngineCreateFlags.AudioOnly)) {
                    AudioMediaEngine.Volume = vol;
                    AudioMediaEngine.Source = audioFile;
                    AudioMediaEngine.Play();
                }
            }
        }
    }
}
