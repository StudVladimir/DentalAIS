using System;

using AppKit;
using Foundation;
using MySql.Data.MySqlClient;
using System.Data;
using System.Threading;
using System.Linq;

namespace DentalSV
{
	public partial class ViewController : NSViewController
	{
		public ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
            TestsClass test = new TestsClass();
            Console.WriteLine("Test 1 - "+test.InsertTestMethod1());

            test = new TestsClass();
            Console.WriteLine("Test 2 - "+test.UpdateTestMethod2());

            test = new TestsClass();
            Console.WriteLine("Test 3 - " + test.DeleteTestMethod3());

            test = new TestsClass();
            Console.WriteLine("Test 4 - " + test.SceneTestMethod4());

            test = new TestsClass();
            Console.WriteLine("Test 5 - " + test.ConstFullPartialTableTestMethod5());

            test = new TestsClass();
            Console.WriteLine("Test 6 - " + test.ConstDentalSetTableTestMethod6());

            test = new TestsClass();
            Console.WriteLine("Test 7 - " + test.ConstClammersTableTestMethod7());

            test = new TestsClass();
            Console.WriteLine("Test 8 - " + test.ConstSaddlesTableTestMethod8());

            test = new TestsClass();
            Console.WriteLine("Test 9 - " + test.ConstMaterialsTableTestMethod9());

            test = new TestsClass();
            Console.WriteLine("Test 10 - " + test.ConstSolderingTableTestMethod10());

            test = new TestsClass();
            Console.WriteLine("Test 11 - " + test.ConstInsetTableTestMethod11());

            test = new TestsClass();
            Console.WriteLine("Test 12 - " + test.ConstCariesTableTestMethod12());

            test = new TestsClass();
            Console.WriteLine("Test 13 - " + test.ConstAestheticRestorationTableTestMethod13());

            test = new TestsClass();
            Console.WriteLine("Test 14 - " + test.ConstPinningTableTestMethod14());

            test = new TestsClass();
            Console.WriteLine("Test 15 - " + test.ConstDepulpationTableTestMethod15());
        }

        public override NSObject RepresentedObject {
			get {   
                return base.RepresentedObject;
			}
			set {
                base.RepresentedObject = value;
                // Update the view, if already loaded.
                
            }
		}

        partial void EnterBtn(NSObject sender)
        {
            DB db = new DB();

            db.OpenConnection();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM Employees WHERE Login=@login AND Password=@password;", db.GetConnection());
			command.Parameters.Add("@login",MySqlDbType.VarChar).Value=LoginTxtField.StringValue;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = PasswordTxtField.StringValue;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            string[] AuthEmp = table.Rows.Cast<DataRow>().Select(r => Convert.ToString(r["Employee_id"])).ToArray();

            if (table.Rows.Count != 0)
			{
                command = new MySqlCommand("INSERT INTO LoginHistory (`Employee_id`, `DateTime`) VALUES (@emp_id,now());", db.GetConnection());
                command.Parameters.Add("@emp_id", MySqlDbType.Int32).Value = AuthEmp[0];
                command.ExecuteNonQuery();
                db.CloseConnection();
                //Закрывает стартовое окно
                View.Window.OrderOut(Self);
                // Получить новое окно
                var storyboard = NSStoryboard.FromName("Scene2", null);
                var window = storyboard.InstantiateControllerWithIdentifier("Scene2Main") as NSWindowController;
                // Вывести новое окно
                window.ShowWindow(this);
            }
			else
			{
                db.CloseConnection();
                NSViewController LoginFail = Storyboard.InstantiateControllerWithIdentifier("LoginFail") as NSViewController;
                View.Window.ContentViewController = LoginFail;
            }
            db.CloseConnection();
        }

    }
}
