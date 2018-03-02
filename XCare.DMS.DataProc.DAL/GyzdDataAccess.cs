using System;
using Dapper;
using XCare.DMS.Entity;

namespace XCare.DMS.DataProc.DAL
{
    public class GyzdDataAccess
    {
        public void Create(YdhlGyzd obj)
        {
            using (var conn = DbHelper.GetDbConnection())
            {
                conn.Execute(@"
IF NOT EXISTS ( SELECT  0
                FROM    dbo.YDHL_GYZD
                WHERE   DMLB = @DMLB
                        AND DMSB = @DMSB ) 
   BEGIN
         INSERT INTO dbo.YDHL_GYZD ( ID, DMLB, DMSB, DMMC, SRDM )
         VALUES ( @ID, -- ID - uniqueidentifier
                  @DMLB, -- DMLB - int
                  @DMSB, -- DMSB - int
                  @DMMC, -- DMMC - varchar(40)
                  @SRDM  -- SRDM - varchar(10)
                  )
   END",
                    new
                    {
                        ID = obj.Id,
                        DMLB = obj.Dmlb,
                        DMSB = obj.Dmsb,
                        DMMC = obj.Dmmc,
                        SRDM = obj.Srdm
                    });
            }
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}