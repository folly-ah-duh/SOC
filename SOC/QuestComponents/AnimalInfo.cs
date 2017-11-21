using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOC.QuestComponents
{
    public static class AnimalInfo
    {
        public static string[] animals =
        {
            "Sheep",
            "Cashmere_Goat",
            "Boer_Goat",
            "Nubian",
            "Donkey",
            "Zebra",
            "Okapi",
            "Wolf",
            "Jackal",
            "African_Wild_Dog",
            "Bear",
        };

        public static string[] AnimalTypes = new string[] {
            "TppGoat",
            "TppNubian",
            "TppZebra",
            "TppWolf",
            "TppJackal",
            "TppBear"
        };

        public static string getAnimalCategory(string animalName)
        {
            switch(animalName) {
                case "Sheep":
                case "Cashmere_Goat":
                case "Boer_Goat":
                case "Nubian":
                case "Donkey":
                case "Zebra":
                case "Okapi":
                    return "animal";
                case "Wolf":
                case "Jackal":
                case "African_Wild_Dog":
                    return "wolf";
            }
            return "bear";
        }

        public static string getAnimalType(string animalName)
        {
            switch(animalName)
            {
                case "Sheep":
                case "Cashmere_Goat":
                    return "TppGoat";
                    
                case "Boer_Goat":
                case "Nubian":
                    return "TppNubian";

                case "Donkey":
                case "Okapi":
                case "Zebra":
                    return "TppZebra";

                
                case "Wolf":
                    return "TppWolf";

                case "African_Wild_Dog":
                case "Jackal":
                    return "TppJackal";
                
                case "Bear":
                    return "TppBear";
            }
            return "TppBear";
        }

        public static void getAnimalPaths(string animalName, out string partsPath, out string mtarPath, out string mogPath, out string fv2Path)
        {
            partsPath = ""; mtarPath = ""; mogPath = ""; fv2Path = "";

            switch (animalName)
            {
                case "Sheep":
                    partsPath = "/Assets/tpp/parts/chara/kkl/kkl0_main0_def_v00.parts";
                    mtarPath = "/Assets/tpp/motion/motion_graph/goat/Goat_layers.mog";
                    mogPath = "/Assets/tpp/motion/mtar/goat/Goat_layers.mtar";
                    fv2Path = "/Assets/tpp/fova/chara/kkl/kkl_v00.fv2";
                    break;
                case "Cashmere_Goat":
                    partsPath = "/Assets/tpp/parts/chara/kkl/kkl0_main0_def_v00.parts";
                    mtarPath = "/Assets/tpp/motion/motion_graph/goat/Goat_layers.mog";
                    mogPath = "/Assets/tpp/motion/mtar/goat/Goat_layers.mtar";
                    fv2Path = "/Assets/tpp/fova/chara/got/got0_kkl_v00.fv2";
                    break;
                case "Boer_Goat":
                    partsPath = "/Assets/tpp/parts/chara/bor/bor0_main0_def_v00.parts";
                    mtarPath = "/Assets/tpp/motion/motion_graph/goat/Goat_layers.mog";
                    mogPath = "/Assets/tpp/motion/mtar/goat/Goat_layers.mtar";
                    fv2Path = "/Assets/tpp/fova/chara/bor/bor0_v00.fv2";
                    break;
                case "Nubian":
                    partsPath = "/Assets/tpp/parts/chara/nbn/nbn0_main0_def_v00.parts";
                    mtarPath = "/Assets/tpp/motion/motion_graph/goat/Goat_layers.mog";
                    mogPath = "/Assets/tpp/motion/mtar/goat/Goat_layers.mtar";
                    fv2Path = "/Assets/tpp/fova/chara/nbn/nbn_v00.fv2";
                    break;
                case "Donkey":
                    partsPath = "/Assets/tpp/parts/chara/dnk/dnk0_main0_def_v00.parts";
                    mtarPath = "/Assets/tpp/motion/motion_graph/zebra/TppZebra_layers.mog";
                    mogPath = "/Assets/tpp/motion/mtar/zebra/Zebra_layers.mtar";
                    fv2Path = "";
                    break;
                case "Zebra":
                    partsPath = "/Assets/tpp/parts/chara/zbr/zbr0_main0_def_v00.parts";
                    mtarPath = "/Assets/tpp/motion/motion_graph/zebra/TppZebra_layers.mog";
                    mogPath = "/Assets/tpp/motion/mtar/zebra/Zebra_layers.mtar";
                    fv2Path = "";
                    break;
                case "Okapi":
                    partsPath = "/Assets/tpp/parts/chara/okp/okp0_main0_def_v00.parts";
                    mtarPath = "/Assets/tpp/motion/motion_graph/zebra/TppZebra_layers.mog";
                    mogPath = "/Assets/tpp/motion/mtar/zebra/Zebra_layers.mtar";
                    fv2Path = "";
                    break;
                case "Wolf":
                    partsPath = "/Assets/tpp/parts/chara/wlf/wlf0_main0_def_v00.parts";
                    mtarPath = "/Assets/tpp/motion/mtar/wolf/Wolf_layers.mtar";
                    mogPath = "/Assets/tpp/motion/motion_graph/wolf/Wolf_layers.mog";
                    fv2Path = "";
                    break;
                case "Jackal":
                    partsPath = "/Assets/tpp/parts/chara/jcl/jcl0_main0_def_v00.parts";
                    mtarPath = "/Assets/tpp/motion/mtar/wolf/Wolf_layers.mtar";
                    mogPath = "/Assets/tpp/motion/motion_graph/wolf/Wolf_layers.mog";
                    fv2Path = "/Assets/tpp/fova/chara/jcl/jcl0_v00_c00.fv2";
                    break;
                case "African_Wild_Dog":
                    partsPath = "/Assets/tpp/parts/chara/lyc/lyc0_main0_def_v00.parts";
                    mtarPath = "/Assets/tpp/motion/mtar/wolf/Wolf_layers.mtar";
                    mogPath = "/Assets/tpp/motion/motion_graph/wolf/Wolf_layers.mog";
                    fv2Path = "/Assets/tpp/fova/chara/jcl/jcl0_v00_c00.fv2";
                    break;
                case "Bear":
                    partsPath = "/Assets/tpp/parts/chara/ber/ber0_main0_def_v00.parts";
                    mtarPath = "/Assets/tpp/motion/mtar/bear/Bear_layers.mtar";
                    mogPath = "/Assets/tpp/motion/motion_graph/bear/Bear_layers.mog";
                    fv2Path = "/Assets/tpp/fova/chara/ber/ber0_c00.fv2";
                    break;

            }
        }
    }
}
