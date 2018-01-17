﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using DSA_Project;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Project.Tests
{
    [TestClass()]
    public class LoadXMLTalentFileTests
    {
        private Interface_LoadXMLTalentFile loader;
        private String ResourcePath;

        private Type currentType;
        private String currentName;
        private String currentComplexeName;
        private String currentProbeStringOne;
        private String currentProbeStringTwo;
        private String currentBE;
        private String currentDeviate;
        private String currentTAW;
        private String currentTAWBonus;
        private String currentRequirementString;
        private String currentPA;
        private int currentProbeValueAT;
        private int currentProbeValuePA;
        private int currentProbeCount;
        private int currentAT;

        [TestInitialize()]
        public void initialize()
        {
            loader = new LoadXMLTalentFile();
            ResourcePath = ManagmentSaveStrings.currentDirectory;
            ResourcePath = Path.Combine(ResourcePath, ManagmentSaveStrings.Recources);
            ResourcePath = Path.Combine(ResourcePath, "TestResources");
            ResourcePath = Path.Combine(ResourcePath, ManagmentSaveStrings.TalentLocation);
            ResourcePath = Path.Combine(ResourcePath, "Test_LoadXMLTalentFile");
        }
        [TestCleanup()]
        public void testCleanup()
        {
            loader = null;
            ResourcePath = null;

            currentType = null;
            currentName = null;
            currentComplexeName = null;
            currentProbeStringOne = null;
            currentProbeStringTwo = null;
            currentBE = null;
            currentDeviate = null;
            currentTAW = null;
            currentTAWBonus = null;
            currentRequirementString = null;
            currentPA = null;

            currentAT = 0;
            currentProbeCount = 0;
            currentProbeValueAT = 0;
            currentProbeValuePA = 0;
        }


        public void controllInterfaceTalent(InterfaceTalent talent)
        {
            Assert.AreEqual(currentType, talent.GetType());
            Assert.AreEqual(currentName, talent.getName());
            Assert.AreEqual(currentComplexeName, talent.getComplexName());
            Assert.AreEqual(currentProbeCount, talent.getProbeCount());
            Assert.AreEqual(currentProbeStringOne, talent.getProbeStringOne());
            Assert.AreEqual(currentProbeStringTwo, talent.getProbeStringTwo());

            Assert.AreEqual(currentBE, talent.getBe());
            Assert.AreEqual(currentDeviate, talent.getDeviateString());
            Assert.AreEqual(currentTAW, talent.getTaW());
            Assert.AreEqual(currentTAWBonus, talent.getTAWBonus());
        }
        public void controllTalentGeneral(notFighting talent)
        {
            Assert.AreEqual(currentRequirementString, talent.getRequirementString());
        }
        public void controllTalentFighting(TalentFighting talent)
        {
            Assert.AreEqual(currentAT, talent.getAT());
            Assert.AreEqual(currentPA, talent.getPA());
            Assert.AreEqual(currentProbeValueAT, talent.getProbeValueAT());
            Assert.AreEqual(currentProbeValuePA, talent.getProbeValuePA());
        }

        //##########################################################################################################################
        //Teste Laden der Basic Structur
        [TestMethod()]
        public void loadBasicStructurTalentGeneral()
        {
            String file = Path.Combine(ResourcePath, "Basic_Construction_01.xml");
            currentName = "BasicConstructionTalent01";
            currentComplexeName = "BasicConstructionTalent01";
            currentProbeStringOne = "-";
            currentProbeStringTwo = "";
            currentBE = "-";
            currentDeviate = "-";
            currentTAW = "-";
            currentTAWBonus = "0";
            currentProbeCount = 0;
            currentRequirementString = "-";

            TalentGeneral talent = loader.loadFile<TalentGeneral>(file);
            currentType = typeof(TalentGeneral);

            controllInterfaceTalent(talent);
            controllTalentGeneral(talent);
        }
        [TestMethod()]
        public void loadBasicStructurTalentCrafting()
        {
            String file = Path.Combine(ResourcePath, "Basic_Construction_01.xml");
            currentName = "BasicConstructionTalent01";
            currentComplexeName = "BasicConstructionTalent01";
            currentProbeStringOne = "-";
            currentProbeStringTwo = "";
            currentBE = "-";
            currentDeviate = "-";
            currentTAW = "-";
            currentTAWBonus = "0";
            currentProbeCount = 0;
            currentRequirementString = "-";

            InterfaceTalent talent = loader.loadFile<TalentCrafting>(file);
            currentType = typeof(TalentCrafting);

            controllInterfaceTalent(talent);
            controllTalentGeneral((TalentCrafting)talent);
        }
        [TestMethod()]
        public void loadBasicStructurTalentKnowldage()
        {
            String file = Path.Combine(ResourcePath, "Basic_Construction_01.xml");
            currentName = "BasicConstructionTalent01";
            currentComplexeName = "BasicConstructionTalent01";
            currentProbeStringOne = "-";
            currentProbeStringTwo = "";
            currentBE = "-";
            currentDeviate = "-";
            currentTAW = "-";
            currentTAWBonus = "0";
            currentProbeCount = 0;
            currentRequirementString = "-";

            InterfaceTalent talent = loader.loadFile<TalentKnwoldage>(file);
            currentType = typeof(TalentKnwoldage);

            controllInterfaceTalent(talent);
            controllTalentGeneral((TalentKnwoldage)talent);
        }
        [TestMethod()]
        public void loadBasicStructurTalentNature()
        {
            String file = Path.Combine(ResourcePath, "Basic_Construction_01.xml");
            currentName = "BasicConstructionTalent01";
            currentComplexeName = "BasicConstructionTalent01";
            currentProbeStringOne = "-";
            currentProbeStringTwo = "";
            currentBE = "-";
            currentDeviate = "-";
            currentTAW = "-";
            currentTAWBonus = "0";
            currentProbeCount = 0;
            currentRequirementString = "-";

            InterfaceTalent talent = loader.loadFile<TalentNature>(file);
            currentType = typeof(TalentNature);

            controllInterfaceTalent(talent);
            controllTalentGeneral((TalentNature)talent);
        }
        [TestMethod()]
        public void loadBasicStructurTalentPhysical()
        {
            String file = Path.Combine(ResourcePath, "Basic_Construction_01.xml");
            currentName = "BasicConstructionTalent01";
            currentComplexeName = "BasicConstructionTalent01";
            currentProbeStringOne = "-";
            currentProbeStringTwo = "";
            currentBE = "-";
            currentDeviate = "-";
            currentTAW = "-";
            currentTAWBonus = "0";
            currentProbeCount = 0;
            currentRequirementString = "-";

            InterfaceTalent talent = loader.loadFile<TalentPhysical>(file);
            currentType = typeof(TalentPhysical);

            controllInterfaceTalent(talent);
            controllTalentGeneral((TalentPhysical)talent);
        }
        [TestMethod()]
        public void loadBasicStructurTalentSocial()
        {
            String file = Path.Combine(ResourcePath, "Basic_Construction_01.xml");
            currentName = "BasicConstructionTalent01";
            currentComplexeName = "BasicConstructionTalent01";
            currentProbeStringOne = "-";
            currentProbeStringTwo = "";
            currentBE = "-";
            currentDeviate = "-";
            currentTAW = "-";
            currentTAWBonus = "0";
            currentProbeCount = 0;
            currentRequirementString = "-";

            InterfaceTalent talent = loader.loadFile<TalentSocial>(file);
            currentType = typeof(TalentSocial);

            controllInterfaceTalent(talent);
            controllTalentGeneral((TalentSocial)talent);
        }

        [TestMethod()]
        public void loadBasicStructurGiftTalent()
        {
            String file = Path.Combine(ResourcePath, "Basic_Construction_01.xml");
            currentName = "BasicConstructionTalent01";
            currentComplexeName = "BasicConstructionTalent01";
            currentProbeStringOne = "-";
            currentProbeStringTwo = "";
            currentBE = "-";
            currentDeviate = "";   //Der Unterschied ist Tatsächlich Vorhanden!
            currentTAW = "-";
            currentTAWBonus = "0";
            currentProbeCount = 0;
            currentRequirementString = "";    

            InterfaceTalent talent = loader.loadFile<GiftTalent>(file);
            currentType = typeof(GiftTalent);

            controllInterfaceTalent(talent);
            controllTalentGeneral((notFighting)talent);
        }

        [TestMethod()]
        public void loadBasicStructurTalentFighting()
        {
            String file = Path.Combine(ResourcePath, "Basic_Construction_01.xml");
            currentName = "BasicConstructionTalent01";
            currentComplexeName = "BasicConstructionTalent01";
            currentProbeStringOne = "0";
            currentProbeStringTwo = "0";
            currentBE = "-";
            currentDeviate = "-";
            currentTAW = "-";
            currentTAWBonus = "0";
            currentProbeCount = 2;

            currentAT = 0;
            currentPA = "---";
            currentProbeValueAT = 0;
            currentProbeValuePA = 0;

            InterfaceTalent talent = loader.loadFile<TalentFighting>(file);
            currentType = typeof(TalentFighting);

            controllInterfaceTalent(talent);
            controllTalentFighting((TalentFighting)talent);
        }
        [TestMethod()]
        public void loadBasicStructurTalentClose()
        {
            String file = Path.Combine(ResourcePath, "Basic_Construction_01.xml");
            currentName = "BasicConstructionTalent01";
            currentComplexeName = "BasicConstructionTalent01";
            currentProbeStringOne = "0";
            currentProbeStringTwo = "0";
            currentBE = "-";
            currentDeviate = "-";
            currentTAW = "-";
            currentTAWBonus = "0";
            currentProbeCount = 2;

            currentAT = 0;
            currentPA = "---";
            currentProbeValueAT = 0;
            currentProbeValuePA = 0;

            InterfaceTalent talent = loader.loadFile<TalentClose>(file);
            currentType = typeof(TalentClose);

            controllInterfaceTalent(talent);
            controllTalentFighting((TalentFighting)talent);
        }
        [TestMethod()]
        public void loadBasicStructurTalentRange()
        {
            String file = Path.Combine(ResourcePath, "Basic_Construction_01.xml");
            currentName = "BasicConstructionTalent01";
            currentComplexeName = "BasicConstructionTalent01";
            currentProbeStringOne = "0";
            currentProbeStringTwo = "0";
            currentBE = "-";
            currentDeviate = "-";
            currentTAW = "-";
            currentTAWBonus = "0";
            currentProbeCount = 2;

            currentAT = 0;
            currentPA = "---";
            currentProbeValueAT = 0;
            currentProbeValuePA = 0;

            InterfaceTalent talent = loader.loadFile<TalentRange>(file);
            currentType = typeof(TalentRange);

            controllInterfaceTalent(talent);
            controllTalentFighting((TalentFighting)talent);
        }
        [TestMethod()]
        public void loadBasicStructurTalentWeaponless()
        {
            String file = Path.Combine(ResourcePath, "Basic_Construction_01.xml");
            currentName = "BasicConstructionTalent01";
            currentComplexeName = "BasicConstructionTalent01";
            currentProbeStringOne = "0";
            currentProbeStringTwo = "0";
            currentBE = "-";
            currentDeviate = "-";
            currentTAW = "-";
            currentTAWBonus = "0";
            currentProbeCount = 2;

            currentAT = 0;
            currentPA = "---";
            currentProbeValueAT = 0;
            currentProbeValuePA = 0;

            InterfaceTalent talent = loader.loadFile<TalentWeaponless>(file);
            currentType = typeof(TalentWeaponless);

            controllInterfaceTalent(talent);
            controllTalentFighting((TalentFighting)talent);
        }
        //##########################################################################################################################
    }
}