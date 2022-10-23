using AutoMapper;
using DevIO.App.ViewModels;
using DevIO.Bussines.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevIO.App.AutoMapper
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {

            //Quando utiliza ReverseMap -> Significa que o inverso tbm é verdade (Fornecedor está para ForViewModel, como ForViewModel está para Fornecedor)
            //Basicamente um De-Para
            CreateMap<Fornecedor, FornecedorViewModel>().ReverseMap();
            CreateMap<Endereco, EnderecoViewModel>().ReverseMap();
            CreateMap<Produto, ProdutoViewModel>().ReverseMap();

        }


    }
}
