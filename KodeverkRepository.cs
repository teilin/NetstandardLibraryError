using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
//using Dapper;

namespace ACOS.Levekaar.KodeverkService.Repositories
{
  public class KodeverkRepository
  {
      private readonly AppSettings _appSettings;

      public KodeverkRepository(AppSettings appSettings)
      {
          _appSettings = appSettings;
      }
  }
}
