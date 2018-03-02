using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using XCare.DMS.DataProc.Common;
using XCare.DMS.Entity;

namespace XCare.DMS.DataProc.DAL
{
    public class JybgDataAccess
    {
        public void Create(IEnumerable<YdhlJybg> objs)
        {
            var array = objs as YdhlJybg[] ?? objs.ToArray();
            using (var conn = DbHelper.GetDbConnection())
            {
                SaveJybg(array, conn);
                SaveJybgxq(array.SelectMany(e => e.Items), conn);
            }
        }

        public void Update()
        {
            throw new NotImplementedException();
        }

        private static void SaveJybgxq(IEnumerable<YdhlJybgxq> objs, IDbConnection conn)
        {
            conn.Execute(@"
INSERT  INTO dbo.YDHL_JYBGXQ ( ID, XMMC, XMCDZ, TS, CKFW, DW, DATE_TEST, YBH, JYBGID )
VALUES  ( @ID, -- ID - uniqueidentifier
          @XMMC, -- XMMC - nvarchar(40)
          @XMCDZ, -- XMCDZ - nvarchar(24)
          @TS, -- TS - nvarchar(1)
          @CKFW, -- CKFW - nvarchar(200)
          @DW, -- DW - nvarchar(20)
          @DATE_TEST, -- DATE_TEST - datetime
          @YBH,  -- YBH - nvarchar(20)
          @JYBGID -- JYBGID - uniqueidentifier
          )",
                objs.Select(e => new
                {
                    ID = e.Id,
                    XMMC = e.Xmmc,
                    XMCDZ = e.Xmcdz,
                    TS = e.Ts,
                    CKFW = e.Ckfw,
                    DW = e.Dw,
                    DATETEST = e.DateTest,
                    YBH = e.Ybh,
                    JYBGID = e.JybgId
                }));
        }

        private static void SaveJybg(IEnumerable<YdhlJybg> objs, IDbConnection conn)
        {
            conn.Execute(@"
INSERT  INTO dbo.YDHL_JYBG ( ID, ZYH, TXM, KZXM, YBH, DATE_TEST, ROWID, JCMD )
VALUES  ( @ID, -- ID - uniqueidentifier
          @ZYH, -- ZYH - bigint
          @TXM, -- TXM - nvarchar(50)
          @KZXM, -- KZXM - nvarchar(100)
          @YBH, -- YBH - nvarchar(20)
          @DATE_TEST, -- DATE_TEST - datetime
          @ROWID, -- ROWID - bigint
          @JCMD  -- JCMD - nvarchar(250)
          )", objs.Select(e => new
            {
                ID = e.Id,
                ZYH = e.Zyh,
                TXM = e.Txm,
                KZXM = e.Kzxm,
                YBH = e.Ybh,
                DATE_TEST = e.DateTest,
                ROWID = e.Rowid,
                JCMD = e.Jcmd
            }));
        }
    }
}