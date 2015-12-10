using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomLoL
{
    public class RastgeleGülüş
    {
        private char[] _karakterler;
        private string[] _simileyler;
        private char _boşluk;
        private Random _random;

        private RastgeleGülüş()
        {
            _boşluk = ' ';
            _karakterler = new char[31];
            _simileyler = new string[]
            {
                ":D", "XD", "Azuzuzuzuz", "Azuhahhahahaha", "Haha", "Ehuehuehueh"
            };
            for(int i = 0; i < 26; ++i)
            {
                _karakterler[i] = (char)(i + 97);
            }
            _karakterler[26] = 'ç';
            _karakterler[27] = 'ğ';
            _karakterler[28] = 'ü';
            _karakterler[29] = 'ş';
            _karakterler[30] = 'ı';
            _random = new Random(Guid.NewGuid().GetHashCode());
        }
        public static string RastgeleGül(int KaçKarakterli)
        {
            return (new RastgeleGülüş().HaydiRastgele(KaçKarakterli));
        }
        private string HaydiRastgele(int KaçKarakterli)
        {
            var tmp = new StringBuilder();
            for (int i = 0; i < KaçKarakterli; i++)
            {
                tmp.Append(RastgeleKarakter());
                if (_random.Next(0, 100) < 10)
                {
                    tmp.Append(_boşluk);
                }
            }
            tmp.Append(' ');
            tmp.Append(RastgeleSmiley());

            return tmp.ToString();
        }

        private char RastgeleKarakter()
        {
            return _karakterler[_random.Next(0, _karakterler.Length)];
        }
        private string RastgeleSmiley()
        {
            return _simileyler[_random.Next(0, _simileyler.Length)];
        }
        
    }
}
