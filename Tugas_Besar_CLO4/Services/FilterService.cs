using System;
using System.Collections.Generic;
using System.Text;

namespace Tugas_Besar_CLO4.Services
{
    public class FilterService
    {
        public List<T> FilterData<T>(
           List<T> data,
           Func<T, bool> kondisi)
        {
            if (data == null)
            {
                throw new ArgumentNullException(
                    nameof(data),
                    "Data tidak boleh null"
                );
            }

            List<T> hasil =
                new List<T>();

            foreach (T item in data)
            {
                if (kondisi(item))
                {
                    hasil.Add(item);
                }
            }
            return hasil;
        }
    }
}
