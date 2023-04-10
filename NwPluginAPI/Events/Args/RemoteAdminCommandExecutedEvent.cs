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
	public class RemoteAdminCommandExecutedEvent : IEventArguments
	{
		public ServerEventType BaseType { get; } = ServerEventType.RemoteAdminCommandExecuted;
		[EventArgument]
		public ICommandSender Sender { get; set; }
		[EventArgument]
		public string Command { get; set; }
		[EventArgument]
		public string[] Arguments { get; set; }
		[EventArgument]
		public bool Result { get; set; }
		[EventArgument]
		public string Response { get; set; }
	}
}
