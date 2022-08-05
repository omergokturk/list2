using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericHalkbankList
{
    public class Iterasyon : IMyEnumerator
    {
        private GenericHalkBankList _halkbankList;
        int _position;

        internal Iterasyon(GenericHalkBankList halkbankList)
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
