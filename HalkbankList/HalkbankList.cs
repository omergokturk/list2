using HalkbankList.MyEnumarable;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalkbankList
{
    public class HalkbankList : IBankList, IMyEnumerable
    {
        protected object[] _dizi;
        public HalkbankList()
        {
            _dizi = new object[0];
        }
        public HalkbankList(int maxElemanSayisi) : this()
        {
            MaxElemanSayisi = maxElemanSayisi;
        }
        public int ElemanSayisi => _dizi.Length;
        public static int MaxElemanSayisi { get; set; } = 5;
        public object this[int index] //C# 7.0
        {
            get => _dizi[index];
            set => _dizi[index] = value;
        }
        public virtual void Ekle(object eleman)
        {
            if (ElemanSayisi >= MaxElemanSayisi)
                throw new System.Exception($"Maksimum eleman sayısına ulaştınız");

            var yedekDizi = _dizi;
            _dizi = new object[yedekDizi.Length + 1];

            yedekDizi.CopyTo(_dizi, 0);

            _dizi[yedekDizi.Length] = eleman;
        }
        public void Sil(int index)
        {
            var yedekDizi = _dizi;
            _dizi = new object[yedekDizi.Length - 1];

            int sayac = 0;

            for (int i = 0; i < yedekDizi.Length; i++)
            {
                if (i == index)
                    continue;

                _dizi[sayac] = yedekDizi[i];
                sayac++;
            }
        }

        public void Temizle()
        {
            _dizi = new object[0];
        }

        public IMyEnumerator GetEnumerator()
        {
            return new Iterasyon(this);
        }

        public virtual bool Contains(Object eleman)
        {
            if (eleman == null)
            {
                for (int i = 0; i < ElemanSayisi; i++)
                    if (_dizi[i] == null)
                        return true;
                return false;
            }
            else
            {
                for (int i = 0; i < ElemanSayisi; i++)
                    if ((_dizi[i] != null) && (_dizi[i].Equals(eleman)))
                        return true;
                return false;
            }
        }

        public virtual void ItibarenKopyala(Object[] yeniDizi, int baslangic)
        {   
            foreach (var item in _dizi)
            {
                yeniDizi[baslangic] = item;
                baslangic++;
            }
        }

        public virtual void TersCevir()
        {
            var yedekDizi = new object[_dizi.Length];
            int sayac = _dizi.Length-1;

            for (int i = 0; i < _dizi.Length; i++)
            {
                yedekDizi[i] = _dizi[sayac];
                sayac--;
            }
            _dizi = yedekDizi;
        }

        public int IndexOf(object? eleman)
        {
            for (int i = 0; i < ElemanSayisi; i++)
                if (_dizi[i] == eleman)
                    return i;
            return -1;
        }

        public int LastIndexOf(object? eleman)
        {
            int sakla = -1;
            for (int i = 0; i < ElemanSayisi; i++)
                if (_dizi[i] == eleman)
                    sakla = i;
            return sakla;
        }


    }
}
