using Crash;

namespace CrashEdit
{
    public sealed class OldT15EntryController : MysteryMultiItemEntryController
    {
        private OldT15Entry oldt15entry;

        public OldT15EntryController(EntryChunkController entrychunkcontroller,OldT15Entry oldt15entry) : base(entrychunkcontroller,oldt15entry)
        {
            this.oldt15entry = oldt15entry;
            Node.Text = string.Format("Old T15 Entry ({0})",oldt15entry.EIDString);
            Node.ImageKey = "oldt15entry";
            Node.SelectedImageKey = "oldt15entry";
        }

        public OldT15Entry OldT15Entry
        {
            get { return oldt15entry; }
        }
    }
}
