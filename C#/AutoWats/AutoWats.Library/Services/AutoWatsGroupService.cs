using AutoWats.Library.Abstract;
using AutoWats.Library.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoWats.Library.Services
{
    public class AutoWatsGroupService:IAutoWatsGroups
    {
        private readonly AcceptedTokenModel _tokenModel;
        public AutoWatsGroupService(AcceptedTokenModel tokenModel)
        {

        }
    }
}
