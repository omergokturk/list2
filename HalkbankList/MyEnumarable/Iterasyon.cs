using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalkbankList.MyEnumarable
{
    public class Iterasyon : IMyEnumerator
    {
        private HalkbankList _halkbankList;
        int _position;

        internal Iterasyon(HalkbankList halkbankList)
        {
            _halkbankList = halkbankList;
            _position = -1;
        }

        public object Current
        {
            get
            {
                if (_position < _halkbankList.ElemanSayisi)
                    return _halkbankList[_position];
                else
                    throw new InvalidOperationException();
            }
        }

        public bool MoveNext()
        {
            _position++;
            return _position < _halkbankList.ElemanSayisi;
        }
        public void Reset()
        {
            _position = -2;
        }
    }
}
