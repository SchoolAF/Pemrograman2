﻿using P12_1_714220066;
using P12_1_714220066.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P12_1_714220066.controller
{
    internal class Barang
    {
        Koneksi connect = new Koneksi();

        //Method insert
        public bool Insert(M_barang barang)
        {
            Boolean status = false;
            try
            {
                connect.OpenConnection();
                connect.ExecuteQuery("INSERT INTO t_barang (nama_barang, harga) VALUES('" + barang.Nama_barang + "', '" + barang.Harga + "')");
                status = true;
                MessageBox.Show("Data berhasil ditambahkan", "Informasi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                connect.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            return status;
        }
        //Method update
        public bool Update(M_barang barang, string id)
        {
            Boolean status = false;
            try
            {
                connect.OpenConnection();
                connect.ExecuteQuery("UPDATE t_barang SET nama_barang='" + barang.Nama_barang + "'," + "harga='" + barang.Harga + "' WHERE id_barang = '" + id + "'");

                status = true;
                MessageBox.Show("Data berhasil diubah", "Informasi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                connect.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            return status;
        }
        //Method delete
        public bool Delete(string id)
        {
            Boolean status = false;
            try
            {
                connect.OpenConnection();
                connect.ExecuteQuery("DELETE FROM t_barang WHERE id_barang='" + id + "'");
                status = true;
                MessageBox.Show("Data berhasil dihapus", "Informasi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                connect.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            return status;
        }
    }
}
