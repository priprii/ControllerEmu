using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace ControllerEmu {
    public static class Config {
        private static System.Threading.Timer ConfigTimer;
        public static Options Options { get; set; } = new Options();

        public static Options.GeneralOptions General { get { return Options.General; } set { Options.General = value; } }
        public static Options.BindingOptions Binding { get { return Options.Binding; } set { Options.Binding = value; } }

        public static void Load() {
            if(!File.Exists(Application.StartupPath + @"\Config.ini")) {
                Save(false);
            } else {
                Options = JsonConvert.DeserializeObject<Options>(File.ReadAllText(Application.StartupPath + @"\Config.ini"), new JsonSerializerSettings() { ObjectCreationHandling = ObjectCreationHandling.Replace, TypeNameHandling = TypeNameHandling.Auto });
            }
        }

        public static void Save(bool delay = true) {
            if(delay) {
                if(ConfigTimer == null) {
                    ConfigTimer = new System.Threading.Timer(new TimerCallback((state) => {
                        ConfigTimer.Dispose();
                        ConfigTimer = null;
                        Save(false);
                    }));
                }
                ConfigTimer.Change(2000, 0);
            } else {
                File.WriteAllText(Application.StartupPath + @"\Config.ini", JsonConvert.SerializeObject(Options, Formatting.Indented));
            }
        }
    }

    public class Options {
        public GeneralOptions General { get; set; } = new GeneralOptions();
        public BindingOptions Binding { get; set; } = new BindingOptions();

        public class GeneralOptions {
            public string ClientTitle { get; set; } = "LOST ARK";
            public bool ToggleAPassthrough { get; set; } = false;
            public bool ToggleBPassthrough { get; set; } = true;
            public bool BindingPassthrough { get; set; } = true;
            public bool ToggleAAudio { get; set; } = true;
            public bool ToggleBAudio { get; set; } = false;
            public string EnabledAudioFile { get; set; } = "toggleon.mp3";
            public string DisabledAudioFile { get; set; } = "toggleoff.mp3";
            public double EnabledAudioVolume { get; set; } = 0.25;
            public double DisabledAudioVolume { get; set; } = 0.35;
        }

        public class BindingOptions {
            public List<Keys> SkillBindings { get; set; } = new List<Keys>();
            public Keys ToggleA { get; set; } = Keys.None;
            public Keys ToggleB { get; set; } = Keys.None;
            public Keys Up { get; set; } = Keys.W;
            public Keys Down { get; set; } = Keys.S;
            public Keys Left { get; set; } = Keys.A;
            public Keys Right { get; set; } = Keys.D;
            public Keys A { get; set; } = Keys.None;
            public Keys B { get; set; } = Keys.None;
            public Keys X { get; set; } = Keys.None;
            public Keys Y { get; set; } = Keys.None;
            public Keys L1 { get; set; } = Keys.None;
            public Keys L2 { get; set; } = Keys.None;
            public Keys R1 { get; set; } = Keys.None;
            public Keys R2 { get; set; } = Keys.None;
            public Keys Start { get; set; } = Keys.None;
            public Keys Back { get; set; } = Keys.None;
        }
    }
}
