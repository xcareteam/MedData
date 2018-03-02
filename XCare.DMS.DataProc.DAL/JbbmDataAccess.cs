using System;
using Dapper;
using XCare.DMS.Entity;

namespace XCare.DMS.DataProc.DAL
{
    public class JbbmDataAccess
    {
        public void Create(YdhlJbbm obj)
        {
            using (var conn = DbHelper.GetDbConnection())
            {
                conn.Execute(@"
INSERT  INTO dbo.YDHL_JBBM ( CODE, NAME, PYDM, ZZZZ, ICD9, ICD10, DMLB, ZFPB, SHICD10, SHJBMC )
VALUES  ( @CODE, -- CODE - int
          @NAME, -- NAME - nvarchar(150)
          @PYDM, -- PYDM - nvarchar(20)
          @ZZZZ, -- ZZZZ - nvarchar(50)
          @ICD9, -- ICD9 - nvarchar(50)
          @ICD10, -- ICD10 - nvarchar(50)
          @DMLB, -- DMLB - int
          @ZFPB, -- ZFPB - tinyint
          @SHICD10, -- SHICD10 - nvarchar(50)
          @SHJBMC  -- SHJBMC - nvarchar(150)
          )", new
                {
                    CODE = obj.Code,
                    NAME = obj.Name,
                    PYDM = obj.Pydm,
                    ZZZZ = obj.Zzzz,
                    ICD9 = obj.Icd9,
                    ICD10 = obj.Icd10,
                    DMLB = obj.Dmlb,
                    ZFPB = obj.Zfpb,
                    SHICD10 = obj.Shicd10,
                    SHJBMC = obj.Shjbmc
                });
            }
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}