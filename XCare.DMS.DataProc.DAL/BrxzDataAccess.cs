using System;
using Dapper;
using XCare.DMS.DataProc.Common;
using XCare.DMS.Entity;

namespace XCare.DMS.DataProc.DAL
{
    public class BrxzDataAccess
    {
        public void Create(YdhlBrxz obj)
        {
            using (var conn = DbHelper.GetDbConnection())
            {
                conn.Execute(@"
IF NOT EXISTS ( SELECT  0
                FROM    dbo.YDHL_BRXZ
                WHERE   BRXZ = @BRXZ ) 
   BEGIN
         INSERT INTO dbo.YDHL_BRXZ ( ID, BRXZ, XZMC, PYDM, SJXZ, GSXZ )
         VALUES ( @ID, -- ID - uniqueidentifier
                  @BRXZ, -- BRXZ - int
                  @XZMC, -- XZMC - nvarchar(50)
                  @PYDM, -- PYDM - nvarchar(20)
                  @SJXZ, -- SJXZ - int
                  @GSXZ  -- GSXZ - int
                  )
   END",
                    new
                    {
                        ID = obj.Id,
                        BRXZ = obj.Brxz,
                        XZMC = obj.Xzmc,
                        PYDM = obj.Pydm,
                        SJXZ = obj.Sjxz,
                        GSXZ = obj.Gsxz
                    });
            }
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}