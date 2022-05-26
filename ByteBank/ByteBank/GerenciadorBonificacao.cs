using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class GerenciadorBonificacao
    {
        private double _totalBonifacacao { get; set; }

        public void Registrar(Funcionario funcionario) {
            _totalBonifacacao += funcionario.GetBonificacao();
        }

        public double GetBonificacao() { 
            return _totalBonifacacao; 
        }
    }
}
