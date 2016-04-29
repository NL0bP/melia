// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using Melia.Channel.World;
using Melia.Shared.Network;

namespace Melia.Channel.Network.Helpers
{
	public static class ItemHelper
	{
		public static void AddItem(this Packet packet, Item item, int index)
		{
			packet.PutInt(item.Id);
			packet.PutShort(0); // Size of the object at the end
			packet.PutEmptyBin(2);
			packet.PutLong(item.WorldId);
			packet.PutInt(item.Amount);
			packet.PutInt(item.Price);
			packet.PutInt(index);
			packet.PutInt(1); // ?
			//packet.PutEmptyBin(0);
		}
	}
}
