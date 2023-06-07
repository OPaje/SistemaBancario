using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario
{
    public abstract class BaseEntity{

        private long id;

        public long Id { get => id; set => id = value; }

    }
}
