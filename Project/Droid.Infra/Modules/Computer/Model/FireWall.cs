﻿//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using NetFwTypeLib;

//namespace Droid.Infra.Modules.Computer.Model
//{
//    public class FireWall
//    {
//        #region Attributes
//        #endregion

//        #region Properties
//        #endregion

//        #region Constructor
//        public FireWall()
//        {
//            Init();
//        }
//        #endregion

//        #region Methods public
//        public void Rules(string applicationName)
//        {
//            try
//            {
//                Type tNetFwPolicy2 = Type.GetTypeFromProgID("HNetCfg.FwPolicy2");
//                INetFwPolicy2 fwPolicy2 = (INetFwPolicy2)Activator.CreateInstance(tNetFwPolicy2);
//                var currentProfiles = fwPolicy2.CurrentProfileTypes;

//                List<INetFwRule> RuleList = new List<INetFwRule>();
//                // Lista rules

//                foreach (INetFwRule rule in fwPolicy2.Rules)
//                {
//                    if (rule.Name.Contains(applicationName))
//                    { 
//                        Console.WriteLine(rule.Name);
//                    }
//                }
//            }
//            catch (Exception r)
//            {
//                Console.WriteLine("Error delete rule from firewall");
//            }
//        }
//        public void RemoveFirewallRules(string RuleName = "BreakermindCom")
//        {
//            try
//            {
//                Type tNetFwPolicy2 = Type.GetTypeFromProgID("HNetCfg.FwPolicy2");
//                INetFwPolicy2 fwPolicy2 = (INetFwPolicy2)Activator.CreateInstance(tNetFwPolicy2);
//                var currentProfiles = fwPolicy2.CurrentProfileTypes;

//                // Lista rules
//                List<INetFwRule> RuleList = new List<INetFwRule>();

//                foreach (INetFwRule rule in fwPolicy2.Rules)
//                {
//                    // Add rule to list
//                    //RuleList.Add(rule);
//                    // Console.WriteLine(rule.Name);
//                    if (rule.Name.IndexOf(RuleName) != -1)
//                    {
//                        // Now add the rule
//                        INetFwPolicy2 firewallPolicy = (INetFwPolicy2)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FwPolicy2"));
//                        //firewallPolicy.Rules.Remove(rule.Name);
//                        Console.WriteLine(rule.Name + " has been deleted from Firewall Policy");
//                    }
//                }
//            }
//            catch (Exception r)
//            {
//                Console.WriteLine("Error delete rule from firewall");
//            }
//        }
//        #endregion

//        #region Methods private
//        private void Init()
//        {

//        }
//        #endregion

//        #region Event
//        #endregion
//    }
//}
