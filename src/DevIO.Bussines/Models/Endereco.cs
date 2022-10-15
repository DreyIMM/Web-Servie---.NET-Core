using System;
using System.Collections.Generic;
using System.Text;

namespace DevIO.Bussines.Models
{
    class Endereco: Entity
    {                     
            /* o EF entende que como o atributo fornecedor tem o ID no final, ele considera como FK */
            public Guid FornecedorId { get; set; }           
            public string Logradouro { get; set; }            
            public string Numero { get; set; }
            public string Complemento { get; set; }            
            public string Cep { get; set; }            
            public string Bairro { get; set; }            
            public string Cidade { get; set; }            
            public string Estado { get; set; }
            /* EF Relation */
            public Fornecedor Fornecedor { get; set; }
      
    }
}
