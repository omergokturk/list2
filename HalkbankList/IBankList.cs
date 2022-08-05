using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalkbankList
{
    internal interface IBankList
    {
        int ElemanSayisi { get; }
        object this[int index]
        {
            get;
            set;
        }
        bool Contains(Object eleman);
        void ItibarenKopyala(Object[] yeniDizi, int baslangic );
        void Ekle(object eleman);
        void Sil(int index);
        void Temizle();
        int IndexOf(object? elaman);
        int LastIndexOf(object? eleman);
        void TersCevir();
    }
}
