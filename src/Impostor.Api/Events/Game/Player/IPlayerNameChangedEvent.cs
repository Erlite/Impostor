namespace Impostor.Api.Events.Player
{
    public interface IPlayerNameChangedEvent : IPlayerEvent
    {
        /// <summary>
        /// The player's old name.
        /// </summary>
        string OldName { get; } 
        
        /// <summary>
        /// The player's new name.
        /// </summary>
        string NewName { get; }
    }
}
