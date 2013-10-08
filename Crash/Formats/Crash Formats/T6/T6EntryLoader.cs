using System;

namespace Crash
{
    [EntryType(6,GameVersion.Crash1BetaMAR08)]
    public sealed class T6EntryLoader : EntryLoader
    {
        public override Entry Load(byte[][] items,int eid)
        {
            if (items == null)
                throw new ArgumentNullException("items");
            if (items.Length != 1)
            {
                ErrorManager.SignalError("T6Entry: Wrong number of items");
            }
            return new T6Entry(items[0],eid);
        }
    }
}