using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_QuanLyQuanCaPhe.BusinessLogic
{
    internal class Table
    {
        private int iD;
        private string tenBan;
        private string viTri;
        private int trangThai;
        public int ID { get => iD; set => iD = value; }
        public string TenBan { get => tenBan; set => tenBan = value; }
        public string ViTri { get => viTri; set => viTri = value; }
        public int TrangThai { get => trangThai; set => trangThai = value; }
        
        //property chuyển đổi trạng thái sang text
        public string TrangThaiText
        {
            get => TrangThai == 0 ? "Trống" : "Có khách";
        }

        public Table(int iD, string tenBan, string viTri, int trangThai)
        {
            this.ID = iD;
            this.TenBan = tenBan;
            this.ViTri = viTri;
            this.TrangThai = trangThai;
        }
        public Table(DataRow row)
        {
            this.ID = (int)row["Id"];
            this.TenBan = row["TenBan"].ToString();
            this.ViTri = row["ViTri"].ToString();
            this.TrangThai = (int)row["TrangThai"];
        }
    }
}
