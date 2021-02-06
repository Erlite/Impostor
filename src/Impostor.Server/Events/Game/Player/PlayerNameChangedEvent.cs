using Impostor.Api.Events.Player;
using Impostor.Api.Games;
using Impostor.Api.Net;
using Impostor.Api.Net.Inner.Objects;

namespace Impostor.Server.Events.Player
{
    public class PlayerNameChangedEvent : IPlayerNameChangedEvent
    {
        public PlayerNameChangedEvent(IGame game, IClientPlayer client, IInnerPlayerControl control, string oldName,
            string newName)
        {
            Game = game;
            ClientPlayer = client;
            PlayerControl = control;
            OldName = oldName;
            NewName = newName;
        }

        public IGame Game { get; }

        public IClientPlayer ClientPlayer { get; }

        public IInnerPlayerControl PlayerControl { get; }

        public string OldName { get; }

        public string NewName { get; }
    }
}
