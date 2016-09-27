using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;

namespace PriestBestInSlot
{
    public partial class Default : System.Web.UI.Page
    {
       /*
        double[] SecondaryScaling = {
                                    1.0,                        // 0
                                    1.0, 1.0, 1.0, 1.0, 1.0,    // 5
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,
                                    1.0, 1.0, 1.0, 1.0, 1.0,                                        //800
                                    0.994435486,0.988901936,0.983399178,0.977927039,0.972485351,    //805                                    0.967073942,0.961692646,0.956341294,0.95101972,0.945727757,     //810                                    0.940465242,0.93523201,0.930027899,0.924852745,0.91970639,      //815                                    0.914588671,0.909499429,0.904438507,0.899405746,0.894400991,    //820                                    0.889424084,0.884474871,0.879553199,0.874658913,0.869791861,    //825                                    0.864951892,0.860138855,0.855352601,0.850592979,0.845859843,    //830                                    0.841153044,0.836472436,0.831817874,0.827189212,0.822586306,    //835                                    0.818009013,0.813457191,0.808930697,0.804429391,0.799953132,    //840                                    0.795501782,0.791075201,0.786673252,0.782295798,0.777942702,    //845                                    0.773613829,0.769309044,0.765028214,0.760771204,0.756537882,    //850                                    0.752328116,0.748141776,0.743978731,0.739838851,0.735722007,    //855                                    0.731628072,0.727556917,0.723508417,0.719482444,0.715478874,    //860                                    0.711497582,0.707538444,0.703601336,0.699686137,0.695792724,    //865                                    0.691920975,0.688070772,0.684241992,0.680434518,0.676648231,    //870                                    0.672883012,0.669138746,0.665415314,0.661712601,0.658030492,    //875                                    0.654368872,0.650727628,0.647106645,0.643505811,0.639925014,    //880                                    0.636364142,0.632823085,0.629301732,0.625799974,0.622317701,    //885                                    0.618854806,0.61541118,0.611986716,0.608581307,0.605194848,     //890                                    0.601827233,0.598478357,0.595148116,0.591836406,0.588543124,    //895                                    0.585268168,0.582011435,0.578772824,0.575552235,0.572349566,    //900                                    0.569164719,0.565997594,0.562848093,0.559716117,0.556601569,    //905                                    0.553504352,0.550424369,0.547361525,0.544315724,0.541286872,    //910                                    0.538274873,0.535279635,0.532301064,0.529339068,0.526393553,    //915                                    0.523464429,0.520551604,0.517654987,0.514774489,0.511910019,    //920                                    0.509061489,0.506228809,0.503411892,0.500610649,0.497824994,    //925                                    0.49505484,0.492300101,0.48956069,0.486836523,0.484127514,      //930                                    0.48143358,0.478754636,0.476090599,0.473441387,0.470806916,     //935                                    0.468187104,0.46558187,0.462991133,0.460414813,0.457852828      //940
                                    };
        * */

        //Mythic Combined
        //double[] ShadowMythicStatWeights = {
        //                  1.0000,     //Int           0
        //                  0.9069,     //Spell Power   1
        //                  0.9660,     //Crit          2
        //                  0.8355,     //Haste         3
        //                  0.5520,     //Mastery       4
        //                  0.7062,     //Multistrike   5
        //                  0.6734,     //Versatility   6
        //                  0.1118,     //DPS/Int       7
        //                  0.0         //Combined Stats for Bonuses  8
        //                  };

        ////Mythic Auspicious Spirits
        //double[] ShadowASMythicStatWeights = {
        //                  1.0000,     //Int           0
        //                  0.9066,     //Spell Power   1
        //                  1.0729,     //Crit          2
        //                  0.8429,     //Haste         3
        //                  0.4907,     //Mastery       4
        //                  0.6946,     //Multistrike   5
        //                  0.6529,     //Versatility   6
        //                  0.1125,     //DPS/Int       7
        //                  1.0         //AS Stats for Bonuses  8
        //                  };

        ////Mythic Clarity of Power
        //double[] ShadowCoPMythicStatWeights = {
        //                  1.0000,     //Int           0
        //                  0.9057,     //Spell Power   1
        //                  0.7592,     //Crit          2
        //                  0.8540,     //Haste         3
        //                  0.6198,     //Mastery       4
        //                  0.6584,     //Multistrike   5
        //                  0.6427,     //Versatility   6
        //                  0.1118,     //DPS/Int       7
        //                  2.0         //CoP Stats for Bonuses  8
        //                  };

        ////Mythic Clarity of Power 1 Target
        //double[] ShadowCoP1TarMythicStatWeights = {
        //                  1.0000,     //Int           0
        //                  0.9064,     //Spell Power   1
        //                  0.6849,     //Crit          2
        //                  0.7438,     //Haste         3
        //                  0.6899,     //Mastery       4
        //                  0.6415,     //Multistrike   5
        //                  0.6281,     //Versatility   6
        //                  0.1111,     //DPS/Int       7
        //                  3.0         //CoP 1 Target Stats for Bonuses  8
        //                  };

        ////Mythic Void Entropy
        //double[] ShadowVEntMythicStatWeights = {
        //                  1.0000,     //Int           0
        //                  0.9055,     //Spell Power   1
        //                  0.8581,     //Crit          2
        //                  0.7030,     //Haste         3
        //                  0.4973,     //Mastery       4
        //                  0.7051,     //Multistrike   5
        //                  0.6866,     //Versatility   6
        //                  0.1194,     //DPS/Int       7
        //                  4.0         //VEnt Stats for Bonuses  8
        //                  };


        double[] ShadowHeroicENStatWeights = {
                          1.00,     //Int           0
                          0.00,     //Spell Power   1
                          1.25,     //Crit          2
                          1.39,     //Haste         3
                          1.05,     //Mastery       4
                          0.00,     //Multistrike   5
                          0.94,     //Versatility   6
                          0.10,     //DPS/Int       7
                          0.0       //Combined Stats for Bonuses  8
                          };

        //Heroic S2M
        double[] ShadowS2MHeroicENStatWeights = {
                          1.00,     //Int           0
                          0.00,     //Spell Power   1
                          1.26,     //Crit          2
                          1.78,     //Haste         3
                          1.07,     //Mastery       4
                          0.00,     //Multistrike   5
                          0.94,     //Versatility   6
                          0.09,     //DPS/Int       7
                          1.0       //S2M Stats for Bonuses  8
                          };

        //Heroic LotV + MSp
        double[] ShadowLotVMSpHeroicENStatWeights = {
                          1.00,     //Int           0
                          0.00,     //Spell Power   1
                          1.25,     //Crit          2
                          1.20,     //Haste         3
                          1.03,     //Mastery       4
                          0.00,     //Multistrike   5
                          0.94,     //Versatility   6
                          0.10,     //DPS/Int       7
                          2.0       //S2M Stats for Bonuses  8
                          };

        //double[] ShadowNormalStatWeights = {
        //                  1.00,     //Int           0
        //                  0.75,     //Spell Power   1
        //                  0.66,     //Crit          2
        //                  0.66,     //Haste         3
        //                  0.66,     //Mastery       4
        //                  0.50,     //Multistrike   5
        //                  0.50,     //Versatility   6
        //                  0.12      //DPS/Int       7
        //                  };      

        public struct MHOHCombo
        {
            public ItemTotals MH,
                              OH;
        }

        public string Shadow_Generate_MHOHCombos(ItemTotals[] MainHand, ItemTotals[] OffHand, int Site, int size, int DataSource) //1=MMO/WoWDB, 2=WoWHead
        {
            string sourceDB;

            if (DataSource == 1)
            {
                sourceDB = "http://www.wowdb.com/items/";
            }
            else if (DataSource == 2)
            {
                sourceDB = "http://www.wowhead.com/item=";
            }
            else
            {
                sourceDB = "http://www.wowdb.com/items/";
            }

            string returnString = "";
            double gemSpirit = 0;
            //Array.Sort(MainHand, (x, y) => string.Compare(x.TotalHitSpirit.ToString("0000.000000"), y.TotalHitSpirit.ToString("0000.000000")));
            //Array.Sort(OffHand, (x, y) => string.Compare(x.TotalHitSpirit.ToString("0000.000000"), y.TotalHitSpirit.ToString("0000.000000")));

            if (Site == 3)
            {
                returnString = "[ol]";
            }
            else
            {
                returnString = "[LIST=1]";
            }
            return "";
        }

        public struct ItemTotals
        {
            public double Total,
                ItemLevel,
                Int,
                Crit,
                Haste,
                Mastery,
                Versatility,
                cInt,
                cCrit,
                cHaste,
                cMastery,
                cVersatility,
                pInt,
                pCrit,
                pHaste,
                pMastery,
                pVersatility,
                SetBonus1,
                SetBonus2,
                OtherBonus1,
                OtherBonus2,
                ProcTotal,
                cProcTotal,
                pProcTotal,
                Warforged;
            public int OfTheID;
            public bool Vendor,
                Gem;
            public string Name,
                   Source,
                   Link,
                   SetDescription,
                   SetBonus2PString,
                   SetBonus4PString,
                   ItemType,
                   SourceType,
                   Tier,
                   OtherBonus1Description,
                   OtherBonus2Description,
                   Bonuses,
                   WarforgedId;
            public List<ItemTotals> WarforgedItems;
        }

        public ItemTotals[] Compute_Totals_Shadow(string Slot, int queryType, double[] StatWeights)
        {
            DataView dvItemsList;

            if (queryType == 1)
            {
                SDS_ItemsList.SelectParameters[0].DefaultValue = Slot;
                dvItemsList = (DataView)SDS_ItemsList.Select(DataSourceSelectArguments.Empty);
            }
            else if (queryType == 2)
            {
                SDS_ItemsList_Preraid.SelectParameters[0].DefaultValue = Slot;
                dvItemsList = (DataView)SDS_ItemsList_Preraid.Select(DataSourceSelectArguments.Empty);
            }
            else if (queryType == 3)
            {
                SDS_Highmaul.SelectParameters[0].DefaultValue = Slot;
                dvItemsList = (DataView)SDS_Highmaul.Select(DataSourceSelectArguments.Empty);
            }
            else if (queryType == 4)
            {
                SDS_Crafted.SelectParameters[0].DefaultValue = Slot;
                dvItemsList = (DataView)SDS_Crafted.Select(DataSourceSelectArguments.Empty);
            }
            else if (queryType == 5)
            {
                SDS_NoCrafted.SelectParameters[0].DefaultValue = Slot;
                dvItemsList = (DataView)SDS_NoCrafted.Select(DataSourceSelectArguments.Empty);
            }
            else
            {
                throw new Exception();
            }

            ItemTotals[] ItemsList = new ItemTotals[dvItemsList.Count];
            DataRowView drvItemsList;
            double computedProc;

            for (int x = 0; x < dvItemsList.Count; x++)
            {
                drvItemsList = dvItemsList[x];

                ItemsList[x].pInt = Convert.ToInt32(drvItemsList["Intellect"].ToString());
                ItemsList[x].pCrit = Convert.ToInt32(drvItemsList["Crit"].ToString());
                ItemsList[x].pHaste = Convert.ToInt32(drvItemsList["Haste"].ToString());
                ItemsList[x].pMastery = Convert.ToInt32(drvItemsList["Mastery"].ToString());
                ItemsList[x].pVersatility = Convert.ToInt32(drvItemsList["Versatility"].ToString());

                ItemsList[x].Name = drvItemsList["ItemName"].ToString();
                ItemsList[x].SourceType = drvItemsList["SourceType"].ToString();
                ItemsList[x].Source = drvItemsList["Source"].ToString();
                ItemsList[x].Tier = drvItemsList["Tier"].ToString();
                ItemsList[x].Link = drvItemsList["Link"].ToString();
                ItemsList[x].Vendor = (bool)drvItemsList["Vendor"];
                ItemsList[x].SetDescription = drvItemsList["SetDescription"].ToString();
                ItemsList[x].SetBonus2PString = drvItemsList["SetBonus2PString"].ToString();
                ItemsList[x].SetBonus4PString = drvItemsList["SetBonus4PString"].ToString();
                ItemsList[x].ItemType = drvItemsList["ItemType"].ToString();
                ItemsList[x].ItemLevel = Convert.ToInt32(drvItemsList["ItemLevel"].ToString());
                ItemsList[x].Bonuses = drvItemsList["Bonuses"].ToString();
                ItemsList[x].Gem = Convert.ToBoolean(drvItemsList["Gems"]);
                ItemsList[x].Warforged = Convert.ToDouble(drvItemsList["Warforged"]);
                ItemsList[x].OfTheID = Convert.ToInt32(drvItemsList["OfTheID"].ToString());
                ItemsList[x].WarforgedId = drvItemsList["WarforgedId"].ToString();

                switch (Convert.ToInt32(StatWeights[8]))
                {
                    case 1:
                        ItemsList[x].SetBonus1 = Convert.ToDouble(drvItemsList["SetBonusShadow1S2M"].ToString());
                        ItemsList[x].SetBonus2 = Convert.ToDouble(drvItemsList["SetBonusShadow2S2M"].ToString());
                        computedProc = Convert.ToDouble(drvItemsList["ProcComputedShadowS2M"].ToString());
                        break;
                    case 2:
                        ItemsList[x].SetBonus1 = Convert.ToDouble(drvItemsList["SetBonusShadow1LotVMSp"].ToString());
                        ItemsList[x].SetBonus2 = Convert.ToDouble(drvItemsList["SetBonusShadow2LotVMSp"].ToString());
                        computedProc = Convert.ToDouble(drvItemsList["ProcComputedShadowLotVMSp"].ToString());
                        break;
                    case 0:
                    default:
                        ItemsList[x].SetBonus1 = Convert.ToDouble(drvItemsList["SetBonusShadow1"].ToString());
                        ItemsList[x].SetBonus2 = Convert.ToDouble(drvItemsList["SetBonusShadow2"].ToString());
                        computedProc = Convert.ToDouble(drvItemsList["ProcComputedShadow"].ToString());
                        break;
                }

                switch (drvItemsList["SetBonusShadow1Stat"].ToString())
                {
                    case "Intellect":
                        ItemsList[x].SetBonus1 *= StatWeights[0];
                        break;
                    //case "Spell Power":
                    //    ItemsList[x].SetBonus1 *= StatWeights[1];
                    //    break;
                    case "Crit":
                        ItemsList[x].SetBonus1 *= StatWeights[2];
                        break;
                    case "Haste":
                        ItemsList[x].SetBonus1 *= StatWeights[3];
                        break;
                    case "Mastery":
                        ItemsList[x].SetBonus1 *= StatWeights[4];
                        break;
                    //case "Multistrike":
                    //    ItemsList[x].SetBonus1 *= StatWeights[5];
                    //    break;
                    case "Versatility":
                        ItemsList[x].SetBonus1 *= StatWeights[6];
                        break;
                    case "DPS":
                        ItemsList[x].SetBonus1 *= StatWeights[7];
                        break;
                    case "PP":
                        break;
                    default:
                        break;
                }
                
                switch (drvItemsList["SetBonusShadow2Stat"].ToString())
                {
                    case "Intellect":
                        ItemsList[x].SetBonus2 *= StatWeights[0];
                        break;
                    //case "Spell Power":
                    //    ItemsList[x].SetBonus2 *= StatWeights[1];
                    //    break;
                    case "Crit":
                        ItemsList[x].SetBonus2 *= StatWeights[2];
                        break;
                    case "Haste":
                        ItemsList[x].SetBonus2 *= StatWeights[3];
                        break;
                    case "Mastery":
                        ItemsList[x].SetBonus2 *= StatWeights[4];
                        break;
                    //case "Multistrike":
                    //    ItemsList[x].SetBonus2 *= StatWeights[5];
                    //    break;
                    case "Versatility":
                        ItemsList[x].SetBonus2 *= StatWeights[6];
                        break;
                    case "DPS":
                        ItemsList[x].SetBonus2 *= StatWeights[7];
                        break;
                    case "PP":
                        break;
                    default:
                        break;
                }

                ItemsList[x].OtherBonus1 = Convert.ToDouble(drvItemsList["OtherBonusShadow1"].ToString());

                switch (drvItemsList["OtherBonusShadow1Stat"].ToString())
                {
                    case "Intellect":
                        ItemsList[x].OtherBonus1 *= StatWeights[0];
                        break;
                    //case "Spell Power":
                    //    ItemsList[x].OtherBonus1 *= StatWeights[1];
                    //    break;
                    case "Crit":
                        ItemsList[x].OtherBonus1 *= StatWeights[2];
                        break;
                    case "Haste":
                        ItemsList[x].OtherBonus1 *= StatWeights[3];
                        break;
                    case "Mastery":
                        ItemsList[x].OtherBonus1 *= StatWeights[4];
                        break;
                    //case "Multistrike":
                    //    ItemsList[x].OtherBonus1 *= StatWeights[5];
                    //    break;
                    case "Versatility":
                        ItemsList[x].OtherBonus1 *= StatWeights[6];
                        break;
                    case "DPS":
                        ItemsList[x].OtherBonus1 *= StatWeights[7];
                        break;
                    case "PP":
                        break;
                    default:
                        break;
                }

                ItemsList[x].OtherBonus1Description = drvItemsList["OtherBonusShadow1Description"].ToString();

                ItemsList[x].OtherBonus2 = Convert.ToDouble(drvItemsList["OtherBonusShadow2"].ToString());

                switch (drvItemsList["OtherBonusShadow1Stat"].ToString())
                {
                    case "Intellect":
                        ItemsList[x].OtherBonus2 *= StatWeights[0];
                        break;
                    //case "Spell Power":
                    //    ItemsList[x].OtherBonus2 *= StatWeights[1];
                    //    break;
                    case "Crit":
                        ItemsList[x].OtherBonus2 *= StatWeights[2];
                        break;
                    case "Haste":
                        ItemsList[x].OtherBonus2 *= StatWeights[3];
                        break;
                    case "Mastery":
                        ItemsList[x].OtherBonus2 *= StatWeights[4];
                        break;
                    //case "Multistrike":
                    //    ItemsList[x].OtherBonus2 *= StatWeights[5];
                    //    break;
                    case "Versatility":
                        ItemsList[x].OtherBonus2 *= StatWeights[6];
                        break;
                    case "DPS":
                        ItemsList[x].OtherBonus2 *= StatWeights[7];
                        break;
                    case "PP":
                        break;
                    default:
                        break;
                }

                ItemsList[x].OtherBonus2Description = drvItemsList["OtherBonusShadow2Description"].ToString();

                ItemsList[x].cInt = Convert.ToDouble(drvItemsList["IntellectComputedShadow"].ToString());
                ItemsList[x].cCrit = Convert.ToDouble(drvItemsList["CritComputedShadow"].ToString());
                ItemsList[x].cHaste = Convert.ToDouble(drvItemsList["HasteComputedShadow"].ToString());
                ItemsList[x].cMastery = Convert.ToDouble(drvItemsList["MasteryComputedShadow"].ToString());
                ItemsList[x].cVersatility = Convert.ToDouble(drvItemsList["VersatilityComputedShadow"].ToString());
                ItemsList[x].cProcTotal = computedProc;
                ItemsList[x].pProcTotal = 0;

                List<ItemTotals> tmpList = ScaleItem(ItemsList[x], Convert.ToInt32(ItemsList[x].Warforged));

                ItemsList[x].Int = (ItemsList[x].pInt + ItemsList[x].cInt) * StatWeights[0];
                ItemsList[x].Crit = (ItemsList[x].pCrit + ItemsList[x].cCrit) * StatWeights[2];
                ItemsList[x].Haste = (ItemsList[x].pHaste + ItemsList[x].cHaste) * StatWeights[3];
                ItemsList[x].Mastery = (ItemsList[x].pMastery + ItemsList[x].cMastery) * StatWeights[4];
                ItemsList[x].Versatility = (ItemsList[x].pVersatility + ItemsList[x].cVersatility) * StatWeights[6];
                ItemsList[x].ProcTotal = (ItemsList[x].pProcTotal + ItemsList[x].cProcTotal) * StatWeights[7];

                ItemsList[x].Total = ItemsList[x].Int + ItemsList[x].Crit + ItemsList[x].Haste + ItemsList[x].Mastery + ItemsList[x].Versatility + ItemsList[x].ProcTotal;

                ItemsList[x].WarforgedItems = new List<ItemTotals>();

                tmpList.ForEach(y =>
                {
                    ItemTotals tmpItem = y;
                    tmpItem.Int = (Math.Ceiling(y.pInt) + y.cInt) * StatWeights[0];
                    tmpItem.Crit = (Math.Ceiling(y.pCrit) + y.cCrit) * StatWeights[2];
                    tmpItem.Haste = (Math.Ceiling(y.pHaste) + y.cHaste) * StatWeights[3];
                    tmpItem.Mastery = (Math.Ceiling(y.pMastery) + y.cMastery) * StatWeights[4];
                    tmpItem.Versatility = (Math.Ceiling(y.pVersatility) + y.cVersatility) * StatWeights[6];
                    tmpItem.ProcTotal = (Math.Ceiling(y.pProcTotal) + y.cProcTotal) * StatWeights[7];

                    tmpItem.Total = tmpItem.Int + tmpItem.Crit + tmpItem.Haste + tmpItem.Mastery + tmpItem.Versatility + tmpItem.ProcTotal;

                    tmpItem.ItemLevel = y.ItemLevel;

                    ItemsList[x].WarforgedItems.Add(tmpItem);
                });

                #region Old Code

                /*
                if (ItemsList[x].numUpgrades == 1)
                {
                    double upgradeHit = Convert.ToInt32(Math.Round(pHit * 1.078, 0, MidpointRounding.AwayFromZero)),
                           upgradeSpirit = Convert.ToInt32(Math.Round(pSpirit * 1.078, 0, MidpointRounding.AwayFromZero)),
                           upgradeHaste = Convert.ToInt32(Math.Round(pHaste * 1.078, 0, MidpointRounding.AwayFromZero)),
                           upgradeCrit = Convert.ToInt32(Math.Round(pCrit * 1.078, 0, MidpointRounding.AwayFromZero)),
                           upgradeMastery = Convert.ToInt32(Math.Round(pMastery * 1.078, 0, MidpointRounding.AwayFromZero)),
                           upgradeIntellect = Convert.ToInt32(Math.Round(pIntellect * 1.078, 0, MidpointRounding.AwayFromZero)),
                           upgradeSpellPower = Convert.ToInt32(Math.Round(pSpellPower * 1.078, 0, MidpointRounding.AwayFromZero)),
                           upgradeProcTotal = 0;


                    if (ItemsList[x].UpgradeExcludeComputed == false)
                    {
                        upgradeSpirit += (Convert.ToDouble(drvItemsList["SpiritComputedShadow"].ToString()) * 1.078);
                        upgradeHit += (Convert.ToDouble(drvItemsList["HitComputedShadow"].ToString()) * 1.078);
                        upgradeHaste += (Convert.ToDouble(drvItemsList["HasteComputedShadow"].ToString()) * 1.078);
                        upgradeCrit += (Convert.ToDouble(drvItemsList["CritComputedShadow"].ToString()) * 1.078);
                        upgradeMastery += (Convert.ToDouble(drvItemsList["MasteryComputedShadow"].ToString()) * 1.078);
                        upgradeIntellect += (Convert.ToDouble(drvItemsList["IntellectComputedShadow"].ToString()) * 1.078);
                        upgradeSpellPower += (Convert.ToDouble(drvItemsList["SpellPowerComputedShadow"].ToString()) * 1.078);
                        upgradeProcTotal = (Convert.ToDouble(drvItemsList["SpellPowerComputedShadow"].ToString()));
                    }
                    else
                    {
                        upgradeSpirit += (Convert.ToDouble(drvItemsList["SpiritComputedShadow"].ToString()));
                        upgradeHit += (Convert.ToDouble(drvItemsList["HitComputedShadow"].ToString()));
                        upgradeHaste += (Convert.ToDouble(drvItemsList["HasteComputedShadow"].ToString()));
                        upgradeCrit += (Convert.ToDouble(drvItemsList["CritComputedShadow"].ToString()));
                        upgradeMastery += (Convert.ToDouble(drvItemsList["MasteryComputedShadow"].ToString()));
                        upgradeIntellect += (Convert.ToDouble(drvItemsList["IntellectComputedShadow"].ToString()));
                        upgradeSpellPower += (Convert.ToDouble(drvItemsList["SpellPowerComputedShadow"].ToString()));
                        upgradeProcTotal = (Convert.ToDouble(drvItemsList["SpellPowerComputedShadow"].ToString()));
                    }

                    ItemsList[x].upgrade1 = (upgradeIntellect * StatWeights[0]) + (upgradeSpirit * StatWeights[1]) + (upgradeSpellPower * StatWeights[2]) + (upgradeHit * StatWeights[3]) + (upgradeCrit * StatWeights[4]) + (upgradeHaste * StatWeights[5]) + (upgradeMastery * StatWeights[6]) + (upgradeProcTotal * StatWeights[7]);
                    ItemsList[x].upgrade1 -= ItemsList[x].Total;
                    ItemsList[x].upgrade2 = 0;
                }
                else if (ItemsList[x].numUpgrades >= 2)
                {
                    double upgradeHit = Convert.ToInt32(Math.Round(pHit * 1.038, 0, MidpointRounding.AwayFromZero)),
                           upgradeSpirit = Convert.ToInt32(Math.Round(pSpirit * 1.038, 0, MidpointRounding.AwayFromZero)),
                           upgradeHaste = Convert.ToInt32(Math.Round(pHaste * 1.038, 0, MidpointRounding.AwayFromZero)),
                           upgradeCrit = Convert.ToInt32(Math.Round(pCrit * 1.038, 0, MidpointRounding.AwayFromZero)),
                           upgradeMastery = Convert.ToInt32(Math.Round(pMastery * 1.038, 0, MidpointRounding.AwayFromZero)),
                           upgradeIntellect = Convert.ToInt32(Math.Round(pIntellect * 1.038, 0, MidpointRounding.AwayFromZero)),
                           upgradeSpellPower = Convert.ToInt32(Math.Round(pSpellPower * 1.038, 0, MidpointRounding.AwayFromZero)),
                           upgradeProcTotal = 0;

                    if (ItemsList[x].UpgradeExcludeComputed == false)
                    {
                        upgradeSpirit += (Convert.ToDouble(drvItemsList["SpiritComputedShadow"].ToString()) * 1.038);
                        upgradeHit += (Convert.ToDouble(drvItemsList["HitComputedShadow"].ToString()) * 1.038);
                        upgradeHaste += (Convert.ToDouble(drvItemsList["HasteComputedShadow"].ToString()) * 1.038);
                        upgradeCrit += (Convert.ToDouble(drvItemsList["CritComputedShadow"].ToString()) * 1.038);
                        upgradeMastery += (Convert.ToDouble(drvItemsList["MasteryComputedShadow"].ToString()) * 1.038);
                        upgradeIntellect += (Convert.ToDouble(drvItemsList["IntellectComputedShadow"].ToString()) * 1.038);
                        upgradeSpellPower += (Convert.ToDouble(drvItemsList["SpellPowerComputedShadow"].ToString()) * 1.038);
                        upgradeProcTotal = (Convert.ToDouble(drvItemsList["ProcComputedShadow"].ToString()) * 1.038); //NOT ADDED. DON'T ADD THE + IN, IDIOT!
                    }
                    else
                    {
                        upgradeSpirit += (Convert.ToDouble(drvItemsList["SpiritComputedShadow"].ToString()));
                        upgradeHit += (Convert.ToDouble(drvItemsList["HitComputedShadow"].ToString()));
                        upgradeHaste += (Convert.ToDouble(drvItemsList["HasteComputedShadow"].ToString()));
                        upgradeCrit += (Convert.ToDouble(drvItemsList["CritComputedShadow"].ToString()));
                        upgradeMastery += (Convert.ToDouble(drvItemsList["MasteryComputedShadow"].ToString()));
                        upgradeIntellect += (Convert.ToDouble(drvItemsList["IntellectComputedShadow"].ToString()));
                        upgradeSpellPower += (Convert.ToDouble(drvItemsList["SpellPowerComputedShadow"].ToString()));
                        upgradeProcTotal = (Convert.ToDouble(drvItemsList["SpellPowerComputedShadow"].ToString())); //NOT ADDED. DON'T ADD THE + IN, IDIOT!
                    }

                    ItemsList[x].upgrade1 = (upgradeIntellect * StatWeights[0]) + (upgradeSpirit * StatWeights[1]) + (upgradeSpellPower * StatWeights[2]) + (upgradeHit * StatWeights[3]) + (upgradeCrit * StatWeights[4]) + (upgradeHaste * StatWeights[5]) + (upgradeMastery * StatWeights[6]) + (upgradeProcTotal * StatWeights[7]);
                    ItemsList[x].upgrade1 -= ItemsList[x].Total;


                    upgradeHit = Convert.ToInt32(Math.Round(Math.Round(pHit * 1.038 * 1.038, 0, MidpointRounding.AwayFromZero), 0, MidpointRounding.AwayFromZero));
                    upgradeSpirit = Convert.ToInt32(Math.Round(Math.Round(pSpirit * 1.038 * 1.038, 0, MidpointRounding.AwayFromZero), 0, MidpointRounding.AwayFromZero));
                    upgradeHaste = Convert.ToInt32(Math.Round(Math.Round(pHaste * 1.038 * 1.038, 0, MidpointRounding.AwayFromZero), 0, MidpointRounding.AwayFromZero));
                    upgradeCrit = Convert.ToInt32(Math.Round(Math.Round(pCrit * 1.038 * 1.038, 0, MidpointRounding.AwayFromZero), 0, MidpointRounding.AwayFromZero));
                    upgradeMastery = Convert.ToInt32(Math.Round(Math.Round(pMastery * 1.038 * 1.038, 0, MidpointRounding.AwayFromZero), 0, MidpointRounding.AwayFromZero));
                    upgradeIntellect = Convert.ToInt32(Math.Round(Math.Round(pIntellect * 1.038 * 1.038, 0, MidpointRounding.AwayFromZero), 0, MidpointRounding.AwayFromZero));
                    upgradeSpellPower = Convert.ToInt32(Math.Round(Math.Round(pSpellPower * 1.038 * 1.038, 0, MidpointRounding.AwayFromZero), 0, MidpointRounding.AwayFromZero));
                    if (ItemsList[x].UpgradeExcludeComputed == false)
                    {
                        upgradeSpirit += (Convert.ToDouble(drvItemsList["SpiritComputedShadow"].ToString()) * 1.038 * 1.038);
                        upgradeHit += (Convert.ToDouble(drvItemsList["HitComputedShadow"].ToString()) * 1.038 * 1.038);
                        upgradeHaste += (Convert.ToDouble(drvItemsList["HasteComputedShadow"].ToString()) * 1.038 * 1.038);
                        upgradeCrit += (Convert.ToDouble(drvItemsList["CritComputedShadow"].ToString()) * 1.038 * 1.038);
                        upgradeMastery += (Convert.ToDouble(drvItemsList["MasteryComputedShadow"].ToString()) * 1.038 * 1.038);
                        upgradeIntellect += (Convert.ToDouble(drvItemsList["IntellectComputedShadow"].ToString()) * 1.038 * 1.038);
                        upgradeSpellPower += (Convert.ToDouble(drvItemsList["SpellPowerComputedShadow"].ToString()) * 1.038 * 1.038);
                        upgradeProcTotal = (Convert.ToDouble(drvItemsList["ProcComputedShadow"].ToString()) * 1.038 * 1.038); //NOT ADDED. DON'T ADD THE + IN, IDIOT!
                    }
                    else
                    {
                        upgradeSpirit += (Convert.ToDouble(drvItemsList["SpiritComputedShadow"].ToString()));
                        upgradeHit += (Convert.ToDouble(drvItemsList["HitComputedShadow"].ToString()));
                        upgradeHaste += (Convert.ToDouble(drvItemsList["HasteComputedShadow"].ToString()));
                        upgradeCrit += (Convert.ToDouble(drvItemsList["CritComputedShadow"].ToString()));
                        upgradeMastery += (Convert.ToDouble(drvItemsList["MasteryComputedShadow"].ToString()));
                        upgradeIntellect += (Convert.ToDouble(drvItemsList["IntellectComputedShadow"].ToString()));
                        upgradeSpellPower += (Convert.ToDouble(drvItemsList["SpellPowerComputedShadow"].ToString()));
                        upgradeProcTotal = (Convert.ToDouble(drvItemsList["ProcComputedShadow"].ToString())); //NOT ADDED. DON'T ADD THE + IN, IDIOT!
                    }

                    ItemsList[x].upgrade2 = (upgradeIntellect * StatWeights[0]) + (upgradeSpirit * StatWeights[1]) + (upgradeSpellPower * StatWeights[2]) + (upgradeHit * StatWeights[3]) + (upgradeCrit * StatWeights[4]) + (upgradeHaste * StatWeights[5]) + (upgradeMastery * StatWeights[6]) + (upgradeProcTotal * StatWeights[7]);
                    ItemsList[x].upgrade2 -= ItemsList[x].Total;
                    ItemsList[x].upgrade2 -= ItemsList[x].upgrade1;

                    if (ItemsList[x].numUpgrades == 4)
                    {
                        upgradeHit = Convert.ToInt32(Math.Round(Math.Round(pHit * 1.038 * 1.038 * 1.038, 0, MidpointRounding.AwayFromZero), 0, MidpointRounding.AwayFromZero));
                        upgradeSpirit = Convert.ToInt32(Math.Round(Math.Round(pSpirit * 1.038 * 1.038 * 1.038, 0, MidpointRounding.AwayFromZero), 0, MidpointRounding.AwayFromZero));
                        upgradeHaste = Convert.ToInt32(Math.Round(Math.Round(pHaste * 1.038 * 1.038 * 1.038, 0, MidpointRounding.AwayFromZero), 0, MidpointRounding.AwayFromZero));
                        upgradeCrit = Convert.ToInt32(Math.Round(Math.Round(pCrit * 1.038 * 1.038 * 1.038, 0, MidpointRounding.AwayFromZero), 0, MidpointRounding.AwayFromZero));
                        upgradeMastery = Convert.ToInt32(Math.Round(Math.Round(pMastery * 1.038 * 1.038 * 1.038, 0, MidpointRounding.AwayFromZero), 0, MidpointRounding.AwayFromZero));
                        upgradeIntellect = Convert.ToInt32(Math.Round(Math.Round(pIntellect * 1.038 * 1.038 * 1.038, 0, MidpointRounding.AwayFromZero), 0, MidpointRounding.AwayFromZero));
                        upgradeSpellPower = Convert.ToInt32(Math.Round(Math.Round(pSpellPower * 1.038 * 1.038 * 1.038, 0, MidpointRounding.AwayFromZero), 0, MidpointRounding.AwayFromZero));


                        if (ItemsList[x].UpgradeExcludeComputed == false)
                        {
                            upgradeSpirit += (Convert.ToDouble(drvItemsList["SpiritComputedShadow"].ToString()) * 1.038 * 1.038 * 1.038);
                            upgradeHit += (Convert.ToDouble(drvItemsList["HitComputedShadow"].ToString()) * 1.038 * 1.038 * 1.038);
                            upgradeHaste += (Convert.ToDouble(drvItemsList["HasteComputedShadow"].ToString()) * 1.038 * 1.038 * 1.038);
                            upgradeCrit += (Convert.ToDouble(drvItemsList["CritComputedShadow"].ToString()) * 1.038 * 1.038 * 1.038);
                            upgradeMastery += (Convert.ToDouble(drvItemsList["MasteryComputedShadow"].ToString()) * 1.038 * 1.038 * 1.038);
                            upgradeIntellect += (Convert.ToDouble(drvItemsList["IntellectComputedShadow"].ToString()) * 1.038 * 1.038 * 1.038);
                            upgradeSpellPower += (Convert.ToDouble(drvItemsList["SpellPowerComputedShadow"].ToString()) * 1.038 * 1.038 * 1.038);
                            upgradeProcTotal = (Convert.ToDouble(drvItemsList["ProcComputedShadow"].ToString()) * 1.038 * 1.038 * 1.038); //NOT ADDED. DON'T ADD THE + IN, IDIOT!
                        }
                        else
                        {
                            upgradeSpirit += (Convert.ToDouble(drvItemsList["SpiritComputedShadow"].ToString()));
                            upgradeHit += (Convert.ToDouble(drvItemsList["HitComputedShadow"].ToString()));
                            upgradeHaste += (Convert.ToDouble(drvItemsList["HasteComputedShadow"].ToString()));
                            upgradeCrit += (Convert.ToDouble(drvItemsList["CritComputedShadow"].ToString()));
                            upgradeMastery += (Convert.ToDouble(drvItemsList["MasteryComputedShadow"].ToString()));
                            upgradeIntellect += (Convert.ToDouble(drvItemsList["IntellectComputedShadow"].ToString()));
                            upgradeSpellPower += (Convert.ToDouble(drvItemsList["SpellPowerComputedShadow"].ToString()));
                            upgradeProcTotal = (Convert.ToDouble(drvItemsList["ProcComputedShadow"].ToString())); //NOT ADDED. DON'T ADD THE + IN, IDIOT!
                        }

                        ItemsList[x].upgrade3 = (upgradeIntellect * StatWeights[0]) + (upgradeSpirit * StatWeights[1]) + (upgradeSpellPower * StatWeights[2]) + (upgradeHit * StatWeights[3]) + (upgradeCrit * StatWeights[4]) + (upgradeHaste * StatWeights[5]) + (upgradeMastery * StatWeights[6]) + (upgradeProcTotal * StatWeights[7]);
                        ItemsList[x].upgrade3 -= ItemsList[x].Total;
                        ItemsList[x].upgrade3 -= ItemsList[x].upgrade1;
                        ItemsList[x].upgrade3 -= ItemsList[x].upgrade2;


                        upgradeHit = Convert.ToInt32(Math.Round(Math.Round(pHit * 1.038 * 1.038 * 1.038 * 1.038, 0, MidpointRounding.AwayFromZero), 0, MidpointRounding.AwayFromZero));
                        upgradeSpirit = Convert.ToInt32(Math.Round(Math.Round(pSpirit * 1.038 * 1.038 * 1.038 * 1.038, 0, MidpointRounding.AwayFromZero), 0, MidpointRounding.AwayFromZero));
                        upgradeHaste = Convert.ToInt32(Math.Round(Math.Round(pHaste * 1.038 * 1.038 * 1.038 * 1.038, 0, MidpointRounding.AwayFromZero), 0, MidpointRounding.AwayFromZero));
                        upgradeCrit = Convert.ToInt32(Math.Round(Math.Round(pCrit * 1.038 * 1.038 * 1.038 * 1.038, 0, MidpointRounding.AwayFromZero), 0, MidpointRounding.AwayFromZero));
                        upgradeMastery = Convert.ToInt32(Math.Round(Math.Round(pMastery * 1.038 * 1.038 * 1.038 * 1.038, 0, MidpointRounding.AwayFromZero), 0, MidpointRounding.AwayFromZero));
                        upgradeIntellect = Convert.ToInt32(Math.Round(Math.Round(pIntellect * 1.038 * 1.038 * 1.038 * 1.038, 0, MidpointRounding.AwayFromZero), 0, MidpointRounding.AwayFromZero));
                        upgradeSpellPower = Convert.ToInt32(Math.Round(Math.Round(pSpellPower * 1.038 * 1.038 * 1.038 * 1.038, 0, MidpointRounding.AwayFromZero), 0, MidpointRounding.AwayFromZero));

                        if (ItemsList[x].UpgradeExcludeComputed == false)
                        {
                            upgradeSpirit += (Convert.ToDouble(drvItemsList["SpiritComputedShadow"].ToString()) * 1.038 * 1.038 * 1.038 * 1.038);
                            upgradeHit += (Convert.ToDouble(drvItemsList["HitComputedShadow"].ToString()) * 1.038 * 1.038 * 1.038 * 1.038);
                            upgradeHaste += (Convert.ToDouble(drvItemsList["HasteComputedShadow"].ToString()) * 1.038 * 1.038 * 1.038 * 1.038);
                            upgradeCrit += (Convert.ToDouble(drvItemsList["CritComputedShadow"].ToString()) * 1.038 * 1.038 * 1.038 * 1.038);
                            upgradeMastery += (Convert.ToDouble(drvItemsList["MasteryComputedShadow"].ToString()) * 1.038 * 1.038 * 1.038 * 1.038);
                            upgradeIntellect += (Convert.ToDouble(drvItemsList["IntellectComputedShadow"].ToString()) * 1.038 * 1.038 * 1.038 * 1.038);
                            upgradeSpellPower += (Convert.ToDouble(drvItemsList["SpellPowerComputedShadow"].ToString()) * 1.038 * 1.038 * 1.038 * 1.038);
                            upgradeProcTotal = (Convert.ToDouble(drvItemsList["ProcComputedShadow"].ToString()) * 1.038 * 1.038 * 1.038 * 1.038); //NOT ADDED. DON'T ADD THE + IN, IDIOT!
                        }
                        else
                        {
                            upgradeSpirit += (Convert.ToDouble(drvItemsList["SpiritComputedShadow"].ToString()));
                            upgradeHit += (Convert.ToDouble(drvItemsList["HitComputedShadow"].ToString()));
                            upgradeHaste += (Convert.ToDouble(drvItemsList["HasteComputedShadow"].ToString()));
                            upgradeCrit += (Convert.ToDouble(drvItemsList["CritComputedShadow"].ToString()));
                            upgradeMastery += (Convert.ToDouble(drvItemsList["MasteryComputedShadow"].ToString()));
                            upgradeIntellect += (Convert.ToDouble(drvItemsList["IntellectComputedShadow"].ToString()));
                            upgradeSpellPower += (Convert.ToDouble(drvItemsList["SpellPowerComputedShadow"].ToString()));
                            upgradeProcTotal = (Convert.ToDouble(drvItemsList["ProcComputedShadow"].ToString())); //NOT ADDED. DON'T ADD THE + IN, IDIOT!
                        }

                        ItemsList[x].upgrade4 = (upgradeIntellect * StatWeights[0]) + (upgradeSpirit * StatWeights[1]) + (upgradeSpellPower * StatWeights[2]) + (upgradeHit * StatWeights[3]) + (upgradeCrit * StatWeights[4]) + (upgradeHaste * StatWeights[5]) + (upgradeMastery * StatWeights[6]) + (upgradeProcTotal * StatWeights[7]);
                        ItemsList[x].upgrade4 -= ItemsList[x].Total;
                        ItemsList[x].upgrade4 -= ItemsList[x].upgrade1;
                        ItemsList[x].upgrade4 -= ItemsList[x].upgrade2;
                        ItemsList[x].upgrade4 -= ItemsList[x].upgrade3;
                    }
                }
                */
#endregion
            }

            return ItemsList;
        }

        public string Print_Table_Shadow(ItemTotals[] ItemsList, int Site, int size, int DataSource, double[] StatWeights) //1=MMO/WoWDB, 2=WoWHead
        {
            string sourceDB;

            if (DataSource == 1)
            {
                sourceDB = "http://www.wowdb.com/items/";
            }
            else if (DataSource == 2)
            {
                sourceDB = "http://ptr.wowhead.com/item=";
            }
            else
            {
                sourceDB = "http://ptr.wowhead.com/item=";
                //sourceDB = "http://www.wowdb.com/items/";
            }

            string returnString = "";
            Array.Sort(ItemsList, (x, y) => string.Compare(x.Total.ToString("00000.00"), y.Total.ToString("00000.00")));

            if (Site == 3)
            {
                returnString = "[ol]";
            }
            else
            {
                returnString = "[LIST=1]";
            }

            for (int x = ItemsList.Length - 1; x >= 0 && (ItemsList.Length - 1 - x) < size; x--)
            {
                if (ItemsList[x].Total > 0)
                {
                    returnString += "\n";
                        
                    if (Site == 3)
                    {
                        returnString += "[li]";
                    }
                    else
                    {
                        returnString += "[*]";
                    }
                    
                    returnString += "[b]";

                    if (ItemsList[x].SourceType == "RF")
                    {
                        returnString += "[COLOR=#FFD700](RF)[/COLOR] ";
                    }
                    else if (ItemsList[x].SourceType == "RN" || ItemsList[x].SourceType == "N" || ItemsList[x].SourceType == "5N" || ItemsList[x].SourceType == "5")
                    {
                        returnString += "[COLOR=#FFD700](N)[/COLOR] ";
                    }
                    else if (ItemsList[x].SourceType == "RH" || ItemsList[x].SourceType == "H" || ItemsList[x].SourceType == "5H")
                    {
                        returnString += "[COLOR=#00dd00](H)[/COLOR] ";
                    }
                    else if (ItemsList[x].SourceType == "RM" || ItemsList[x].SourceType == "M" || ItemsList[x].SourceType == "5M")
                    {
                        returnString += "[COLOR=#00dd00](M)[/COLOR] ";
                    }
                    else if (ItemsList[x].SourceType == "TW")
                    {
                        returnString += "[COLOR=#00dd00](TW)[/COLOR] ";
                    }
                    
                    if (ItemsList[x].Vendor == true)
                    {
                        returnString += "[COLOR=#a335ee](V)[/COLOR] ";
                    }


                    if (ItemsList[x].Tier.ToString().Trim().Length > 0)
                    {
                        if (ItemsList[x].ItemType == "PVP" || ItemsList[x].Tier.Contains('S'))
                        {
                            returnString += "[COLOR=#00dd00](" + ItemsList[x].Tier + ")[/COLOR] ";
                        }
                        else if (ItemsList[x].Tier.Contains('/'))
                        {
                            returnString += "[COLOR=#a335ee](" + ItemsList[x].Tier + ")[/COLOR] ";
                        }
                        else
                        {
                            returnString += "[COLOR=#0080ff](" + ItemsList[x].Tier + ")[/COLOR] ";
                        }
                    }

                    returnString += "[url=" + sourceDB + ItemsList[x].Link;

                    if (DataSource != 1)
                    {                            
                        returnString += WoWHeadTooltipAddonsShadow(ItemsList[x], StatWeights);
                    }

                    returnString += "]";
                    
                    if (ItemsList[x].ItemType == "Caster" || ItemsList[x].ItemType == "DPS")
                    {
                        returnString += "[COLOR=#6495ED]";
                    }
                    else if (ItemsList[x].ItemType == "PVP")
                    {
                        returnString += "[COLOR=#8B0000]";
                    }
                    else if (ItemsList[x].ItemType == "Healing")
                    {
                        returnString += "[COLOR=#006400]";
                    }
                    else
                    {
                        returnString += "[COLOR=#F28500]";
                    }

                    returnString += ItemsList[x].Name + OfTheIdToString(ItemsList[x].OfTheID) + "[/COLOR][/url]";

                    if (ItemsList[x].Gem)
                    {
                        returnString += " (+ [url=" + sourceDB + BestGem(StatWeights, 0) + "][color=#" + BestGem(StatWeights, 3) + "]" + Convert.ToDouble(BestGem(StatWeights, 2)).ToString("0.00") + "[/color][/url])";
                    }
      
                    returnString += " (" + ItemsList[x].ItemLevel.ToString() + ")[/b]";

                    returnString += "\n" + ItemsList[x].Source;
                    
                    if (ItemsList[x].SourceType == "RH")
                    {
                        returnString += " / Heroic ";
                    }
                    else if (ItemsList[x].SourceType == "RN")
                    {
                        returnString += " / Normal ";
                    }
                    else if (ItemsList[x].SourceType == "RM")
                    {
                        returnString += " / Mythic ";
                    }
                    else if (ItemsList[x].SourceType == "RF")
                    {
                        returnString += " / Raid Finder ";
                    }
                    else if (ItemsList[x].SourceType == "5M")
                    {
                        returnString += " / Mythic-5 ";
                    }
                    else if (ItemsList[x].SourceType == "5H")
                    {
                        returnString += " / Heroic-5 ";
                    }
                    else if (ItemsList[x].SourceType == "5N")
                    {
                        returnString += " / Normal-5 ";
                    }
                    else if (ItemsList[x].SourceType == "TW")
                    {
                        returnString += " / Timewalking ";
                    }
                    else if (ItemsList[x].SourceType == "WB")
                    {
                        returnString += " / World Boss ";
                    }
                    else if (ItemsList[x].SourceType == "WD")
                    {
                        returnString += " / World Drop ";
                    }
                    else if (ItemsList[x].SourceType == "ZR")
                    {
                        returnString += " / Zone Rare ";
                    }
                    else if (ItemsList[x].SourceType == "Q")
                    {
                    }

                    returnString += "\n";

                    string gemString1 = "";
                    string gemString2 = "";

                    if (ItemsList[x].Gem)
                    {
                        gemString1 = " (";

                        //if (DataSource != 1)
                        //{
                        //    gemString1 += "[url=" + sourceDB + ItemsList[x].Link;
                        //    gemString1 += WoWHeadTooltipAddonsShadow(ItemsList[x], StatWeights, true, false);
                        //    gemString1 += "]";
                        //}

                        gemString1 += "[b]" + (ItemsList[x].Total + Convert.ToDouble(BestGem(StatWeights, 2))).ToString("0.00") + "[/b]";

                        //if (DataSource != 1)
                        //{
                        //    gemString1 += "[/url]";
                        //}

                        gemString1 += ")";

                        //gemString2 += " (+ [url=" + sourceDB + BestGem(StatWeights, 0) + "][color=#" + BestGem(StatWeights, 3) + "]" + Convert.ToDouble(BestGem(StatWeights, 2)).ToString("0.00") + "[/color][/url])";

                        gemString2 += " (+ [color=#" + BestGem(StatWeights, 3) + "]" + Convert.ToDouble(BestGem(StatWeights, 2)).ToString("0.00") + "[/color])";
                    }

                    returnString += "[b](" + ItemsList[x].ItemLevel + ")[/b] ";

                    if (DataSource != 1)
                    {
                        returnString += "[url=" + sourceDB + ItemsList[x].Link;
                        returnString += WoWHeadTooltipAddonsShadow(ItemsList[x], StatWeights);
                        returnString += "]";
                    }
                    
                    returnString += "[b]" + String.Format("{0:0.00}", ItemsList[x].Total);

                    if (DataSource != 1)
                    {
                        returnString += "[/url]";
                    }

                    returnString += "[/b] " + gemString1 + " = ";

                    string TotalPieces = "";

                    if (ItemsList[x].Int > 0)
                    {
                        TotalPieces = "[COLOR=#5F9EA0]" + ItemsList[x].Int.ToString("0.00") + "[/COLOR]";
                    }

                    //if (ItemsList[x].SpellPower > 0)
                    //{
                    //    if (TotalPieces.Length > 0)
                    //    {
                    //        TotalPieces += " + ";
                    //    }

                    //    TotalPieces += "[COLOR=#006400]" + ItemsList[x].SpellPower.ToString("0.0000") + "[/COLOR]";
                    //}

                    if (ItemsList[x].Crit > 0)
                    {
                        if (TotalPieces.Length > 0)
                        {
                            TotalPieces += " + ";
                        }

                        TotalPieces += "[COLOR=#8B0000]" + ItemsList[x].Crit.ToString("0.00") + "[/COLOR]";
                    }

                    if (ItemsList[x].Haste > 0)
                    {
                        if (TotalPieces.Length > 0)
                        {
                            TotalPieces += " + ";
                        }

                        TotalPieces += "[COLOR=DarkGreen]" + ItemsList[x].Haste.ToString("0.00") + "[/COLOR]";
                    }

                    if (ItemsList[x].Mastery > 0)
                    {
                        if (TotalPieces.Length > 0)
                        {
                            TotalPieces += " + ";
                        }

                        TotalPieces += "[COLOR=#8040FF]" + ItemsList[x].Mastery.ToString("0.00") + "[/COLOR]";
                    }

                    //if (ItemsList[x].Multistrike > 0)
                    //{
                    //    if (TotalPieces.Length > 0)
                    //    {
                    //        TotalPieces += " + ";
                    //    }

                    //    TotalPieces += "[COLOR=#FF00FF]" + ItemsList[x].Multistrike.ToString("0.0000") + "[/COLOR]";
                    //}

                    if (ItemsList[x].Versatility > 0)
                    {
                        if (TotalPieces.Length > 0)
                        {
                            TotalPieces += " + ";
                        }

                        TotalPieces += "[COLOR=SlateGray]" + ItemsList[x].Versatility.ToString("0.00") + "[/COLOR]";
                    }

                    if (ItemsList[x].ProcTotal > 0)
                    {
                        if (TotalPieces.Length > 0)
                        {
                            TotalPieces += " + ";
                        }

                        TotalPieces += "[COLOR=#48D1CC]" + ItemsList[x].ProcTotal.ToString("0.00") + "[/COLOR]";
                    }

                    returnString += TotalPieces + gemString2;

                    //if (ItemsList[x].SetBonus1 > 0 || ItemsList[x].SetBonus2 > 0 || ItemsList[x].WarforgedItems.Count > 0)
                    //{
                    //    returnString += "\n[collapse=\"Show More Versions\"]";
                    //}

                    if (ItemsList[x].SetDescription.Length > 0 || ItemsList[x].SetBonus1 > 0 || ItemsList[x].SetBonus2 > 0)
                    {
                        if ((ItemsList[x].SetBonus1 > 0 || ItemsList[x].SetBonus2 > 0) && ItemsList[x].ItemType != "Healing")
                        {
                            if (ItemsList[x].SetBonus1 > 0)
                            {
                                gemString1 = "";
                                gemString2 = "";

                                if (ItemsList[x].Gem)
                                {
                                    gemString1 = " (";

                                    //if (DataSource != 1)
                                    //{
                                    //    gemString1 += "[url=" + sourceDB + ItemsList[x].Link;
                                    //    gemString1 += WoWHeadTooltipAddonsShadow(ItemsList[x], StatWeights, true, false, 0, false, false, true, false);
                                    //    gemString1 += "]";
                                    //}

                                    gemString1 += "[b]" + (ItemsList[x].Total + ItemsList[x].SetBonus1 + Convert.ToDouble(BestGem(StatWeights, 2))).ToString("0.00") + "[/b]";

                                    //if (DataSource != 1)
                                    //{
                                    //    gemString1 += "[/url]";
                                    //}

                                    gemString1 += ")";

                                    //gemString2 += " (+ [url=" + sourceDB + BestGem(StatWeights, 0) + "][color=#" + BestGem(StatWeights, 3) + "]" + Convert.ToDouble(BestGem(StatWeights, 2)).ToString("0.00") + "[/color][/url])";
                                    gemString2 += " (+ [color=#" + BestGem(StatWeights, 3) + "]" + Convert.ToDouble(BestGem(StatWeights, 2)).ToString("0.00") + "[/color])";
                                }

                                returnString += "\n";
                                returnString += "[b](" + ItemsList[x].ItemLevel + ")[/b] ";

                                if (DataSource != 1)
                                {
                                    returnString += "[url=" + sourceDB + ItemsList[x].Link;
                                    returnString += WoWHeadTooltipAddonsShadow(ItemsList[x], StatWeights, false, false, 0, false, false, true, false);
                                    returnString += "]";
                                }

                                returnString += "[b]" + (ItemsList[x].Total + ItemsList[x].SetBonus1).ToString("0.00") + "[/b]";

                                if (DataSource != 1)
                                {
                                    returnString += "[/url]";
                                }

                                returnString += gemString1 + " = " + ItemsList[x].Total.ToString("0.00") + " + " + ItemsList[x].SetBonus1.ToString("0.00") + gemString2 + " {2P";
                                
                                if (!String.IsNullOrWhiteSpace(ItemsList[x].SetDescription))
                                {
                                    returnString += " " + ItemsList[x].SetDescription;
                                }

                                returnString += "}";
                            }

                            //if (ItemsList[x].SetBonus2 > 0)
                            //{
                            //    returnString += "\n";

                            //    if (DataSource != 1)
                            //    {
                            //        returnString += "[url=" + sourceDB + ItemsList[x].Link;
                            //        returnString += WoWHeadTooltipAddonsShadow(ItemsList[x], StatWeights, false, false, 0, false, false, true, true);
                            //        returnString += "]";
                            //    }

                            //    returnString += "[b]" + (ItemsList[x].Total + ItemsList[x].SetBonus2).ToString("0.00") + "[/b]";

                            //    if (DataSource != 1)
                            //    {
                            //        returnString += "[/url]";
                            //    }

                            //    returnString += " = " + ItemsList[x].Total.ToString("0.00") + " + " + ItemsList[x].SetBonus2.ToString("0.00") + " {4P " + ItemsList[x].SetDescription + "}";

                            //    if (ItemsList[x].Gem)
                            //    {
                            //        returnString += "\n";

                            //        if (DataSource != 1)
                            //        {
                            //            returnString += "[url=" + sourceDB + ItemsList[x].Link;
                            //            returnString += WoWHeadTooltipAddonsShadow(ItemsList[x], StatWeights, true, false, 0, false, false, true, true);
                            //            returnString += "]";
                            //        }

                            //        returnString += "[b]" + (ItemsList[x].Total + ItemsList[x].SetBonus2 + Convert.ToDouble(BestGem(StatWeights, 2))).ToString("0.00") + "[/b]";

                            //        if (DataSource != 1)
                            //        {
                            //            returnString += "[/url]";
                            //        }

                            //        returnString += " = " + (ItemsList[x].Total + ItemsList[x].SetBonus2).ToString("0.00") + " + " + Convert.ToDouble(BestGem(StatWeights, 2)).ToString("0.00") + " {";

                            //        returnString += "4P " + ItemsList[x].SetDescription;

                            //        returnString += " + ";

                            //        returnString += "[b][stroke=black][url=" + sourceDB + BestGem(StatWeights, 0) + "][color=#" + BestGem(StatWeights, 3) + "]" + BestGem(StatWeights, 1) + "[/color][/url][/stroke][/b]";

                            //        returnString += "}";
                            //    }
                            //}
                        }
                        else
                        {
                            returnString += "\n[i]" + ItemsList[x].SetDescription + "[/i]";
                        }
                    }




                    if (ItemsList[x].WarforgedItems.Count > 0)
                    {
                        double previousValue = ItemsList[x].Total;
                        double valueDelta = 0.0;
                        foreach (ItemTotals item in ItemsList[x].WarforgedItems)
	                    {
                            valueDelta = item.Total - previousValue;

                            gemString1 = "";
                            gemString2 = "";

                            if (ItemsList[x].Gem)
                            {
                                gemString1 = " (";

                                //if (DataSource != 1)
                                //{
                                //    gemString1 += "[url=" + sourceDB + ItemsList[x].Link;
                                //    gemString1 += WoWHeadTooltipAddonsShadow(item, StatWeights, true, true, (int)(item.ItemLevel - ItemsList[x].ItemLevel));
                                //    gemString1 += "]";
                                //}

                                gemString1 += "[b]" + (previousValue + valueDelta + Convert.ToDouble(BestGem(StatWeights, 2))).ToString("0.00") + "[/b]";

                                //if (DataSource != 1)
                                //{
                                //    gemString1 += "[/url]";
                                //}

                                gemString1 += ")";

                                //gemString2 += " (+ [url=" + sourceDB + BestGem(StatWeights, 0) + "][color=#" + BestGem(StatWeights, 3) + "]" + Convert.ToDouble(BestGem(StatWeights, 2)).ToString("0.00") + "[/color][/url])";

                                gemString2 += " (+ [color=#" + BestGem(StatWeights, 3) + "]" + Convert.ToDouble(BestGem(StatWeights, 2)).ToString("0.00") + "[/color])";
                            }

                            returnString += "\n";                            
                            returnString += "[b](" + item.ItemLevel + ")[/b] ";

                            if (DataSource != 1)
                            {
                                returnString += "[url=" + sourceDB + ItemsList[x].Link;
                                returnString += WoWHeadTooltipAddonsShadow(item, StatWeights, false, true, (int)(item.ItemLevel - ItemsList[x].ItemLevel));
                                returnString += "]";
                            }

                            returnString += "[b]" + (previousValue + valueDelta).ToString("0.00") + "[/b]";

                            if (DataSource != 1)
                            {
                                returnString += "[/url]";
                            }

                            returnString += gemString1 + " = " + previousValue.ToString("0.00") + " + " + valueDelta.ToString("0.00") + gemString2;

                            
                            if (ItemsList[x].SetDescription.Length > 0 || ItemsList[x].SetBonus1 > 0 || ItemsList[x].SetBonus2 > 0)
                            {
                                if ((ItemsList[x].SetBonus1 > 0 || ItemsList[x].SetBonus2 > 0) && ItemsList[x].ItemType != "Healing")
                                {
                                    if (ItemsList[x].SetBonus1 > 0)
                                    {
                                        gemString1 = "";
                                        gemString2 = "";

                                        if (ItemsList[x].Gem)
                                        {
                                            gemString1 = " (";

                                            //if (DataSource != 1)
                                            //{
                                            //    gemString1 += "[url=" + sourceDB + ItemsList[x].Link;
                                            //    gemString1 += WoWHeadTooltipAddonsShadow(item, StatWeights, true, true, (int)(item.ItemLevel - ItemsList[x].ItemLevel), false, false, true, false);
                                            //    gemString1 += "]";
                                            //}

                                            gemString1 += "[b]" + (item.Total + ItemsList[x].SetBonus1 + Convert.ToDouble(BestGem(StatWeights, 2))).ToString("0.00") + "[/b]";

                                            //if (DataSource != 1)
                                            //{
                                            //    gemString1 += "[/url]";
                                            //}

                                            gemString1 += ")";

                                            //gemString2 += " (+ [url=" + sourceDB + BestGem(StatWeights, 0) + "][color=#" + BestGem(StatWeights, 3) + "]" + Convert.ToDouble(BestGem(StatWeights, 2)).ToString("0.00") + "[/color][/url])";

                                            gemString2 += " (+ [color=#" + BestGem(StatWeights, 3) + "]" + Convert.ToDouble(BestGem(StatWeights, 2)).ToString("0.00") + "[/color])";
                                        }

                                        returnString += "\n";
                                        returnString += "[b](" + item.ItemLevel + ")[/b] ";

                                        if (DataSource != 1)
                                        {
                                            returnString += "[url=" + sourceDB + ItemsList[x].Link;
                                            returnString += WoWHeadTooltipAddonsShadow(item, StatWeights, false, true, (int)(item.ItemLevel - ItemsList[x].ItemLevel), false, false, true, false);
                                            returnString += "]";
                                        }

                                        returnString += "[b]" + (item.Total + ItemsList[x].SetBonus1).ToString("0.00") + "[/b]";

                                        if (DataSource != 1)
                                        {
                                            returnString += "[/url]";
                                        }

                                        returnString += gemString1 + " = " + item.Total.ToString("0.00") + " + " + ItemsList[x].SetBonus1.ToString("0.00") + gemString2 + " {2P";

                                        if (!String.IsNullOrWhiteSpace(ItemsList[x].SetDescription))
                                        {
                                            returnString += " " + ItemsList[x].SetDescription;
                                        }

                                        returnString += "}";
                                    }

                                    //if (ItemsList[x].SetBonus2 > 0)
                                    //{
                                    //    returnString += "\n";

                                    //    if (DataSource != 1)
                                    //    {
                                    //        returnString += "[url=" + sourceDB + ItemsList[x].Link;
                                    //        returnString += WoWHeadTooltipAddonsShadow(ItemsList[x], StatWeights, false, false, 0, false, false, true, true);
                                    //        returnString += "]";
                                    //    }

                                    //    returnString += "[b]" + (ItemsList[x].Total + ItemsList[x].SetBonus2).ToString("0.00") + "[/b]";

                                    //    if (DataSource != 1)
                                    //    {
                                    //        returnString += "[/url]";
                                    //    }

                                    //    returnString += " = " + ItemsList[x].Total.ToString("0.00") + " + " + ItemsList[x].SetBonus2.ToString("0.00") + " {4P " + ItemsList[x].SetDescription + "}";

                                    //    if (ItemsList[x].Gem)
                                    //    {
                                    //        returnString += "\n";

                                    //        if (DataSource != 1)
                                    //        {
                                    //            returnString += "[url=" + sourceDB + ItemsList[x].Link;
                                    //            returnString += WoWHeadTooltipAddonsShadow(ItemsList[x], StatWeights, true, false, 0, false, false, true, true);
                                    //            returnString += "]";
                                    //        }

                                    //        returnString += "[b]" + (ItemsList[x].Total + ItemsList[x].SetBonus2 + Convert.ToDouble(BestGem(StatWeights, 2))).ToString("0.00") + "[/b]";

                                    //        if (DataSource != 1)
                                    //        {
                                    //            returnString += "[/url]";
                                    //        }

                                    //        returnString += " = " + (ItemsList[x].Total + ItemsList[x].SetBonus2).ToString("0.00") + " + " + Convert.ToDouble(BestGem(StatWeights, 2)).ToString("0.00") + " {";

                                    //        returnString += "4P " + ItemsList[x].SetDescription;

                                    //        returnString += " + ";

                                    //        returnString += "[b][stroke=black][url=" + sourceDB + BestGem(StatWeights, 0) + "][color=#" + BestGem(StatWeights, 3) + "]" + BestGem(StatWeights, 1) + "[/color][/url][/stroke][/b]";

                                    //        returnString += "}";
                                    //    }
                                    //}
                                }
                                else
                                {
                                    returnString += "\n[i]" + ItemsList[x].SetDescription + "[/i]";
                                }
                            }

                            previousValue += valueDelta;
	                    }
                    }

                    #region Old Reforge Upgrade Code
                    /*
                    if (ItemsList[x].numUpgrades == 1)
                    {
                        returnString += "\n";

                        if (DataSource != 1)
                        {
                            returnString += "[url=" + sourceDB + ItemsList[x].Link;
                            returnString += WoWHeadTooltipAddonsShadow(ItemsList[x], ShadowGemsHeroic, 1);
                            returnString += "]";
                        }

                        returnString += "[b]" + String.Format("{0:0.0000}", (ItemsList[x].Total + ItemsList[x].upgrade1)) + "[/b]";

                        if (DataSource != 1)
                        {
                            returnString += "[/url]";
                        }

                        returnString += " = " + String.Format("{0:0.0000}", ItemsList[x].Total) + " + " + String.Format("{0:0.0000}", ItemsList[x].upgrade1) + " {" + ItemsList[x].UpgradeCurrency + " Upgrade 1/1}";
                    }
                    else if (ItemsList[x].numUpgrades == 2)
                    {
                        returnString += "\n";

                        if (DataSource != 1)
                        {
                            returnString += "[url=" + sourceDB + ItemsList[x].Link;
                            returnString += WoWHeadTooltipAddonsShadow(ItemsList[x], ShadowGemsHeroic, 1);
                            returnString += "]";
                        }

                        returnString += "[b]" + String.Format("{0:0.0000}", (ItemsList[x].Total + ItemsList[x].upgrade1)) + "[/b]";

                        if (DataSource != 1)
                        {
                            returnString += "[/url]";
                        }

                        returnString += " = " + String.Format("{0:0.0000}", ItemsList[x].Total) + " + " + String.Format("{0:0.0000}", ItemsList[x].upgrade1) + " {" + ItemsList[x].UpgradeCurrency + " Upgrade 1/2}";

                        returnString += "\n";

                        if (DataSource != 1)
                        {
                            returnString += "[url=" + sourceDB + ItemsList[x].Link;
                            returnString += WoWHeadTooltipAddonsShadow(ItemsList[x], ShadowGemsHeroic, 2);
                            returnString += "]";
                        }

                        returnString += "[b]" + String.Format("{0:0.0000}", (ItemsList[x].Total + ItemsList[x].upgrade1 + ItemsList[x].upgrade2)) + "[/b]";

                        if (DataSource != 1)
                        {
                            returnString += "[/url]";
                        }

                        returnString += " = " + String.Format("{0:0.0000}", (ItemsList[x].Total + ItemsList[x].upgrade1)) + " + " + String.Format("{0:0.0000}", ItemsList[x].upgrade2) + " {" + ItemsList[x].UpgradeCurrency + " Upgrade 2/2}";
                    }
                    else if (ItemsList[x].numUpgrades == 4)
                    {
                        returnString += "\n";

                        if (DataSource != 1)
                        {
                            returnString += "[url=" + sourceDB + ItemsList[x].Link;
                            returnString += WoWHeadTooltipAddonsShadow(ItemsList[x], ShadowGemsHeroic, 1);
                            returnString += "]";
                        }

                        returnString += "[b]" + String.Format("{0:0.0000}", (ItemsList[x].Total + ItemsList[x].upgrade1)) + "[/b]";

                        if (DataSource != 1)
                        {
                            returnString += "[/url]";
                        }

                        returnString += " = " + String.Format("{0:0.0000}", ItemsList[x].Total) + " + " + String.Format("{0:0.0000}", ItemsList[x].upgrade1) + " {" + ItemsList[x].UpgradeCurrency + " Upgrade 1/4}";

                        returnString += "\n";

                        if (DataSource != 1)
                        {
                            returnString += "[url=" + sourceDB + ItemsList[x].Link;
                            returnString += WoWHeadTooltipAddonsShadow(ItemsList[x], ShadowGemsHeroic, 2);
                            returnString += "]";
                        }

                        returnString += "[b]" + String.Format("{0:0.0000}", (ItemsList[x].Total + ItemsList[x].upgrade1 + ItemsList[x].upgrade2)) + "[/b]";

                        if (DataSource != 1)
                        {
                            returnString += "[/url]";
                        }

                        returnString += " = " + String.Format("{0:0.0000}", (ItemsList[x].Total + ItemsList[x].upgrade1)) + " + " + String.Format("{0:0.0000}", ItemsList[x].upgrade2) + " {" + ItemsList[x].UpgradeCurrency + " Upgrade 2/4}";

                        returnString += "\n";

                        if (DataSource != 1)
                        {
                            returnString += "[url=" + sourceDB + ItemsList[x].Link;
                            returnString += WoWHeadTooltipAddonsShadow(ItemsList[x], ShadowGemsHeroic, 2);
                            returnString += "]";
                        }

                        returnString += "[b]" + String.Format("{0:0.0000}", (ItemsList[x].Total + ItemsList[x].upgrade1 + ItemsList[x].upgrade2 + ItemsList[x].upgrade3)) + "[/b]";

                        if (DataSource != 1)
                        {
                            returnString += "[/url]";
                        }

                        returnString += " = " + String.Format("{0:0.0000}", (ItemsList[x].Total + ItemsList[x].upgrade1 + ItemsList[x].upgrade2)) + " + " + String.Format("{0:0.0000}", ItemsList[x].upgrade3) + " {" + ItemsList[x].UpgradeCurrency + " Upgrade 3/4}";

                        returnString += "\n";

                        if (DataSource != 1)
                        {
                            returnString += "[url=" + sourceDB + ItemsList[x].Link;
                            returnString += WoWHeadTooltipAddonsShadow(ItemsList[x], ShadowGemsHeroic, 2);
                            returnString += "]";
                        }

                        returnString += "[b]" + String.Format("{0:0.0000}", (ItemsList[x].Total + ItemsList[x].upgrade1 + ItemsList[x].upgrade2 + ItemsList[x].upgrade3 + ItemsList[x].upgrade4)) + "[/b]";

                        if (DataSource != 1)
                        {
                            returnString += "[/url]";
                        }

                        returnString += " = " + String.Format("{0:0.0000}", (ItemsList[x].Total + ItemsList[x].upgrade1 + ItemsList[x].upgrade2 + ItemsList[x].upgrade3)) + " + " + String.Format("{0:0.0000}", ItemsList[x].upgrade4) + " {" + ItemsList[x].UpgradeCurrency + " Upgrade 4/4}";
                    }

                    if (ItemsList[x].ExpertiseType.Trim().Length > 0)
                    {
                        string expTypeName = "";
                        if (ItemsList[x].ExpertiseType == "Mace")
                        {
                            expTypeName = "Human/Dwarf";
                        }
                        else if (ItemsList[x].ExpertiseType == "Dagger")
                        {
                            expTypeName = "Gnome";
                        }
                        else if (ItemsList[x].ExpertiseType == "DM")
                        {
                            expTypeName = "Human/Dwarf/Gnome";
                        }
                        
                        returnString += "\n";

                        if (DataSource != 1)
                        {
                            returnString += "[url=" + sourceDB + ItemsList[x].Link;
                            returnString += WoWHeadTooltipAddonsShadow(ItemsList[x], ShadowGemsHeroic, 0);
                            returnString += "]";
                        }

                        returnString += "[b]" + String.Format("{0:0.0000}", (ItemsList[x].Total + (340 * StatWeights[3]))) + "[/b]";

                        if (DataSource != 1)
                        {
                            returnString += "[/url]";
                        }

                        returnString += " = " + String.Format("{0:0.0000}", ItemsList[x].Total) + " + " + String.Format("{0:0.0000}", +(340 * StatWeights[3])) + " {" + expTypeName + " Racial}";

                        if (ItemsList[x].numUpgrades == 1)
                        {
                            returnString += "\n";

                            if (DataSource != 1)
                            {
                                returnString += "[url=" + sourceDB + ItemsList[x].Link;
                                returnString += WoWHeadTooltipAddonsShadow(ItemsList[x], ShadowGemsHeroic, 1);
                                returnString += "]";
                            }

                            returnString += "[b]" + String.Format("{0:0.0000}", (ItemsList[x].Total + (340 * StatWeights[3]) + ItemsList[x].upgrade1)) + "[/b]";

                            if (DataSource != 1)
                            {
                                returnString += "[/url]";
                            }

                            returnString += " = " + String.Format("{0:0.0000}", ItemsList[x].Total) + " + " + String.Format("{0:0.0000}", (340 * StatWeights[3])) + " + " + String.Format("{0:0.0000}", ItemsList[x].upgrade1) + " {" + expTypeName + " Racial";

                            returnString += " + " + ItemsList[x].UpgradeCurrency + " Upgrade 1/1}";
                        }
                        else if (ItemsList[x].numUpgrades == 2)
                        {
                            returnString += "\n";

                            if (DataSource != 1)
                            {
                                returnString += "[url=" + sourceDB + ItemsList[x].Link;
                                returnString += WoWHeadTooltipAddonsShadow(ItemsList[x], ShadowGemsHeroic, 1);
                                returnString += "]";
                            }

                            returnString += "[b]" + String.Format("{0:0.0000}", (ItemsList[x].Total + (340 * StatWeights[3]) + ItemsList[x].upgrade1)) + "[/b]";

                            if (DataSource != 1)
                            {
                                returnString += "[/url]";
                            }

                            returnString += " = " + String.Format("{0:0.0000}", (ItemsList[x].Total + (340 * StatWeights[3]))) + " + " + String.Format("{0:0.0000}", ItemsList[x].upgrade1) + " {" + expTypeName + " Racial";

                            returnString += " + " + ItemsList[x].UpgradeCurrency + " Upgrade 1/2}";

                            returnString += "\n";

                            if (DataSource != 1)
                            {
                                returnString += "[url=" + sourceDB + ItemsList[x].Link;
                                returnString += WoWHeadTooltipAddonsShadow(ItemsList[x], ShadowGemsHeroic, 2);
                                returnString += "]";
                            }

                            returnString += "[b]" + String.Format("{0:0.0000}", (ItemsList[x].Total + (340 * StatWeights[3]) + ItemsList[x].upgrade1 + ItemsList[x].upgrade2)) + "[/b]";

                            if (DataSource != 1)
                            {
                                returnString += "[/url]";
                            }

                            returnString += " = " + String.Format("{0:0.0000}", (ItemsList[x].Total + ItemsList[x].upgrade1 + (340 * StatWeights[3]))) + " + " + String.Format("{0:0.0000}", ItemsList[x].upgrade2) + " {" + expTypeName + " Racial";

                            returnString += " + " + ItemsList[x].UpgradeCurrency + " Upgrade 2/2}";
                        }
                        else if (ItemsList[x].numUpgrades == 4)
                        {
                            returnString += "\n";

                            if (DataSource != 1)
                            {
                                returnString += "[url=" + sourceDB + ItemsList[x].Link;
                                returnString += WoWHeadTooltipAddonsShadow(ItemsList[x], ShadowGemsHeroic, 1);
                                returnString += "]";
                            }

                            returnString += "[b]" + String.Format("{0:0.0000}", (ItemsList[x].Total + (340 * StatWeights[3]) + ItemsList[x].upgrade1)) + "[/b]";

                            if (DataSource != 1)
                            {
                                returnString += "[/url]";
                            }

                            returnString += " = " + String.Format("{0:0.0000}", (ItemsList[x].Total + (340 * StatWeights[3]))) + " + " + String.Format("{0:0.0000}", ItemsList[x].upgrade1) + " {" + expTypeName + " Racial";

                            returnString += " + " + ItemsList[x].UpgradeCurrency + " Upgrade 1/4}";

                            returnString += "\n";

                            if (DataSource != 1)
                            {
                                returnString += "[url=" + sourceDB + ItemsList[x].Link;
                                returnString += WoWHeadTooltipAddonsShadow(ItemsList[x], ShadowGemsHeroic, 2);
                                returnString += "]";
                            }

                            returnString += "[b]" + String.Format("{0:0.0000}", (ItemsList[x].Total + (340 * StatWeights[3]) + ItemsList[x].upgrade1 + ItemsList[x].upgrade2)) + "[/b]";

                            if (DataSource != 1)
                            {
                                returnString += "[/url]";
                            }

                            returnString += " = " + String.Format("{0:0.0000}", (ItemsList[x].Total + ItemsList[x].upgrade1 + (340 * StatWeights[3]))) + " + " + String.Format("{0:0.0000}", ItemsList[x].upgrade2) + " {" + expTypeName + " Racial";

                            returnString += " + " + ItemsList[x].UpgradeCurrency + " Upgrade 2/4}";

                            returnString += "\n";

                            if (DataSource != 1)
                            {
                                returnString += "[url=" + sourceDB + ItemsList[x].Link;
                                returnString += WoWHeadTooltipAddonsShadow(ItemsList[x], ShadowGemsHeroic, 2);
                                returnString += "]";
                            }

                            returnString += "[b]" + String.Format("{0:0.0000}", (ItemsList[x].Total + (340 * StatWeights[3]) + ItemsList[x].upgrade1 + ItemsList[x].upgrade2 + ItemsList[x].upgrade3)) + "[/b]";

                            if (DataSource != 1)
                            {
                                returnString += "[/url]";
                            }

                            returnString += " = " + String.Format("{0:0.0000}", (ItemsList[x].Total + ItemsList[x].upgrade1 + ItemsList[x].upgrade2 + (340 * StatWeights[3]))) + " + " + String.Format("{0:0.0000}", ItemsList[x].upgrade3) + " {" + expTypeName + " Racial";

                            returnString += " + " + ItemsList[x].UpgradeCurrency + " Upgrade 3/4}";

                            returnString += "\n";

                            if (DataSource != 1)
                            {
                                returnString += "[url=" + sourceDB + ItemsList[x].Link;
                                returnString += WoWHeadTooltipAddonsShadow(ItemsList[x], ShadowGemsHeroic, 2);
                                returnString += "]";
                            }

                            returnString += "[b]" + String.Format("{0:0.0000}", (ItemsList[x].Total + (340 * StatWeights[3]) + ItemsList[x].upgrade1 + ItemsList[x].upgrade2 + ItemsList[x].upgrade3 + ItemsList[x].upgrade4)) + "[/b]";

                            if (DataSource != 1)
                            {
                                returnString += "[/url]";
                            }

                            returnString += " = " + String.Format("{0:0.0000}", (ItemsList[x].Total + ItemsList[x].upgrade1 + ItemsList[x].upgrade2 + ItemsList[x].upgrade3 + (340 * StatWeights[3]))) + " + " + String.Format("{0:0.0000}", ItemsList[x].upgrade4) + " {" + expTypeName + " Racial";

                            returnString += " + " + ItemsList[x].UpgradeCurrency + " Upgrade 4/4}";
                        }
                    }
                    */
                    #endregion

                    if (ItemsList[x].OtherBonus1 > 0)
                    {
                        returnString += "\n";

                        if (DataSource != 1)
                        {
                            returnString += "[url=" + sourceDB + ItemsList[x].Link;
                            returnString += WoWHeadTooltipAddonsShadow(ItemsList[x], StatWeights, false, false, 0, true);
                            returnString += "]";
                        }

                        returnString += "[b]" + (ItemsList[x].Total + ItemsList[x].OtherBonus1).ToString("0.00") + "[/b]";

                        if (DataSource != 1)
                        {
                            returnString += "[/url]";
                        }

                        returnString += " = " + ItemsList[x].Total.ToString("0.00") + " + " + ItemsList[x].OtherBonus1.ToString("0.00") + " {";

                        returnString += ItemsList[x].OtherBonus1Description;

                        returnString += "}";


                        //if (ItemsList[x].Warforged)
                        //{
                        //    returnString += "\n";

                        //    if (DataSource != 1)
                        //    {
                        //        returnString += "[url=" + sourceDB + ItemsList[x].Link;
                        //        returnString += WoWHeadTooltipAddonsShadow(ItemsList[x], StatWeights, false, true);
                        //        returnString += "]";
                        //    }

                        //    returnString += "[b]" + (ItemsList[x].Total + ItemsList[x].OtherBonus1 + ItemsList[x].TotalWarforged).ToString("0.0000") + "[/b]";

                        //    if (DataSource != 1)
                        //    {
                        //        returnString += "[/url]";
                        //    }

                        //    returnString += " = " + (ItemsList[x].Total + ItemsList[x].OtherBonus1).ToString("0.0000") + " + " + ItemsList[x].TotalWarforged + " {";

                        //    returnString += ItemsList[x].OtherBonus1Description;

                        //    returnString += " + ";

                        //    returnString += "Warforged";

                        //    returnString += "}";
                        //}

                        if (ItemsList[x].Gem)
                        {
                            returnString += "\n";

                            if (DataSource != 1)
                            {
                                returnString += "[url=" + sourceDB + ItemsList[x].Link;
                                returnString += WoWHeadTooltipAddonsShadow(ItemsList[x], StatWeights, true);
                                returnString += "]";
                            }

                            returnString += "[b]" + (ItemsList[x].Total + ItemsList[x].OtherBonus1 + Convert.ToDouble(BestGem(StatWeights, 2))).ToString("0.00") + "[/b]";

                            if (DataSource != 1)
                            {
                                returnString += "[/url]";
                            }

                            returnString += " = " + (ItemsList[x].Total + ItemsList[x].OtherBonus1).ToString("0.00") + " + " + Convert.ToDouble(BestGem(StatWeights, 2)).ToString("0.00") + " {";

                            returnString += ItemsList[x].OtherBonus1Description;

                            returnString += " + ";

                            returnString += "[b][stroke=black][url=" + sourceDB + BestGem(StatWeights, 0) + "][color=#" + BestGem(StatWeights, 3) + "]" + BestGem(StatWeights, 1) + "[/color][/url][/stroke][/b]";

                            returnString += "}";

                            //if (ItemsList[x].Warforged)
                            //{
                            //    returnString += "\n";

                            //    if (DataSource != 1)
                            //    {
                            //        returnString += "[url=" + sourceDB + ItemsList[x].Link;
                            //        returnString += WoWHeadTooltipAddonsShadow(ItemsList[x], StatWeights, true, true);
                            //        returnString += "]";
                            //    }

                            //    returnString += "[b]" + (ItemsList[x].Total + ItemsList[x].OtherBonus1 + ItemsList[x].TotalWarforged + Convert.ToDouble(BestGem(StatWeights, 2))).ToString("0.0000") + "[/b]";

                            //    if (DataSource != 1)
                            //    {
                            //        returnString += "[/url]";
                            //    }

                            //    returnString += " = " + (ItemsList[x].Total + ItemsList[x].OtherBonus1).ToString("0.0000") + " + " + (ItemsList[x].TotalWarforged + Convert.ToDouble(BestGem(StatWeights, 2))).ToString("0.0000") + " {";

                            //    returnString += ItemsList[x].OtherBonus1Description;

                            //    returnString += " + ";

                            //    returnString += "Warforged + [b][stroke=black][url=" + sourceDB + BestGem(StatWeights, 0) + "][color=#" + BestGem(StatWeights, 3) + "]" + BestGem(StatWeights, 1) + "[/color][/url][/stroke][/b]";

                            //    returnString += "}";
                            //}
                        }
                    }

                    if (ItemsList[x].OtherBonus2 > 0)
                    {
                        returnString += "\n";

                        if (DataSource != 1)
                        {
                            returnString += "[url=" + sourceDB + ItemsList[x].Link;
                            returnString += WoWHeadTooltipAddonsShadow(ItemsList[x], StatWeights, false, false, 0, true, true);
                            returnString += "]";
                        }

                        returnString += "[b]" + (ItemsList[x].Total + ItemsList[x].OtherBonus1 + ItemsList[x].OtherBonus2).ToString("0.00") + "[/b]";

                        if (DataSource != 1)
                        {
                            returnString += "[/url]";
                        }

                        returnString += " = " + (ItemsList[x].Total + ItemsList[x].OtherBonus1).ToString("0.00") + " + " + ItemsList[x].OtherBonus2.ToString("0.00") + " {";
 
                        returnString += ItemsList[x].OtherBonus2Description;

                        returnString += "}";
                        

                        //if (ItemsList[x].Warforged)
                        //{
                        //    returnString += "\n";

                        //    if (DataSource != 1)
                        //    {
                        //        returnString += "[url=" + sourceDB + ItemsList[x].Link;
                        //        returnString += WoWHeadTooltipAddonsShadow(ItemsList[x], StatWeights, false, true);
                        //        returnString += "]";
                        //    }

                        //    returnString += "[b]" + (ItemsList[x].Total + ItemsList[x].OtherBonus1 + ItemsList[x].OtherBonus2 + ItemsList[x].TotalWarforged).ToString("0.0000") + "[/b]";

                        //    if (DataSource != 1)
                        //    {
                        //        returnString += "[/url]";
                        //    }

                        //    returnString += " = " + (ItemsList[x].Total + ItemsList[x].OtherBonus1 + ItemsList[x].OtherBonus2).ToString("0.0000") + " + " + ItemsList[x].TotalWarforged.ToString("0.0000") + " {";

                        //    returnString += ItemsList[x].OtherBonus2Description;

                        //    returnString += " + ";

                        //    returnString += "Warforged";

                        //    returnString += "}";
                        //}

                        if (ItemsList[x].Gem)
                        {
                            returnString += "\n";

                            if (DataSource != 1)
                            {
                                returnString += "[url=" + sourceDB + ItemsList[x].Link;
                                returnString += WoWHeadTooltipAddonsShadow(ItemsList[x], StatWeights, true);
                                returnString += "]";
                            }

                            returnString += "[b]" + (ItemsList[x].Total + ItemsList[x].OtherBonus1 + ItemsList[x].OtherBonus2 + Convert.ToDouble(BestGem(StatWeights, 2))).ToString("0.00") + "[/b]";

                            if (DataSource != 1)
                            {
                                returnString += "[/url]";
                            }

                            returnString += " = " + (ItemsList[x].Total + ItemsList[x].OtherBonus1 + ItemsList[x].OtherBonus2).ToString("0.00") + " + " + Convert.ToDouble(BestGem(StatWeights, 2)).ToString("0.00") + " {";

                            returnString += ItemsList[x].OtherBonus2Description;

                            returnString += " + ";

                            returnString += "[b][stroke=black][url=" + sourceDB + BestGem(StatWeights, 0) + "][color=#" + BestGem(StatWeights, 3) + "]" + BestGem(StatWeights, 1) + "[/color][/url][/stroke][/b]";

                            returnString += "}";

                            //if (ItemsList[x].Warforged)
                            //{
                            //    returnString += "\n";

                            //    if (DataSource != 1)
                            //    {
                            //        returnString += "[url=" + sourceDB + ItemsList[x].Link;
                            //        returnString += WoWHeadTooltipAddonsShadow(ItemsList[x], StatWeights, true, true);
                            //        returnString += "]";
                            //    }

                            //    returnString += "[b]" + (ItemsList[x].Total + ItemsList[x].OtherBonus1 + ItemsList[x].OtherBonus2 + ItemsList[x].TotalWarforged + Convert.ToDouble(BestGem(StatWeights, 2))).ToString("0.0000") + "[/b]";

                            //    if (DataSource != 1)
                            //    {
                            //        returnString += "[/url]";
                            //    }

                            //    returnString += " = " + (ItemsList[x].Total + ItemsList[x].OtherBonus1).ToString("0.0000") + " + " + (ItemsList[x].TotalWarforged + Convert.ToDouble(BestGem(StatWeights, 2))).ToString("0.0000") + " {";

                            //    returnString += ItemsList[x].OtherBonus2Description;

                            //    returnString += " + ";

                            //    returnString += "Warforged + [b][stroke=black][url=" + sourceDB + BestGem(StatWeights, 0) + "][color=#" + BestGem(StatWeights, 3) + "]" + BestGem(StatWeights, 1) + "[/color][/url][/stroke][/b]";

                            //    returnString += "}";
                            //}
                        }

                    }

                    //if (ItemsList[x].SetBonus1 > 0 || ItemsList[x].SetBonus2 > 0 || ItemsList[x].WarforgedItems.Count > 0)
                    //{
                    //    returnString += "[/collapse]";
                    //}
                    
                    if (Site == 3)
                    {
                        returnString += "[/li]";
                    }
                    returnString += "\n\n";
                }
            }
            
            if (Site == 3)
            {
                returnString += "[/ol]";
            }
            else
            {
                returnString += "[/LIST]";
            }

            return returnString;
        }

        public string BestGem(double[] weights, int returnWhat = 0) //0 = ID, 1 = Name, 2 = PP value, 3 = Gem Color, 4 = weights[x] ID
        {
            if (weights[2] >= weights[3] && weights[2] >= weights[4] && weights[2] >= weights[5] && weights[2] >= weights[6]) //Crit
            {
                switch (returnWhat)
                {
                    case 1:
                        return "Deadly Eye of Prophecy";
                    case 2:
                        return Convert.ToString((double) (weights[2] * 150));
                    case 3:
                        return "008000";
                    case 4:
                        return "2";
                    case 0:
                    default:
                        return "130219";
                }
            }
            else if (weights[3] >= weights[2] && weights[3] >= weights[4] && weights[3] >= weights[5] && weights[3] >= weights[6]) //Haste
            {
                switch (returnWhat)
                {
                    case 1:
                        return "Quick Dawnlight";
                    case 2:
                        return Convert.ToString((double)(weights[3] * 150));
                    case 3:
                        return "ccad00";
                    case 4:
                        return "3";
                    case 0:
                    default:
                        return "130220";
                }
            }
            else if (weights[4] >= weights[2] && weights[4] >= weights[3] && weights[4] >= weights[5] && weights[4] >= weights[6]) //Mastery
            {
                switch (returnWhat)
                {
                    case 1:
                        return "Masterful Shadowruby";
                    case 2:
                        return Convert.ToString((double)(weights[4] * 150));
                    case 3:
                        return "A335EE";
                    case 4:
                        return "4";
                    case 0:
                    default:
                        return "130222";
                }
            }
            //else if (weights[5] >= weights[2] && weights[5] >= weights[3] && weights[5] >= weights[4] && weights[5] >= weights[6]) //Multistrike
            //{
            //    switch (returnWhat)
            //    {
            //        case 1:
            //            return "Immaculate Multistrike Taladite";
            //        case 2:
            //            return Convert.ToString((double)(weights[5] * 75));
            //        case 3:
            //            return "FFA500";
            //        case 4:
            //            return "5";
            //        case 0:
            //        default:
            //            return "127763";
            //    }
            //}
            else if (weights[6] >= weights[2] && weights[6] >= weights[3] && weights[6] >= weights[4] && weights[6] >= weights[5]) //Versatility
            {
                switch (returnWhat)
                {
                    case 1:
                        return "Versatile Maelstrom Sapphire";
                    case 2:
                        return Convert.ToString((double)(weights[6] * 150));
                    case 3:
                        return "0070DD";
                    case 4:
                        return "6";
                    case 0:
                    default:
                        return "130221";
                }
            }
            else
            {
                switch (returnWhat) //Default to haste
                {
                    case 1:
                        return "Quick Dawnlight";
                    case 2:
                        return Convert.ToString((double)(weights[3] * 150));
                    case 3:
                        return "ccad00";
                    case 4:
                        return "3";
                    case 0:
                    default:
                        return "130220";
                }
            }
        }

        public string WoWHeadTooltipAddonsShadow(ItemTotals item, double[] weights, bool gem = false, bool warforged = false, int warforgeBonusOffset = 0, bool otherbonus1 = false, bool otherbonus2 = false, bool setbonus1 = false, bool setbonus2 = false)
        {
            string returnString = ";";

            if (item.Bonuses.Length > 0)
            {
                returnString += "bonus=" + item.Bonuses;
            }

            if (item.OfTheID > -1)
            {
                if (returnString.Length == 1)
                {
                    returnString += "bonus=";
                }
                else
                {
                    returnString += ":";
                }

                returnString += item.OfTheID;
            }

            if (warforged)
            {
                if (returnString.Length == 1)
                {
                    returnString += "bonus=";
                }
                else
                {
                    returnString += ":";
                }

                if (!String.IsNullOrWhiteSpace(item.WarforgedId))
                {
                    returnString += LegionLevelBonusId(Convert.ToInt32(item.WarforgedId), warforgeBonusOffset).ToString();
                }
                else
                {
                    returnString += LegionLevelBonusId(1472, warforgeBonusOffset).ToString();
                }
            }

            if (gem)
            {
                if (returnString.Length > 1)
                {
                    returnString += "&amp;";
                }

                returnString += "gems=" + BestGem(weights);
            }

            if (setbonus1 == true)
            {
                if (returnString.Length > 1)
                {
                    returnString += "&amp;";
                }

                returnString += "pcs=" + item.SetBonus2PString;

                if (setbonus2 == true)
                {
                    returnString += ":" + item.SetBonus4PString;
                }
            }

            return returnString;
        }

        public string OfTheIdToString(int id = -1)
        {
            if (id == -1)
                return "";
            else if ((id >= 19 && id <= 39) || (id >= 1690 && id <= 1696) || (id >= 1750 && id <= 1756))
                return " of the Fireflash";
            else if ((id >= 45 && id <= 65) || (id >= 1683 && id <= 1689) || (id >= 1743 && id <= 1749))
                return " of the Peerless";
            //else if ((id >= 66 && id <= 86))
            //    return " of the Savage";
            else if ((id >= 87 && id <= 107) || (id >= 1676 && id <= 1682) || (id >= 1736 && id <= 1742))
                return " of the Quickblade";
            else if ((id >= 108 && id <= 128) || (id >= 1697 && id <= 1703) || (id >= 1757 && id <= 1763))
                return " of the Feverflare";
            //else if ((id >= 129 && id <= 149) (id >=  && id <=) || (id >=  && id <=))
            //    return " of the Deft";
            //else if ((id >= 175 && id <= 195) || (id >=  && id <=) || (id >=  && id <=))
            //    return " of the Merciless";
            else if ((id >= 196 && id <= 216) || (id >= 1711 && id <= 1717) || (id >= 1771 && id <= 1777))
                return " of the Harmonious";
            else if ((id >= 217 && id <= 237) || (id >= 1704 && id <= 1710) || (id >= 1764 && id <= 1770))
                return " of the Aurora";
            //return " of the Strategist";
            //else if ((id >= 343 && id <= 363) || (id >=  && id <=))
            //    return " of the Fanatic";
            //else if ((id >= 364 && id <= 384) || (id >=  && id <=))
            //    return " of the Zealot";
            //else if ((id >= 385 && id <= 405) || (id >=  && id <=))
            //    return " of the Diviner";
            //else if ((id >= 406 && id <= 426) || (id >=  && id <=))
            //    return " of the Herald";
            //else if ((id >= 427 && id <= 447) || (id >=  && id <=))
            //    return " of the Herald";
            else
            {
                switch (id)
                {
                    case 486:
                    case 1718:
                    case 1778:
                        return " of the Decimator";
                    case 487:
                    case 1720:
                    case 1780:
                        return " of the Impatient";
                    case 488:
                    case 1721:
                    case 1781:
                        return " of the Savant";
                    case 489:
                        return " of the Relentless";
                    case 490:
                    case 1719:
                    case 1779:
                        return " of the Adaptable";
                    case 491:
                        return " of the Unbreakable";
                    case 492:
                        return " of the Pious";
                    default:
                        return "";
                }
            }
        }

        public List<ItemTotals> ScaleItem(ItemTotals item, int steps, int stepSize = 5)
        {
            List<ItemTotals> returnItems = new List<ItemTotals>();
            
            int itemlevel = Convert.ToInt32(item.ItemLevel);
            int maxlevel = itemlevel + steps * stepSize;

            if (itemlevel < maxlevel)
            {
                while (item.ItemLevel < maxlevel)
                {
                    item.ItemLevel = item.ItemLevel + stepSize;
                    item.cInt = item.cInt * Math.Pow(1.15, (stepSize/15));
                    item.cCrit = item.cCrit * Math.Pow(1.0037444020662509239443726693104, stepSize);
                    item.cHaste = item.cHaste * Math.Pow(1.0037444020662509239443726693104, stepSize);
                    item.cMastery = item.cMastery * Math.Pow(1.0037444020662509239443726693104, stepSize);
                    item.cVersatility = item.cVersatility * Math.Pow(1.0037444020662509239443726693104, stepSize);
                    item.cProcTotal = item.cProcTotal * Math.Pow(1.15, (stepSize / 15)); //This is probably wrong.
                    item.pInt = item.pInt * Math.Pow(1.15, (stepSize / 15));
                    item.pCrit = item.pCrit * Math.Pow(1.0037444020662509239443726693104, stepSize);
                    item.pHaste = item.pHaste * Math.Pow(1.0037444020662509239443726693104, stepSize);
                    item.pMastery = item.pMastery * Math.Pow(1.0037444020662509239443726693104, stepSize);
                    item.pVersatility = item.pVersatility * Math.Pow(1.0037444020662509239443726693104, stepSize);
                    item.pProcTotal = item.pProcTotal * Math.Pow(1.15, (stepSize / 15)); //This is probably wrong.

                    returnItems.Add(item);
                }
            }

            return returnItems;
        }

        public int LegionLevelBonusId(int bonusId, int offSet)
        {
            return bonusId + offSet;
        }

        public string GenerateList(string iterations, string patch, double[] statWeights, int queryType = 1, int size = 40)
        {
            string returnString,
                   HeaderStringShadow0,
                   HeaderStringShadow1,
                   HeaderStringShadow2;
            
            DateTime NowTime = DateTime.Now;

            ItemTotals[] Mhead = Compute_Totals_Shadow("Head", queryType, statWeights);
            ItemTotals[] Mneck = Compute_Totals_Shadow("Neck", queryType, statWeights);
            ItemTotals[] Mshoulders = Compute_Totals_Shadow("Shoulder", queryType, statWeights);
            ItemTotals[] Mback = Compute_Totals_Shadow("Back", queryType, statWeights);
            ItemTotals[] Mchest = Compute_Totals_Shadow("Chest", queryType, statWeights);
            ItemTotals[] Mwrists = Compute_Totals_Shadow("Wrists", queryType, statWeights);
            ItemTotals[] Mhands = Compute_Totals_Shadow("Hands", queryType, statWeights);
            ItemTotals[] Mbelt = Compute_Totals_Shadow("Belt", queryType, statWeights);
            ItemTotals[] Mlegs = Compute_Totals_Shadow("Legs", queryType, statWeights);
            ItemTotals[] Mfeet = Compute_Totals_Shadow("Feet", queryType, statWeights);
            ItemTotals[] Mfinger = Compute_Totals_Shadow("Finger", queryType, statWeights);
            ItemTotals[] Mtrinkets = Compute_Totals_Shadow("Trinket", queryType, statWeights);
            //ItemTotals[] Mmainhand = Compute_Totals_Shadow("Mainhand", queryType, statWeights);
            //ItemTotals[] Moffhand = Compute_Totals_Shadow("Offhand", queryType, statWeights);
            //ItemTotals[] Mtwohand = Compute_Totals_Shadow("Twohand", queryType, statWeights);

            HeaderStringShadow0 = "Below is the latest listing of the best raid gear available for patch " + patch + ".\n\n";
            HeaderStringShadow0 += "Items in the following lists are ranked according to the normalized values of their stats. Stats are represented via PP (Pseudo Points) -- how valuable a given stat is -- normalized to where Intellect = 1PP.\n\n";
            HeaderStringShadow0 += "PP Stat weights are the average of the best 3 per fight for Surrender to Madness, 6 for Legacy of the Void/Mind Spike, all 9 for combined. Fight scenarios include combinations of:";
            HeaderStringShadow0 += "[list][*]1 Target {50% weight}/2 Target (Stacked) {25% weight}/2 Targets (Spread) {25% weight}[*]No Adds/1 Big Add/3 Little Adds[*]Patchwerk/Helter Skelter/Light Movement/Heavy Movement.[/list]Gear used is for T19 Heroic Emerald Nightmare (ilvl 865. [url=https://www.beotorch.com/batch.php?r=9354d26f-6917-11e6-9379-008cfa070490]Simulation details are available from Beotorch.com here.[/url]), ";
            HeaderStringShadow0 += "\n\nThis list is for " + patch + ", last generated " + NowTime.ToString("MMMM dd, yyyy") + "):";
            HeaderStringShadow0 += "\n[color=#5F9EA0]Int[/color] = " + statWeights[0].ToString("0.00");
            //HeaderStringShadow0 += "\n[color=DarkGreen]Spell Power[/color] = " + statWeights[1].ToString("0.0000");
            HeaderStringShadow0 += "\n[color=DarkRed]Crit[/color] = " + statWeights[2].ToString("0.00");
            HeaderStringShadow0 += "\n[color=DarkGreen]Haste[/color] = " + statWeights[3].ToString("0.00");
            HeaderStringShadow0 += "\n[color=#8040FF]Mastery[/color] = " + statWeights[4].ToString("0.00");
            //HeaderStringShadow0 += "\n[color=#FF00FF]Multistrike[/color] = " + statWeights[5].ToString("0.0000");
            HeaderStringShadow0 += "\n[color=SlateGray]Versatility[/color] = " + statWeights[6].ToString("0.00");
            HeaderStringShadow0 += "\n[color=MediumTurquoise]DPS[/color] (Pure Damage) = " + statWeights[7].ToString("0.00");
            
            HeaderStringShadow1 = "\n\n[b]Item Formatting[/b]\n";
            HeaderStringShadow1 += "[b][color=#6495ED]Blue[/color][/b] denotes DPS items.\n";
            HeaderStringShadow1 += "[b][color=#006400]Dark Green[/color][/b] denotes Healing-specific items.\n";
            HeaderStringShadow1 += "[b][color=#8B0000]Dark Red[/color][/b] denotes PVP items.\n";
            HeaderStringShadow1 += "[b][color=#F28500]Tangerine[/color][/b] denotes crafted/tradeskill items.\n";
            HeaderStringShadow1 += "[b][COLOR=#0080ff](T##)[/COLOR][/b] as a prefix denotes the item's Raid Tier\n";
            HeaderStringShadow1 += "[b][COLOR=#00dd00](M)[/COLOR][/b] as a prefix denotes the item is the Mythic version\n";
            HeaderStringShadow1 += "[b][COLOR=#00dd00](H)[/COLOR][/b] as a prefix denotes the item is the Heroic version\n";
            HeaderStringShadow1 += "[b][COLOR=#00dd00](TW)[/COLOR][/b] as a prefix denotes the item is the Timewarped version\n";
            //HeaderStringShadow1 += "[b][COLOR=#FFD700](N)[/COLOR][/b] as a prefix denotes the item is the Normal version\n";
            //HeaderStringShadow1 += "[b][COLOR=#FFD700](RF)[/COLOR][/b] as a prefix denotes the item is the Raid Finder version\n";
            HeaderStringShadow1 += "[b][COLOR=#a335ee](V)[/COLOR][/b] as a prefix denotes the item is sold from a vendor\n";
            HeaderStringShadow1 += "[b][COLOR=#a335ee](#/7)[/COLOR][/b] as a prefix denotes the item is crafted and at a current upgrade level\n";
            HeaderStringShadow1 += "[b][COLOR=#00dd00](S##)[/COLOR][/b] as a prefix denotes the item's PvP Season\n";
            HeaderStringShadow1 += "[b][COLOR=#000000](###)[/COLOR][/b] as a suffix denotes the item's iLevel\n\n";

            HeaderStringShadow1 += "[b]Line Formatting[/b]\n";
            //HeaderStringShadow1 += "[b]TOTAL [/b] = [color=#5F9EA0]INT[/color] + [color=DarkGreen]SPELLPOWER[/color] + [color=DarkRed]CRIT[/color] + [color=Sienna]HASTE[/color] + [color=#8040FF]MASTERY[/color] + [color=Magenta]MULTISTRIKE[/color] + [color=SlateGray]VERSATILITY[/color] + [color=MediumTurquoise]PROC[/color]\n\n";
            HeaderStringShadow1 += "[b]TOTAL [/b] = [color=#5F9EA0]INT[/color] + [color=DarkRed]CRIT[/color] + [color=DarkGreen]HASTE[/color] + [color=#8040FF]MASTERY[/color] + [color=SlateGray]VERSATILITY[/color] + [color=MediumTurquoise]PROC[/color]\n\n";
            HeaderStringShadow1 += "The values of set bonuses, Warforged bonuses, and Gem sockets. are included under a given item.\n\n";

            //HeaderStringShadowMMOH2P2 = "[b][color=#00dd00](H)[/color] [color=#a335ee](V)[/color] [color=#0080ff](T14)[/color] [url=http://www.wowdb.com/items/87120][color=#6495ED]Guardian Serpent Hood[/color][/url] [color=#AAAAAA](509)[/color][/b] + [b][url=http://www.wowdb.com/items/76885][color=#555555]Burning Primal Diamond[/color][/url][/b] + [b][url=http://www.wowdb.com/items/76686][color=#8040FF]Purified Imperial Amethyst[/color][/url][/b]\nToken / Terrace of Endless Spring: Sha of Fear / Heroic-10/25 \n[b]2538.51[/b] = [color=#5F9EA0]1140[/color] + [color=#A0522D]187.55[/color] + [color=#8B0000]383.4[/color] + [color=#8040FF]266.76[/color] + [color=#708090]560.8[/color] [i]{Mastery-to-Haste}[/i]\n[b]2613.12[/b] = 2538.51 + 74.61 {Valor Upgrade 1/2}\n[b]2691.34[/b] = 2613.12 + 78.22 {Valor Upgrade 2/2}\n[b]3106.50[/b] = 2538.51 + 567.99 {2P T14 Shadow}\n[b]3181.11[/b] = 3106.50 + 74.61 {2P T14 Shadow + Valor Upgrade 1/2}\n[b]3259.33[/b] = 3181.11 + 78.22 {2P T14 Shadow + Valor Upgrade 2/2}\n[b]3336.05[/b] = 2538.51 + 797.54 {4P T14 Shadow}\n[b]3410.66[/b] = 2538.51 + 74.61 {4P T14 Shadow + Valor Upgrade 1/2}\n[b]3488.88[/b] = 3410.66 + 78.22 {4P T14 Shadow + Valor Upgrade 2/2}\n\n";
            //HeaderStringShadowBlog2 = "[b][color=#00dd00](H)[/color] [color=#a335ee](V)[/color] [color=#0080ff](T14)[/color] [url=http://www.wowhead.com/item=87120][color=#6495ED]Guardian Serpent Hood[/color][/url] [color=#AAAAAA](509)[/color][/b] + [b][url=http://www.wowhead.com/item=76885][color=#555555]Burning Primal Diamond[/color][/url][/b] + [b][url=http://www.wowhead.com/item=76686][color=#8040FF]Purified Imperial Amethyst[/color][/url][/b]\nToken / Terrace of Endless Spring: Sha of Fear / Heroic-10/25 \n[b]2538.51[/b] = [color=#5F9EA0]1140[/color] + [color=#A0522D]187.55[/color] + [color=#8B0000]383.4[/color] + [color=#8040FF]266.76[/color] + [color=#708090]560.8[/color] [i]{Mastery-to-Haste}[/i]\n[b]2613.12[/b] = 2538.51 + 74.61 {Valor Upgrade 1/2}\n[b]2691.34[/b] = 2613.12 + 78.22 {Valor Upgrade 2/2}\n[b]3106.50[/b] = 2538.51 + 567.99 {2P T14 Shadow}\n[b]3181.11[/b] = 3106.50 + 74.61 {2P T14 Shadow + Valor Upgrade 1/2}\n[b]3259.33[/b] = 3181.11 + 78.22 {2P T14 Shadow + Valor Upgrade 2/2}\n[b]3336.05[/b] = 2538.51 + 797.54 {4P T14 Shadow}\n[b]3410.66[/b] = 2538.51 + 74.61 {4P T14 Shadow + Valor Upgrade 1/2}\n[b]3488.88[/b] = 3410.66 + 78.22 {4P T14 Shadow + Valor Upgrade 2/2}\n\n";

            //HeaderStringShadow3 = "The bottom section shows that the 2P set bonus is worth 567.99 PP and the 4P set bonus is worth 797.54 PP. The total for no set bonuses (such as if this is the only piece of T14 you have, or if you have 3 pieces of T14 and you're 'using' the other 2 pieces of T14 you have to get the 2p bonus, or if you have 5 pieces of T14 and you're using the other 4 pieces to get the 2p and 4p bonuses) is 2538.51 5PP (main line); using this piece to get the 2p bonus it is worth 3106.50 PP (fourth line), and using this piece to get the 4p bonus is worth 3336.05 PP (seventh line). The other lines show how valuable the piece is if you have 1/2 or 2/2 Valor Upgrades on the item.\n\n\n";
            HeaderStringShadow2 = "For a list of changes to this list, see the [url=https://howtopriest.com/viewtopic.php?t=8693&p=72743#p72742]Changelog[/url]\n\n";
            HeaderStringShadow2 += "For any specific questions that you might have, [url=https://howtopriest.com/viewtopic.php?t=8693&p=72741#p72741]please refer to the Best in Slot FAQ[/url]\n\n\n";


            //HTPString = "[size=1][wowdbitem]18608[/wowdbitem][/size]" + HeaderStringHeroic + HeaderStringShadowMMOH2P1 + HeaderStringShadow2 + HeaderStringShadowMMOH2P2 + HeaderStringShadow3;
            returnString = HeaderStringShadow0 + HeaderStringShadow1 + HeaderStringShadow2;

            returnString += "[B][SIZE=200][anchor=iTheList]The List[/anchor][/SIZE][/B]\n";
            returnString += "[anchorlink=iHead]Head[/anchorlink]\n";
            returnString += "[anchorlink=iNeck]Neck[/anchorlink]\n";
            returnString += "[anchorlink=iShoulders]Shoulders[/anchorlink]\n";
            returnString += "[anchorlink=iBack]Back[/anchorlink]\n";
            returnString += "[anchorlink=iChest]Chest[/anchorlink]\n";
            returnString += "[anchorlink=iWrists]Wrists[/anchorlink]\n";
            returnString += "[anchorlink=iHands]Hands[/anchorlink]\n";
            returnString += "[anchorlink=iBelt]Belt[/anchorlink]\n";
            returnString += "[anchorlink=iLegs]Legs[/anchorlink]\n";
            returnString += "[anchorlink=iFeet]Feet[/anchorlink]\n";
            returnString += "[anchorlink=iRing]Rings[/anchorlink]\n";
            returnString += "[anchorlink=iTrinket]Trinkets[/anchorlink]\n";
            //returnString += "[anchorlink=iMainHand]Main Hand[/anchorlink]\n";
            //returnString += "[anchorlink=iOffHand]Off Hand[/anchorlink]\n";
            //returnString += "[anchorlink=iStaff]Staff[/anchorlink]\n";

            returnString += "\n\n";

            
            returnString += "[B][SIZE=200][anchor=iHead]Head[/anchor][/SIZE][/B]\n";
            returnString += Print_Table_Shadow(Mhead, 2, size, 2, statWeights);
            returnString += "\n\n[B][SIZE=125][anchorlink=iTheList]Back to List TOC[/anchorlink][/SIZE][/B]\n\n";
            returnString += "[B][SIZE=200][anchor=iNeck]Neck[/anchor][/SIZE][/B]\n";
            returnString += Print_Table_Shadow(Mneck, 2, size, 2, statWeights);
            returnString += "\n\n[B][SIZE=125][anchorlink=iTheList]Back to List TOC[/anchorlink][/SIZE][/B]\n\n";
            returnString += "[B][SIZE=200][anchor=iShoulders]Shoulders[/anchor][/SIZE][/B]\n";
            returnString += Print_Table_Shadow(Mshoulders, 2, size, 2, statWeights);
            returnString += "\n\n[B][SIZE=125][anchorlink=iTheList]Back to List TOC[/anchorlink][/SIZE][/B]\n\n";
            returnString += "[B][SIZE=200][anchor=iBack]Back[/anchor][/SIZE][/B]\n";
            returnString += Print_Table_Shadow(Mback, 2, size, 2, statWeights);
            returnString += "\n\n[B][SIZE=125][anchorlink=iTheList]Back to List TOC[/anchorlink][/SIZE][/B]\n\n";
            returnString += "[B][SIZE=200][anchor=iChest]Chest[/anchor][/SIZE][/B]\n";
            returnString += Print_Table_Shadow(Mchest, 2, size, 2, statWeights);
            returnString += "\n\n[B][SIZE=125][anchorlink=iTheList]Back to List TOC[/anchorlink][/SIZE][/B]\n\n";
            returnString += "[B][SIZE=200][anchor=iWrists]Wrists[/anchor][/SIZE][/B]\n";
            returnString += Print_Table_Shadow(Mwrists, 2, size, 2, statWeights);
            returnString += "\n\n[B][SIZE=125][anchorlink=iTheList]Back to List TOC[/anchorlink][/SIZE][/B]\n\n";
            returnString += "[B][SIZE=200][anchor=iHands]Hands[/anchor][/SIZE][/B]\n";
            returnString += Print_Table_Shadow(Mhands, 2, size, 2, statWeights);
            returnString += "\n\n[B][SIZE=125][anchorlink=iTheList]Back to List TOC[/anchorlink][/SIZE][/B]\n\n";
            returnString += "[B][SIZE=200][anchor=iBelt]Belt[/anchor][/SIZE][/B]\n";
            returnString += Print_Table_Shadow(Mbelt, 2, size, 2, statWeights);
            returnString += "\n\n[B][SIZE=125][anchorlink=iTheList]Back to List TOC[/anchorlink][/SIZE][/B]\n\n";
            returnString += "[B][SIZE=200][anchor=iLegs]Legs[/anchor][/SIZE][/B]\n";
            returnString += Print_Table_Shadow(Mlegs, 2, size, 2, statWeights);
            returnString += "\n\n[B][SIZE=125][anchorlink=iTheList]Back to List TOC[/anchorlink][/SIZE][/B]\n\n";
            returnString += "[B][SIZE=200][anchor=iFeet]Feet[/anchor][/SIZE][/B]\n";
            returnString += Print_Table_Shadow(Mfeet, 2, size, 2, statWeights);
            returnString += "\n\n[B][SIZE=125][anchorlink=iTheList]Back to List TOC[/anchorlink][/SIZE][/B]\n\n";
            returnString += "[B][SIZE=200][anchor=iRing]Ring[/anchor][/SIZE][/B]\n";
            returnString += Print_Table_Shadow(Mfinger, 2, size, 2, statWeights);
            returnString += "\n\n[B][SIZE=125][anchorlink=iTheList]Back to List TOC[/anchorlink][/SIZE][/B]\n\n";
            returnString += "[B][SIZE=200][anchor=iTrinket]Trinket[/anchor][/SIZE][/B]\n";
            returnString += Print_Table_Shadow(Mtrinkets, 2, size, 2, statWeights);
            returnString += "\n\n[B][SIZE=125][anchorlink=iTheList]Back to List TOC[/anchorlink][/SIZE][/B]\n\n";
            //returnString += "[B][SIZE=200][anchor=iMainHand]Main Hand[/anchor][/SIZE][/B]\n";
            //returnString += Print_Table_Shadow(Mmainhand, 2, size, 2, statWeights);
            //returnString += "\n\n[B][SIZE=125][anchorlink=iTheList]Back to List TOC[/anchorlink][/SIZE][/B]\n\n";
            //returnString += "[B][SIZE=200][anchor=iOffHand]Off Hand[/anchor][/SIZE][/B]\n";
            //returnString += Print_Table_Shadow(Moffhand, 2, size, 2, statWeights);
            //returnString += "\n\n[B][SIZE=125][anchorlink=iTheList]Back to List TOC[/anchorlink][/SIZE][/B]\n\n";
            //returnString += "[B][SIZE=200][anchor=iStaff]Staff[/anchor][/SIZE][/B]\n";
            //returnString += Print_Table_Shadow(Mtwohand, 2, size, 2, statWeights);
            //returnString += "\n\n[B][SIZE=125][anchorlink=iTheList]Back to List TOC[/anchorlink][/SIZE][/B]\n\n";

            return returnString;
        }


        protected void Page_Load(object sender, EventArgs e)
        {
            string outputString;
            
            outputString = GenerateList("25,000", "7.0.3", ShadowHeroicENStatWeights, 1, 40);
            TB_HTP_Mythic_Combined.Text = outputString;

            outputString = GenerateList("25,000", "7.0.3", ShadowHeroicENStatWeights, 5, 40);
            TB_HTP_Mythic_Combined_No_Crafted.Text = outputString;

            outputString = GenerateList("25,000", "7.0.3", ShadowS2MHeroicENStatWeights, 5, 40);
            TB_HTP_Mythic_AS.Text = outputString;

            outputString = GenerateList("25,000", "7.0.3", ShadowLotVMSpHeroicENStatWeights, 5, 40);
            TB_HTP_Mythic_CoP.Text = outputString;
            /*
            outputString = GenerateList("25,000", "7.0.3", ShadowCoP1TarMythicStatWeights, 5, 40);
            TB_HTP_Mythic_CoP1Tar.Text = outputString;

            outputString = GenerateList("25,000", "7.0.3", ShadowVEntMythicStatWeights, 5, 40);
            TB_HTP_Mythic_VEnt.Text = outputString;*/

            outputString = GenerateList("25,000", "7.0.3", ShadowHeroicENStatWeights, 2, 40);
            TB_HTP_PreRaid_Combined.Text = outputString;

            outputString = GenerateList("25,000", "7.0.3", ShadowHeroicENStatWeights, 4, 100);
            TB_HTP_Crafted.Text = outputString;
            
        }
    }
}