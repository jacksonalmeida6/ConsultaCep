using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using ConsultaCep.Servico.Modelo;
using Newtonsoft.Json;

namespace ConsultaCep.Servico
{
    public class ViaCepServico
    {
        private static string EnderecoURL = "http//viacep.com.br/ws/{0}/json/";

        public static Endereco BuscarEnderecoViaCEP(string cep)
        {
            string NovoEndereco = string.Format(EnderecoURL, cep);

            WebClient wc = new WebClient();
            string Conteudo = wc.DownloadString(NovoEndereco);


            Endereco end = JsonConvert.DeserializeObject<Endereco>(Conteudo) ;

            return end;

        }
    }
}
