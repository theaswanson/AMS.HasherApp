using AMS.Hasher.Hashers;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AMS.HasherApp
{
    public class HashUpdater : IHashUpdater
    {
        public void UpdateHashes(string input, Dictionary<ITextHasher, TextBox> textboxes)
        {
            foreach (var textbox in textboxes)
            {
                UpdateHash(textbox.Key, textbox.Value, input);
            }
        }

        private void UpdateHash(ITextHasher hasher, TextBox textbox, string input)
        {
            var hash = hasher.Hash(input);
            textbox.Text = hash;
        }
    }
}