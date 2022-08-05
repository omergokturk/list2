using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericHalkbankList
{
    public interface IBankListG
    {
        int ElemanSayisi { get; }
        object this[int index]
        {
            get;
            set;
        }
        bool Contains(Object eleman);
        void ItibarenKopyala(Object[] yeniDizi, int baslangic);
        void Ekle(Object eleman);
        void Sil(int index);
        void Temizle();
        void TersCevir();
    }
}
