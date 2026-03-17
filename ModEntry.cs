using System;
using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewValley;

namespace CinderboxSmartClick
{
    public class ModEntry : Mod
    {
        public override void Entry(IModHelper helper)
        {
            // Listen for when you press a button/touch the screen
            helper.Events.Input.ButtonPressed += OnButtonPressed;
        }

        private void OnButtonPressed(object sender, ButtonPressedEventArgs e)
        {
            // Only run if the game world is loaded
            if (!Context.IsWorldReady)
                return;

            // If you touch the screen (MouseLeft), 
            // we immediately fire a MouseRight signal to trigger the movement mod.
            if (e.Button == SButton.MouseLeft)
            {
                // Trigger the Right Click action
                this.Helper.Input.TriggerPress(SButton.MouseRight);
            }
        }
    }
}
