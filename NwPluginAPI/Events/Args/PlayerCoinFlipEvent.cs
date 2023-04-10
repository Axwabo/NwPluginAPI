using LiteNetLib;
using UnityEngine;

using AdminToys;
using PlayerRoles;
using Footprinting;
using CustomPlayerEffects;
using MapGeneration.Distributors;

using Interactables.Interobjects;
using Interactables.Interobjects.DoorUtils;

using CommandSystem;
using PlayerStatsSystem;

using InventorySystem.Items;
using InventorySystem.Items.Radio;
using InventorySystem.Items.Pickups;
using InventorySystem.Items.Usables;
using InventorySystem.Items.Firearms;
using InventorySystem.Items.ThrowableProjectiles;

using PluginAPI.Core;
using PluginAPI.Enums;
using PluginAPI.Core.Attributes;

using static BanHandler;
using static MapGeneration.Distributors.Scp079Generator;

namespace PluginAPI.Events
{
	public class PlayerCoinFlipEvent : IEventArguments
	{
		public ServerEventType BaseType { get; } = ServerEventType.PlayerCoinFlip;
		[EventArgument]
		public Player Player { get; }
		[EventArgument]
		public bool IsTails { get; }

		public PlayerCoinFlipEvent(ReferenceHub hub, bool isTails)
		{
			Player = Player.Get(hub);
			IsTails = isTails;
		}
	}
}
