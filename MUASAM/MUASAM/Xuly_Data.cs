﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace MUASAM
{
    class Xuly_Data
    {

        public List<Sanpham> sqlGetSanpham(string tukhoa)
        {
            List<Sanpham> list = new List<Sanpham>();
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            string query = "select * from Sanpham where danhmuc = '" + tukhoa + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    list.Add(new Sanpham()
                    {
                        idsanpham = Convert.ToInt32(reader["idsanpham"]),
                        tensanpham = reader["tensanpham"].ToString(),
                        gia = Convert.ToInt32(reader["gia"]),
                        daban = Convert.ToInt32(reader["daban"])
                    });
                }
                reader.Close();
            }
            conn.Close();
            return list;
        }

        public Sanpham getSP(string id)
        {
            Sanpham h = new Sanpham();
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            string query = "select * from Sanpham where idsanpham = " + id;
            SqlCommand cmd = new SqlCommand(query, conn);
            using (var reader = cmd.ExecuteReader())
            {
                reader.Read();

                h.idsanpham = Convert.ToInt32(reader["idsanpham"]);
                h.tensanpham = reader["tensanpham"].ToString();
                h.gia = Convert.ToInt32(reader["gia"]);
                h.daban = Convert.ToInt32(reader["daban"]);
                h.soluong = Convert.ToInt32(reader["soluong"]);
                h.luotxem = Convert.ToInt32(reader["luotxem"]);
                h.mota = reader["mota"].ToString();

                reader.Close();
            }
            conn.Close();
            return h;
        }

        public string getlinkHA(int id)
        {
            Hinhanh h = new Hinhanh();
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            string query = "select * from Hinhanh where idsanpham = " + id;
            SqlCommand cmd = new SqlCommand(query, conn);
            using (var reader = cmd.ExecuteReader())
            {
                reader.Read();
                
                    h.idhinhanh = Convert.ToInt32(reader["idhinhanh"]);
                    h.linkha = reader["linkha"].ToString();
                
                reader.Close();
            }
            conn.Close();
            string st = h.linkha;
            return st;
        }
        public int themgiohang(string id)
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            int id_tmp = 0;
            int sl_tmp = 0;
            string query = "select * from Giohang where idsanpham = " + id;
            SqlCommand cmd = new SqlCommand(query, conn);
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    id_tmp = Convert.ToInt32(reader["idsanpham"]);
                    sl_tmp = Convert.ToInt32(reader["soluong"]);
                }
            }
            if (id_tmp != 0)
            {
                string query1 = "delete from Giohang where idsanpham=@id";
                SqlCommand cmd1 = new SqlCommand(query1, conn);
                cmd1.Parameters.AddWithValue("id", id);
                var tmp1 = cmd1.ExecuteNonQuery();
            }
            string query2 = "insert into Giohang values (@id,@sl)";
            SqlCommand cmd2 = new SqlCommand(query2, conn);
            cmd2.Parameters.AddWithValue("id", id);
            cmd2.Parameters.AddWithValue("sl", sl_tmp + 1);
            var tmp2 = cmd2.ExecuteNonQuery();
            conn.Close();
            return tmp2;
        }
        public int themyeuthich(string id)
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            int id_tmp = 0;
            string query = "select * from YeuThich where idsanpham = " + id;
            SqlCommand cmd = new SqlCommand(query, conn);
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    id_tmp = Convert.ToInt32(reader["idsanpham"]);
                }
            }
            if (id_tmp != 0)
            {
                string query1 = "delete from YeuThich where idsanpham=@id";
                SqlCommand cmd1 = new SqlCommand(query1, conn);
                cmd1.Parameters.AddWithValue("id", id);
                var tmp1 = cmd1.ExecuteNonQuery();
            }
            string query2 = "insert into YeuThich values (@id)";
            SqlCommand cmd2 = new SqlCommand(query2, conn);
            cmd2.Parameters.AddWithValue("id", id);
            var tmp2 = cmd2.ExecuteNonQuery();
            conn.Close();
            return tmp2;
        }

        public void themdaxem(string id)
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            int id_tmp = 0;
            string query = "select * from Daxem where idsanpham = " + id;
            SqlCommand cmd = new SqlCommand(query, conn);
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    id_tmp = Convert.ToInt32(reader["idsanpham"]);
                }
            }
            if (id_tmp != 0)
            {
                string query1 = "delete from Daxem where idsanpham=@id";
                SqlCommand cmd1 = new SqlCommand(query1, conn);
                cmd1.Parameters.AddWithValue("id", id);
                var tmp1 = cmd1.ExecuteNonQuery();
            }
            string query2 = "insert into Daxem values (@id)";
            SqlCommand cmd2 = new SqlCommand(query2, conn);
            cmd2.Parameters.AddWithValue("id", id);
            var tmp2 = cmd2.ExecuteNonQuery();
            conn.Close();
        }
        public void tangluotxem(string id, int luotthich)
        {
            luotthich += 1;
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            string query = "update Sanpham set luotxem=@sl where idsanpham=@id";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("id", id);
            cmd.Parameters.AddWithValue("sl", luotthich);
            var tmp = cmd.ExecuteNonQuery();
            conn.Close();
        }
        public List<Giohang> sqlGetGiohang()
        {
            List<Giohang> list = new List<Giohang>();
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            string query = "select * from Giohang";
            SqlCommand cmd = new SqlCommand(query, conn);
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    list.Add(new Giohang()
                    {
                        idsanpham = Convert.ToInt32(reader["idsanpham"]),
                        soluong = Convert.ToInt32(reader["soluong"])
                    });
                }
                reader.Close();
            }
            conn.Close();
            return list;
        }
    }
}
