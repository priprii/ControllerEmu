using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace ControllerEmu {
    public static class Config {
        public static Options Options { get; set; } = new Options();

        public static Options.GeneralOptions General { get { return Options.General; } set { Options.General = value; } }
        public static Options.AudioOptions Audio { get { return Options.Audio; } set { Options.Audio = value; } }

        public static void Load() {
            if(!File.Exists(Application.StartupPath + @"\Config.ini")) {
                Save();
            } else {
                Options = JsonConvert.DeserializeObject<Options>(File.ReadAllText(Application.StartupPath + @"\Config.ini"), new JsonSerializerSettings() { ObjectCreationHandling = ObjectCreationHandling.Replace, TypeNameHandling = TypeNameHandling.Auto });
            }
        }

        public static void Save() {
            File.WriteAllText(Application.StartupPath + @"\Config.ini", JsonConvert.SerializeObject(Options, Formatting.Indented));
        }
    }

    public class Options {
        public GeneralOptions General { get; set; } = new GeneralOptions();
        public AudioOptions Audio { get; set; } = new AudioOptions();

        public class GeneralOptions {
            public bool ConnectOnStart { get; set; } = true;
            public bool EnableOnStart { get; set; } = false;
            public string ClientTitle { get; set; } = "LOST ARK";
            public int ToggleKey { get; set; } = 0;
        }

        public class AudioOptions {
            public bool EnabledAudioNotification { get; set; } = true;
            public bool DisabledAudioNotification { get; set; } = true;
            public string EnabledAudioFile { get; set; } = "toggleon.mp3";
            public string DisabledAudioFile { get; set; } = "toggleoff.mp3";
            public double EnabledAudioVolume { get; set; } = 0.25;
            public double DisabledAudioVolume { get; set; } = 0.35;
        }
    }
}
