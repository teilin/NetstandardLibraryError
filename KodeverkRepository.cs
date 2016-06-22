using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
//using Dapper;
using ACOS.Levekaar.KodeverkService.Interfaces;
using ACOS.Levekaar.KodeverkService.Models;
using ACOS.Levekaar.KodeverkService.Params;

namespace ACOS.Levekaar.KodeverkService.Repositories
{
  public class KodeverkRepository : IRepository<object, Kodeverk, KodeverkParam>
  {
      private readonly AppSettings _appSettings;

      public KodeverkRepository(AppSettings appSettings)
      {
          _appSettings = appSettings;
      }

      public async Task<IDictionary<object, Kodeverk>> Get(KodeverkParam param)
      {
          //throw new NotImplementedException();
          using (var connection = new SqlConnection(_appSettings.ConnectionString))
            {
            throw new NotImplementedException();
              // const string kkvQuery =
              //     "select Kkv_KkvId KodeverkId, Kkv_TypeKkvId TypeKodeverkId, Kkv_Tabell Tabell, COALESCE(kkv_utgaatt,0) Utgaatt, Kkv_Oppdaterbar Oppdaterbar from kkv_kodeverk where kkv_kkvid=@kkvid and COALESCE(kkv_utgaatt,0)=@utgaatt";
              // var kodeverk = await connection.QueryAsync<Kodeverk>(kkvQuery, new { kkvid = param.KkvId, utgaatt = false });
              // var kkv = kodeverk.ToDictionary(key => key.KodeverkId as object, item => item);
              //
              // const string query =
              //     @"
              //         select kod_kkvid KodeverkId, kod_kode KodeId, kod_kodetekst kodetekst, kod_forklaring forklaring, kod_sortering sortering, COALESCE(kod_utgaatt,0) Utgaatt from kod_koder where kod_kkvid = @kkvid and COALESCE(kod_utgaatt,0) = @utgaatt";
              //
              // foreach (var item in kkv)
              //   {
              //       using (var multi = await connection.QueryMultipleAsync(query, new { kkvid = item.Key, utgaatt = false }))
              //       {
              //           var listKoder = await multi.ReadAsync<Kode>();
              //           kkv[item.Key].Koder = listKoder;
              //       }
              //   }
              // return kkv;
          }
      }

      public async Task<IDictionary<object, Kodeverk>> Get(KodeverkParam param, long endretEtter)
      {
          //throw new NotImplementedException();
          using (var connection = new SqlConnection(_appSettings.ConnectionString))
            {
              throw new NotImplementedException();
                // const string kkvQuery =
                //     "select Kkv_KkvId KodeverkId, Kkv_TypeKkvId TypeKodeverkId, Kkv_Tabell Tabell, COALESCE(kkv_utgaatt,0) Utgaatt, Kkv_Oppdaterbar Oppdaterbar from kkv_kodeverk where kkv_kkvid=@kkvid and COALESCE(kkv_utgaatt,0)=@utgaatt";
                // var kodeverk = await connection.QueryAsync<Kodeverk>(kkvQuery, new { kkvid = param.KkvId, utgaatt = false });
                // return kodeverk.ToDictionary(key => key.KodeverkId as object, item => item);
            }
      }
  }
}
