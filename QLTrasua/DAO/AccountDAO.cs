using QLTrasua.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace QLTrasua.DAO
{
    class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; }
        }

        private AccountDAO() { }

        public bool Login(string UserName, string PassWord)
        {
            // THỦ TỤC LOGIN
            DataTable result = DataProvider.Instance.ExecuteQuery("EXEC sp_Login @userName , @password", new object[] { UserName,PassWord/* CryptoPassword(PassWord) */}); 

            return result.Rows.Count > 0;
        }



        public DataTable GetListAccount()
        {
            return DataProvider.Instance.ExecuteQuery("Select * From View_Nhanvien");  // KHUNG NHÌN HIỂN THỊ DANH SÁCH NHÂN VIÊN
        }







        public string CryptoPassword(string PassWord)
        {
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(PassWord);
            byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);

            string hasPass = "";

            foreach (byte item in hasData)
            {
                hasPass += item;
            }
            return hasPass;
        }

       
        public bool UpdateAccount(string UserName, string displayName, string PassWord, int type)
        {
            string qr = string.Format("" +
                "UPDATE Account " +
                "SET Displayname = N'{0}', Password = N'{1}' , Type = {3} " +
                "WHERE Username = N'{2}' ", displayName, CryptoPassword(PassWord), UserName, type);

            int result = DataProvider.Instance.ExecuteNonQuery(qr);

            return result > 0;
        }

        internal bool Login(object userName, string passWord)
        {
            throw new NotImplementedException();
        }

       

        public Account GetAccountByUserName(string UserName)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC sp_GetAccount @username ", new object[] { UserName});  // Thủ tục lấy DS tài khoản 

            foreach (DataRow item in data.Rows)
            {
                return new Account(item);
            }

            return null;
        }

        public bool InsertAccount(string name, string displayName, string passWord, int type)
        {

            string query = string.Format("INSERT dbo.Account ( UserName, DisplayName, Type, password )VALUES  ( N'{0}', N'{1}', {2}, N'{3}')", name, displayName, type, CryptoPassword(passWord));
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateAccount(string name, string displayName, int type)
        {
            string query = string.Format("UPDATE dbo.Account SET DisplayName = N'{1}', Type = {2} WHERE UserName = N'{0}'", name, displayName, type);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteAccount(string name)
        {
            string query = string.Format("Delete Account where UserName = N'{0}'", name);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public string GetTypeAccount(string name)
        {
            string qr = string.Format("" +
                "SELECT Type FROM Account WHERE Username = N'{0}'", name);
            return (DataProvider.Instance.ExecuteScalar(qr)).ToString();
        }
    }
}
