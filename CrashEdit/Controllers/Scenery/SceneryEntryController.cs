using Crash;
using System.Windows.Forms;

namespace CrashEdit
{
    public sealed class SceneryEntryController : EntryController
    {
        private SceneryEntry sceneryentry;

        public SceneryEntryController(EntryChunkController entrychunkcontroller,SceneryEntry sceneryentry) : base(entrychunkcontroller,sceneryentry)
        {
            this.sceneryentry = sceneryentry;
            Node.Text = string.Format("Scenery Entry ({0})",sceneryentry.EIDString);
            Node.ImageKey = "sceneryentry";
            Node.SelectedImageKey = "sceneryentry";
        }

        protected override Control CreateEditor()
        {
            return new UndockableControl(new SceneryEntryViewer(sceneryentry));
        }

        public SceneryEntry SceneryEntry
        {
            get { return sceneryentry; }
        }
    }
}
