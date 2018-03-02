using System;
using Dapper;
using XCare.DMS.Entity;

namespace XCare.DMS.DataProc.DAL
{
    public class YpyfDataAccess
    {
        public void Create(YdhlYpyf obj)
        {
            using (var conn = DbHelper.GetDbConnection())
            {
                conn.Execute(@"
INSERT  INTO dbo.YDHL_YPYF ( ID, CODE, NAME, LB )
VALUES  ( @ID, -- ID - uniqueidentifier
          @CODE, -- CODE - int
          @NAME, -- NAME - nvarchar(20)
          @LB  -- LB - smallint
          )", new
                {
                    ID = obj.Id,
                    CODE = obj.Code,
                    NAME = obj.Name,
                    LB = obj.Lb
                });
            }
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}