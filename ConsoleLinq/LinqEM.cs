using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLinq
{
    #region CustomLinq
    public static class LinqEM
    {
        /// <summary>
        /// T burada string, inti float, class hepsi olabilir
        /// <para>
        /// Bu sizin dizinizdeki eleman türüne göre değişir
        /// </para>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dizi"></param>
        /// <param name="fncKontrol"></param>
        /// <returns></returns>
        public static IEnumerable<T> Sorgu<T>(this IEnumerable<T> dizi, Func<T, bool> fncKontrol)
        {
            List<T> _filtrelenenElamanlar = new List<T>();
            foreach (var item in dizi)
            {
                if (fncKontrol(item))
                {
                    _filtrelenenElamanlar.Add(item);
                }
            }
            return _filtrelenenElamanlar;
        }

        /// <summary>
        /// Dizi içinde aranan Kontrol dogrultusunda değer var mı
        /// <para>
        /// eleman türünü sorguda kendin bool belirledin
        /// </para>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dizi"></param>
        /// <param name="funcKontrol"></param>
        /// <returns></returns>
        public static bool VarMi<T>(this IEnumerable<T> dizi, Func<T, bool> funcKontrol)
        {
            foreach (var item in dizi)
            {
                if (funcKontrol(item))
                {
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// Diziden gerekli bilgilerin seçilmesini sağlar
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="dizi"></param>
        /// <param name="fncDegerDondur"></param>
        /// <returns></returns>
        public static IEnumerable<TResult> Sec<T, TResult>(this IEnumerable<T> dizi, Func<T, TResult> fncDegerDondur)
        {
            List<TResult> _datas = new List<TResult>();
            foreach (var item in dizi)
            {
                _datas.Add(fncDegerDondur(item));
            }
            return _datas;
        }
    }
    #endregion
}
