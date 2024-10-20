﻿using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;

namespace Melia.Zone.Buffs.Handlers.Swordsmen.Highlander
{
	/// <summary>
	/// Handler for CrownArmor_Debuff, which zeroes defense.
	/// </summary>
	[BuffHandler(BuffId.Crown_Armor_Debuff)]
	public class CrownArmor_Debuff : BuffHandler
	{
		/// <summary>
		/// Starts buff, zeroing defense.
		/// </summary>
		/// <param name="buff"></param>
		public override void OnActivate(Buff buff, ActivationType activationType)
		{
			var target = buff.Target;
			var reduceDef = target.Properties.GetFloat(PropertyName.DEF);

			AddPropertyModifier(buff, target, PropertyName.DEF_BM, -reduceDef);
		}

		/// <summary>
		/// Ends the buff, resetting defense.
		/// </summary>
		/// <param name="buff"></param>
		public override void OnEnd(Buff buff)
		{
			RemovePropertyModifier(buff, buff.Target, PropertyName.DEF_BM);
		}
	}
}
