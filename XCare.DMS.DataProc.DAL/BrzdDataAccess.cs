using System;
using Dapper;
using XCare.DMS.DataProc.Common;
using XCare.DMS.Entity;

namespace XCare.DMS.DataProc.DAL
{
    public class BrzdDataAccess
    {
        public void Create(YdhlBrzd obj)
        {
            using (var conn = DbHelper.GetDbConnection())
            {
                conn.Execute(@"
INSERT  INTO dbo.YDHL_BRZD ( ID, ZYH, ZD, ZDLB, ZDSJ, NAME, JBZG )
VALUES  ( @ID, -- ID - uniqueidentifier
          @ZYH, -- ZYH - bigint
          @ZD, -- ZD - nvarchar(150)
          @ZDLB, -- ZDLB - nvarchar(2)
          @ZDSJ, -- ZDSJ - datetime
          @NAME, -- NAME - nvarchar(150)
          @JBZG  -- JBZG - nvarchar(2)
          )", new
                {
                    ID = obj.Id,
                    ZYH = obj.Zyh,
                    ZD = obj.Zd,
                    ZDLB = obj.Zdlb,
                    ZDSJ = obj.Zdsj,
                    NAME = obj.Name,
                    JBZG = obj.Jbzg
                });
            }
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}