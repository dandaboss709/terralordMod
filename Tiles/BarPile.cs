using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Terraria.Map;
using Microsoft.Xna.Framework;

namespace terralord.Tiles
{
    public class BarPile : ModTile
    {
		public override void SetDefaults()
		{
			Main.tileShine[Type] = 1100;
			Main.tileSolid[Type] = false;
			Main.placementPreview = true;  
			Main.tileSolidTop[Type] = true;
			Main.tileFrameImportant[Type] = true;
			drop = mod.ItemType("SteelBar");

			TileObjectData.newTile.CopyFrom(TileObjectData.Style1x1);
			TileObjectData.newTile.LavaDeath = false;
			TileObjectData.addTile(Type);
			ModTranslation name = CreateMapEntryName();
			name.SetDefault("Steel bar");

            AddMapEntry(new Color(200, 200, 200), name); // localized text for "Metal Bar"

			minPick = 30;
        }
	}
}
