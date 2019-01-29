using System;
using StardewModdingAPI;

namespace PrideShirtPack
{
    public class ShirtPack: Mod, IAssetLoader
    {

        public override void Entry(IModHelper helper)
        {
            this.Monitor.Log($"loading pride mod.");
        }

        /// <summary>Get whether this instance can load the initial version of the given asset.</summary>
        /// <param name="asset">Basic metadata about the asset being loaded.</param>
        public bool CanLoad<T>(IAssetInfo asset)
        {
            if (asset.AssetNameEquals("Characters/Farmer/shirts"))
            {
                return true;
            }

            return false;
        }

        /// <summary>Load a matched asset.</summary>
        /// <param name="asset">Basic metadata about the asset being loaded.</param>
        public T Load<T>(IAssetInfo asset)
        {
            if (asset.AssetNameEquals("Characters/Farmer/shirts"))
            {
                return this.Helper.Content.Load<T>("assets/shirts_with_pride.png", ContentSource.ModFolder);
            }

            throw new InvalidOperationException($"Unexpected asset '{asset.AssetName}'.");
        }
    }
}
