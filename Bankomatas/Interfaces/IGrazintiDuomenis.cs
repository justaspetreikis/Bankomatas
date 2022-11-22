using Bankomatas.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomatas.Interfaces
{
    public interface IGrazintiDuomenis<T>
    {
        public List<T> GrazintiVisuKorteliuLista();     
    }
}
