using AMS.Hasher.Hashers;
using AMS.Hasher.HashTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AMS.HasherApp
{
    public partial class Form1 : Form
    {
        private Dictionary<ITextHasher, TextBox> textboxes;
        private readonly IHashUpdater hashUpdater;

        public Form1(IHashUpdater hashUpdater, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            SetupHashersForTextboxes(serviceProvider);
            this.hashUpdater = hashUpdater;
        }

        private void SetupHashersForTextboxes(IServiceProvider serviceProvider)
        {
            var base64Hasher = serviceProvider.GetService(typeof(ITextHasher<AMS.Hasher.HashTypes.Base64>)) as ITextHasher<AMS.Hasher.HashTypes.Base64>;
            var md4Hasher = serviceProvider.GetService(typeof(ITextHasher<AMS.Hasher.HashTypes.MD4>)) as ITextHasher<AMS.Hasher.HashTypes.MD4>;
            var md5Hasher = serviceProvider.GetService(typeof(ITextHasher<AMS.Hasher.HashTypes.MD5>)) as ITextHasher<AMS.Hasher.HashTypes.MD5>;
            var sha1Hasher = serviceProvider.GetService(typeof(ITextHasher<AMS.Hasher.HashTypes.SHA1>)) as ITextHasher<AMS.Hasher.HashTypes.SHA1>;
            var sha256Hasher = serviceProvider.GetService(typeof(ITextHasher<AMS.Hasher.HashTypes.SHA256>)) as ITextHasher<AMS.Hasher.HashTypes.SHA256>;
            var sha512Hasher = serviceProvider.GetService(typeof(ITextHasher<AMS.Hasher.HashTypes.SHA512>)) as ITextHasher<AMS.Hasher.HashTypes.SHA512>;
            var whirlpoolHasher = serviceProvider.GetService(typeof(ITextHasher<AMS.Hasher.HashTypes.Whirlpool>)) as ITextHasher<AMS.Hasher.HashTypes.Whirlpool>;
            var rot13Hasher = serviceProvider.GetService(typeof(ITextHasher<AMS.Hasher.HashTypes.ROT13>)) as ITextHasher<AMS.Hasher.HashTypes.ROT13>;
            textboxes = new Dictionary<ITextHasher, TextBox>
            {
                { base64Hasher, base64Textbox },
                { md4Hasher, md4Textbox },
                { md5Hasher, md5Textbox },
                { sha1Hasher, sha1Textbox },
                { sha256Hasher, sha256Textbox },
                { sha512Hasher, sha512Textbox },
                { whirlpoolHasher, whirlpoolTextbox },
                { rot13Hasher, rot13Textbox },
            };
        }

        private void inputTextbox_TextChanged(object sender, EventArgs e)
        {
            hashUpdater.UpdateHashes(inputTextbox.Text, textboxes);
        }
    }
}