using System.Linq;
using Assets.Scripts.Data;
using Assets.Scripts.Data.Cosmetics.Pets;
using Assets.Scripts.Data.TrophyStore;
using BTD_Mod_Helper;
using BTD_Mod_Helper.Extensions;
using IndiscriminatePets;
using MelonLoader;

[assembly: MelonInfo(typeof(IndiscriminatePetsMod), ModHelperData.Name, ModHelperData.Version, ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]

namespace IndiscriminatePets
{
    public class IndiscriminatePetsMod : BloonsTD6Mod
    {
        public override void OnTitleScreen()
        {
            foreach (var trophyStoreItem in GameData.Instance.trophyStoreItems.storeItems)
            {
                foreach (var trophyItemTypeData in trophyStoreItem.itemTypes.Where(data => data.itemType == TrophyItemType.TowerPet))
                {
                    if (trophyItemTypeData.itemTarget.IsType(out Pet pet))
                    {
                        pet.skinId = "";
                    }
                }
            }
        }
    }
}