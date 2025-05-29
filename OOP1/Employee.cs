using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class Employee
    {
        private int _id;
        private string _id_card;
        private string _name;
        private string _email;
        private string _phone;

        #region nhóm các thuộc tính của employee
        public Employee()
        {
            this.Id = 1;
            id_card = "123456789";
            this.name = "LyHuyenThong";
        }
        public Employee(int _id, string _id_card, string _name, string _email, string _phone)
        {
            this._id = _id;
            this._id_card = _id_card;
            this._name = _name;
            this._email = _email;
            this._phone = _phone;
        }
        #endregion
        #region get set của các thuộc tính
        public int Id
        {
            get { return _id; }
            //read-only property    
            set { _id = value; }
            //write-only property
        }
        public string id_card
        {
            get { return _id_card; }
            set { _id_card = value; }
        }
        public string name {
            get { return _name; }
            set { _name = value; }
        }
        public string email
        {
            get { return _email; }
            set { _email = value; }
        }
        public string phone
        {
            get { return _phone; }
            set { _phone = value; }
        }
        #endregion
        #region nhóm các phương thức của in
        public void PrintInfo()
        {
            String msg = $"Id: {Id}\t Id_card: {id_card}\t " +
                $"Name: {name}\t Email: {email}\t Phone: {phone}";
            Console.WriteLine(msg);
        }
        public override string ToString()
        {
            string msg = $"Id: {Id}\t Id_card: {id_card}\t " +
                $"Name: {name}\t Email: {email}\t Phone: {phone}";
            return msg;
        }
        #endregion
    }
}
