using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SimulationCraftBlowtorchImport
{
    public partial class Form1 : Form
    {
        static readonly Regex trimmer = new Regex(@" +");

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonParseScalingFactors_Click(object sender, EventArgs e)
        {
            if (labelFolder.Text.Length > 0)
            {

                List<ProfileValues> parsed = new List<ProfileValues>();
                List<ProfileValues> tempParsed;

                string[] logFiles = Array.FindAll(Directory.GetFiles(@labelFolder.Text), f => !f.ToLower().Contains("bonus"));

                for (int x = 0; x < logFiles.Length; x++)
                {
                    tempParsed = ParseFromFile(@logFiles[x]);
                    parsed.AddRange(tempParsed);
                }

                List<ProfileValues> sortedParsed = parsed.OrderBy(x => x.MainTargetCount).ThenBy(x => x.FightSubType).ThenBy(x => x.ScaleDirection).ThenBy(x => x.Level100).ThenBy(x => x.FightType).ThenBy(x => x.Level90).ThenBy(x => x.Level75).ThenBy(x => x.Level45).ToList();

                StringBuilder textOutput = new StringBuilder();
                textOutput.AppendLine("Profile Name\tScaleDir\tL100\tL90\tL75\tL45\tFight\tTarg\tSub\tInt\tSP\tCrit\tHaste\tMast\tMult\tVers\tDPS");

                foreach (ProfileValues p in sortedParsed)
                {
                    textOutput.AppendLine(p.ProfileName + "\t" + p.ScaleDirection + "\t" + p.Level100 + "\t" + p.Level90 + "\t" + p.Level75 + "\t" + p.Level45 + "\t" + p.FightType + "\t" + p.MainTargetCount + "\t" + p.FightSubType + "\t" + p.Intellect + "\t" + p.SpellPower + "\t" + p.Crit + "\t" + p.Haste + "\t" + p.Mastery + "\t" + p.Multistrike + "\t" + p.Versatility + "\t" + p.DPS);
                }

                rtbOutput.Text = textOutput.ToString();
            }
        }

        private void buttonParseBonuses_Click(object sender, EventArgs e)
        {
            if (labelFolder.Text.Length > 0)
            {

                List<ProfileValues> parsed = new List<ProfileValues>();
                List<ProfileValues> tempParsed;

                string[] logFiles = Array.FindAll(Directory.GetFiles(@labelFolder.Text), f => f.ToLower().Contains("bonus"));

                for (int x = 0; x < logFiles.Length; x++)
                {
                    tempParsed = ParseFromFile(@logFiles[x]);
                    parsed.AddRange(tempParsed);
                }

                List<ProfileValues> sortedParsed = parsed.OrderBy(x => x.MainTargetCount).ThenBy(x => x.FightSubType).ThenBy(x => x.No2P).ThenBy(x => x.No4P).ThenBy(x => x.NoLegendaryRing).ThenBy(x => x.Level100.ToLower()).ThenBy(x => x.FightType).ThenBy(x => x.Level90).ThenBy(x => x.Level75).ThenBy(x => x.Level45).ToList();

                StringBuilder textOutput = new StringBuilder();
                textOutput.AppendLine("Profile Name\tL100\tL90\tL75\tL45\tFight\tTarg\tSub\tDPS\tNo4P\tNo2P\tNoLR");

                foreach (ProfileValues p in sortedParsed)
                {
                    textOutput.AppendLine(p.ProfileName + "\t" + p.Level100 + "\t" + p.Level90 + "\t" + p.Level75 + "\t" + p.Level45 + "\t" + p.FightType + "\t" + p.MainTargetCount + "\t" + p.FightSubType + "\t" + p.DPS + "\t" + p.No4P + "\t" + p.No2P + "\t" + p.NoLegendaryRing);
                }

                rtbOutput.Text = textOutput.ToString();
            }
        }

        public List<ProfileValues> ParseFromFile(string @FilePath)
        {
            List<ProfileValues> profiles = new List<ProfileValues>();
            string line;
            bool gettingDpsRanking = false;
            bool gettingScaleFactors = false;
            string fileName = Path.GetFileNameWithoutExtension(FilePath);

            string[] fileNameParts = fileName.Replace("no_bonuses", "nobonuses").Split('_');

            int mainTargetCount = Convert.ToInt32(fileNameParts[6].Replace("target", ""));

            string fightSubType = string.Empty;

            if (fileNameParts.Length == 8)
            {
                fightSubType = fileNameParts[7];
            }

            StreamReader logFile = new StreamReader(FilePath);
            
            while((line = logFile.ReadLine()) != null)
            {
                line = line.Trim();
                line = trimmer.Replace(line, " "); //Get rid of double spacing.
                if (gettingDpsRanking)
                {
                    if (String.IsNullOrWhiteSpace(line))
                    {
                        gettingDpsRanking = false;
                    }
                    else if (line.ToLower().Contains("100.0% raid"))
                    {
                        //Throw away
                    }
                    else
                    {
                        string[] splitVals = line.Split(' ');
                        string[] splitName = splitVals[2].Split('_');

                        ProfileValues tempProfile = new ProfileValues()
                        {
                            ProfileName = splitVals[2]
                            ,ScaleDirection = fileNameParts[4]
                            ,FightType = fileNameParts[5]
                            ,MainTargetCount = mainTargetCount
                            ,FightSubType = fightSubType
                            ,Level100 = splitName[1]
                            ,Level90 = "Halo"
                            ,Level75 = splitName[2]
                            ,Level45 = splitName[3]
                            ,DPS = Convert.ToInt32(splitVals[0])
                        };                        

                        if (splitName.Length > 4 && splitName[4].ToLower() == "no")
                        {
                            if (splitName[5].ToLower() == "4p")
                            {
                                tempProfile.No4P = true;
                                if (splitName.Length == 7 && splitName[6].ToLower() == "2p")
                                {
                                    tempProfile.No2P = true;
                                }
                            }
                            else if (splitName[5].ToLower() == "legendary")
                            {
                                tempProfile.NoLegendaryRing = true;
                            }
                        }

                        profiles.Add(tempProfile);
                    }
                }
                else if (gettingScaleFactors)
                {
                    if (String.IsNullOrWhiteSpace(line))
                    {
                        gettingScaleFactors = false;
                    }
                    else if (line.ToLower().Contains("weights :")) //This is in-line; we want to grab from summary!
                    {
                        gettingScaleFactors = false;
                    }
                    else
                    {
                        string[] splitVals = line.Split(' ');
                        int id = profiles.FindIndex(x => x.ProfileName == splitVals[0]);

                        for (int x = 1; x < splitVals.Length; x++)
                        {
                            string[] scaleFactor = splitVals[x].Split(new char[] { '=', '(', ')' });
                            double scaleValue = Convert.ToDouble(scaleFactor[1]);

                            switch (scaleFactor[0].ToLower())
                            {
                                case "int":
                                    profiles[id].Intellect = scaleValue;
                                    break;
                                case "sp":
                                    profiles[id].SpellPower = scaleValue;
                                    break;
                                case "crit":
                                    profiles[id].Crit = scaleValue;
                                    break;
                                case "haste":
                                    profiles[id].Haste = scaleValue;
                                    break;
                                case "mastery":
                                    profiles[id].Mastery = scaleValue;
                                    break;
                                case "mult":
                                    profiles[id].Multistrike = scaleValue;
                                    break;
                                case "vers":
                                    profiles[id].Versatility = scaleValue;
                                    break;
                                case "runspeed":
                                    profiles[id].RunSpeed = scaleValue;
                                    break;
                                default:
                                    break;
                            }
                        }

                    }
                }
                else if (line.ToLower().Contains("dps ranking:"))
                {
                    gettingDpsRanking = true;
                }
                else if (line.ToLower().Contains("scale factors:"))
                {
                    gettingScaleFactors = true;
                }
            }

            return profiles;
        }

        private void buttonSelectFolder_Click(object sender, EventArgs e)
        {
            if (fbdLogFolder.ShowDialog() == DialogResult.OK)
            {
                labelFolder.Text = fbdLogFolder.SelectedPath;
            }
        }
    }
}
