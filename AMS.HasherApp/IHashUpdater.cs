using AMS.Hasher.Hashers;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AMS.HasherApp
{
    public interface IHashUpdater
    {
        void UpdateHashes(string input, Dictionary<ITextHasher, TextBox> textboxes);
    }
}