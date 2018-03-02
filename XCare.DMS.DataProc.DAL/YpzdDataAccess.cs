using System;
using Dapper;
using XCare.DMS.DataProc.Common;
using XCare.DMS.Entity;

namespace XCare.DMS.DataProc.DAL
{
    public class YpzdDataAccess
    {
        public void Create(YdhlYpzd obj)
        {
            using (var conn = DbHelper.GetDbConnection())
            {
                conn.Execute(@"
IF NOT EXISTS ( SELECT  0
                FROM    dbo.YDHL_YPZD
                WHERE   XH = @XH ) 
   BEGIN
         INSERT INTO dbo.YDHL_YPZD ( ID, XH, YPMC, YPJC )
         VALUES ( @ID, -- ID - uniqueidentifier
                  @XH, -- XH - int
                  @YPMC, -- YPMC - nvarchar(50)
                  @YPJC  -- YPJC - nvarchar(8)
                  )
   END", new
                {
                    ID = obj.Id,
                    XH = obj.Xh,
                    YPMC = obj.Ypmc,
                    YPJC = obj.Ypjc
                });
            }
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}