using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.GameMenus;
using TaleWorlds.Core;
using TaleWorlds.Localization;


namespace HireTroops
{
    internal class HiringTroops : CampaignBehaviorBase
    {
        public override void RegisterEvents() {
            CampaignEvents.OnSessionLaunchedEvent.AddNonSerializedListener((object)this, new Action<CampaignGameStarter>(this.AddMenuItem));
        }

        private void AddMenuItem(CampaignGameStarter campaignGameStarter) {
            campaignGameStarter.AddGameMenuOption("town", "hire_troops", "Hire Troops", (GameMenuOption.OnConditionDelegate)(args =>
           {
               args.Tooltip = new TextObject("Hire Troops");
               args.IsEnabled = true;
               args.optionLeaveType = GameMenuOption.LeaveType.Continue;
               return true;
                
           }), (GameMenuOption.OnConsequenceDelegate)(args => InformationManager.DisplayMessage(new InformationMessage("Nice!"))), index: 1);
        }
        public override void SyncData(IDataStore dataStore)
        {
        }

    }
}
