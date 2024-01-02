using System;
using MySql.Data.MySqlClient;
using System.Data;
using AppKit;

namespace DentalSV
{
	public class TestsClass
	{
		public bool InsertTestMethod1()
		{
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM Patients;", db.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            int RowCountFirst = table.Rows.Count;

            db.OpenConnection();
            command = new MySqlCommand("INSERT INTO Patients (`Name`, `Surname`, `Patronymic`, `BirthDate`, `Phone`, `WorkingPlace`, `Pensioner`) VALUES ('testValue', 'testValue', 'testValue', now(), 'testValue', 'testValue', '1');", db.GetConnection());
            command.ExecuteNonQuery();
            db.CloseConnection();

            command = new MySqlCommand("SELECT * FROM Patients;", db.GetConnection());

            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            int RowCountSecond = table.Rows.Count;

            if (RowCountFirst + 1 == RowCountSecond)
                return true;
            else
                return false;
        }

        public bool UpdateTestMethod2()
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM Patients;", db.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);
            var row = table.Rows[table.Rows.Count-1].ItemArray;

            var BeforeUpdateValue = row[1];

            command = new MySqlCommand("UPDATE Patients SET `Name` = 'changedTestValue' WHERE (`Patient_id` = @id);", db.GetConnection());
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = row[0];
            db.OpenConnection();
            command.ExecuteNonQuery();
            db.CloseConnection();

            command = new MySqlCommand("SELECT * FROM Patients;", db.GetConnection());

            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);

            row = table.Rows[table.Rows.Count - 1].ItemArray;
            var AfterUpdateValue = row[1];

            if (BeforeUpdateValue != AfterUpdateValue && AfterUpdateValue.ToString()== "changedTestValue")
                return true;
            return false;
        }

        public bool DeleteTestMethod3()
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM Patients;", db.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);
            var row = table.Rows[table.Rows.Count - 1].ItemArray;

            var BeforeDeleteValue = row[0];

            command = new MySqlCommand("DELETE FROM Patients WHERE (`Patient_id` = @id);", db.GetConnection());
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = row[0];
            db.OpenConnection();
            command.ExecuteNonQuery();
            db.CloseConnection();

            command = new MySqlCommand("SELECT * FROM Patients;", db.GetConnection());

            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);

            row = table.Rows[table.Rows.Count - 1].ItemArray;
            var AfterDeleteValue = row[0];

            command = new MySqlCommand("ALTER TABLE Patients AUTO_INCREMENT=0", db.GetConnection());
            db.OpenConnection();
            command.ExecuteNonQuery();
            db.CloseConnection();

            if (BeforeDeleteValue != AfterDeleteValue)
                return true;
            return false;
        }

        public bool SceneTestMethod4()
        {
            NSStoryboard empty = new NSStoryboard();
            var Scene1 = NSStoryboard.FromName("Main", null);
            var Scene2 = NSStoryboard.FromName("Scene2", null);
            var Scene3 = NSStoryboard.FromName("Scene3", null);
            var Scene4 = NSStoryboard.FromName("Scene4", null);
            if (Scene1 != empty && Scene2 != empty && Scene3 != empty && Scene4 != empty)
                return true;
            return false;
        }

        public bool ConstFullPartialTableTestMethod5()
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM FullPartial;", db.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count == 2)
                return true;
            return false;
        }

        public bool ConstDentalSetTableTestMethod6()
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM DentalSet;", db.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count == 2)
                return true;
            return false;
        }

        public bool ConstClammersTableTestMethod7()
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM Clamers;", db.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count == 5)
                return true;
            return false;
        }

        public bool ConstSaddlesTableTestMethod8()
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM Saddles;", db.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count == 3)
                return true;
            return false;
        }

        public bool ConstMaterialsTableTestMethod9()
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM Materials;", db.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count == 9)
                return true;
            return false;
        }

        public bool ConstSolderingTableTestMethod10()
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM Soldering;", db.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count == 2)
                return true;
            return false;
        }

        public bool ConstInsetTableTestMethod11()
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM Inset;", db.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count == 8)
                return true;
            return false;
        }

        public bool ConstCariesTableTestMethod12()
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM Сaries;", db.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count == 2)
                return true;
            return false;
        }

        public bool ConstAestheticRestorationTableTestMethod13()
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM AestheticRestoration;", db.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count == 3)
                return true;
            return false;
        }

        public bool ConstPinningTableTestMethod14()
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM Pinning;", db.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count == 2)
                return true;
            return false;
        }

        public bool ConstDepulpationTableTestMethod15()
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM Depulpation;", db.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count == 3)
                return true;
            return false;
        }
    }
}

