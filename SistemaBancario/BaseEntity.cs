using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario
{
    public abstract class BaseEntity{

        private Guid id = new Guid();

        public Guid Id { get => id;}

    }
}
